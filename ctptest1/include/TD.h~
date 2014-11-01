#include<iostream>
#include "ThostFtdcTraderApi.h"
using namespace std;
class TD :public CThostFtdcTraderSpi
{
  public: TD(CThostFtdcTraderApi* api):pUserApi(api){};
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
	
	///¿Í»§¶ËÈÏÖ€ÏìÓŠ
	virtual void OnRspAuthenticate(CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};
	

	///µÇÂŒÇëÇóÏìÓŠ
	virtual void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///µÇ³öÇëÇóÏìÓŠ
	virtual void OnRspUserLogout(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÓÃ»§¿ÚÁîžüÐÂÇëÇóÏìÓŠ
	virtual void OnRspUserPasswordUpdate(CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///×ÊœðÕË»§¿ÚÁîžüÐÂÇëÇóÏìÓŠ
	virtual void OnRspTradingAccountPasswordUpdate(CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///±šµ¥ÂŒÈëÇëÇóÏìÓŠ
	virtual void OnRspOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///Ô€Âñµ¥ÂŒÈëÇëÇóÏìÓŠ
	virtual void OnRspParkedOrderInsert(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///Ô€Âñ³·µ¥ÂŒÈëÇëÇóÏìÓŠ
	virtual void OnRspParkedOrderAction(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///±šµ¥²Ù×÷ÇëÇóÏìÓŠ
	virtual void OnRspOrderAction(CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///²éÑ¯×îŽó±šµ¥ÊýÁ¿ÏìÓŠ
	virtual void OnRspQueryMaxOrderVolume(CThostFtdcQueryMaxOrderVolumeField *pQueryMaxOrderVolume, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///Í¶×ÊÕßœáËãœá¹ûÈ·ÈÏÏìÓŠ
	virtual void OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÉŸ³ýÔ€Âñµ¥ÏìÓŠ
	virtual void OnRspRemoveParkedOrder(CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÉŸ³ýÔ€Âñ³·µ¥ÏìÓŠ
	virtual void OnRspRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯±šµ¥ÏìÓŠ
	virtual void OnRspQryOrder(CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯³Éœ»ÏìÓŠ
	virtual void OnRspQryTrade(CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯Í¶×ÊÕß³Ö²ÖÏìÓŠ
	virtual void OnRspQryInvestorPosition(CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯×ÊœðÕË»§ÏìÓŠ
	virtual void OnRspQryTradingAccount(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯Í¶×ÊÕßÏìÓŠ
	virtual void OnRspQryInvestor(CThostFtdcInvestorField *pInvestor, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯œ»Ò×±àÂëÏìÓŠ
	virtual void OnRspQryTradingCode(CThostFtdcTradingCodeField *pTradingCode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯ºÏÔŒ±£Ö€œðÂÊÏìÓŠ
	virtual void OnRspQryInstrumentMarginRate(CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯ºÏÔŒÊÖÐø·ÑÂÊÏìÓŠ
	virtual void OnRspQryInstrumentCommissionRate(CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯œ»Ò×ËùÏìÓŠ
	virtual void OnRspQryExchange(CThostFtdcExchangeField *pExchange, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯²úÆ·ÏìÓŠ
	virtual void OnRspQryProduct(CThostFtdcProductField *pProduct, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯ºÏÔŒÏìÓŠ
	virtual void OnRspQryInstrument(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯ÐÐÇéÏìÓŠ
	virtual void OnRspQryDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯Í¶×ÊÕßœáËãœá¹ûÏìÓŠ
	virtual void OnRspQrySettlementInfo(CThostFtdcSettlementInfoField *pSettlementInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯×ªÕÊÒøÐÐÏìÓŠ
	virtual void OnRspQryTransferBank(CThostFtdcTransferBankField *pTransferBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯Í¶×ÊÕß³Ö²ÖÃ÷ÏžÏìÓŠ
	virtual void OnRspQryInvestorPositionDetail(CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯¿Í»§ÍšÖªÏìÓŠ
	virtual void OnRspQryNotice(CThostFtdcNoticeField *pNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯œáËãÐÅÏ¢È·ÈÏÏìÓŠ
	virtual void OnRspQrySettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯Í¶×ÊÕß³Ö²ÖÃ÷ÏžÏìÓŠ
	virtual void OnRspQryInvestorPositionCombineDetail(CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///²éÑ¯±£Ö€œðŒà¹ÜÏµÍ³Ÿ­ŒÍ¹«ËŸ×ÊœðÕË»§ÃÜÔ¿ÏìÓŠ
	virtual void OnRspQryCFMMCTradingAccountKey(CThostFtdcCFMMCTradingAccountKeyField *pCFMMCTradingAccountKey, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯²Öµ¥ÕÛµÖÐÅÏ¢ÏìÓŠ
	virtual void OnRspQryEWarrantOffset(CThostFtdcEWarrantOffsetField *pEWarrantOffset, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯Í¶×ÊÕßÆ·ÖÖ/¿çÆ·ÖÖ±£Ö€œðÏìÓŠ
	virtual void OnRspQryInvestorProductGroupMargin(CThostFtdcInvestorProductGroupMarginField *pInvestorProductGroupMargin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯œ»Ò×Ëù±£Ö€œðÂÊÏìÓŠ
	virtual void OnRspQryExchangeMarginRate(CThostFtdcExchangeMarginRateField *pExchangeMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯œ»Ò×Ëùµ÷Õû±£Ö€œðÂÊÏìÓŠ
	virtual void OnRspQryExchangeMarginRateAdjust(CThostFtdcExchangeMarginRateAdjustField *pExchangeMarginRateAdjust, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯»ãÂÊÏìÓŠ
	virtual void OnRspQryExchangeRate(CThostFtdcExchangeRateField *pExchangeRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯¶þŒ¶ŽúÀí²Ù×÷Ô±ÒøÆÚÈšÏÞÏìÓŠ
	virtual void OnRspQrySecAgentACIDMap(CThostFtdcSecAgentACIDMapField *pSecAgentACIDMap, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯×ªÕÊÁ÷Ë®ÏìÓŠ
	virtual void OnRspQryTransferSerial(CThostFtdcTransferSerialField *pTransferSerial, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯ÒøÆÚÇ©ÔŒ¹ØÏµÏìÓŠ
	virtual void OnRspQryAccountregister(CThostFtdcAccountregisterField *pAccountregister, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ŽíÎóÓŠŽð
	virtual void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///±šµ¥ÍšÖª
	virtual void OnRtnOrder(CThostFtdcOrderField *pOrder) {};

	///³Éœ»ÍšÖª
	virtual void OnRtnTrade(CThostFtdcTradeField *pTrade) {};

	///±šµ¥ÂŒÈëŽíÎó»Ø±š
	virtual void OnErrRtnOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo) {};

	///±šµ¥²Ù×÷ŽíÎó»Ø±š
	virtual void OnErrRtnOrderAction(CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo) {};

	///ºÏÔŒœ»Ò××ŽÌ¬ÍšÖª
	virtual void OnRtnInstrumentStatus(CThostFtdcInstrumentStatusField *pInstrumentStatus) {};

	///œ»Ò×ÍšÖª
	virtual void OnRtnTradingNotice(CThostFtdcTradingNoticeInfoField *pTradingNoticeInfo) {};

	///ÌáÊŸÌõŒþµ¥Ð£ÑéŽíÎó
	virtual void OnRtnErrorConditionalOrder(CThostFtdcErrorConditionalOrderField *pErrorConditionalOrder) {};

	///±£Ö€œðŒà¿ØÖÐÐÄÓÃ»§ÁîÅÆ
	virtual void OnRtnCFMMCTradingAccountToken(CThostFtdcCFMMCTradingAccountTokenField *pCFMMCTradingAccountToken) {};

	///ÇëÇó²éÑ¯Ç©ÔŒÒøÐÐÏìÓŠ
	virtual void OnRspQryContractBank(CThostFtdcContractBankField *pContractBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯Ô€Âñµ¥ÏìÓŠ
	virtual void OnRspQryParkedOrder(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯Ô€Âñ³·µ¥ÏìÓŠ
	virtual void OnRspQryParkedOrderAction(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯œ»Ò×ÍšÖªÏìÓŠ
	virtual void OnRspQryTradingNotice(CThostFtdcTradingNoticeField *pTradingNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯Ÿ­ŒÍ¹«ËŸœ»Ò×²ÎÊýÏìÓŠ
	virtual void OnRspQryBrokerTradingParams(CThostFtdcBrokerTradingParamsField *pBrokerTradingParams, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯Ÿ­ŒÍ¹«ËŸœ»Ò×Ëã·šÏìÓŠ
	virtual void OnRspQryBrokerTradingAlgos(CThostFtdcBrokerTradingAlgosField *pBrokerTradingAlgos, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÇëÇó²éÑ¯Œà¿ØÖÐÐÄÓÃ»§ÁîÅÆ
	virtual void OnRspQueryCFMMCTradingAccountToken(CThostFtdcQueryCFMMCTradingAccountTokenField *pQueryCFMMCTradingAccountToken, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÒøÐÐ·¢ÆðÒøÐÐ×Êœð×ªÆÚ»õÍšÖª
	virtual void OnRtnFromBankToFutureByBank(CThostFtdcRspTransferField *pRspTransfer) {};

	///ÒøÐÐ·¢ÆðÆÚ»õ×Êœð×ªÒøÐÐÍšÖª
	virtual void OnRtnFromFutureToBankByBank(CThostFtdcRspTransferField *pRspTransfer) {};

	///ÒøÐÐ·¢Æð³åÕýÒøÐÐ×ªÆÚ»õÍšÖª
	virtual void OnRtnRepealFromBankToFutureByBank(CThostFtdcRspRepealField *pRspRepeal) {};

	///ÒøÐÐ·¢Æð³åÕýÆÚ»õ×ªÒøÐÐÍšÖª
	virtual void OnRtnRepealFromFutureToBankByBank(CThostFtdcRspRepealField *pRspRepeal) {};

	///ÆÚ»õ·¢ÆðÒøÐÐ×Êœð×ªÆÚ»õÍšÖª
	virtual void OnRtnFromBankToFutureByFuture(CThostFtdcRspTransferField *pRspTransfer) {};

	///ÆÚ»õ·¢ÆðÆÚ»õ×Êœð×ªÒøÐÐÍšÖª
	virtual void OnRtnFromFutureToBankByFuture(CThostFtdcRspTransferField *pRspTransfer) {};

	///ÏµÍ³ÔËÐÐÊ±ÆÚ»õ¶ËÊÖ¹€·¢Æð³åÕýÒøÐÐ×ªÆÚ»õÇëÇó£¬ÒøÐÐŽŠÀíÍê±Ïºó±šÅÌ·¢»ØµÄÍšÖª
	virtual void OnRtnRepealFromBankToFutureByFutureManual(CThostFtdcRspRepealField *pRspRepeal) {};

	///ÏµÍ³ÔËÐÐÊ±ÆÚ»õ¶ËÊÖ¹€·¢Æð³åÕýÆÚ»õ×ªÒøÐÐÇëÇó£¬ÒøÐÐŽŠÀíÍê±Ïºó±šÅÌ·¢»ØµÄÍšÖª
	virtual void OnRtnRepealFromFutureToBankByFutureManual(CThostFtdcRspRepealField *pRspRepeal) {};

	///ÆÚ»õ·¢Æð²éÑ¯ÒøÐÐÓà¶îÍšÖª
	virtual void OnRtnQueryBankBalanceByFuture(CThostFtdcNotifyQueryAccountField *pNotifyQueryAccount) {};

	///ÆÚ»õ·¢ÆðÒøÐÐ×Êœð×ªÆÚ»õŽíÎó»Ø±š
	virtual void OnErrRtnBankToFutureByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) {};

	///ÆÚ»õ·¢ÆðÆÚ»õ×Êœð×ªÒøÐÐŽíÎó»Ø±š
	virtual void OnErrRtnFutureToBankByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) {};

	///ÏµÍ³ÔËÐÐÊ±ÆÚ»õ¶ËÊÖ¹€·¢Æð³åÕýÒøÐÐ×ªÆÚ»õŽíÎó»Ø±š
	virtual void OnErrRtnRepealBankToFutureByFutureManual(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) {};

	///ÏµÍ³ÔËÐÐÊ±ÆÚ»õ¶ËÊÖ¹€·¢Æð³åÕýÆÚ»õ×ªÒøÐÐŽíÎó»Ø±š
	virtual void OnErrRtnRepealFutureToBankByFutureManual(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) {};

	///ÆÚ»õ·¢Æð²éÑ¯ÒøÐÐÓà¶îŽíÎó»Ø±š
	virtual void OnErrRtnQueryBankBalanceByFuture(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo) {};

	///ÆÚ»õ·¢Æð³åÕýÒøÐÐ×ªÆÚ»õÇëÇó£¬ÒøÐÐŽŠÀíÍê±Ïºó±šÅÌ·¢»ØµÄÍšÖª
	virtual void OnRtnRepealFromBankToFutureByFuture(CThostFtdcRspRepealField *pRspRepeal) {};

	///ÆÚ»õ·¢Æð³åÕýÆÚ»õ×ªÒøÐÐÇëÇó£¬ÒøÐÐŽŠÀíÍê±Ïºó±šÅÌ·¢»ØµÄÍšÖª
	virtual void OnRtnRepealFromFutureToBankByFuture(CThostFtdcRspRepealField *pRspRepeal) {};

	///ÆÚ»õ·¢ÆðÒøÐÐ×Êœð×ªÆÚ»õÓŠŽð
	virtual void OnRspFromBankToFutureByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÆÚ»õ·¢ÆðÆÚ»õ×Êœð×ªÒøÐÐÓŠŽð
	virtual void OnRspFromFutureToBankByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÆÚ»õ·¢Æð²éÑ¯ÒøÐÐÓà¶îÓŠŽð
	virtual void OnRspQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) {};

	///ÒøÐÐ·¢ÆðÒøÆÚ¿ª»§ÍšÖª
	virtual void OnRtnOpenAccountByBank(CThostFtdcOpenAccountField *pOpenAccount) {};

	///ÒøÐÐ·¢ÆðÒøÆÚÏú»§ÍšÖª
	virtual void OnRtnCancelAccountByBank(CThostFtdcCancelAccountField *pCancelAccount) {};

	///ÒøÐÐ·¢Æð±äžüÒøÐÐÕËºÅÍšÖª
	virtual void OnRtnChangeAccountByBank(CThostFtdcChangeAccountField *pChangeAccount) {};
private:CThostFtdcTraderApi* pUserApi;
  
};

