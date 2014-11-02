///本文档有刘建平提供转换工具
#include "stdafx.h"
#include "./ThostFtdcTraderApi.h"

#ifdef CTPTDAPI_EXPORTS
#define CTPTDAPI_API __declspec(dllexport)
#else
#define 
CTPTDAPI_API __declspec(dllimport)
#endif
#include <iostream>
using namespace std;

class  CCTPTDAPI:public CThostFtdcTraderSpi

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
	
	///客户端认证响应
	virtual void OnRspAuthenticate(CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
	

	///登录请求响应
	virtual void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///登出请求响应
	virtual void OnRspUserLogout(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///用户口令更新请求响应
	virtual void OnRspUserPasswordUpdate(CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///资金账户口令更新请求响应
	virtual void OnRspTradingAccountPasswordUpdate(CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///报单录入请求响应
	virtual void OnRspOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///预埋单录入请求响应
	virtual void OnRspParkedOrderInsert(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///预埋撤单录入请求响应
	virtual void OnRspParkedOrderAction(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///报单操作请求响应
	virtual void OnRspOrderAction(CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///查询最大报单数量响应
	virtual void OnRspQueryMaxOrderVolume(CThostFtdcQueryMaxOrderVolumeField *pQueryMaxOrderVolume, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///投资者结算结果确认响应
	virtual void OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///删除预埋单响应
	virtual void OnRspRemoveParkedOrder(CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///删除预埋撤单响应
	virtual void OnRspRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询报单响应
	virtual void OnRspQryOrder(CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询成交响应
	virtual void OnRspQryTrade(CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询投资者持仓响应
	virtual void OnRspQryInvestorPosition(CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询资金账户响应
	virtual void OnRspQryTradingAccount(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询投资者响应
	virtual void OnRspQryInvestor(CThostFtdcInvestorField *pInvestor, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询交易编码响应
	virtual void OnRspQryTradingCode(CThostFtdcTradingCodeField *pTradingCode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询合约保证金率响应
	virtual void OnRspQryInstrumentMarginRate(CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询合约手续费率响应
	virtual void OnRspQryInstrumentCommissionRate(CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询交易所响应
	virtual void OnRspQryExchange(CThostFtdcExchangeField *pExchange, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询合约响应
	virtual void OnRspQryInstrument(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询行情响应
	virtual void OnRspQryDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询投资者结算结果响应
	virtual void OnRspQrySettlementInfo(CThostFtdcSettlementInfoField *pSettlementInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询转帐银行响应
	virtual void OnRspQryTransferBank(CThostFtdcTransferBankField *pTransferBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询投资者持仓明细响应
	virtual void OnRspQryInvestorPositionDetail(CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询客户通知响应
	virtual void OnRspQryNotice(CThostFtdcNoticeField *pNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询结算信息确认响应
	virtual void OnRspQrySettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询投资者持仓明细响应
	virtual void OnRspQryInvestorPositionCombineDetail(CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///查询保证金监管系统经纪公司资金账户密钥响应
	virtual void OnRspQryCFMMCTradingAccountKey(CThostFtdcCFMMCTradingAccountKeyField *pCFMMCTradingAccountKey, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询仓单折抵信息响应
	virtual void OnRspQryEWarrantOffset(CThostFtdcEWarrantOffsetField *pEWarrantOffset, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询投资者品种/跨品种保证金响应
	virtual void OnRspQryInvestorProductGroupMargin(CThostFtdcInvestorProductGroupMarginField *pInvestorProductGroupMargin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询交易所保证金率响应
	virtual void OnRspQryExchangeMarginRate(CThostFtdcExchangeMarginRateField *pExchangeMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询交易所调整保证金率响应
	virtual void OnRspQryExchangeMarginRateAdjust(CThostFtdcExchangeMarginRateAdjustField *pExchangeMarginRateAdjust, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询转帐流水响应
	virtual void OnRspQryTransferSerial(CThostFtdcTransferSerialField *pTransferSerial, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询银期签约关系响应
	virtual void OnRspQryAccountregister(CThostFtdcAccountregisterField *pAccountregister, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///错误应答
	virtual void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///报单通知
	virtual void OnRtnOrder(CThostFtdcOrderField *pOrder) ;

	///成交通知
	virtual void OnRtnTrade(CThostFtdcTradeField *pTrade) ;

	///报单录入错误回报
	virtual void OnErrRtnOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo) ;

	///报单操作错误回报
	virtual void OnErrRtnOrderAction(CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo) ;

	///合约交易状态通知
	virtual void OnRtnInstrumentStatus(CThostFtdcInstrumentStatusField *pInstrumentStatus) ;

	///交易通知
	virtual void OnRtnTradingNotice(CThostFtdcTradingNoticeInfoField *pTradingNoticeInfo) ;

	///提示条件单校验错误
	virtual void OnRtnErrorConditionalOrder(CThostFtdcErrorConditionalOrderField *pErrorConditionalOrder) ;

	///请求查询签约银行响应
	virtual void OnRspQryContractBank(CThostFtdcContractBankField *pContractBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询预埋单响应
	virtual void OnRspQryParkedOrder(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询预埋撤单响应
	virtual void OnRspQryParkedOrderAction(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询交易通知响应
	virtual void OnRspQryTradingNotice(CThostFtdcTradingNoticeField *pTradingNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询经纪公司交易参数响应
	virtual void OnRspQryBrokerTradingParams(CThostFtdcBrokerTradingParamsField *pBrokerTradingParams, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///请求查询经纪公司交易算法响应
	virtual void OnRspQryBrokerTradingAlgos(CThostFtdcBrokerTradingAlgosField *pBrokerTradingAlgos, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///银行发起银行资金转期货通知
	virtual void OnRtnFromBankToFutureByBank(CThostFtdcRspTransferField *pRspTransfer) ;

	///银行发起期货资金转银行通知
	virtual void OnRtnFromFutureToBankByBank(CThostFtdcRspTransferField *pRspTransfer) ;

	///银行发起冲正银行转期货通知
	virtual void OnRtnRepealFromBankToFutureByBank(CThostFtdcRspRepealField *pRspRepeal) ;

	///银行发起冲正期货转银行通知
	virtual void OnRtnRepealFromFutureToBankByBank(CThostFtdcRspRepealField *pRspRepeal) ;

	///期货发起银行资金转期货通知
	virtual void OnRtnFromBankToFutureByFuture(CThostFtdcRspTransferField *pRspTransfer) ;

	///期货发起期货资金转银行通知
	virtual void OnRtnFromFutureToBankByFuture(CThostFtdcRspTransferField *pRspTransfer) ;

	///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
	virtual void OnRtnRepealFromBankToFutureByFutureManual(CThostFtdcRspRepealField *pRspRepeal) ;

	///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
	virtual void OnRtnRepealFromFutureToBankByFutureManual(CThostFtdcRspRepealField *pRspRepeal) ;

	///期货发起查询银行余额通知
	virtual void OnRtnQueryBankBalanceByFuture(CThostFtdcNotifyQueryAccountField *pNotifyQueryAccount) ;

	///期货发起银行资金转期货错误回报
	virtual void OnErrRtnBankToFutureByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) ;

	///期货发起期货资金转银行错误回报
	virtual void OnErrRtnFutureToBankByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) ;

	///系统运行时期货端手工发起冲正银行转期货错误回报
	virtual void OnErrRtnRepealBankToFutureByFutureManual(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) ;

	///系统运行时期货端手工发起冲正期货转银行错误回报
	virtual void OnErrRtnRepealFutureToBankByFutureManual(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) ;

	///期货发起查询银行余额错误回报
	virtual void OnErrRtnQueryBankBalanceByFuture(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo) ;

	///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
	virtual void OnRtnRepealFromBankToFutureByFuture(CThostFtdcRspRepealField *pRspRepeal) ;

	///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
	virtual void OnRtnRepealFromFutureToBankByFuture(CThostFtdcRspRepealField *pRspRepeal) ;

	///期货发起银行资金转期货应答
	virtual void OnRspFromBankToFutureByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///期货发起期货资金转银行应答
	virtual void OnRspFromFutureToBankByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///期货发起查询银行余额应答
	virtual void OnRspQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;

	///银行发起银期开户通知
	virtual void OnRtnOpenAccountByBank(CThostFtdcOpenAccountField *pOpenAccount) ;

	///银行发起银期销户通知
	virtual void OnRtnCancelAccountByBank(CThostFtdcCancelAccountField *pCancelAccount) ;

	///银行发起变更银行账号通知
	virtual void OnRtnChangeAccountByBank(CThostFtdcChangeAccountField *pChangeAccount) ;

    CCTPTDAPI(void);
	//
	bool IsErrorRspInfo(CThostFtdcRspInfoField *pRspInfo);
	CThostFtdcRspInfoField* repareInfo(CThostFtdcRspInfoField *pRspInfo);
};
typedef int (WINAPI *CBOnFrontConnected)();
typedef int (WINAPI *CBOnFrontDisconnected)(int nReason);
typedef int (WINAPI *CBOnHeartBeatWarning)(int nTimeLapse);
typedef int (WINAPI *CBOnRspAuthenticate)(CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspUserLogin)(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspUserLogout)(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspUserPasswordUpdate)(CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspTradingAccountPasswordUpdate)(CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspOrderInsert)(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspParkedOrderInsert)(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspParkedOrderAction)(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspOrderAction)(CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQueryMaxOrderVolume)(CThostFtdcQueryMaxOrderVolumeField *pQueryMaxOrderVolume, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspSettlementInfoConfirm)(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspRemoveParkedOrder)(CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspRemoveParkedOrderAction)(CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryOrder)(CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryTrade)(CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryInvestorPosition)(CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryTradingAccount)(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryInvestor)(CThostFtdcInvestorField *pInvestor, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryTradingCode)(CThostFtdcTradingCodeField *pTradingCode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryInstrumentMarginRate)(CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryInstrumentCommissionRate)(CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryExchange)(CThostFtdcExchangeField *pExchange, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryInstrument)(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryDepthMarketData)(CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQrySettlementInfo)(CThostFtdcSettlementInfoField *pSettlementInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryTransferBank)(CThostFtdcTransferBankField *pTransferBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryInvestorPositionDetail)(CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryNotice)(CThostFtdcNoticeField *pNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQrySettlementInfoConfirm)(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryInvestorPositionCombineDetail)(CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryCFMMCTradingAccountKey)(CThostFtdcCFMMCTradingAccountKeyField *pCFMMCTradingAccountKey, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryEWarrantOffset)(CThostFtdcEWarrantOffsetField *pEWarrantOffset, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryInvestorProductGroupMargin)(CThostFtdcInvestorProductGroupMarginField *pInvestorProductGroupMargin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryExchangeMarginRate)(CThostFtdcExchangeMarginRateField *pExchangeMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryExchangeMarginRateAdjust)(CThostFtdcExchangeMarginRateAdjustField *pExchangeMarginRateAdjust, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryTransferSerial)(CThostFtdcTransferSerialField *pTransferSerial, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryAccountregister)(CThostFtdcAccountregisterField *pAccountregister, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspError)(CThostFtdcRspInfoField *pRspInfo) ;
typedef int (WINAPI *CBOnRtnOrder)(CThostFtdcOrderField *pOrder) ;
typedef int (WINAPI *CBOnRtnTrade)(CThostFtdcTradeField *pTrade) ;
typedef int (WINAPI *CBOnErrRtnOrderInsert)(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo) ;
typedef int (WINAPI *CBOnErrRtnOrderAction)(CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo) ;
typedef int (WINAPI *CBOnRtnInstrumentStatus)(CThostFtdcInstrumentStatusField *pInstrumentStatus) ;
typedef int (WINAPI *CBOnRtnTradingNotice)(CThostFtdcTradingNoticeInfoField *pTradingNoticeInfo) ;
typedef int (WINAPI *CBOnRtnErrorConditionalOrder)(CThostFtdcErrorConditionalOrderField *pErrorConditionalOrder) ;
typedef int (WINAPI *CBOnRspQryContractBank)(CThostFtdcContractBankField *pContractBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryParkedOrder)(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryParkedOrderAction)(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryTradingNotice)(CThostFtdcTradingNoticeField *pTradingNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryBrokerTradingParams)(CThostFtdcBrokerTradingParamsField *pBrokerTradingParams, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQryBrokerTradingAlgos)(CThostFtdcBrokerTradingAlgosField *pBrokerTradingAlgos, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRtnFromBankToFutureByBank)(CThostFtdcRspTransferField *pRspTransfer) ;
typedef int (WINAPI *CBOnRtnFromFutureToBankByBank)(CThostFtdcRspTransferField *pRspTransfer) ;
typedef int (WINAPI *CBOnRtnRepealFromBankToFutureByBank)(CThostFtdcRspRepealField *pRspRepeal) ;
typedef int (WINAPI *CBOnRtnRepealFromFutureToBankByBank)(CThostFtdcRspRepealField *pRspRepeal) ;
typedef int (WINAPI *CBOnRtnFromBankToFutureByFuture)(CThostFtdcRspTransferField *pRspTransfer) ;
typedef int (WINAPI *CBOnRtnFromFutureToBankByFuture)(CThostFtdcRspTransferField *pRspTransfer) ;
typedef int (WINAPI *CBOnRtnRepealFromBankToFutureByFutureManual)(CThostFtdcRspRepealField *pRspRepeal) ;
typedef int (WINAPI *CBOnRtnRepealFromFutureToBankByFutureManual)(CThostFtdcRspRepealField *pRspRepeal) ;
typedef int (WINAPI *CBOnRtnQueryBankBalanceByFuture)(CThostFtdcNotifyQueryAccountField *pNotifyQueryAccount) ;
typedef int (WINAPI *CBOnErrRtnBankToFutureByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) ;
typedef int (WINAPI *CBOnErrRtnFutureToBankByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) ;
typedef int (WINAPI *CBOnErrRtnRepealBankToFutureByFutureManual)(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) ;
typedef int (WINAPI *CBOnErrRtnRepealFutureToBankByFutureManual)(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) ;
typedef int (WINAPI *CBOnErrRtnQueryBankBalanceByFuture)(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo) ;
typedef int (WINAPI *CBOnRtnRepealFromBankToFutureByFuture)(CThostFtdcRspRepealField *pRspRepeal) ;
typedef int (WINAPI *CBOnRtnRepealFromFutureToBankByFuture)(CThostFtdcRspRepealField *pRspRepeal) ;
typedef int (WINAPI *CBOnRspFromBankToFutureByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspFromFutureToBankByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRspQueryBankAccountMoneyByFuture)(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) ;
typedef int (WINAPI *CBOnRtnOpenAccountByBank)(CThostFtdcOpenAccountField *pOpenAccount) ;
typedef int (WINAPI *CBOnRtnCancelAccountByBank)(CThostFtdcCancelAccountField *pCancelAccount) ;
typedef int (WINAPI *CBOnRtnChangeAccountByBank)(CThostFtdcChangeAccountField *pChangeAccount) ;
CBOnFrontConnected cbOnFrontConnected=0;
CBOnFrontDisconnected cbOnFrontDisconnected=0;
CBOnHeartBeatWarning cbOnHeartBeatWarning=0;
CBOnRspAuthenticate cbOnRspAuthenticate=0;
CBOnRspUserLogin cbOnRspUserLogin=0;
CBOnRspUserLogout cbOnRspUserLogout=0;
CBOnRspUserPasswordUpdate cbOnRspUserPasswordUpdate=0;
CBOnRspTradingAccountPasswordUpdate cbOnRspTradingAccountPasswordUpdate=0;
CBOnRspOrderInsert cbOnRspOrderInsert=0;
CBOnRspParkedOrderInsert cbOnRspParkedOrderInsert=0;
CBOnRspParkedOrderAction cbOnRspParkedOrderAction=0;
CBOnRspOrderAction cbOnRspOrderAction=0;
CBOnRspQueryMaxOrderVolume cbOnRspQueryMaxOrderVolume=0;
CBOnRspSettlementInfoConfirm cbOnRspSettlementInfoConfirm=0;
CBOnRspRemoveParkedOrder cbOnRspRemoveParkedOrder=0;
CBOnRspRemoveParkedOrderAction cbOnRspRemoveParkedOrderAction=0;
CBOnRspQryOrder cbOnRspQryOrder=0;
CBOnRspQryTrade cbOnRspQryTrade=0;
CBOnRspQryInvestorPosition cbOnRspQryInvestorPosition=0;
CBOnRspQryTradingAccount cbOnRspQryTradingAccount=0;
CBOnRspQryInvestor cbOnRspQryInvestor=0;
CBOnRspQryTradingCode cbOnRspQryTradingCode=0;
CBOnRspQryInstrumentMarginRate cbOnRspQryInstrumentMarginRate=0;
CBOnRspQryInstrumentCommissionRate cbOnRspQryInstrumentCommissionRate=0;
CBOnRspQryExchange cbOnRspQryExchange=0;
CBOnRspQryInstrument cbOnRspQryInstrument=0;
CBOnRspQryDepthMarketData cbOnRspQryDepthMarketData=0;
CBOnRspQrySettlementInfo cbOnRspQrySettlementInfo=0;
CBOnRspQryTransferBank cbOnRspQryTransferBank=0;
CBOnRspQryInvestorPositionDetail cbOnRspQryInvestorPositionDetail=0;
CBOnRspQryNotice cbOnRspQryNotice=0;
CBOnRspQrySettlementInfoConfirm cbOnRspQrySettlementInfoConfirm=0;
CBOnRspQryInvestorPositionCombineDetail cbOnRspQryInvestorPositionCombineDetail=0;
CBOnRspQryCFMMCTradingAccountKey cbOnRspQryCFMMCTradingAccountKey=0;
CBOnRspQryEWarrantOffset cbOnRspQryEWarrantOffset=0;
CBOnRspQryInvestorProductGroupMargin cbOnRspQryInvestorProductGroupMargin=0;
CBOnRspQryExchangeMarginRate cbOnRspQryExchangeMarginRate=0;
CBOnRspQryExchangeMarginRateAdjust cbOnRspQryExchangeMarginRateAdjust=0;
CBOnRspQryTransferSerial cbOnRspQryTransferSerial=0;
CBOnRspQryAccountregister cbOnRspQryAccountregister=0;
CBOnRspError cbOnRspError=0;
CBOnRtnOrder cbOnRtnOrder=0;
CBOnRtnTrade cbOnRtnTrade=0;
CBOnErrRtnOrderInsert cbOnErrRtnOrderInsert=0;
CBOnErrRtnOrderAction cbOnErrRtnOrderAction=0;
CBOnRtnInstrumentStatus cbOnRtnInstrumentStatus=0;
CBOnRtnTradingNotice cbOnRtnTradingNotice=0;
CBOnRtnErrorConditionalOrder cbOnRtnErrorConditionalOrder=0;
CBOnRspQryContractBank cbOnRspQryContractBank=0;
CBOnRspQryParkedOrder cbOnRspQryParkedOrder=0;
CBOnRspQryParkedOrderAction cbOnRspQryParkedOrderAction=0;
CBOnRspQryTradingNotice cbOnRspQryTradingNotice=0;
CBOnRspQryBrokerTradingParams cbOnRspQryBrokerTradingParams=0;
CBOnRspQryBrokerTradingAlgos cbOnRspQryBrokerTradingAlgos=0;
CBOnRtnFromBankToFutureByBank cbOnRtnFromBankToFutureByBank=0;
CBOnRtnFromFutureToBankByBank cbOnRtnFromFutureToBankByBank=0;
CBOnRtnRepealFromBankToFutureByBank cbOnRtnRepealFromBankToFutureByBank=0;
CBOnRtnRepealFromFutureToBankByBank cbOnRtnRepealFromFutureToBankByBank=0;
CBOnRtnFromBankToFutureByFuture cbOnRtnFromBankToFutureByFuture=0;
CBOnRtnFromFutureToBankByFuture cbOnRtnFromFutureToBankByFuture=0;
CBOnRtnRepealFromBankToFutureByFutureManual cbOnRtnRepealFromBankToFutureByFutureManual=0;
CBOnRtnRepealFromFutureToBankByFutureManual cbOnRtnRepealFromFutureToBankByFutureManual=0;
CBOnRtnQueryBankBalanceByFuture cbOnRtnQueryBankBalanceByFuture=0;
CBOnErrRtnBankToFutureByFuture cbOnErrRtnBankToFutureByFuture=0;
CBOnErrRtnFutureToBankByFuture cbOnErrRtnFutureToBankByFuture=0;
CBOnErrRtnRepealBankToFutureByFutureManual cbOnErrRtnRepealBankToFutureByFutureManual=0;
CBOnErrRtnRepealFutureToBankByFutureManual cbOnErrRtnRepealFutureToBankByFutureManual=0;
CBOnErrRtnQueryBankBalanceByFuture cbOnErrRtnQueryBankBalanceByFuture=0;
CBOnRtnRepealFromBankToFutureByFuture cbOnRtnRepealFromBankToFutureByFuture=0;
CBOnRtnRepealFromFutureToBankByFuture cbOnRtnRepealFromFutureToBankByFuture=0;
CBOnRspFromBankToFutureByFuture cbOnRspFromBankToFutureByFuture=0;
CBOnRspFromFutureToBankByFuture cbOnRspFromFutureToBankByFuture=0;
CBOnRspQueryBankAccountMoneyByFuture cbOnRspQueryBankAccountMoneyByFuture=0;
CBOnRtnOpenAccountByBank cbOnRtnOpenAccountByBank=0;
CBOnRtnCancelAccountByBank cbOnRtnCancelAccountByBank=0;
CBOnRtnChangeAccountByBank cbOnRtnChangeAccountByBank=0;
// 请求编号
int iRequestID = 0;
// UserApi对象
CThostFtdcTraderApi* pUserApi;

////////////////////////////回调函数实现/////////////////////////////////////////////////////////////
void CCTPTDAPI::OnFrontConnected()
{
   if(cbOnFrontConnected!=NULL)
        cbOnFrontConnected();
}
void CCTPTDAPI::OnFrontDisconnected(int nReason)
{
   if(cbOnFrontDisconnected!=NULL)
        cbOnFrontDisconnected(nReason);
}
void CCTPTDAPI::OnHeartBeatWarning(int nTimeLapse)
{
   if(cbOnHeartBeatWarning!=NULL)
        cbOnHeartBeatWarning(nTimeLapse);
}
void CCTPTDAPI::OnRspAuthenticate(CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspAuthenticate!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pRspAuthenticateField)
	   {
        cbOnRspAuthenticate(pRspAuthenticateField,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspUserLogin!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pRspUserLogin)
	   {
        cbOnRspUserLogin(pRspUserLogin,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspUserLogout(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspUserLogout!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pUserLogout)
	   {
        cbOnRspUserLogout(pUserLogout,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspUserPasswordUpdate(CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspUserPasswordUpdate!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pUserPasswordUpdate)
	   {
        cbOnRspUserPasswordUpdate(pUserPasswordUpdate,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspTradingAccountPasswordUpdate(CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspTradingAccountPasswordUpdate!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pTradingAccountPasswordUpdate)
	   {
        cbOnRspTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspOrderInsert!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pInputOrder)
	   {
        cbOnRspOrderInsert(pInputOrder,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspParkedOrderInsert(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspParkedOrderInsert!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pParkedOrder)
	   {
        cbOnRspParkedOrderInsert(pParkedOrder,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspParkedOrderAction(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspParkedOrderAction!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pParkedOrderAction)
	   {
        cbOnRspParkedOrderAction(pParkedOrderAction,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspOrderAction(CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspOrderAction!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pInputOrderAction)
	   {
        cbOnRspOrderAction(pInputOrderAction,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQueryMaxOrderVolume(CThostFtdcQueryMaxOrderVolumeField *pQueryMaxOrderVolume, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQueryMaxOrderVolume!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pQueryMaxOrderVolume)
	   {
        cbOnRspQueryMaxOrderVolume(pQueryMaxOrderVolume,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
//投资者结算结果确认响应
void CCTPTDAPI::OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspSettlementInfoConfirm!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pSettlementInfoConfirm)
	   {
		 cbOnRspSettlementInfoConfirm(pSettlementInfoConfirm,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspRemoveParkedOrder(CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspRemoveParkedOrder!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pRemoveParkedOrder)
	   {
        cbOnRspRemoveParkedOrder(pRemoveParkedOrder,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspRemoveParkedOrderAction!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pRemoveParkedOrderAction)
	   {
        cbOnRspRemoveParkedOrderAction(pRemoveParkedOrderAction,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryOrder(CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryOrder!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pOrder)
	   {
        cbOnRspQryOrder(pOrder,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryTrade(CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryTrade!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pTrade)
	   {
        cbOnRspQryTrade(pTrade,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
//请求查询投资者持仓响应
void CCTPTDAPI::OnRspQryInvestorPosition(CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryInvestorPosition!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pInvestorPosition)
	   {
        cbOnRspQryInvestorPosition(pInvestorPosition,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryTradingAccount(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryTradingAccount!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pTradingAccount)
	   {
        cbOnRspQryTradingAccount(pTradingAccount,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryInvestor(CThostFtdcInvestorField *pInvestor, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryInvestor!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pInvestor)
	   {
        cbOnRspQryInvestor(pInvestor,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryTradingCode(CThostFtdcTradingCodeField *pTradingCode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryTradingCode!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pTradingCode)
	   {
        cbOnRspQryTradingCode(pTradingCode,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryInstrumentMarginRate(CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryInstrumentMarginRate!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pInstrumentMarginRate)
	   {
        cbOnRspQryInstrumentMarginRate(pInstrumentMarginRate,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryInstrumentCommissionRate(CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryInstrumentCommissionRate!=NULL)
	    if (!IsErrorRspInfo(pRspInfo) &&  pInstrumentCommissionRate)
	   {
        cbOnRspQryInstrumentCommissionRate(pInstrumentCommissionRate,repareInfo(pRspInfo),nRequestID,bIsLast);
		}
}
void CCTPTDAPI::OnRspQryExchange(CThostFtdcExchangeField *pExchange, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryExchange!=NULL)
	    if (!IsErrorRspInfo(pRspInfo) &&  pExchange)
	   {
        cbOnRspQryExchange(pExchange,repareInfo(pRspInfo),nRequestID,bIsLast);
		}
}
//查询合约响应
void CCTPTDAPI::OnRspQryInstrument(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryInstrument!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pInstrument)
	   {
        cbOnRspQryInstrument(pInstrument,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryDepthMarketData!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pDepthMarketData)
	   {
        cbOnRspQryDepthMarketData(pDepthMarketData,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
//请求查询投资者结算结果响应
void CCTPTDAPI::OnRspQrySettlementInfo(CThostFtdcSettlementInfoField *pSettlementInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQrySettlementInfo!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pSettlementInfo)
	   {
        cbOnRspQrySettlementInfo(pSettlementInfo,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
//报单录入响应
void CCTPTDAPI::OnRtnOrder(CThostFtdcOrderField *pOrder)
{
	if(cbOnRtnOrder!=NULL)
	{
		cbOnRtnOrder(pOrder);
	}
}
void CCTPTDAPI::OnRspQryTransferBank(CThostFtdcTransferBankField *pTransferBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryTransferBank!=NULL)
	    if (!IsErrorRspInfo(pRspInfo) &&  pTransferBank)
	   {
        cbOnRspQryTransferBank(pTransferBank,repareInfo(pRspInfo),nRequestID,bIsLast);
		}
}
//投资者持仓明细响应
void CCTPTDAPI::OnRspQryInvestorPositionDetail(CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryInvestorPositionDetail!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pInvestorPositionDetail)
	   {
        cbOnRspQryInvestorPositionDetail(pInvestorPositionDetail,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryNotice(CThostFtdcNoticeField *pNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryNotice!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pNotice)
	   {
        cbOnRspQryNotice(pNotice,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQrySettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQrySettlementInfoConfirm!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pSettlementInfoConfirm)
	   {
        cbOnRspQrySettlementInfoConfirm(pSettlementInfoConfirm,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryInvestorPositionCombineDetail(CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryInvestorPositionCombineDetail!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pInvestorPositionCombineDetail)
	   {
        cbOnRspQryInvestorPositionCombineDetail(pInvestorPositionCombineDetail,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryCFMMCTradingAccountKey(CThostFtdcCFMMCTradingAccountKeyField *pCFMMCTradingAccountKey, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryCFMMCTradingAccountKey!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pCFMMCTradingAccountKey)
	   {
        cbOnRspQryCFMMCTradingAccountKey(pCFMMCTradingAccountKey,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryEWarrantOffset(CThostFtdcEWarrantOffsetField *pEWarrantOffset, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryEWarrantOffset!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pEWarrantOffset)
	   {
        cbOnRspQryEWarrantOffset(pEWarrantOffset,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryInvestorProductGroupMargin(CThostFtdcInvestorProductGroupMarginField *pInvestorProductGroupMargin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryInvestorProductGroupMargin!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pInvestorProductGroupMargin)
	   {
        cbOnRspQryInvestorProductGroupMargin(pInvestorProductGroupMargin,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryExchangeMarginRate(CThostFtdcExchangeMarginRateField *pExchangeMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryExchangeMarginRate!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pExchangeMarginRate)
	   {
        cbOnRspQryExchangeMarginRate(pExchangeMarginRate,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryExchangeMarginRateAdjust(CThostFtdcExchangeMarginRateAdjustField *pExchangeMarginRateAdjust, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryExchangeMarginRateAdjust!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pExchangeMarginRateAdjust)
	   {
        cbOnRspQryExchangeMarginRateAdjust(pExchangeMarginRateAdjust,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryTransferSerial(CThostFtdcTransferSerialField *pTransferSerial, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryTransferSerial!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pTransferSerial)
	   {
        cbOnRspQryTransferSerial(pTransferSerial,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryAccountregister(CThostFtdcAccountregisterField *pAccountregister, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryAccountregister!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pAccountregister)
	   {
        cbOnRspQryAccountregister(pAccountregister,pRspInfo,nRequestID,bIsLast);
	   }
}
//错误响应
void CCTPTDAPI::OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
  // if(cbOnRspError!=NULL)
	//{
		IsErrorRspInfo(repareInfo(pRspInfo));
	//}
}
//成交响应
void CCTPTDAPI::OnRtnTrade(CThostFtdcTradeField *pTrade) 
{
   if(cbOnRtnTrade!=NULL)
   {
	 cbOnRtnTrade(pTrade);
   }
}
//报单错误响应
void CCTPTDAPI::OnErrRtnOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo) 
{
   if(cbOnErrRtnOrderInsert!=NULL)
   {
	   if (!IsErrorRspInfo(pRspInfo) &&  pInputOrder)
	   {
       cbOnErrRtnOrderInsert(pInputOrder,repareInfo(pRspInfo));
	   }
   }
}
void CCTPTDAPI::OnErrRtnOrderAction(CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo) 
{
   if(cbOnErrRtnOrderAction!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pOrderAction)
	   {
        cbOnErrRtnOrderAction(pOrderAction,repareInfo(pRspInfo));
	   }
}
void CCTPTDAPI::OnRtnInstrumentStatus(CThostFtdcInstrumentStatusField *pInstrumentStatus) 
{
   if(cbOnRtnInstrumentStatus!=NULL)
        cbOnRtnInstrumentStatus(pInstrumentStatus);
}
void CCTPTDAPI::OnRtnTradingNotice(CThostFtdcTradingNoticeInfoField *pTradingNoticeInfo) 
{
   if(cbOnRtnTradingNotice!=NULL)
        cbOnRtnTradingNotice(pTradingNoticeInfo);
}
void CCTPTDAPI::OnRtnErrorConditionalOrder(CThostFtdcErrorConditionalOrderField *pErrorConditionalOrder) 
{
   if(cbOnRtnErrorConditionalOrder!=NULL)
        cbOnRtnErrorConditionalOrder(pErrorConditionalOrder);
}
void CCTPTDAPI::OnRspQryContractBank(CThostFtdcContractBankField *pContractBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryContractBank!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pContractBank)
	   {
        cbOnRspQryContractBank(pContractBank,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryParkedOrder(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryParkedOrder!=NULL)
	    if (!IsErrorRspInfo(pRspInfo) &&  pParkedOrder)
	   {
        cbOnRspQryParkedOrder(pParkedOrder,repareInfo(pRspInfo),nRequestID,bIsLast);
		}
}
void CCTPTDAPI::OnRspQryParkedOrderAction(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryParkedOrderAction!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pParkedOrderAction)
	   {
        cbOnRspQryParkedOrderAction(pParkedOrderAction,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }

}
void CCTPTDAPI::OnRspQryTradingNotice(CThostFtdcTradingNoticeField *pTradingNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryTradingNotice!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pTradingNotice)
	   {
        cbOnRspQryTradingNotice(pTradingNotice,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryBrokerTradingParams(CThostFtdcBrokerTradingParamsField *pBrokerTradingParams, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryBrokerTradingParams!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pBrokerTradingParams)
	   {
        cbOnRspQryBrokerTradingParams(pBrokerTradingParams,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRspQryBrokerTradingAlgos(CThostFtdcBrokerTradingAlgosField *pBrokerTradingAlgos, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQryBrokerTradingAlgos!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pBrokerTradingAlgos)
	   {
        cbOnRspQryBrokerTradingAlgos(pBrokerTradingAlgos,repareInfo(pRspInfo),nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRtnFromBankToFutureByBank(CThostFtdcRspTransferField *pRspTransfer) 
{
   if(cbOnRtnFromBankToFutureByBank!=NULL)

        cbOnRtnFromBankToFutureByBank(pRspTransfer);
}
void CCTPTDAPI::OnRtnFromFutureToBankByBank(CThostFtdcRspTransferField *pRspTransfer) 
{
   if(cbOnRtnFromFutureToBankByBank!=NULL)
        cbOnRtnFromFutureToBankByBank(pRspTransfer);
}
void CCTPTDAPI::OnRtnRepealFromBankToFutureByBank(CThostFtdcRspRepealField *pRspRepeal) 
{
   if(cbOnRtnRepealFromBankToFutureByBank!=NULL)
        cbOnRtnRepealFromBankToFutureByBank(pRspRepeal);
}
void CCTPTDAPI::OnRtnRepealFromFutureToBankByBank(CThostFtdcRspRepealField *pRspRepeal) 
{
   if(cbOnRtnRepealFromFutureToBankByBank!=NULL)
        cbOnRtnRepealFromFutureToBankByBank(pRspRepeal);
}
void CCTPTDAPI::OnRtnFromBankToFutureByFuture(CThostFtdcRspTransferField *pRspTransfer) 
{
   if(cbOnRtnFromBankToFutureByFuture!=NULL)
        cbOnRtnFromBankToFutureByFuture(pRspTransfer);
}
void CCTPTDAPI::OnRtnFromFutureToBankByFuture(CThostFtdcRspTransferField *pRspTransfer) 
{
   if(cbOnRtnFromFutureToBankByFuture!=NULL)
        cbOnRtnFromFutureToBankByFuture(pRspTransfer);
}
void CCTPTDAPI::OnRtnRepealFromBankToFutureByFutureManual(CThostFtdcRspRepealField *pRspRepeal) 
{
   if(cbOnRtnRepealFromBankToFutureByFutureManual!=NULL)
        cbOnRtnRepealFromBankToFutureByFutureManual(pRspRepeal);
}
void CCTPTDAPI::OnRtnRepealFromFutureToBankByFutureManual(CThostFtdcRspRepealField *pRspRepeal) 
{
   if(cbOnRtnRepealFromFutureToBankByFutureManual!=NULL)
        cbOnRtnRepealFromFutureToBankByFutureManual(pRspRepeal);
}
void CCTPTDAPI::OnRtnQueryBankBalanceByFuture(CThostFtdcNotifyQueryAccountField *pNotifyQueryAccount) 
{
   if(cbOnRtnQueryBankBalanceByFuture!=NULL)
        cbOnRtnQueryBankBalanceByFuture(pNotifyQueryAccount);
}
void CCTPTDAPI::OnErrRtnBankToFutureByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) 
{
   if(cbOnErrRtnBankToFutureByFuture!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pReqTransfer)
	   {
        cbOnErrRtnBankToFutureByFuture(pReqTransfer,repareInfo(pRspInfo));
	   }
}
void CCTPTDAPI::OnErrRtnFutureToBankByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo) 
{
   if(cbOnErrRtnFutureToBankByFuture!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pReqTransfer)
	   {
        cbOnErrRtnFutureToBankByFuture(pReqTransfer,repareInfo(pRspInfo));
	   }
}
void CCTPTDAPI::OnErrRtnRepealBankToFutureByFutureManual(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) 
{
   if(cbOnErrRtnRepealBankToFutureByFutureManual!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pReqRepeal)
	   {
        cbOnErrRtnRepealBankToFutureByFutureManual(pReqRepeal,repareInfo(pRspInfo));
	   }
}
void CCTPTDAPI::OnErrRtnRepealFutureToBankByFutureManual(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo) 
{
   if(cbOnErrRtnRepealFutureToBankByFutureManual!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pReqRepeal)
	   {
        cbOnErrRtnRepealFutureToBankByFutureManual(pReqRepeal,repareInfo(pRspInfo));
	   }
}
void CCTPTDAPI::OnErrRtnQueryBankBalanceByFuture(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo) 
{
   if(cbOnErrRtnQueryBankBalanceByFuture!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pReqQueryAccount)
	   {
        cbOnErrRtnQueryBankBalanceByFuture(pReqQueryAccount,repareInfo(pRspInfo));
	   }
}
void CCTPTDAPI::OnRtnRepealFromBankToFutureByFuture(CThostFtdcRspRepealField *pRspRepeal) 
{
   if(cbOnRtnRepealFromBankToFutureByFuture!=NULL)
        cbOnRtnRepealFromBankToFutureByFuture(pRspRepeal);
}
void CCTPTDAPI::OnRtnRepealFromFutureToBankByFuture(CThostFtdcRspRepealField *pRspRepeal) 
{
   if(cbOnRtnRepealFromFutureToBankByFuture!=NULL)
        cbOnRtnRepealFromFutureToBankByFuture(pRspRepeal);
}
void CCTPTDAPI::OnRspFromBankToFutureByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspFromBankToFutureByFuture!=NULL)
	    if (!IsErrorRspInfo(pRspInfo) &&  pReqTransfer)
	   {
        cbOnRspFromBankToFutureByFuture(pReqTransfer,repareInfo(pRspInfo),nRequestID,bIsLast);
		}
}
void CCTPTDAPI::OnRspFromFutureToBankByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspFromFutureToBankByFuture!=NULL)
	    if (!IsErrorRspInfo(pRspInfo) &&  pReqTransfer)
	   {
        cbOnRspFromFutureToBankByFuture(pReqTransfer,repareInfo(pRspInfo),nRequestID,bIsLast);
		}
}
void CCTPTDAPI::OnRspQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast) 
{
   if(cbOnRspQueryBankAccountMoneyByFuture!=NULL)
	   if (!IsErrorRspInfo(pRspInfo) &&  pReqQueryAccount)
	   {
        cbOnRspQueryBankAccountMoneyByFuture(pReqQueryAccount,pRspInfo,nRequestID,bIsLast);
	   }
}
void CCTPTDAPI::OnRtnOpenAccountByBank(CThostFtdcOpenAccountField *pOpenAccount) 
{
   if(cbOnRtnOpenAccountByBank!=NULL)
        cbOnRtnOpenAccountByBank(pOpenAccount);
}
void CCTPTDAPI::OnRtnCancelAccountByBank(CThostFtdcCancelAccountField *pCancelAccount) 
{
   if(cbOnRtnCancelAccountByBank!=NULL)
        cbOnRtnCancelAccountByBank(pCancelAccount);
}
void CCTPTDAPI::OnRtnChangeAccountByBank(CThostFtdcChangeAccountField *pChangeAccount) 
{
   if(cbOnRtnChangeAccountByBank!=NULL)
        cbOnRtnChangeAccountByBank(pChangeAccount);
}

////////////////////////////回调函数导出///////////////////////////////////////////////////
CTPTDAPI_API void WINAPI RegOnFrontConnected(CBOnFrontConnected cb)
{
    cbOnFrontConnected=cb;
}
CTPTDAPI_API void WINAPI RegOnFrontDisconnected(CBOnFrontDisconnected cb)
{
    cbOnFrontDisconnected=cb;
}
CTPTDAPI_API void WINAPI RegOnHeartBeatWarning(CBOnHeartBeatWarning cb)
{
    cbOnHeartBeatWarning=cb;
}
CTPTDAPI_API void WINAPI RegOnRspAuthenticate(CBOnRspAuthenticate cb)
{
    cbOnRspAuthenticate=cb;
}
CTPTDAPI_API void WINAPI RegOnRspUserLogin(CBOnRspUserLogin cb)
{
    cbOnRspUserLogin=cb;
}
CTPTDAPI_API void WINAPI RegOnRspUserLogout(CBOnRspUserLogout cb)
{
    cbOnRspUserLogout=cb;
}
CTPTDAPI_API void WINAPI RegOnRspUserPasswordUpdate(CBOnRspUserPasswordUpdate cb)
{
    cbOnRspUserPasswordUpdate=cb;
}
CTPTDAPI_API void WINAPI RegOnRspTradingAccountPasswordUpdate(CBOnRspTradingAccountPasswordUpdate cb)
{
    cbOnRspTradingAccountPasswordUpdate=cb;
}
CTPTDAPI_API void WINAPI RegOnRspOrderInsert(CBOnRspOrderInsert cb)
{
    cbOnRspOrderInsert=cb;
}
CTPTDAPI_API void WINAPI RegOnRspParkedOrderInsert(CBOnRspParkedOrderInsert cb)
{
    cbOnRspParkedOrderInsert=cb;
}
CTPTDAPI_API void WINAPI RegOnRspParkedOrderAction(CBOnRspParkedOrderAction cb)
{
    cbOnRspParkedOrderAction=cb;
}
CTPTDAPI_API void WINAPI RegOnRspOrderAction(CBOnRspOrderAction cb)
{
    cbOnRspOrderAction=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQueryMaxOrderVolume(CBOnRspQueryMaxOrderVolume cb)
{
    cbOnRspQueryMaxOrderVolume=cb;
}
CTPTDAPI_API void WINAPI RegOnRspSettlementInfoConfirm(CBOnRspSettlementInfoConfirm cb)
{
    cbOnRspSettlementInfoConfirm=cb;
}
CTPTDAPI_API void WINAPI RegOnRspRemoveParkedOrder(CBOnRspRemoveParkedOrder cb)
{
    cbOnRspRemoveParkedOrder=cb;
}
CTPTDAPI_API void WINAPI RegOnRspRemoveParkedOrderAction(CBOnRspRemoveParkedOrderAction cb)
{
    cbOnRspRemoveParkedOrderAction=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryOrder(CBOnRspQryOrder cb)
{
    cbOnRspQryOrder=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryTrade(CBOnRspQryTrade cb)
{
    cbOnRspQryTrade=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryInvestorPosition(CBOnRspQryInvestorPosition cb)
{
    cbOnRspQryInvestorPosition=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryTradingAccount(CBOnRspQryTradingAccount cb)
{
    cbOnRspQryTradingAccount=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryInvestor(CBOnRspQryInvestor cb)
{
    cbOnRspQryInvestor=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryTradingCode(CBOnRspQryTradingCode cb)
{
    cbOnRspQryTradingCode=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryInstrumentMarginRate(CBOnRspQryInstrumentMarginRate cb)
{
    cbOnRspQryInstrumentMarginRate=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryInstrumentCommissionRate(CBOnRspQryInstrumentCommissionRate cb)
{
    cbOnRspQryInstrumentCommissionRate=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryExchange(CBOnRspQryExchange cb)
{
    cbOnRspQryExchange=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryInstrument(CBOnRspQryInstrument cb)
{
    cbOnRspQryInstrument=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryDepthMarketData(CBOnRspQryDepthMarketData cb)
{
    cbOnRspQryDepthMarketData=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQrySettlementInfo(CBOnRspQrySettlementInfo cb)
{
    cbOnRspQrySettlementInfo=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryTransferBank(CBOnRspQryTransferBank cb)
{
    cbOnRspQryTransferBank=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryInvestorPositionDetail(CBOnRspQryInvestorPositionDetail cb)
{
    cbOnRspQryInvestorPositionDetail=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryNotice(CBOnRspQryNotice cb)
{
    cbOnRspQryNotice=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQrySettlementInfoConfirm(CBOnRspQrySettlementInfoConfirm cb)
{
    cbOnRspQrySettlementInfoConfirm=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryInvestorPositionCombineDetail(CBOnRspQryInvestorPositionCombineDetail cb)
{
    cbOnRspQryInvestorPositionCombineDetail=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryCFMMCTradingAccountKey(CBOnRspQryCFMMCTradingAccountKey cb)
{
    cbOnRspQryCFMMCTradingAccountKey=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryEWarrantOffset(CBOnRspQryEWarrantOffset cb)
{
    cbOnRspQryEWarrantOffset=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryInvestorProductGroupMargin(CBOnRspQryInvestorProductGroupMargin cb)
{
    cbOnRspQryInvestorProductGroupMargin=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryExchangeMarginRate(CBOnRspQryExchangeMarginRate cb)
{
    cbOnRspQryExchangeMarginRate=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryExchangeMarginRateAdjust(CBOnRspQryExchangeMarginRateAdjust cb)
{
    cbOnRspQryExchangeMarginRateAdjust=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryTransferSerial(CBOnRspQryTransferSerial cb)
{
    cbOnRspQryTransferSerial=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryAccountregister(CBOnRspQryAccountregister cb)
{
    cbOnRspQryAccountregister=cb;
}
CTPTDAPI_API void WINAPI RegOnRspError(CBOnRspError cb)
{
    cbOnRspError=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnOrder(CBOnRtnOrder cb)
{
    cbOnRtnOrder=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnTrade(CBOnRtnTrade cb)
{
    cbOnRtnTrade=cb;
}
CTPTDAPI_API void WINAPI RegOnErrRtnOrderInsert(CBOnErrRtnOrderInsert cb)
{
    cbOnErrRtnOrderInsert=cb;
}
CTPTDAPI_API void WINAPI RegOnErrRtnOrderAction(CBOnErrRtnOrderAction cb)
{
    cbOnErrRtnOrderAction=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnInstrumentStatus(CBOnRtnInstrumentStatus cb)
{
    cbOnRtnInstrumentStatus=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnTradingNotice(CBOnRtnTradingNotice cb)
{
    cbOnRtnTradingNotice=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnErrorConditionalOrder(CBOnRtnErrorConditionalOrder cb)
{
    cbOnRtnErrorConditionalOrder=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryContractBank(CBOnRspQryContractBank cb)
{
    cbOnRspQryContractBank=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryParkedOrder(CBOnRspQryParkedOrder cb)
{
    cbOnRspQryParkedOrder=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryParkedOrderAction(CBOnRspQryParkedOrderAction cb)
{
    cbOnRspQryParkedOrderAction=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryTradingNotice(CBOnRspQryTradingNotice cb)
{
    cbOnRspQryTradingNotice=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryBrokerTradingParams(CBOnRspQryBrokerTradingParams cb)
{
    cbOnRspQryBrokerTradingParams=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQryBrokerTradingAlgos(CBOnRspQryBrokerTradingAlgos cb)
{
    cbOnRspQryBrokerTradingAlgos=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnFromBankToFutureByBank(CBOnRtnFromBankToFutureByBank cb)
{
    cbOnRtnFromBankToFutureByBank=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnFromFutureToBankByBank(CBOnRtnFromFutureToBankByBank cb)
{
    cbOnRtnFromFutureToBankByBank=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnRepealFromBankToFutureByBank(CBOnRtnRepealFromBankToFutureByBank cb)
{
    cbOnRtnRepealFromBankToFutureByBank=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnRepealFromFutureToBankByBank(CBOnRtnRepealFromFutureToBankByBank cb)
{
    cbOnRtnRepealFromFutureToBankByBank=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnFromBankToFutureByFuture(CBOnRtnFromBankToFutureByFuture cb)
{
    cbOnRtnFromBankToFutureByFuture=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnFromFutureToBankByFuture(CBOnRtnFromFutureToBankByFuture cb)
{
    cbOnRtnFromFutureToBankByFuture=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnRepealFromBankToFutureByFutureManual(CBOnRtnRepealFromBankToFutureByFutureManual cb)
{
    cbOnRtnRepealFromBankToFutureByFutureManual=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnRepealFromFutureToBankByFutureManual(CBOnRtnRepealFromFutureToBankByFutureManual cb)
{
    cbOnRtnRepealFromFutureToBankByFutureManual=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnQueryBankBalanceByFuture(CBOnRtnQueryBankBalanceByFuture cb)
{
    cbOnRtnQueryBankBalanceByFuture=cb;
}
CTPTDAPI_API void WINAPI RegOnErrRtnBankToFutureByFuture(CBOnErrRtnBankToFutureByFuture cb)
{
    cbOnErrRtnBankToFutureByFuture=cb;
}
CTPTDAPI_API void WINAPI RegOnErrRtnFutureToBankByFuture(CBOnErrRtnFutureToBankByFuture cb)
{
    cbOnErrRtnFutureToBankByFuture=cb;
}
CTPTDAPI_API void WINAPI RegOnErrRtnRepealBankToFutureByFutureManual(CBOnErrRtnRepealBankToFutureByFutureManual cb)
{
    cbOnErrRtnRepealBankToFutureByFutureManual=cb;
}
CTPTDAPI_API void WINAPI RegOnErrRtnRepealFutureToBankByFutureManual(CBOnErrRtnRepealFutureToBankByFutureManual cb)
{
    cbOnErrRtnRepealFutureToBankByFutureManual=cb;
}
CTPTDAPI_API void WINAPI RegOnErrRtnQueryBankBalanceByFuture(CBOnErrRtnQueryBankBalanceByFuture cb)
{
    cbOnErrRtnQueryBankBalanceByFuture=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnRepealFromBankToFutureByFuture(CBOnRtnRepealFromBankToFutureByFuture cb)
{
    cbOnRtnRepealFromBankToFutureByFuture=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnRepealFromFutureToBankByFuture(CBOnRtnRepealFromFutureToBankByFuture cb)
{
    cbOnRtnRepealFromFutureToBankByFuture=cb;
}
CTPTDAPI_API void WINAPI RegOnRspFromBankToFutureByFuture(CBOnRspFromBankToFutureByFuture cb)
{
    cbOnRspFromBankToFutureByFuture=cb;
}
CTPTDAPI_API void WINAPI RegOnRspFromFutureToBankByFuture(CBOnRspFromFutureToBankByFuture cb)
{
    cbOnRspFromFutureToBankByFuture=cb;
}
CTPTDAPI_API void WINAPI RegOnRspQueryBankAccountMoneyByFuture(CBOnRspQueryBankAccountMoneyByFuture cb)
{
    cbOnRspQueryBankAccountMoneyByFuture=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnOpenAccountByBank(CBOnRtnOpenAccountByBank cb)
{
    cbOnRtnOpenAccountByBank=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnCancelAccountByBank(CBOnRtnCancelAccountByBank cb)
{
    cbOnRtnCancelAccountByBank=cb;
}
CTPTDAPI_API void WINAPI RegOnRtnChangeAccountByBank(CBOnRtnChangeAccountByBank cb)
{
    cbOnRtnChangeAccountByBank=cb;
}
////////////////////////////////////命令函数导出/////////////////////////////////////////////////////////
//连接
CTPTDAPI_API void Connect(char* FRONT_ADDR[])
{
	// 初始化UserApi
	pUserApi = CThostFtdcTraderApi::CreateFtdcTraderApi("TD");			// 创建UserApi
	CCTPTDAPI* pUserSpi = new CCTPTDAPI();
	pUserApi->RegisterSpi((CThostFtdcTraderSpi*)pUserSpi);			// 注册事件类
	pUserApi->SubscribePublicTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// 注册公有流
	pUserApi->SubscribePrivateTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// 注册私有流
	pUserApi->RegisterSpi(pUserSpi);						// 注册事件类
	for(int i=0;i<sizeof(FRONT_ADDR)/sizeof(char*);i++)
	{
		pUserApi->RegisterFront(FRONT_ADDR[i]);
	}
	//pUserApi->RegisterFront(FRONT_ADDR);							// connect
	pUserApi->Init();
	//pUserApi->Join();
}
//发送用户登录请求
CTPTDAPI_API int ReqUserLogin(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcUserIDType USER_ID,TThostFtdcPasswordType PASSWORD)
{
	CThostFtdcReqUserLoginField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID, BROKER_ID);
	strcpy_s(req.UserID, USER_ID);
	strcpy_s(req.Password, PASSWORD);
	strcpy_s(req.UserProductInfo,"LJP");
	return pUserApi->ReqUserLogin(&req, ++iRequestID);
}
//投资者结算结果确认
CTPTDAPI_API int ReqSettlementInfoConfirm(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID)
{
	CThostFtdcSettlementInfoConfirmField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID, BROKER_ID);
	strcpy_s(req.InvestorID, INVESTOR_ID);
	return pUserApi->ReqSettlementInfoConfirm(&req, ++iRequestID);
}
///请求查询投资者结算结果
CTPTDAPI_API int ReqQrySettlementInfo(TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcDateType	TRADING_DAY)
{
	CThostFtdcQrySettlementInfoField req;
	memset(&req, 0, sizeof(req));
	strcpy_s(req.BrokerID ,BROKER_ID);
	strcpy_s(req.InvestorID,INVESTOR_ID);	
	if(TRADING_DAY != NULL)
		strcpy_s(req.TradingDay, TRADING_DAY);
	return pUserApi->ReqQrySettlementInfo(&req, ++iRequestID);
}
//请求查询合约
CTPTDAPI_API int ReqQryInstrument(TThostFtdcInstrumentIDType INSTRUMENT_ID)
{
	CThostFtdcQryInstrumentField req;
	memset(&req, 0, sizeof(req));
	if(INSTRUMENT_ID != NULL)
		strcpy_s(req.InstrumentID, INSTRUMENT_ID);
	return pUserApi->ReqQryInstrument(&req, ++iRequestID);
}
//报单录入请求
//char *orderRef="LJP";
CTPTDAPI_API int ReqOrderInsert(CThostFtdcInputOrderField *pOrder)
{
	//CThostFtdcInputOrderField req;
	//memset(&req, 0, sizeof(req));	
	////memcpy(&req,  pOrder, sizeof(pOrder));
	//strcpy(req.BrokerID, pOrder->BrokerID);  //应用单元代码	
	//strcpy(req.InvestorID, pOrder->InvestorID); //投资者代码	
	//strcpy(req.InstrumentID,  pOrder->InstrumentID); //合约代码	
	//strcpy(req.OrderRef,  pOrder->OrderRef);  //报单引用
	//req.LimitPrice = pOrder->LimitPrice;	//价格
	////req.OrderPriceType = THOST_FTDC_OPT_AnyPrice;//价格类型=市价
	//req.TimeCondition = pOrder->TimeCondition;//有效期类型:立即完成，否则撤销
 //   req.OrderPriceType = pOrder->OrderPriceType;//价格类型=限价	
 //   req.TimeCondition =  pOrder->TimeCondition;  //有效期类型:当日有效
	//req.Direction =pOrder->Direction;  //买卖方向	
	//strcpy(req.CombOffsetFlag,  pOrder->CombOffsetFlag); 
	////req.CombOffsetFlag =pOrder->CombOffsetFlag; //组合开平标志:开仓
	////strcpy(req.CombHedgeFlag,  pOrder->CombHedgeFlag); 
	//req.CombHedgeFlag[0] = THOST_FTDC_HF_Speculation;	  //组合投机套保标志	
	//req.VolumeTotalOriginal =  pOrder->VolumeTotalOriginal;	///数量		
	//req.VolumeCondition =  pOrder->VolumeCondition; //成交量类型:任何数量
	//req.MinVolume = pOrder->MinVolume;	//最小成交量:1	
	//req.ContingentCondition = pOrder-> ContingentCondition;  //触发条件:立即
 // //TThostFtdcPriceType	StopPrice;  //止损价
	//req.ForceCloseReason =pOrder->ForceCloseReason;	//强平原因:非强平	
	//req.IsAutoSuspend = pOrder->IsAutoSuspend;  //自动挂起标志:否	
	//req.UserForceClose = pOrder->IsAutoSuspend;   //用户强评标志:否
	
	return  pUserApi->ReqOrderInsert(pOrder, ++iRequestID);
}
//报单操作请求
CTPTDAPI_API int ReqOrderAction(CThostFtdcInputOrderActionField *pInputOrderAction)
{
//	CThostFtdcInputOrderActionField req;
//	memset(&req, 0, sizeof(req));
//	strcpy(req.BrokerID, pInputOrderAction->BrokerID);   //经纪公司代码	
//	strcpy(req.InvestorID,pInputOrderAction->InvestorID); //投资者代码
//	//strcpy(req.OrderRef, pOrderRef); //报单引用	
//	//req.FrontID = frontId;           //前置编号	
//	//req.SessionID = sessionId;       //会话编号
//	strcpy(req.ExchangeID, pInputOrderAction->ExchangeID);
//	strcpy(req.OrderSysID, pInputOrderAction->OrderSysID);
//	req.ActionFlag =pInputOrderAction->ActionFlag;  //操作标志 

	return pUserApi->ReqOrderAction(pInputOrderAction, ++iRequestID);
}
///等待接口线程结束运行
	///@return 线程退出代码
CTPTDAPI_API int Join()
{
	return 	pUserApi->Join();	
}
//查询投资者持仓
CTPTDAPI_API int ReqQryInvestorPosition(CThostFtdcQryInvestorPositionField *pQryInvestorPosition)
{
	return 	pUserApi->ReqQryInvestorPosition(pQryInvestorPosition,++iRequestID);
}
//投资者持仓明细查询
CTPTDAPI_API int ReqQryInvestorPositionDetail(CThostFtdcQryInvestorPositionDetailField *pQryInvestorPositionDetail)
{
	return 	pUserApi->ReqQryInvestorPositionDetail(pQryInvestorPositionDetail,++iRequestID);
}
//投资者持仓明细查询
CTPTDAPI_API int ReqQryInvestorPositionCombineDetail(CThostFtdcQryInvestorPositionCombineDetailField *pQryInvestorPositionCombineDetail)
{
	return pUserApi->ReqQryInvestorPositionCombineDetail(pQryInvestorPositionCombineDetail,++iRequestID);
}
//查询报单

CTPTDAPI_API int ReqQryOrder(CThostFtdcQryOrderField *pQryOrder)
{
	return pUserApi->ReqQryOrder(pQryOrder,++iRequestID);
}
//////////////////////////////其他//////////////////////////////////////////////////////

//////////////////////////////构造函数/////////////////////////////////////////////////////////
CCTPTDAPI::CCTPTDAPI()
{
 return;
}
//针对收到空反馈的处理
CThostFtdcRspInfoField rif;
CThostFtdcRspInfoField* CCTPTDAPI::repareInfo(CThostFtdcRspInfoField *pRspInfo)
{
	if(pRspInfo==NULL)
	{
		memset(&rif,0,sizeof(rif));
		return &rif;
	}
	else
		return pRspInfo;
}

//错误的发现
bool CCTPTDAPI::IsErrorRspInfo(CThostFtdcRspInfoField *pRspInfo)
{
	// 如果ErrorID != 0, 说明收到了错误的响应
	bool ret = ((pRspInfo) && (pRspInfo->ErrorID != 0));
  if (ret)
  {
	  if(cbOnRspError!=NULL)
	{
		cbOnRspError(pRspInfo);
	}
    
  }
	return ret;
}