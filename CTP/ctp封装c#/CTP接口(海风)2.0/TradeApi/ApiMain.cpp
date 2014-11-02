
#include "stdafx.h"
#include "TradeApi.h"
#include ".\api\ThostFtdcUserApiDataType.h"
#include ".\api\ThostFtdcUserApiStruct.h"

// UserApi����
CThostFtdcTraderApi* pUserApi;

//�ص�����
CBOnFrontConnected cbOnFrontConnected=0;		///���ͻ����뽻�׺�̨������ͨ������ʱ����δ��¼ǰ�����÷��������á�
CBOnFrontDisconnected cbOnFrontDisconnected=0;		///���ͻ����뽻�׺�̨ͨ�����ӶϿ�ʱ���÷��������á���������������API���Զ��������ӣ��ͻ��˿ɲ�������
CBOnHeartBeatWarning cbOnHeartBeatWarning=0;		///������ʱ���档����ʱ��δ�յ�����ʱ���÷��������á�
CBRspUserLogin cbRspUserLogin=0;	///��¼������Ӧ
CBRspUserLogout cbRspUserLogout=0;	///�ǳ�������Ӧ
CBRspUserPasswordUpdate cbRspUserPasswordUpdate=0;	///�û��������������Ӧ
CBRspTradingAccountPasswordUpdate cbRspTradingAccountPasswordUpdate=0;	///�ʽ��˻��������������Ӧ
CBRspOrderInsert cbRspOrderInsert=0;	///����¼��������Ӧ
CBRspParkedOrderInsert cbRspParkedOrderInsert=0;	///Ԥ��¼��������Ӧ
CBRspParkedOrderAction cbRspParkedOrderAction=0;	///Ԥ�񳷵�¼��������Ӧ
CBRspOrderAction cbRspOrderAction=0;	///��������������Ӧ
CBRspQueryMaxOrderVolume cbRspQueryMaxOrderVolume=0;	///��ѯ��󱨵�������Ӧ
CBRspSettlementInfoConfirm cbRspSettlementInfoConfirm=0;	///Ͷ���߽�����ȷ����Ӧ
CBRspRemoveParkedOrder cbRspRemoveParkedOrder=0;	///ɾ��Ԥ����Ӧ
CBRspRemoveParkedOrderAction cbRspRemoveParkedOrderAction=0;	///ɾ��Ԥ�񳷵���Ӧ
CBRspQryOrder cbRspQryOrder=0;	///�����ѯ������Ӧ
CBRspQryTrade cbRspQryTrade=0;	///�����ѯ�ɽ���Ӧ
CBRspQryInvestorPosition cbRspQryInvestorPosition=0;	///�����ѯͶ���ֲ߳���Ӧ
CBRspQryTradingAccount cbRspQryTradingAccount=0;	///�����ѯ�ʽ��˻���Ӧ
CBRspQryInvestor cbRspQryInvestor=0;	///�����ѯͶ������Ӧ
CBRspQryTradingCode cbRspQryTradingCode=0;	///�����ѯ���ױ�����Ӧ
CBRspQryInstrumentMarginRate cbRspQryInstrumentMarginRate=0;	///�����ѯ��Լ��֤������Ӧ
CBRspQryInstrumentCommissionRate cbRspQryInstrumentCommissionRate=0;	///�����ѯ��Լ����������Ӧ
CBRspQryExchange cbRspQryExchange=0;	///�����ѯ��������Ӧ
CBRspQryInstrument cbRspQryInstrument=0;	///�����ѯ��Լ��Ӧ
CBRspQryDepthMarketData cbRspQryDepthMarketData=0;	///�����ѯ������Ӧ
CBRspQrySettlementInfo cbRspQrySettlementInfo=0;	///�����ѯͶ���߽�������Ӧ
CBRspQryTransferBank cbRspQryTransferBank=0;	///�����ѯת��������Ӧ
CBRspQryInvestorPositionDetail cbRspQryInvestorPositionDetail=0;	///�����ѯͶ���ֲ߳���ϸ��Ӧ
CBRspQryNotice cbRspQryNotice=0;	///�����ѯ�ͻ�֪ͨ��Ӧ
CBRspQrySettlementInfoConfirm cbRspQrySettlementInfoConfirm=0;	///�����ѯ������Ϣȷ����Ӧ
CBRspQryInvestorPositionCombineDetail cbRspQryInvestorPositionCombineDetail=0;	///�����ѯͶ���ֲ߳���ϸ��Ӧ
CBRspQryCFMMCTradingAccountKey cbRspQryCFMMCTradingAccountKey=0;	///��ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ��Ӧ
CBRspQryTransferSerial cbRspQryTransferSerial=0;	///�����ѯת����ˮ��Ӧ
CBRspError cbRspError=0;	///����Ӧ��
CBRtnOrder cbRtnOrder=0;	///����֪ͨ
CBRtnTrade cbRtnTrade=0;	///�ɽ�֪ͨ
CBErrRtnOrderInsert cbErrRtnOrderInsert=0;	///����¼�����ر�
CBErrRtnOrderAction cbErrRtnOrderAction=0;	///������������ر�
CBRtnInstrumentStatus cbRtnInstrumentStatus=0;	///��Լ����״̬֪ͨ
CBRtnTradingNotice cbRtnTradingNotice=0;	///����֪ͨ
CBRtnErrorConditionalOrder cbRtnErrorConditionalOrder=0;	///��ʾ������У�����
CBRspQryContractBank cbRspQryContractBank=0;	///�����ѯǩԼ������Ӧ
CBRspQryParkedOrder cbRspQryParkedOrder=0;	///�����ѯԤ����Ӧ
CBRspQryParkedOrderAction cbRspQryParkedOrderAction=0;	///�����ѯԤ�񳷵���Ӧ
CBRspQryTradingNotice cbRspQryTradingNotice=0;	///�����ѯ����֪ͨ��Ӧ
CBRspQryBrokerTradingParams cbRspQryBrokerTradingParams=0;	///�����ѯ���͹�˾���ײ�����Ӧ
CBRspQryBrokerTradingAlgos cbRspQryBrokerTradingAlgos=0;	///�����ѯ���͹�˾�����㷨��Ӧ
CBRtnFromBankToFutureByBank cbRtnFromBankToFutureByBank=0;	///���з��������ʽ�ת�ڻ�֪ͨ
CBRtnFromFutureToBankByBank cbRtnFromFutureToBankByBank=0;	///���з����ڻ��ʽ�ת����֪ͨ
CBRtnRepealFromBankToFutureByBank cbRtnRepealFromBankToFutureByBank=0;	///���з����������ת�ڻ�֪ͨ
CBRtnRepealFromFutureToBankByBank cbRtnRepealFromFutureToBankByBank=0;	///���з�������ڻ�ת����֪ͨ
CBRtnFromBankToFutureByFuture cbRtnFromBankToFutureByFuture=0;	///�ڻ����������ʽ�ת�ڻ�֪ͨ
CBRtnFromFutureToBankByFuture cbRtnFromFutureToBankByFuture=0;	///�ڻ������ڻ��ʽ�ת����֪ͨ
CBRtnRepealFromBankToFutureByFutureManual cbRtnRepealFromBankToFutureByFutureManual=0;	///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
CBRtnRepealFromFutureToBankByFutureManual cbRtnRepealFromFutureToBankByFutureManual=0;	///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
CBRtnQueryBankBalanceByFuture cbRtnQueryBankBalanceByFuture=0;	///�ڻ������ѯ�������֪ͨ
CBErrRtnBankToFutureByFuture cbErrRtnBankToFutureByFuture=0;	///�ڻ����������ʽ�ת�ڻ�����ر�
CBErrRtnFutureToBankByFuture cbErrRtnFutureToBankByFuture=0;	///�ڻ������ڻ��ʽ�ת���д���ر�
CBErrRtnRepealBankToFutureByFutureManual cbErrRtnRepealBankToFutureByFutureManual=0;	///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ�����ر�
CBErrRtnRepealFutureToBankByFutureManual cbErrRtnRepealFutureToBankByFutureManual=0;	///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת���д���ر�
CBErrRtnQueryBankBalanceByFuture cbErrRtnQueryBankBalanceByFuture=0;	///�ڻ������ѯ����������ر�
CBRtnRepealFromBankToFutureByFuture cbRtnRepealFromBankToFutureByFuture=0;	///�ڻ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
CBRtnRepealFromFutureToBankByFuture cbRtnRepealFromFutureToBankByFuture=0;	///�ڻ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
CBRspFromBankToFutureByFuture cbRspFromBankToFutureByFuture=0;	///�ڻ����������ʽ�ת�ڻ�Ӧ��
CBRspFromFutureToBankByFuture cbRspFromFutureToBankByFuture=0;	///�ڻ������ڻ��ʽ�ת����Ӧ��
CBRspQueryBankAccountMoneyByFuture cbRspQueryBankAccountMoneyByFuture=0;	///�ڻ������ѯ�������Ӧ��
//===============

