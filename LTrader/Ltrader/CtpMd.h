#ifndef __CTPMD_H__
#define __CTPMD_H__
#include "Globals.h"
#include "ThostFtdcMdApi.h"
class CTPMD:public CThostFtdcMdSpi
{
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
};

#endif
