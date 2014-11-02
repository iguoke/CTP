// MdApi.cpp : ���� DLL Ӧ�ó���ĵ���������
//
#include "stdafx.h"
#include "MdApi.h"
#include <iostream>
//#include <vector>		//��̬����,֧�ָ�ֵ
//using namespace std;

#include ".\api\ThostFtdcMdApi.h"

// UserApi����
CThostFtdcMdApi* pUserApi;

// ������
int iRequestID = 0;

//�ص�����
CBOnRspError cbOnRspError=0;
CBOnHeartBeatWarning cbOnHeartBeatWarning=0;

CBOnFrontConnected cbOnFrontConnected=0;
CBOnFrontDisconnected cbOnFrontDisconnected=0;
CBOnRspUserLogin cbOnRspUserLogin=0;
CBOnRspUserLogout cbOnRspUserLogout=0;
CBOnRspSubMarketData cbOnRspSubMarketData=0;
CBOnRspUnSubMarketData cbOnRspUnSubMarketData=0;
CBOnRtnDepthMarketData cbOnRtnDepthMarketData=0;

//����
MDAPI_API void Connect(char* FRONT_ADDR)
{
	
	CThostFtdcMdSpi* pUserSpi = new CMdSpi();
	// ��ʼ��UserApi
	pUserApi = CThostFtdcMdApi::CreateFtdcMdApi();			// ����UserApi

	pUserApi->RegisterSpi(pUserSpi);						// ע���¼���
	pUserApi->RegisterFront(FRONT_ADDR);					// connect
	pUserApi->Init();
//	pUserApi->Join();
}
MDAPI_API void DisConnect()
{
	pUserApi->Release();
}
//��¼
MDAPI_API void ReqUserLogin(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcPasswordType PASSWORD)
{	
	CThostFtdcReqUserLoginField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID, BROKER_ID);
	strcpy_s(req.UserID, INVESTOR_ID);
	strcpy_s(req.Password, PASSWORD);
	pUserApi->ReqUserLogin(&req, ++iRequestID);
}

///�ǳ�����
MDAPI_API void ReqUserLogout(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID)
{
	CThostFtdcUserLogoutField req;
	memset(&req,0,sizeof(req));
	strcpy_s(req.BrokerID,BROKER_ID);
	strcpy_s(req.UserID,INVESTOR_ID);
	pUserApi->ReqUserLogout(&req,++iRequestID);
}
//��������
MDAPI_API void SubMarketData(char* instrumentsID[],int nCount)
{
	pUserApi->SubscribeMarketData(instrumentsID,nCount);
}
///�˶�����
MDAPI_API void UnSubscribeMarketData(char *ppInstrumentID[], int nCount)
{
	pUserApi->UnSubscribeMarketData(ppInstrumentID, nCount);
}
///��ȡ��ǰ������:ֻ�е�¼�ɹ���,���ܵõ���ȷ�Ľ�����
MDAPI_API const char *GetTradingDay()
{
	return pUserApi->GetTradingDay();
}

//============================================ �ص� ����ע�� ===========================================
MDAPI_API void WINAPI RegOnRspError(CBOnRspError cb)
{
	cbOnRspError= cb;
}
//����
MDAPI_API void WINAPI RegOnHeartBeatWarning(CBOnHeartBeatWarning cb)
{
	cbOnHeartBeatWarning = cb;
}

//����Ӧ��
MDAPI_API void WINAPI RegOnFrontConnected(CBOnFrontConnected cb)
{
		cbOnFrontConnected=cb;
}
//���ӶϿ�
MDAPI_API void WINAPI RegOnFrontDisconnected(CBOnFrontDisconnected cb)
{
		cbOnFrontDisconnected=cb;
}
//��¼����Ӧ��
MDAPI_API void WINAPI RegOnRspUserLogin(CBOnRspUserLogin cb)
{
		cbOnRspUserLogin=cb;
}
//�ǳ�����Ӧ��
MDAPI_API void WINAPI RegOnRspUserLogout(CBOnRspUserLogout cb)
{
		cbOnRspUserLogout=cb;
}
//��������Ӧ��
MDAPI_API void WINAPI RegOnRspSubMarketData(CBOnRspSubMarketData cb)
{
		cbOnRspSubMarketData=cb;
}

//�˶�����Ӧ��
MDAPI_API void WINAPI RegOnRspUnSubMarketData(CBOnRspUnSubMarketData cb)
{
		cbOnRspUnSubMarketData=cb;
}
//�������֪ͨ
MDAPI_API void WINAPI RegOnRtnDepthMarketData(CBOnRtnDepthMarketData cb)
{
		cbOnRtnDepthMarketData=cb;
}