// ������
int iRequestID = 0;
//����
TRADEAPI_API void Connect(char* FRONT_ADDR)
{
	// ��ʼ��UserApi
	pUserApi = CThostFtdcTraderApi::CreateFtdcTraderApi();			// ����UserApi
	CTraderSpi* pUserSpi = new CTraderSpi();
	pUserApi->RegisterSpi((CThostFtdcTraderSpi*)pUserSpi);			// ע���¼���
	pUserApi->SubscribePublicTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// ע�ṫ����
	pUserApi->SubscribePrivateTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// ע��˽����
	pUserApi->RegisterFront(FRONT_ADDR);							// connect
	pUserApi->Init();
	//pUserApi->Join();
}

TRADEAPI_API const char *GetTradingDay()
{
	return pUserApi->GetTradingDay();
}
//�Ͽ�
TRADEAPI_API void DisConnect()
{
	pUserApi->Release();
}
//�����û���¼����
TRADEAPI_API int ReqUserLogin(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcUserIDType USER_ID,TThostFtdcPasswordType PASSWORD)
{
	CThostFtdcReqUserLoginField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID, BROKER_ID);
	strcpy_s(req.UserID, USER_ID);
	strcpy_s(req.Password, PASSWORD);
	strcpy_s(req.UserProductInfo,"HF");
	return pUserApi->ReqUserLogin(&req, ++iRequestID);
}
//���͵ǳ�����
TRADEAPI_API int ReqUserLogout(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcUserIDType INVESTOR_ID)
{
	CThostFtdcUserLogoutField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID, BROKER_ID);
	strcpy_s(req.UserID, INVESTOR_ID);
	return pUserApi->ReqUserLogout(&req, ++iRequestID);
}
//�����û�����
TRADEAPI_API int ReqUserPasswordUpdate(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcUserIDType USER_ID,TThostFtdcUserIDType OLD_PASSWORD,TThostFtdcPasswordType NEW_PASSWORD)
{
	CThostFtdcUserPasswordUpdateField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID, BROKER_ID);
	strcpy_s(req.UserID, USER_ID);
	strcpy_s(req.OldPassword,OLD_PASSWORD);
	strcpy_s(req.NewPassword,NEW_PASSWORD);
	return pUserApi->ReqUserPasswordUpdate(&req, ++iRequestID);
}
///�ʽ��˻������������
TRADEAPI_API int ReqTradingAccountPasswordUpdate(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcAccountIDType ACCOUNT_ID,TThostFtdcUserIDType OLD_PASSWORD,TThostFtdcPasswordType NEW_PASSWORD)
{
	CThostFtdcTradingAccountPasswordUpdateField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID, BROKER_ID);
	strcpy_s(req.AccountID, ACCOUNT_ID);
	strcpy_s(req.NewPassword,NEW_PASSWORD);
	strcpy_s(req.OldPassword,OLD_PASSWORD);
	return pUserApi->ReqTradingAccountPasswordUpdate(&req, ++iRequestID);
}
//����¼������
TRADEAPI_API int ReqOrderInsert(CThostFtdcInputOrderField *pOrder)
{
	strcpy_s(pOrder->BusinessUnit,"HF");
	return pUserApi->ReqOrderInsert(pOrder, ++iRequestID);
}
//������������
TRADEAPI_API int ReqOrderAction(CThostFtdcInputOrderActionField *pOrder)
{
	return pUserApi->ReqOrderAction(pOrder, ++iRequestID);
}
///��ѯ��󱨵���������
TRADEAPI_API int ReqQueryMaxOrderVolume(CThostFtdcQueryMaxOrderVolumeField *pMaxOrderVolume)
{
	return pUserApi->ReqQueryMaxOrderVolume(pMaxOrderVolume, ++iRequestID);
}
//Ͷ���߽�����ȷ��
TRADEAPI_API int ReqSettlementInfoConfirm(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID)
{
	CThostFtdcSettlementInfoConfirmField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID, BROKER_ID);
	strcpy_s(req.InvestorID, INVESTOR_ID);
	return pUserApi->ReqSettlementInfoConfirm(&req, ++iRequestID);
}
///�����ѯ����
TRADEAPI_API int ReqQryOrder(CThostFtdcQryOrderField *pQryOrder)
{
	return pUserApi->ReqQryOrder(pQryOrder, ++iRequestID);
}
///�����ѯ�ɽ�
TRADEAPI_API int ReqQryTrade(CThostFtdcQryTradeField *pQryTrade)
{
	return pUserApi->ReqQryTrade(pQryTrade, ++iRequestID);
}
//�����ѯͶ���ֲ߳�
TRADEAPI_API int ReqQryInvestorPosition(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcInstrumentIDType INSTRUMENT_ID)
{
	CThostFtdcQryInvestorPositionField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID, BROKER_ID);
	strcpy_s(req.InvestorID, INVESTOR_ID);
	if(INSTRUMENT_ID != NULL)
		strcpy_s(req.InstrumentID, INSTRUMENT_ID);
	return pUserApi->ReqQryInvestorPosition(&req, ++iRequestID);
}
//�����ѯ�ʽ��˻�
TRADEAPI_API int ReqQryTradingAccount(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID)
{
	CThostFtdcQryTradingAccountField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID, BROKER_ID);
	strcpy_s(req.InvestorID, INVESTOR_ID);
	return pUserApi->ReqQryTradingAccount(&req, ++iRequestID);
}
///�����ѯͶ����
TRADEAPI_API int ReqQryInvestor(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID)
{
	CThostFtdcQryInvestorField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID ,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->ReqQryInvestor(&req, ++iRequestID);
}
	///�����ѯ���ױ���
