#include<iostream>
#include "ThostFtdcMdApi.h"
using namespace std;
int nRequestID=0;
char *ppInstrumentID[]={"ag1412"};
char tradeFront[]="tcp://115.238.108.184:41213";
class MD:public CThostFtdcMdSpi
{
public:
	 MD(CThostFtdcMdApi* api):pUserApi(api){};
public:
	///µ±¿Í»§¶ËÓëœ»Ò×ºóÌšœšÁ¢ÆðÍšÐÅÁ¬œÓÊ±£š»¹ÎŽµÇÂŒÇ°£©£¬žÃ·œ·š±»µ÷ÓÃ¡£
	virtual void OnFrontConnected();
	
	///µ±¿Í»§¶ËÓëœ»Ò×ºóÌšÍšÐÅÁ¬œÓ¶Ï¿ªÊ±£¬žÃ·œ·š±»µ÷ÓÃ¡£µ±·¢ÉúÕâžöÇé¿öºó£¬API»á×Ô¶¯ÖØÐÂÁ¬œÓ£¬¿Í»§¶Ë¿É²»×öŽŠÀí¡£
	///@param nReason ŽíÎóÔ­Òò
	///        0x1001 ÍøÂç¶ÁÊ§°Ü
	///        0x1002 ÍøÂçÐŽÊ§°Ü
	///        0x2001 œÓÊÕÐÄÌø³¬Ê±
	///        0x2002 ·¢ËÍÐÄÌøÊ§°Ü
	///        0x2003 ÊÕµœŽíÎó±šÎÄ
	virtual void OnFrontDisconnected(int nReason){};
		
	///ÐÄÌø³¬Ê±Ÿ¯žæ¡£µ±³€Ê±ŒäÎŽÊÕµœ±šÎÄÊ±£¬žÃ·œ·š±»µ÷ÓÃ¡£
	///@param nTimeLapse ŸàÀëÉÏŽÎœÓÊÕ±šÎÄµÄÊ±Œä
	virtual void OnHeartBeatWarning(int nTimeLapse){};
	

	///µÇÂŒÇëÇóÏìÓŠ
	virtual void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);

	///µÇ³öÇëÇóÏìÓŠ
	virtual void OnRspUserLogout(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ŽíÎóÓŠŽð
	virtual void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);

	///¶©ÔÄÐÐÇéÓŠŽð
	virtual void OnRspSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);

	///È¡Ïû¶©ÔÄÐÐÇéÓŠŽð
	virtual void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///Éî¶ÈÐÐÇéÍšÖª
	virtual void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData);
private:
  CThostFtdcMdApi* pUserApi;
};

//////////////////////////////////////////////////////////////////////////////////////////////////////
void MD::OnFrontConnected()
{
	cout<<"OnFrontConnected!"<<endl;
	CThostFtdcReqUserLoginField pReqUserLoginField;
	pUserApi-> ReqUserLogin(&pReqUserLoginField,nRequestID++);
}
void MD::OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
  cout<<"OnRspUserLogin!"<<endl;
	pUserApi->SubscribeMarketData(ppInstrumentID,1);
}
void MD::OnRspSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	cout<<"OnRspSubMarketData!"<<endl;
	cout<<pRspInfo->ErrorMsg<<endl;
}
 void MD::OnRtnDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData) 
{
	//cout<<"OnRtnDepthMarketData!"<<endl;
	cout<<pDepthMarketData->InstrumentID<<"->"<<pDepthMarketData->LastPrice<<endl;
}
void MD::OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
	cout<<"OnRspError->"<<pRspInfo->ErrorMsg<<endl;
}
//////////////////////////////////////////////////////////////////////////////////////////////////
int main()
{
	CThostFtdcMdApi* pUserApi= CThostFtdcMdApi::CreateFtdcMdApi();
	MD* pUserSpi = new MD(pUserApi);
	pUserApi->RegisterSpi((CThostFtdcMdSpi*)pUserSpi);			// 注册事件类
	pUserApi->RegisterFront(tradeFront);							// 注册交易前置地址
	pUserApi->Init();
	
	pUserApi->Join();  
}
//g++  main.cpp -L. -lthostmduserapi -o test

