#include<iostream>
#include "../include/CtpTraderSpi.h"
#include "../include/CSem.h"

using namespace std;

//请求编号
int requestId=0;

// 前置地址
char tradeFront[]="tcp://asp-sim2-front1.financial-trading-platform.com:26205";

CSem sem(0);

int main(){
	CThostFtdcTraderApi* pUserApi;//= CThostFtdcTraderApi::CreateFtdcTraderApi();
	//CtpTraderSpi* pUserSpi = new CtpTraderSpi(pUserApi);
	//pUserApi->RegisterSpi((CThostFtdcTraderSpi*)pUserSpi);			// 注册事件类
	//pUserApi->SubscribePublicTopic(THOST_TERT_RESTART);					// 注册公有流
	//pUserApi->SubscribePrivateTopic(THOST_TERT_RESTART);			  // 注册私有流
	//pUserApi->RegisterFront(tradeFront);							// 注册交易前置地址
	pUserApi->Init();
	//todo
	
	pUserApi->Join();  
	//pUserApi->Release();
}

class MD:public CThostFtdcMdSpi
{
public:
	// MD(CThostFtdcMdApi* api):pUserApi(api){};
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
	virtual void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///µÇ³öÇëÇóÏìÓŠ
	virtual void OnRspUserLogout(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ŽíÎóÓŠŽð
	virtual void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///¶©ÔÄÐÐÇéÓŠŽð
	virtual void OnRspSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///È¡Ïû¶©ÔÄÐÐÇéÓŠŽð
	virtual void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField *pSpecificInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///Éî¶ÈÐÐÇéÍšÖª
	virtual void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData) {};
private:
  //CThostFtdcMdApi* pUserApi;
};

void MD::OnFrontConnected()
{
	cout<<"OnFrontConnected!"<<endl;
}