TRADEAPI_API int ReqQryTradingCode(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcClientIDType CLIENT_ID,TThostFtdcExchangeIDType	EXCHANGE_ID)
{
	CThostFtdcQryTradingCodeField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID ,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);
	if(CLIENT_ID != NULL)
		strcpy_s(req.ClientID,CLIENT_ID);
	if(EXCHANGE_ID != NULL)
		strcpy_s(req.ExchangeID,EXCHANGE_ID);
	return pUserApi->ReqQryTradingCode(&req, ++iRequestID);
}
	///�����ѯ��Լ��֤����
TRADEAPI_API int ReqQryInstrumentMarginRate(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcInstrumentIDType INSTRUMENT_ID,TThostFtdcHedgeFlagType	HEDGE_FLAG)
{
	CThostFtdcQryInstrumentMarginRateField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID ,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);
	if(INSTRUMENT_ID != NULL)
		strcpy_s(req.InstrumentID,INSTRUMENT_ID);
	if(HEDGE_FLAG != NULL)
		req.HedgeFlag = HEDGE_FLAG;						//*��*�ܲ���null�������в�ѯ
	return pUserApi->ReqQryInstrumentMarginRate(&req, ++iRequestID);
}
	///�����ѯ��Լ��������
TRADEAPI_API int ReqQryInstrumentCommissionRate(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcInstrumentIDType INSTRUMENT_ID)
{
	CThostFtdcQryInstrumentCommissionRateField  req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID ,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);	
	if(INSTRUMENT_ID != NULL)
		strcpy_s(req.InstrumentID,INSTRUMENT_ID);
	return pUserApi->ReqQryInstrumentCommissionRate(&req, ++iRequestID);
}
	///�����ѯ������
