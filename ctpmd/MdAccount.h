#pragma once
//#ifndef _ACCOUNT _ACCOUNT_H
//#define _ACCOUNT _ACCOUNT_H
#include "ThostFtdcMdApi.h"
#include "Main.h"
class MdSpi:public CThostFtdcMdSpi
{
	public:
	     HunterEvent Event_OnFrontConnected,Event_OnFrontDisconnected,Event_OnHeartBeatWarning,Event_OnRspUserLogin,Event_OnRspUserLogout,Event_OnRspError,Event_OnRspSubMarketData,Event_OnRspUnSubMarketData,Event_OnRspSubForQuoteRsp,Event_OnRspUnSubForQuoteRsp,Event_OnRtnDepthMarketData,Event_OnRtnForQuoteRsp;
	public:
		///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
		virtual void OnFrontConnected();
		virtual void OnFrontDisconnected(int n);
        virtual void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
		virtual void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
			
		virtual void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData);
	private:
		bool IsErrorRspInfo(CThostFtdcRspInfoField *pRspInfo);

};
//////////////////MdApi///////////////////////
class MdApi
{
	private:
		CThostFtdcMdApi* md_UserApi;
		int requestId;
	public:
		void MdConnect(MdSpi *mdspi,char* addr);
		int SubscribeMarketData(char* instIdList);
     	int UnSubscribeMarketData(char* instIdList);
		int ReqUserLogin(TThostFtdcBrokerIDType	appId,TThostFtdcUserIDType	userId,	TThostFtdcPasswordType	passwd);
		int ReqUserLogout(TThostFtdcBrokerIDType	appId,TThostFtdcUserIDType	userId);
		int Join();
};
