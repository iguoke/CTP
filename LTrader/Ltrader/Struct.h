#ifndef __STRUCT_H_
#define __STRUCT_H_
#include "Enum.h"

//交易账户
struct Account
{
 EnumAPI Api;//平台
 EnumMarket Market;//市场结构 
 double Available;//可用资金
 double Balance;//动态权益
 char *BrokerID;//经纪公司代码
 double CloseProfit;//平仓亏盈
 double Commission;//手续费
 double CurrMargin;//持仓保证金
 double FrozenCommission;//报单未成交冻结手续费
 double FrozenMargin;//报单未成交冻结保证金
 char InvestorID;//投资者代码 
 double PositionProfit;//持仓亏盈
 double PreBalance;// 昨结
 double PreDeposit;//上次存款额: 前一交易日结算后的结存现金 ( 期末结存 - 保证金占用 ) 
 double PreMargin;//上次占用的保证金: 前一交易日交易结算单中（保证金占用） 
 double Risk;//风险=持仓/权益 
 double MarketValue;// 证券市值  
 };
typedef Account account;
 //手续费
struct CommissionRate 
{
  EnumAPI Api;//平台
  EnumMarket Market;//市场结构 
  char *BrokerID;// 经纪公司代码  
  double CloseRatioByMoney;// 平仓手续费率 
  double CloseRatioByVolume;// 每手平仓手续费  
  double CloseTodayRatioByMoney;// 平今手续费率
  double  CloseTodayRatioByVolume;// 每手平今手续费  
  char *InstrumentID;// 合约代码
  char * InvestorID;//投资者代码  
  double  OpenRatioByMoney;// 开仓手续费率  
  double OpenRatioByVolume;// 每手开仓手续费  
  };
typedef CommissionRate CommissionRate;
//保证金
struct MarginRate
{
  EnumAPI Api;//平台
  EnumMarket Market;//市场结构 
  char *BrokerID;// 经纪公司代码  
  EnumHedgeFlag HedgeFlag;// 投机套保标志  
  char *InstrumentID;// 合约代码  
  char * InvestorID;// 投资者代码
  bool  IsRelative;// 是否相对交易所收取  
  double LongMarginRatioByMoney;// 多头保证金率 
  double LongMarginRatioByVolume;// 多头保证金费  
  double ShortMarginRatioByMoney;// 空头保证金率 
  double ShortMarginRatioByVolume;// 空头保证金费  
  };
typedef MarginRate MarginRate;
//Tick 
struct tick
{
  EnumAPI Api;//平台
  EnumMarket Market;//市场结构 
  char *BrokerID;// 经纪公司代码   
  char *  TradingDay ;//交易日 
  char *InstrumentID ;//合约代码
  EnumExchange Exchange;//交易所
  double  LastPrice;//  最新价 
  double  PreSettlementPrice ;//上次结算价 
  double PreClosePrice ;// 昨收盘 
  double PreOpenInterest ;//昨持仓量 
  double OpenPrice ;//今开盘 
  double HighestPrice ;//最高价 
  double LowestPrice ;//最低价 
  int Volume ;//数量 
  double Turnover ;// 成交金额 
  int OpenInterest ;//持仓量 
  double ClosePrice ;// 今收盘 
  double SettlementPrice ;// 本次结算价 
  double UpperLimitPrice ;// 涨停板价 
  double LowerLimitPrice ;// 跌停板价 
  double PreDelta ;// 昨虚实度 
  double CurrDelta ;//今虚实度 
  double UpdateTime ;//最后修改时间 
  int  UpdateMillisec ;//最后修改毫秒 
  double BidPrice1 ;//申买价一 
  int BidVolume1;// 申买量一 
  double  AskPrice1;// 申卖价一 
  int AskVolume1;// 申卖量一 
  double BidPrice2;//申买价二 
  int  BidVolume2;//  申买量二 
  double  AskPrice2 ;//申卖价二 
  int AskVolume2;//  申卖量二 
  double BidPrice3 ;// 申买价三 
  int BidVolume3 ;//申买量三 
  double AskPrice3 ;// 申卖价三 
  int AskVolume3 ;//申卖量三 
  double BidPrice4;//申买价四 
  int BidVolume4 ;//申买量四 
  double AskPrice4;// 申卖价四 
  int AskVolume4 ;//申卖量四 
  double BidPrice5 ;//申买价五 
  int BidVolume5 ;//申买量五 
  double AskPrice5 ;// 申卖价五 
  int AskVolume5 ;//申卖量五 
  double AveragePrice ;//当日均价 
  char *ActionDay ;//业务日期 
};
typedef tick tick;
//商品品种
struct Product
{
  EnumAPI Api;//平台
  EnumMarket Market;//市场结构
  EnumExchange Exchange;//交易所
  bool IsArbitrage; //是否为套利品种 郑商所一些SP开头的品种时套利的  
  double DropLimit;// 跌停价  
  char *ExpireDate ;//到期日  
  char *InstrumentID;// 合约代码  
  double LastPrice ;//最新价格  
  tick LastTick ;//最新Tick  
  double LongMarginRatio ;//多头保证金率  
  EnumLifeStatus LifeStatus ;//合约生命周期状态  
  int MaxLimitOrderVolume;// 限价单最大下单量  
  int MaxMarketOrderVolume ;//市价单最大下单量  
  int MinLimitOrderVolume ;//限价单最小下单量  
  int MinMarketOrderVolume;// 市价单最小下单量  
  char *Name ;//合约名称  
  double PreClose;// 昨收盘  
  double PreSettlementPrice ;//昨结算价  
  double PriceTick ;//最小变动价位  
  double  ShortMarginRatio ;//空头保证金率  
  double UpLimit ;//涨停价  
  int VolumeMultiple;// 合约数量乘数  
};
typedef Product Product;
#endif

