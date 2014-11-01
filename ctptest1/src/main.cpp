#include "MD.h"
#include "TD.h"
using namespace std;
int nRequestID=0;
char *ppInstrumentID[]={"ag1412"};
char mdFront[]="tcp://115.238.108.184:41213";
int TDnRequestID=0;
char tradeFront[]="tcp://115.238.53.139:51205";

//////////////////////////////////////////////////////////////////////////////////////////////////
int main()
{
	/////////////////////////MD//////////////////////////////////////////
	CThostFtdcMdApi* pUserApi= CThostFtdcMdApi::CreateFtdcMdApi();
	MD* pUserSpi = new MD(pUserApi);
	pUserApi->RegisterSpi((CThostFtdcMdSpi*)pUserSpi);			// 注册事件类
	pUserApi->RegisterFront(mdFront);							// 注册交易前置地址
	pUserApi->Init();
	
	//pUserApi->Join();
	////////////////////////TD//////////////////////////////////////////
	CThostFtdcTraderApi* TDpUserApi= CThostFtdcTraderApi::CreateFtdcTraderApi();
	TD* TDpUserSpi = new TD(TDpUserApi);
	TDpUserApi->RegisterSpi((CThostFtdcTraderSpi*)TDpUserSpi);			// 注册事件类
	TDpUserApi->SubscribePublicTopic(THOST_TERT_RESTART);					// 注册公有流
	TDpUserApi->SubscribePrivateTopic(THOST_TERT_RESTART);			  // 注册私有流
	TDpUserApi->RegisterFront(tradeFront);							// 注册交易前置地址
	TDpUserApi->Init();
	
	TDpUserApi->Join();  
	//TDpUserApi->Release();  
}
//g++  main.cpp -L. -lthostmduserapi -o test
//sudo cp libthostmduserapi.so ~/../../usr/lib