TRADEAPI_API int ReqQryExchange(TThostFtdcExchangeIDType EXCHANGE_ID)
{
	CThostFtdcQryExchangeField  req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.ExchangeID,EXCHANGE_ID);
	return pUserApi->ReqQryExchange(&req, ++iRequestID);
}
//�����ѯ��Լ
TRADEAPI_API int ReqQryInstrument(TThostFtdcInstrumentIDType INSTRUMENT_ID)
{
	CThostFtdcQryInstrumentField req;
	memset(&req, 0, sizeof(req));
	if(INSTRUMENT_ID != NULL)
		strcpy_s(req.InstrumentID, INSTRUMENT_ID);
	return pUserApi->ReqQryInstrument(&req, ++iRequestID);
}
//�����ѯ����
TRADEAPI_API int ReqQryDepthMarketData(TThostFtdcInstrumentIDType INSTRUMENT_ID)
{
	CThostFtdcQryDepthMarketDataField req;
	memset(&req,0,sizeof(req));
	if(INSTRUMENT_ID != NULL)
		strcpy_s(req.InstrumentID, INSTRUMENT_ID);
	return pUserApi->ReqQryDepthMarketData(&req, ++iRequestID);
}
	///�����ѯͶ���߽�����
TRADEAPI_API int ReqQrySettlementInfo(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcDateType	TRADING_DAY)
{
	CThostFtdcQrySettlementInfoField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID ,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);	
	if(TRADING_DAY != NULL)
		strcpy_s(req.TradingDay, TRADING_DAY);
	return pUserApi->ReqQrySettlementInfo(&req, ++iRequestID);
}
//��ѯ�ֲ���ϸ
TRADEAPI_API int ReqQryInvestorPositionDetail(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcInstrumentIDType INSTRUMENT_ID)
{
	CThostFtdcQryInvestorPositionDetailField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);
	if(INSTRUMENT_ID != NULL)
		strcpy_s(req.InstrumentID, INSTRUMENT_ID);
	return pUserApi->ReqQryInvestorPositionDetail(&req, ++iRequestID);
}
	///�����ѯ�ͻ�֪ͨ
TRADEAPI_API int ReqQryNotice(TThostFtdcBrokerIDType BROKERID)
{
	CThostFtdcQryNoticeField  req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,BROKERID);
	return pUserApi->ReqQryNotice(&req, ++iRequestID);
}
	///�����ѯ������Ϣȷ��
TRADEAPI_API int ReqQrySettlementInfoConfirm(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID)
{
	CThostFtdcQrySettlementInfoConfirmField  req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->ReqQrySettlementInfoConfirm(&req, ++iRequestID);
}
	///�����ѯ**���**�ֲ���ϸ
TRADEAPI_API int ReqQryInvestorPositionCombineDetail(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcInstrumentIDType INSTRUMENT_ID)
{
	CThostFtdcQryInvestorPositionCombineDetailField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);
	if(INSTRUMENT_ID != NULL)
		strcpy_s(req.CombInstrumentID, INSTRUMENT_ID);
	return pUserApi->ReqQryInvestorPositionCombineDetail(&req, ++iRequestID);
}
	///�����ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ
TRADEAPI_API int ReqQryCFMMCTradingAccountKey(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID)
{
	CThostFtdcQryCFMMCTradingAccountKeyField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->ReqQryCFMMCTradingAccountKey(&req, ++iRequestID);
}
	///�����ѯ����֪ͨ
TRADEAPI_API int ReqQryTradingNotice(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID)
{
	CThostFtdcQryTradingNoticeField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->ReqQryTradingNotice(&req, ++iRequestID);
}
	///�����ѯ���͹�˾���ײ���
TRADEAPI_API int ReqQryBrokerTradingParams(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID)
{
	CThostFtdcQryBrokerTradingParamsField  req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->ReqQryBrokerTradingParams(&req, ++iRequestID);
}
	///�����ѯ���͹�˾�����㷨
