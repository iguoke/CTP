#include "Globals.h"
#include <string.h>
int req=0;
void CtpMd::OnFrontConnected()
{
  //printf("ctpmdapi connected!\n");
  //CTPMDOnFront();
  OnFront(CtpMdOnFront);
}
void CtpMdOnFront()
{
  printf("ctpmdapi connected!\n"); 
  //Print(&stringq,"","CTPMD Connected!");
}
void CtpMd::OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
  //printf("ctpmdapi login!\n");
  OnLogin((void*)pRspUserLogin,CtpMdOnLogin);
}
void CtpMdOnLogin(void *acc)
{
 printf("ctpmdapi login!\n");
 //(CThostFtdcRspUserLoginField *)acc->
}
void CtpMd::OnRtnDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData)
{
  printf("ctpmdapi OnRtnDepthMarketData!\n");
  OnMarket((void*)pDepthMarketData,CtpMdOnMarket);
}
void CtpMdOnMarket(void *data)
{
  
  printf("%f\n",((CThostFtdcDepthMarketDataField *)data)->LastPrice);
}
void CtpMdCreateApi(void *ctpapi)
{
  //printf("ctpmdapi connected!\n");
  ((CtpMdApi*)ctpapi)->api = CThostFtdcMdApi::CreateFtdcMdApi("MD",false);
  ((CtpMdApi*)ctpapi)->spi = new CtpMd();
}

void CtpMdConnect(void *ctpapi,char *pFront)
{
  ((CtpMdApi*)ctpapi)->api->RegisterSpi(((CtpMdApi*)ctpapi)->spi);
  ((CtpMdApi*)ctpapi)->api->RegisterFront(pFront);
  ((CtpMdApi*)ctpapi)->api->Init();
   printf("end!\n");
  //((CtpApi*)ctpapi)->api->Join(); 
}
void CtpMdLogin(void *ctpapi,char* pInvestor, char* pPwd, char* pBroker)
{
  CThostFtdcReqUserLoginField f;
  memset(&f, 0, sizeof(CThostFtdcReqUserLoginField));
  strcpy(f.BrokerID,pBroker);
  strcpy(f.UserID, pInvestor);
  strcpy(f.Password, pPwd);
  ((CtpMdApi*)ctpapi)->api->ReqUserLogin(&f, ++req);
  //printf("ctpmdapi login!\n");
}
void SubMarketData(void*ctpapi,char*pInstrumentID)
{
  char *insts[] = { pInstrumentID };
  ((CtpMdApi*)ctpapi)->api->SubscribeMarketData(insts, 1);
}
