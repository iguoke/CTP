#include "MD.h"
extern int nRequestID;
extern char *ppInstrumentID[];
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

