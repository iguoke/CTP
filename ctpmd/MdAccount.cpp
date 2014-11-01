//#pragma once
#include <string.h>
#include "MdAccount.h"
#include <vector>
#include <iostream> 
using namespace std;
//////////////////////////////////////////////////////MDSpi����ʵ��///
void MdSpi::OnFrontConnected()
{
	this->Event_OnFrontConnected.Trigger();
	//cout<<"MD:OnFrontConnected!"<<endl;
}
void MdSpi::OnFrontDisconnected(int n)
{
	this->Event_OnFrontDisconnected.Trigger((ObejctSender*)n);
}
void MdSpi::OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if (!IsErrorRspInfo(pRspInfo) && pRspUserLogin)
	{
		this->Event_OnRspUserLogin.Trigger((ObejctSender *)pRspUserLogin,(ObejctSender *)nRequestID,(ObejctSender *)bIsLast);
	}
}
bool MdSpi::IsErrorRspInfo(CThostFtdcRspInfoField *pRspInfo)
{
	  bool ret = ((pRspInfo) && (pRspInfo->ErrorID != 0));
	  if (ret)
	{				
		this->Event_OnRspError.Trigger((ObejctSender *)pRspInfo);
		return ret;
	}
}
void MdSpi::OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	IsErrorRspInfo(pRspInfo);
}
void MdSpi:: OnRtnDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData) 
{
		this->Event_OnRtnDepthMarketData.Trigger((ObejctSender *)pDepthMarketData);
}
	//////////////////////MdApi����ʵ��//////////////
void MdApi::MdConnect(MdSpi *mdspi,char* addr)
{
     	this->md_UserApi=CThostFtdcMdApi::CreateFtdcMdApi("MD",false);
		this->md_UserApi->RegisterSpi(mdspi); // �ص�����ע��ӿ���
		this->md_UserApi->RegisterFront(addr); // ע������ǰ�õ�ַ
		this->md_UserApi->Init();      //�ӿ��߳�����, ��ʼ����
		this->md_UserApi->Join();      //�ȴ��ӿ��߳��˳�
		//this->md_UserApi->Release()
}
int MdApi::ReqUserLogin(TThostFtdcBrokerIDType	appId,TThostFtdcUserIDType	userId,	TThostFtdcPasswordType	passwd)
{	
	CThostFtdcReqUserLoginField req;
	memset(&req, 0, sizeof(req));
	strcpy(req.BrokerID, appId);
	strcpy(req.UserID, userId);
	strcpy(req.Password, passwd);
	return this->md_UserApi->ReqUserLogin(&req, ++requestId);
}

int MdApi::ReqUserLogout(TThostFtdcBrokerIDType	appId,TThostFtdcUserIDType	userId)
{
	CThostFtdcUserLogoutField req;
	memset(&req, 0, sizeof(req));
	strcpy(req.BrokerID, appId);
	strcpy(req.UserID, userId);
	return this->md_UserApi->ReqUserLogout(&req, ++requestId);
}
int MdApi::Join()
{
	return this->md_UserApi->Join();
}
int MdApi::SubscribeMarketData(char* instIdList)
{
	vector<char*> list;
	char *token;
	while((token = strsep (&instIdList,","))!=NULL)				
	{						
		list.push_back(token); 					
	}
		unsigned int len = list.size();			
		char** pInstId = new char* [len];  					
		for(unsigned int i=0; i<len;i++) 						
		pInstId[i]=list[i];
	return this->md_UserApi->SubscribeMarketData(pInstId, len);	
}