TRADEAPI_API int ReqQryBrokerTradingAlgos(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcExchangeIDType EXCHANGE_ID,TThostFtdcInstrumentIDType INSTRUMENT_ID)
{
	CThostFtdcQryBrokerTradingAlgosField  req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,BROKER_ID);
	if(EXCHANGE_ID != NULL)
		strcpy_s(req.ExchangeID, EXCHANGE_ID);
	if(INSTRUMENT_ID != NULL)
		strcpy_s(req.InstrumentID, INSTRUMENT_ID);

	return pUserApi->ReqQryBrokerTradingAlgos(&req, ++iRequestID);
}
	///Ԥ��¼������
TRADEAPI_API int ReqParkedOrderInsert(CThostFtdcParkedOrderField *ParkedOrder)
{
	return pUserApi->ReqParkedOrderInsert(ParkedOrder,++iRequestID);
}
	///Ԥ�񳷵�¼������
TRADEAPI_API int ReqParkedOrderAction(CThostFtdcParkedOrderActionField *ParkedOrderAction)
{
	return pUserApi->ReqParkedOrderAction(ParkedOrderAction,++iRequestID);
}
	///����ɾ��Ԥ��
TRADEAPI_API int ReqRemoveParkedOrder(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcParkedOrderIDType ParkedOrder_ID)
{
	CThostFtdcRemoveParkedOrderField  req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);
	strcpy_s(req.ParkedOrderID,ParkedOrder_ID);
	return pUserApi->ReqRemoveParkedOrder(&req, ++iRequestID);
}
	///����ɾ��Ԥ�񳷵�
TRADEAPI_API int ReqRemoveParkedOrderAction(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcParkedOrderActionIDType ParkedOrderAction_ID)
{
	CThostFtdcRemoveParkedOrderActionField  req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);
	strcpy_s(req.ParkedOrderActionID,ParkedOrderAction_ID);
	return pUserApi->ReqRemoveParkedOrderAction(&req, ++iRequestID);
}
	///�����ѯת������
TRADEAPI_API int ReqQryTransferBank(TThostFtdcBankIDType Bank_ID,	TThostFtdcBankBrchIDType BankBrch_ID)
{
	CThostFtdcQryTransferBankField  req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BankID,Bank_ID);
	strcpy_s(req.BankBrchID,BankBrch_ID);
	return pUserApi->ReqQryTransferBank(&req, ++iRequestID);
}
	///�����ѯת����ˮ
TRADEAPI_API int ReqQryTransferSerial(TThostFtdcBrokerIDType Broker_ID,TThostFtdcAccountIDType Account_ID,TThostFtdcBankIDType Bank_ID)
{ 
	CThostFtdcQryTransferSerialField  req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,Broker_ID);
	strcpy_s(req.AccountID,Account_ID);
	strcpy_s(req.BankID,Bank_ID);
	return pUserApi->ReqQryTransferSerial(&req, ++iRequestID);
}
	///�����ѯǩԼ����
TRADEAPI_API int ReqQryContractBank(TThostFtdcBrokerIDType Broker_ID,TThostFtdcBankIDType Bank_ID,	TThostFtdcBankBrchIDType BankBrch_ID)
{
	CThostFtdcQryContractBankField  req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,Broker_ID);
	if(Bank_ID != NULL)
		strcpy_s(req.BankID,Bank_ID);
	if(BankBrch_ID !=NULL)
		strcpy_s(req.BankBrchID,BankBrch_ID);
	return pUserApi->ReqQryContractBank(&req, ++iRequestID);
}
	///�����ѯԤ��
TRADEAPI_API int ReqQryParkedOrder(TThostFtdcBrokerIDType BrokerID,TThostFtdcInvestorIDType InvestorID,TThostFtdcInstrumentIDType InstrumentID,TThostFtdcExchangeIDType ExchangeID)
{
	CThostFtdcQryParkedOrderField  req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,BrokerID);
	strcpy_s(req.InvestorID,InvestorID);
	if(InstrumentID != NULL)
		strcpy_s(req.InstrumentID,InstrumentID);
	if(ExchangeID != NULL)
		strcpy_s(req.ExchangeID,ExchangeID);
	return pUserApi->ReqQryParkedOrder(&req, ++iRequestID);
}
	///�����ѯԤ�񳷵�
TRADEAPI_API int ReqQryParkedOrderAction(TThostFtdcBrokerIDType BrokerID,TThostFtdcInvestorIDType InvestorID,TThostFtdcInstrumentIDType InstrumentID,TThostFtdcExchangeIDType ExchangeID)
{
	CThostFtdcQryParkedOrderActionField  req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID,BrokerID);
	strcpy_s(req.InvestorID,InvestorID);
	if(InstrumentID != NULL)
		strcpy_s(req.InstrumentID,InstrumentID);
	if(ExchangeID != NULL)
		strcpy_s(req.ExchangeID,ExchangeID);
	return pUserApi->ReqQryParkedOrderAction(&req, ++iRequestID);
}
	///�ڻ����������ʽ�ת�ڻ�����
TRADEAPI_API int ReqFromBankToFutureByFuture(CThostFtdcReqTransferField *ReqTransfer)
{
	return pUserApi->ReqFromBankToFutureByFuture(ReqTransfer,++iRequestID);
}
	///�ڻ������ڻ��ʽ�ת��������
