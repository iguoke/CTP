#ifndef __ENUM_H_
#define __ENUM_H_


//交易类型
typedef enum TradeType
{
  Back,
  Simulation,
  Real
} TradeType;
//API
typedef enum EnumAPI
{
  CTP,
  FRMAS,
  XSPEE,
  Esunny,
  HBLTS,
  GSFIX
} EnumAPI;
//Exchange
typedef enum EnumExchange
{
  CFFEX,
  DCE,
  CZCE,
  SHFE,
  SSE,
  SZSE
} EnumExchange;
//市场结构
typedef enum EnumMarket
{
 Stock,
 Bonds,
 Forex,
 Futures,
 Options,
 ETF
} EnumMarket;
//BarType
typedef enum EnumBarType
{
 Tick,
 Second,
 Minute, 
 Hour, 
 Day, 
 Week,
 Month, 
 Year
} EnumBarType;
//买卖方向
typedef enum EnumDirection
{
  BuyDirection,
  SellDirection
} EnumDirection;
//出发条件
typedef enum EnumContingentCondition
{
  Immediately, //立即  
  Touch, //止损  
  TouchProfit, // 止赢  
  ParkedOrder, // 预埋单  
  LastPriceGreaterThanStopPrice, // 最新价大于条件价  
  LastPriceGreaterEqualStopPrice, // 最新价大于等于条件价  
  LastPriceLesserThanStopPrice, // 最新价小于条件价  
  LastPriceLesserEqualStopPrice, // 最新价小于等于条件价  
  AskPriceGreaterThanStopPrice, // 卖一价大于条件价  
  AskPriceGreaterEqualStopPrice, // 卖一价大于等于条件价  
  AskPriceLesserThanStopPrice, // 卖一价小于条件价  
  AskPriceLesserEqualStopPrice, // 卖一价小于等于条件价  
  BidPriceGreaterThanStopPrice, // 买一价大于条件价  
  BidPriceGreaterEqualStopPrice, // 买一价大于等于条件价  
  BidPriceLesserThanStopPrice, // 买一价小于条件价  
  BidPriceLesserEqualStopPrice //买一价小于等于条件价
} EnumContingentCondition;
//两条曲线互相穿过关系 
typedef enum EnumCross
{
  Above , //上穿  
  Below , //下穿  
  None  //无  
} EnumCross;
//期货委托状态 
typedef enum EnumFutureOrderStatus
{
  Waste  ,// 废单  
  Tobereported  , //待报  
  Reported // 已报  
} EnumFutureOrderStatus;
//投机套保标志
typedef enum EnumHedgeFlag
{
  Speculation ,// 投机  
  Arbitrage ,// 套利  
  Hedge //套保
} EnumHedgeFlag;
//索引选项
typedef enum EnumIndexOption
{
    Null,//没有
    Next,//向前
    Prev//向后
} EnumIndexOption;
//合约生命周期
typedef enum EnumLifeStatus
{
    Maturity, //未上市
    Listed ,//上市
    Suspended,// 停牌
    Unlisted //到期
} EnumLifeStatus;
//网络结构
typedef enum EnumNetType
{
  UniCom ,//联通  
  TeleCom //电信
} EnumNetType;
//回报模式
typedef enum RESUMETYPE
{
	RESTART,
	RESUME,
	QUICK
} RESUMETYPE;

//开平仓
typedef enum EnumOpenClose
{
  Open ,// 开仓  
  Close ,// 平仓  
  CloseToday, // 平今  
  StrongClose ,// 强平  
  StrongReduction//强减
} EnumOpenClose;
//报单状态类型
typedef enum EnumOrderStatus
{
  AllTraded ,// 全部成交  
  PartTradedQueueing ,// 部分成交还在队列中  
  PartTradedNotQueueing ,// 部分成交不在队列中  
  NoTradeQueueing ,// 未成交还在队列中  
  NoTradeNotQueueing ,// 未成交不在队列中  
  Canceled ,// 撤单  
  Unknown ,// 未知  
  NotTouched ,// 尚未触发  
  Touched // 已触发  
} EnumOrderStatus;
//是一个报单提交状态类型
typedef enum EnumOrderSubmitStatus
{
  InsertSubmitted ,// 已经提交  
 CancelSubmitted ,// 撤单已经提交  
 ModifySubmitted ,// 修改已经提交  
 Accepted ,// 已经接受  
 InsertRejected ,// 报单已经被拒绝  
 CancelRejected ,// 撤单已经被拒绝  
 ModifyRejected // 修改已经被拒绝  
} EnumOrderSubmitStatus;
//报单类型 
typedef enum EnumOrderType
{
  Normal ,//正常  
 DeriveFromQuote ,// 报价衍生  
 DeriveFromCombination ,// 组合衍生  
 Combination ,// 组合报单  
 ConditionalOrder ,// 条件单  
 Swap //互换单
} EnumOrderType;
//是一个预埋单状态类型
typedef enum EnumParkedOrderStatus
{
  NotSend ,//未发送  
 Send ,// 已发送  
 Deleted // 已删除  
} EnumParkedOrderStatus;
//持仓日期类型
typedef enum EnumPositionDate
{
  Today,
  History
} EnumPositionDate ;
//期货持仓方向 
typedef enum EnumPositionDirection
{
 Long,
 Short,
 Netpositions//净持仓
} EnumPositionDirection;
//成交价来源 
typedef enum EnumPriceSource
{
  LastPrice ,// 前成交价  
 Buy ,// 买委托价  
 Sell //卖委托价
} EnumPriceSource;
//报单被拒绝原因
typedef enum  EnumRejectReason
{
  Superlicense,// 已撤单报单被拒绝综合交易平台：交易所每秒发送请求数超过许可数  
 Nonminimumunit ,// 已撤单报单被拒绝价格非最小单位的倍数  
 Higherthanlimit ,// 已撤单报单被拒绝价格涨破涨停板  
 Lowerthanlimit ,// 已撤单报单被拒绝价格跌破跌停板  
 Lackoffunds ,// 综合交易平台：资金不足  
 Lackoftodaypostion ,// 综合交易平台：平今仓位不足  
 Lackofhistorypostion ,// 综合交易平台：平昨仓位不足  
 Nonsupportordertype  ,// 已撤单报单被拒绝不被支持的报单类型  
 NonsupportHedgetype ,// 该交易所不支持套利类型报单  
 //保值额度不足 9 已撤单报单被拒绝保值额度不足  
 Nonnetconnect ,// 网络连接失败  
 Delayorder ,// 委托数超过流量限制，拒绝延迟发送开仓单  
 Stop ,// 暂停发送开仓单XX秒  
 Undown 
} EnumRejectReason;
//复权方式
typedef enum EnumRestoration
{
 NonR,
 PreR,
 NextR
} EnumRestoration;
//声音类型
typedef enum EnumSound
{
 Alarm ,  
 Beep ,  
 Chimes ,  
 Clear ,  
 Ding ,  
 Error, 
 Logout ,  
 Notenough ,  
 Notify ,  
 Ring 
} EnumSound;
//交易助手-撤单成功后续处理 
typedef enum EnumAfterCancel
{
 NonA,//无操作
 Reorder//重发委托 
} EnumAfterCancel;
//驱动方式
typedef enum EnumTriggerMode
{
  Ticker,
  Timer,
  Barer
} EnumTriggerMode;
//市场状态 
typedef enum EnumMarketState
{
  Auction,//集合竞价 0  
  Continuous,//连续竞价 1  
  MiddayRest,//午间休市 2  
  Closed//闭市 3  
} EnumMarketState;

#endif
