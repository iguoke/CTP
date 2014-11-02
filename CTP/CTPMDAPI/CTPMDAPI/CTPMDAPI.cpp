///本文档有刘建平提供转换工具
#include "stdafx.h"
#include "./ThostFtdcMdApi.h"

#ifdef CTPMDAPI_EXPORTS
#define CTPMDAPI_API __declspec(dllexport)
#else
#define 
CTPMDAPI_API __declspec(dllimport)
#endif
class  CCTPMDAPI:public CThostFtdcMdSpi

{
public:
	///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
	virtual void OnFrontConnected();
	
	///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
	///@param nReason 错误原因
	///        0x1001 网络读失败
	///        0x1002 网络写失败
	///        0x2001 接收心跳超时
	///        0x2002 发送心跳失败
	///        0x2003 收到错误报文
	virtual void OnFrontDisconnected(int nReason);
		
	///心跳超时警告。当长时间未收到报文时，该方法被调用。
	///@param nTimeLapse 距离上次接收报文的时间
	virtual void OnHeartBeatWarning(int nTimeLapse);
	

	///登录请求响应
	virtual void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///登出请求响应
	virtual void OnRspUserLogout(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///错误应答
	virtual void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///订阅行情应答
	virtual void OnRspSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///取消订阅行情应答
	virtual void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///深度行情通知
	virtual void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData) ;