TRADEAPI_API int ReqFromFutureToBankByFuture(CThostFtdcReqTransferField *ReqTransfer)
{
	return pUserApi->ReqFromFutureToBankByFuture(ReqTransfer,++iRequestID);
}
	///�ڻ������ѯ�����������
TRADEAPI_API int ReqQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField *ReqQueryAccount)
{
	return pUserApi->ReqQueryBankAccountMoneyByFuture(ReqQueryAccount,++iRequestID);
}
//========================================
///==================================== �ص����� =======================================
TRADEAPI_API void WINAPI RegOnFrontConnected(CBOnFrontConnected cb)		///���ͻ����뽻�׺�̨������ͨ������ʱ����δ��¼ǰ�����÷��������á�
{	cbOnFrontConnected = cb;	}

TRADEAPI_API void WINAPI RegOnFrontDisconnected(CBOnFrontDisconnected cb)		///���ͻ����뽻�׺�̨ͨ�����ӶϿ�ʱ���÷��������á���������������API���Զ��������ӣ��ͻ��˿ɲ�������
{	cbOnFrontDisconnected = cb;	}

TRADEAPI_API void WINAPI RegOnHeartBeatWarning(CBOnHeartBeatWarning cb)		///������ʱ���档����ʱ��δ�յ�����ʱ���÷��������á�
{	cbOnHeartBeatWarning = cb;	}