    CCTPMDAPI(void);
};
typedef int (WINAPI *CBOnFrontConnected)();
typedef int (WINAPI *CBOnFrontDisconnected)(int nReason);
typedef int (WINAPI *CBOnHeartBeatWarning)(int nTimeLapse);
typedef int (WINAPI *CBOnRspUserLogin)(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspUserLogout)(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspError)(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspSubMarketData)(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspUnSubMarketData)(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRtnDepthMarketData)(CThostFtdcDepthMarketDataField *pDepthMarketData) ;
CBOnFrontConnected cbOnFrontConnected=0;
CBOnFrontDisconnected cbOnFrontDisconnected=0;
CBOnHeartBeatWarning cbOnHeartBeatWarning=0;
CBOnRspUserLogin cbOnRspUserLogin=0;
CBOnRspUserLogout cbOnRspUserLogout=0;
CBOnRspError cbOnRspError=0;
CBOnRspSubMarketData cbOnRspSubMarketData=0;
CBOnRspUnSubMarketData cbOnRspUnSubMarketData=0;
CBOnRtnDepthMarketData cbOnRtnDepthMarketData=0;
// 请求编号
int iRequestID = 0;
// UserApi对象
CThostFtdcMdApi* pUserApi;
void CCTPMDAPI::OnFrontConnected()
{
   if(cbOnFrontConnected!=NULL)
        cbOnFrontConnected();
}
void CCTPMDAPI::OnFrontDisconnected(int nReason)
{
   if(cbOnFrontDisconnected!=NULL)
        cbOnFrontDisconnected(nReason);
}
void CCTPMDAPI::OnHeartBeatWarning(int nTimeLapse)
{
   if(cbOnHeartBeatWarning!=NULL)
        cbOnHeartBeatWarning(nTimeLapse);
}
void CCTPMDAPI::OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspUserLogin!=NULL)
        cbOnRspUserLogin(pRspUserLogin,pRspInfo,nRequestID,bIsLast);
}
void CCTPMDAPI::OnRspUserLogout(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspUserLogout!=NULL)
        cbOnRspUserLogout(pUserLogout,pRspInfo,nRequestID,bIsLast);
}
void CCTPMDAPI::OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspError!=NULL)
        cbOnRspError(pRspInfo,nRequestID,bIsLast);
}
void CCTPMDAPI::OnRspSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspSubMarketData!=NULL)
        cbOnRspSubMarketData(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
}
void CCTPMDAPI::OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspUnSubMarketData!=NULL)
        cbOnRspUnSubMarketData(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
}
void CCTPMDAPI::OnRtnDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData) 
{
   if(cbOnRtnDepthMarketData!=NULL)
        cbOnRtnDepthMarketData(pDepthMarketData);
}
CTPMDAPI_API void WINAPI RegOnFrontConnected(CBOnFrontConnected cb)
{
    cbOnFrontConnected=cb;
}
CTPMDAPI_API void WINAPI RegOnFrontDisconnected(CBOnFrontDisconnected cb)
{
    cbOnFrontDisconnected=cb;
}
CTPMDAPI_API void WINAPI RegOnHeartBeatWarning(CBOnHeartBeatWarning cb)
{
    cbOnHeartBeatWarning=cb;
}
CTPMDAPI_API void WINAPI RegOnRspUserLogin(CBOnRspUserLogin cb)
{
    cbOnRspUserLogin=cb;
}
CTPMDAPI_API void WINAPI RegOnRspUserLogout(CBOnRspUserLogout cb)
{
    cbOnRspUserLogout=cb;
}
CTPMDAPI_API void WINAPI RegOnRspError(CBOnRspError cb)
{
    cbOnRspError=cb;
}
CTPMDAPI_API void WINAPI RegOnRspSubMarketData(CBOnRspSubMarketData cb)
{
    cbOnRspSubMarketData=cb;
}
CTPMDAPI_API void WINAPI RegOnRspUnSubMarketData(CBOnRspUnSubMarketData cb)
{
    cbOnRspUnSubMarketData=cb;
}
CTPMDAPI_API void WINAPI RegOnRtnDepthMarketData(CBOnRtnDepthMarketData cb)
{
    cbOnRtnDepthMarketData=cb;
}
CCTPMDAPI::CCTPMDAPI()
{
 return;
}
//连接
CTPMDAPI_API void Connect(char* FRONT_ADDR[])
{
	
	CThostFtdcMdSpi* pUserSpi = new CCTPMDAPI();
	// 初始化UserApi
	pUserApi = CThostFtdcMdApi::CreateFtdcMdApi("MD");			// 创建UserApi

	pUserApi->RegisterSpi(pUserSpi);						// 注册事件类
	for(int i=0;i<sizeof(FRONT_ADDR)/sizeof(char*);i++)
	{
		pUserApi->RegisterFront(FRONT_ADDR[i]);
	}
	// connect
	pUserApi->Init();
//	pUserApi->Join();
}
CTPMDAPI_API void Release()
{
	pUserApi->Release();
}
CTPMDAPI_API int Join()
{
	return pUserApi->Join();
}
//登录
CTPMDAPI_API int ReqUserLogin(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcPasswordType PASSWORD)
{	
	CThostFtdcReqUserLoginField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID, BROKER_ID);
	strcpy_s(req.UserID, INVESTOR_ID);
	strcpy_s(req.Password, PASSWORD);
	return pUserApi->ReqUserLogin(&req, ++iRequestID);
}

///登出请求
CTPMDAPI_API int  ReqUserLogout(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID)
{
	CThostFtdcUserLogoutField req;
	memset(&req,0,sizeof(req));
	strcpy_s(req.BrokerID,BROKER_ID);
	strcpy_s(req.UserID,INVESTOR_ID);
	return pUserApi->ReqUserLogout(&req,++iRequestID);
}
//订阅行情
CTPMDAPI_API int SubMarketData(char* instrumentsID[],int nCount)
{
	return pUserApi->SubscribeMarketData(instrumentsID,nCount);
}
///退订行情
CTPMDAPI_API int UnSubscribeMarketData(char *ppInstrumentID[], int nCount)
{
	return pUserApi->UnSubscribeMarketData(ppInstrumentID, nCount);
}
///获取当前交易日:只有登录成功后,才能得到正确的交易日
CTPMDAPI_API const char *GetTradingDay()
{
	return pUserApi->GetTradingDay();
}