TRADEAPI_API void WINAPI RegRspUserLogin(CBRspUserLogin cb)	///��¼������Ӧ
{cbRspUserLogin = cb; }
TRADEAPI_API void WINAPI RegRspUserLogout(CBRspUserLogout cb)	///�ǳ�������Ӧ
{cbRspUserLogout = cb; }
TRADEAPI_API void WINAPI RegRspUserPasswordUpdate(CBRspUserPasswordUpdate cb)	///�û��������������Ӧ
{cbRspUserPasswordUpdate = cb; }
TRADEAPI_API void WINAPI RegRspTradingAccountPasswordUpdate(CBRspTradingAccountPasswordUpdate cb)	///�ʽ��˻��������������Ӧ
{cbRspTradingAccountPasswordUpdate = cb; }
TRADEAPI_API void WINAPI RegRspOrderInsert(CBRspOrderInsert cb)	///����¼��������Ӧ
{cbRspOrderInsert = cb; }
TRADEAPI_API void WINAPI RegRspParkedOrderInsert(CBRspParkedOrderInsert cb)	///Ԥ��¼��������Ӧ
{cbRspParkedOrderInsert = cb; }
TRADEAPI_API void WINAPI RegRspParkedOrderAction(CBRspParkedOrderAction cb)	///Ԥ�񳷵�¼��������Ӧ
{cbRspParkedOrderAction = cb; }
TRADEAPI_API void WINAPI RegRspOrderAction(CBRspOrderAction cb)	///��������������Ӧ
{cbRspOrderAction = cb; }
TRADEAPI_API void WINAPI RegRspQueryMaxOrderVolume(CBRspQueryMaxOrderVolume cb)	///��ѯ��󱨵�������Ӧ
{cbRspQueryMaxOrderVolume = cb; }
TRADEAPI_API void WINAPI RegRspSettlementInfoConfirm(CBRspSettlementInfoConfirm cb)	///Ͷ���߽�����ȷ����Ӧ
{cbRspSettlementInfoConfirm = cb; }
TRADEAPI_API void WINAPI RegRspRemoveParkedOrder(CBRspRemoveParkedOrder cb)	///ɾ��Ԥ����Ӧ
{cbRspRemoveParkedOrder = cb; }
TRADEAPI_API void WINAPI RegRspRemoveParkedOrderAction(CBRspRemoveParkedOrderAction cb)	///ɾ��Ԥ�񳷵���Ӧ
{cbRspRemoveParkedOrderAction = cb; }
TRADEAPI_API void WINAPI RegRspQryOrder(CBRspQryOrder cb)	///�����ѯ������Ӧ
{cbRspQryOrder = cb; }
TRADEAPI_API void WINAPI RegRspQryTrade(CBRspQryTrade cb)	///�����ѯ�ɽ���Ӧ
{cbRspQryTrade = cb; }
TRADEAPI_API void WINAPI RegRspQryInvestorPosition(CBRspQryInvestorPosition cb)	///�����ѯͶ���ֲ߳���Ӧ
{cbRspQryInvestorPosition = cb; }
TRADEAPI_API void WINAPI RegRspQryTradingAccount(CBRspQryTradingAccount cb)	///�����ѯ�ʽ��˻���Ӧ
{cbRspQryTradingAccount = cb; }
TRADEAPI_API void WINAPI RegRspQryInvestor(CBRspQryInvestor cb)	///�����ѯͶ������Ӧ
{cbRspQryInvestor = cb; }
TRADEAPI_API void WINAPI RegRspQryTradingCode(CBRspQryTradingCode cb)	///�����ѯ���ױ�����Ӧ
{cbRspQryTradingCode = cb; }
TRADEAPI_API void WINAPI RegRspQryInstrumentMarginRate(CBRspQryInstrumentMarginRate cb)	///�����ѯ��Լ��֤������Ӧ
{cbRspQryInstrumentMarginRate = cb; }
TRADEAPI_API void WINAPI RegRspQryInstrumentCommissionRate(CBRspQryInstrumentCommissionRate cb)	///�����ѯ��Լ����������Ӧ
{cbRspQryInstrumentCommissionRate = cb; }
TRADEAPI_API void WINAPI RegRspQryExchange(CBRspQryExchange cb)	///�����ѯ��������Ӧ
{cbRspQryExchange = cb; }
TRADEAPI_API void WINAPI RegRspQryInstrument(CBRspQryInstrument cb)	///�����ѯ��Լ��Ӧ
{cbRspQryInstrument = cb; }
TRADEAPI_API void WINAPI RegRspQryDepthMarketData(CBRspQryDepthMarketData cb)	///�����ѯ������Ӧ
{cbRspQryDepthMarketData = cb; }
TRADEAPI_API void WINAPI RegRspQrySettlementInfo(CBRspQrySettlementInfo cb)	///�����ѯͶ���߽�������Ӧ
{cbRspQrySettlementInfo = cb; }
TRADEAPI_API void WINAPI RegRspQryTransferBank(CBRspQryTransferBank cb)	///�����ѯת��������Ӧ
{cbRspQryTransferBank = cb; }
TRADEAPI_API void WINAPI RegRspQryInvestorPositionDetail(CBRspQryInvestorPositionDetail cb)	///�����ѯͶ���ֲ߳���ϸ��Ӧ
{cbRspQryInvestorPositionDetail = cb; }
TRADEAPI_API void WINAPI RegRspQryNotice(CBRspQryNotice cb)	///�����ѯ�ͻ�֪ͨ��Ӧ
{cbRspQryNotice = cb; }
TRADEAPI_API void WINAPI RegRspQrySettlementInfoConfirm(CBRspQrySettlementInfoConfirm cb)	///�����ѯ������Ϣȷ����Ӧ
{cbRspQrySettlementInfoConfirm = cb; }
TRADEAPI_API void WINAPI RegRspQryInvestorPositionCombineDetail(CBRspQryInvestorPositionCombineDetail cb)	///�����ѯͶ���ֲ߳���ϸ��Ӧ
{cbRspQryInvestorPositionCombineDetail = cb; }
TRADEAPI_API void WINAPI RegRspQryCFMMCTradingAccountKey(CBRspQryCFMMCTradingAccountKey cb)	///��ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ��Ӧ
{cbRspQryCFMMCTradingAccountKey = cb; }
TRADEAPI_API void WINAPI RegRspQryTransferSerial(CBRspQryTransferSerial cb)	///�����ѯת����ˮ��Ӧ
{cbRspQryTransferSerial = cb; }
TRADEAPI_API void WINAPI RegRspError(CBRspError cb)	///����Ӧ��
{cbRspError = cb; }
TRADEAPI_API void WINAPI RegRtnOrder(CBRtnOrder cb)	///����֪ͨ
{cbRtnOrder = cb; }
TRADEAPI_API void WINAPI RegRtnTrade(CBRtnTrade cb)	///�ɽ�֪ͨ
{cbRtnTrade = cb; }
TRADEAPI_API void WINAPI RegErrRtnOrderInsert(CBErrRtnOrderInsert cb)	///����¼�����ر�
{cbErrRtnOrderInsert = cb; }
TRADEAPI_API void WINAPI RegErrRtnOrderAction(CBErrRtnOrderAction cb)	///������������ر�
{cbErrRtnOrderAction = cb; }
TRADEAPI_API void WINAPI RegRtnInstrumentStatus(CBRtnInstrumentStatus cb)	///��Լ����״̬֪ͨ
{cbRtnInstrumentStatus = cb; }
TRADEAPI_API void WINAPI RegRtnTradingNotice(CBRtnTradingNotice cb)	///����֪ͨ
{cbRtnTradingNotice = cb; }
TRADEAPI_API void WINAPI RegRtnErrorConditionalOrder(CBRtnErrorConditionalOrder cb)	///��ʾ������У�����
{cbRtnErrorConditionalOrder = cb; }
TRADEAPI_API void WINAPI RegRspQryContractBank(CBRspQryContractBank cb)	///�����ѯǩԼ������Ӧ
{cbRspQryContractBank = cb; }
TRADEAPI_API void WINAPI RegRspQryParkedOrder(CBRspQryParkedOrder cb)	///�����ѯԤ����Ӧ
{cbRspQryParkedOrder = cb; }
TRADEAPI_API void WINAPI RegRspQryParkedOrderAction(CBRspQryParkedOrderAction cb)	///�����ѯԤ�񳷵���Ӧ
{cbRspQryParkedOrderAction = cb; }
TRADEAPI_API void WINAPI RegRspQryTradingNotice(CBRspQryTradingNotice cb)	///�����ѯ����֪ͨ��Ӧ
{cbRspQryTradingNotice = cb; }
TRADEAPI_API void WINAPI RegRspQryBrokerTradingParams(CBRspQryBrokerTradingParams cb)	///�����ѯ���͹�˾���ײ�����Ӧ
{cbRspQryBrokerTradingParams = cb; }
TRADEAPI_API void WINAPI RegRspQryBrokerTradingAlgos(CBRspQryBrokerTradingAlgos cb)	///�����ѯ���͹�˾�����㷨��Ӧ
{cbRspQryBrokerTradingAlgos = cb; }
TRADEAPI_API void WINAPI RegRtnFromBankToFutureByBank(CBRtnFromBankToFutureByBank cb)	///���з��������ʽ�ת�ڻ�֪ͨ
{cbRtnFromBankToFutureByBank = cb; }
TRADEAPI_API void WINAPI RegRtnFromFutureToBankByBank(CBRtnFromFutureToBankByBank cb)	///���з����ڻ��ʽ�ת����֪ͨ
{cbRtnFromFutureToBankByBank = cb; }
TRADEAPI_API void WINAPI RegRtnRepealFromBankToFutureByBank(CBRtnRepealFromBankToFutureByBank cb)	///���з����������ת�ڻ�֪ͨ
{cbRtnRepealFromBankToFutureByBank = cb; }
TRADEAPI_API void WINAPI RegRtnRepealFromFutureToBankByBank(CBRtnRepealFromFutureToBankByBank cb)	///���з�������ڻ�ת����֪ͨ
{cbRtnRepealFromFutureToBankByBank = cb; }
TRADEAPI_API void WINAPI RegRtnFromBankToFutureByFuture(CBRtnFromBankToFutureByFuture cb)	///�ڻ����������ʽ�ת�ڻ�֪ͨ
{cbRtnFromBankToFutureByFuture = cb; }
TRADEAPI_API void WINAPI RegRtnFromFutureToBankByFuture(CBRtnFromFutureToBankByFuture cb)	///�ڻ������ڻ��ʽ�ת����֪ͨ
{cbRtnFromFutureToBankByFuture = cb; }
TRADEAPI_API void WINAPI RegRtnRepealFromBankToFutureByFutureManual(CBRtnRepealFromBankToFutureByFutureManual cb)	///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
{cbRtnRepealFromBankToFutureByFutureManual = cb; }
TRADEAPI_API void WINAPI RegRtnRepealFromFutureToBankByFutureManual(CBRtnRepealFromFutureToBankByFutureManual cb)	///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
{cbRtnRepealFromFutureToBankByFutureManual = cb; }
TRADEAPI_API void WINAPI RegRtnQueryBankBalanceByFuture(CBRtnQueryBankBalanceByFuture cb)	///�ڻ������ѯ�������֪ͨ
{cbRtnQueryBankBalanceByFuture = cb; }
TRADEAPI_API void WINAPI RegErrRtnBankToFutureByFuture(CBErrRtnBankToFutureByFuture cb)	///�ڻ����������ʽ�ת�ڻ�����ر�
{cbErrRtnBankToFutureByFuture = cb; }
TRADEAPI_API void WINAPI RegErrRtnFutureToBankByFuture(CBErrRtnFutureToBankByFuture cb)	///�ڻ������ڻ��ʽ�ת���д���ر�
{cbErrRtnFutureToBankByFuture = cb; }
TRADEAPI_API void WINAPI RegErrRtnRepealBankToFutureByFutureManual(CBErrRtnRepealBankToFutureByFutureManual cb)	///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ�����ر�
{cbErrRtnRepealBankToFutureByFutureManual = cb; }
TRADEAPI_API void WINAPI RegErrRtnRepealFutureToBankByFutureManual(CBErrRtnRepealFutureToBankByFutureManual cb)	///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת���д���ر�
{cbErrRtnRepealFutureToBankByFutureManual = cb; }
TRADEAPI_API void WINAPI RegErrRtnQueryBankBalanceByFuture(CBErrRtnQueryBankBalanceByFuture cb)	///�ڻ������ѯ����������ر�
{cbErrRtnQueryBankBalanceByFuture = cb; }
TRADEAPI_API void WINAPI RegRtnRepealFromBankToFutureByFuture(CBRtnRepealFromBankToFutureByFuture cb)	///�ڻ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
{cbRtnRepealFromBankToFutureByFuture = cb; }
TRADEAPI_API void WINAPI RegRtnRepealFromFutureToBankByFuture(CBRtnRepealFromFutureToBankByFuture cb)	///�ڻ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
{cbRtnRepealFromFutureToBankByFuture = cb; }
TRADEAPI_API void WINAPI RegRspFromBankToFutureByFuture(CBRspFromBankToFutureByFuture cb)	///�ڻ����������ʽ�ת�ڻ�Ӧ��
{cbRspFromBankToFutureByFuture = cb; }
TRADEAPI_API void WINAPI RegRspFromFutureToBankByFuture(CBRspFromFutureToBankByFuture cb)	///�ڻ������ڻ��ʽ�ת����Ӧ��
{cbRspFromFutureToBankByFuture = cb; }
TRADEAPI_API void WINAPI RegRspQueryBankAccountMoneyByFuture(CBRspQueryBankAccountMoneyByFuture cb)	///�ڻ������ѯ�������Ӧ��
{cbRspQueryBankAccountMoneyByFuture = cb; }
