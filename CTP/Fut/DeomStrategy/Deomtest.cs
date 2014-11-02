using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CTPAPI; 
namespace Fut.Core
{
    public class Deomtest2 : Strategy
    { 
    
    }
    public class Deomtest1 : Strategy
    { 
    
    }
    public class Deomtest : Strategy
    {
        public int n = 0;
        public bool k = false;
        private  string ordersysid = "";
        public string inst = "ag1406";
        public double LastPrice = 0;
        StateMachine stateMachine = new StateMachine();
        public override void Init()
        {
            //Print("这是Deomtest的Init（）");
            //MdApi_SubMarketData(inst);
            base.Init();
            
        }
        public override void MdApi_OnFrontConnected()
        {
            Print("连接行情前置成功!!!");
            MdApi_UserLogin();
        }
        public override void MdApi_OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Print("登陆行情账户成功!!!");
            
        }
        public override void OnTick(ref CThostFtdcDepthMarketDataField pDepthMarketData)
        {
            n++;
            Print(n.ToString() + " OnTick:" + pDepthMarketData.UpdateTime + "," + pDepthMarketData.UpdateMillisec.ToString()
                + "," + pDepthMarketData.LastPrice.ToString() + "," + pDepthMarketData.AskPrice1.ToString ()
                + "," + pDepthMarketData.BidPrice1.ToString() + "," + pDepthMarketData.HighestPrice.ToString ()
                + "," + pDepthMarketData.OpenPrice.ToString() + "," + pDepthMarketData.LowestPrice.ToString()
                + "," + pDepthMarketData.Volume.ToString() + "," + pDepthMarketData.Turnover.ToString ()
                + "," + pDepthMarketData.OpenInterest.ToString());
           //Print(SendMessage(pDepthMarketData.LastPrice.ToString()));
            #region 坏点过滤
            if (base.BackTest == true)
            {
                k = true;
            }
            else
            {
                if (
                    pDepthMarketData.AskPrice1 <= 0 ||
                    pDepthMarketData.AskVolume1 <= 0 ||
                    pDepthMarketData.BidPrice1 <= 0 ||
                    pDepthMarketData.BidVolume1 <= 0 ||
                    pDepthMarketData.AskPrice1 > 1000000 ||
                    pDepthMarketData.AskVolume1 > 1000000 ||
                    pDepthMarketData.BidPrice1 > 1000000 ||
                    pDepthMarketData.BidVolume1 > 1000000)
                {
                    return;
                }
            }
            #endregion
            
            LastPrice = pDepthMarketData.LastPrice;
            //if (k == true)
           // {
                if (stateMachine.Flag == 0 && stateMachine.TargetFlag == 0)
                {
                    stateMachine.TargetFlag = 5;
                }
                if (stateMachine.Flag != 0 && stateMachine.TargetFlag != 0)
                {
                    stateMachine.TargetFlag = 0;
                   //k = false;
                }
                CoreRun(ref pDepthMarketData); 
           // }
            
            //if (k==true)
            //{
            //    k = false;
            //    Print(LimitOrder("ag1406", pDepthMarketData.AskPrice1, 5, TThostFtdcDirectionType.THOST_FTDC_D_Buy, "00000").ToString());
            //    //CancelOrder();

            //}
            //if (ordersysid!= "")
            //{
            //   // CancelOrder(ordersysid);
            //}
           // Print(n.ToString());
            //if (n == 3)
            //{
            //    MdApi_UnSubMarketData("ag1406");

            //}
        }
        public override void OnOrder(ref CThostFtdcOrderField pOrder)
        {
            // base.OnOrder(ref pOrder);
            ordersysid = pOrder.OrderSysID;
            // Print("交易报单响应" + pOrder.OrderSysID + pOrder.ExchangeID);
            Print("报单状态：" + pOrder.StatusMsg.ToString());
            Print("报单编号：" + pOrder.OrderSysID.ToString());
            
            //CThostFtdcInputOrderActionField order = new CThostFtdcInputOrderActionField();
            //order.OrderSysID = pOrder.OrderSysID;
            //order.ExchangeID = pOrder.ExchangeID;
            //if (order.OrderSysID!="")
            //{
            //    CancelOrder(order);
            //}
        }
        public override void OnTrade(ref CThostFtdcTradeField trade)
        {
            //base.OnTrade(ref trade);
            Print("成交编号：" + trade.OrderSysID.ToString());
            Print("成交手数：" + trade.Volume.ToString());
            #region

            string ordID = trade.OrderSysID;

            //肯定是先平后开
            if (trade.OffsetFlag == TThostFtdcOffsetFlagType.THOST_FTDC_OF_Open)
            {
                stateMachine.KN_Trd += trade.Volume;
                if (stateMachine.KN_Trd >= stateMachine.KN)
                {
                    if (stateMachine.PN_Trd >= stateMachine.PN)
                    {
                        stateMachine.IsDoing = false;
                        显示当前状态("开仓完成,逻辑结束");
                    }
                    else
                    {
                        显示当前状态("开仓完成,但还有平仓任务没完成");
                    }
                }
            }
            else
            {
                #region
                stateMachine.PN_Trd += trade.Volume;

                if (stateMachine.PN_Trd >= stateMachine.PN)
                {
                    显示当前状态("平仓动作完成");
                    if (stateMachine.KN == 0)
                    {
                        Print("没有开仓任务，逻辑结束");
                        stateMachine.IsDoing = false;
                    }
                    else
                    {
                        if (stateMachine.KN_Trd >= stateMachine.KN)
                        {
                            Print("开仓任务全部完成,KN_Trd=" + stateMachine.KN_Trd + ",KN=" + stateMachine.KN + "，逻辑结束");
                            stateMachine.IsDoing = false;
                        }
                        else
                        {
                            //把开仓的任务做出来
                            Print("KN=" + stateMachine.KN + ",KN_Trd=" + stateMachine.KN_Trd + "需要执行开仓任务");
                            int K_Vol = stateMachine.KN - stateMachine.KN_Trd;
                            Print("实际开仓量=" + K_Vol);
                            LimitOrder(inst, LastPrice, K_Vol, trade.Direction, "00000");
                        }
                    }
                }
                #endregion
            }
            #endregion
        }
        public override void TdApi_OnFrontConnected()
        {
            Print("连接交易前置成功");
            TdApi_UserLogin();
            //System.Enum.ToString()
        }
        public override void TdApi_OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            base.TdApi_OnRspUserLogin(ref pRspUserLogin, ref pRspInfo, nRequestID, bIsLast);
            TdApi_SettlementInfoConfirm();
        }
        public override void TdApi_OnRspQrySettlementInfo(ref CThostFtdcSettlementInfoField pSettlementInfo, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            base.TdApi_OnRspQrySettlementInfo(ref pSettlementInfo, ref pRspInfo, nRequestID, bIsLast);
        }
        public override void TdApi_OnRspSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            base.TdApi_OnRspSettlementInfoConfirm(ref pSettlementInfoConfirm, ref pRspInfo, nRequestID, bIsLast);
            
            k = true;
        }
 
        public override void TdApi_OnErrRtnOrderInsert(ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo)
        {
            base.TdApi_OnErrRtnOrderInsert(ref pInputOrder, ref pRspInfo);
        }
        public void CoreRun(ref CThostFtdcDepthMarketDataField pDepthMarketData)
        {
            //注意：只要目标Flag!=实际Flag
            //这个时候要看Flag                   
            if (stateMachine.Flag != stateMachine.TargetFlag && !stateMachine.IsDoing)
            {
                #region
                stateMachine.IsDoing = true;//正在操作
                string info = "";
                //绝对工作量
                int AbsWork = Math.Abs(stateMachine.TargetFlag - stateMachine.Flag);
                if (stateMachine.TargetFlag == 0)
                {
                    #region 把Old的全部平掉
                    if (stateMachine.Flag > 0)
                    {
                        info += "目标仓单=0,平全部初始多单,";
                        stateMachine.KN = 0;
                        stateMachine.KN_Trd = 0;
                        stateMachine.PN = AbsWork;
                        stateMachine.PN_Trd = 0;
                        LimitOrder(inst, pDepthMarketData.BidPrice1, AbsWork, TThostFtdcDirectionType.THOST_FTDC_D_Sell, "30000");
                    }
                    else if (stateMachine.Flag < 0)
                    {
                        info += "目标理论仓单=0,平全部初始空单,";
                        if (stateMachine.KN_Trd > 0)
                        {
                            stateMachine.KN = 0;
                            stateMachine.KN_Trd = 0;
                            stateMachine.PN = AbsWork;
                            stateMachine.PN_Trd = 0;
                            显示当前状态("触发平空单");
                            LimitOrder(inst, pDepthMarketData.AskPrice1, AbsWork, TThostFtdcDirectionType.THOST_FTDC_D_Buy, "30000");
                            
                        }
                    }
                    #endregion
                }
                else
                {
                    #region 目标位有持仓
                    if (stateMachine.Flag == 0)
                    {
                        #region 如果当前不持仓，那么直接开
                        if (stateMachine.TargetFlag > 0)
                        {
                            info += "初始理论仓单=0,直接开目标多单,";
                            stateMachine.KN = AbsWork;
                            stateMachine.KN_Trd = 0;
                            stateMachine.PN = 0;
                            stateMachine.PN_Trd = 0;
                            显示当前状态("触发开仓做多");
                            LimitOrder(inst, pDepthMarketData.AskPrice1, AbsWork, TThostFtdcDirectionType.THOST_FTDC_D_Buy, "00000");
                    
                        }
                        else if (stateMachine.TargetFlag < 0)
                        {
                            info += "初始理论仓单=0,直接开目标空单,";
                            stateMachine.KN = AbsWork;
                            stateMachine.KN_Trd = 0;
                            stateMachine.PN = 0;
                            stateMachine.PN_Trd = 0;
                            显示当前状态("触发开仓做空");
                            LimitOrder(inst, pDepthMarketData.BidPrice1, AbsWork, TThostFtdcDirectionType.THOST_FTDC_D_Sell, "00000");
                            
                        }
                        #endregion
                    }
                    else
                    {
                        #region New理论仓单 Old理论仓单 都不为0
                        if (stateMachine.TargetFlag * stateMachine.Flag > 0)
                        {
                            #region 同向
                            if (Math.Abs(stateMachine.TargetFlag) > Math.Abs(stateMachine.Flag))
                            {
                                #region 同向增仓   新开仓
                                if (stateMachine.TargetFlag > 0)
                                {
                                    info += "同向,目标理论仓单>初始理论仓单,同向增仓做多,";
                                    //目标开仓位在原有基础上增加!
                                    stateMachine.KN = stateMachine.KN + AbsWork;
                                    stateMachine.KN_Trd = stateMachine.KN_Trd + 0;
                                    stateMachine.PN = 0;
                                    stateMachine.PN_Trd = 0;
                                    显示当前状态("触发增仓做多");
                                    LimitOrder(inst, pDepthMarketData.AskPrice1, AbsWork, TThostFtdcDirectionType.THOST_FTDC_D_Buy, "00000");
                                }
                                else if (stateMachine.TargetFlag < 0)
                                {
                                    info += "同向,目标理论仓单>初始理论仓单,同向增仓做空,";
                                    //目标开仓位在原有基础上增加!
                                    stateMachine.KN = stateMachine.KN + AbsWork;
                                    stateMachine.KN_Trd = stateMachine.KN_Trd + 0;
                                    stateMachine.PN = 0;
                                    stateMachine.PN_Trd = 0;
                                    显示当前状态("触发增仓做空");
                                    LimitOrder(inst, pDepthMarketData.BidPrice1, AbsWork, TThostFtdcDirectionType.THOST_FTDC_D_Sell, "00000");
                                }
                                #endregion
                            }
                            else if (Math.Abs(stateMachine.TargetFlag) < Math.Abs(stateMachine.Flag))
                            {
                                #region 同向减仓 （平掉部分单子）
                                if (stateMachine.TargetFlag > 0)
                                {
                                    info += "反向,目标理论仓单<初始理论仓单,减仓做空,";
                                    //这里注意把KN降下来
                                    stateMachine.KN = stateMachine.KN - AbsWork;
                                    stateMachine.KN_Trd = stateMachine.KN_Trd - AbsWork;
                                    stateMachine.PN = AbsWork;
                                    stateMachine.PN_Trd = 0;
                                    显示当前状态("触发减仓做空");
                                    LimitOrder(inst, pDepthMarketData.BidPrice1, AbsWork, TThostFtdcDirectionType.THOST_FTDC_D_Sell , "30000");
                                }
                                else if (stateMachine.TargetFlag < 0)
                                {
                                    info += "反向,目标理论仓单<初始理论仓单,减仓做多,";
                                    //这里注意把KN降下来
                                    stateMachine.KN = stateMachine.KN - AbsWork;
                                    stateMachine.KN_Trd = stateMachine.KN_Trd - AbsWork;
                                    stateMachine.PN = AbsWork;
                                    stateMachine.PN_Trd = 0;
                                    显示当前状态("触发减仓做多");
                                    LimitOrder(inst, pDepthMarketData.AskPrice1, AbsWork, TThostFtdcDirectionType.THOST_FTDC_D_Buy, "30000");
                                }
                                #endregion
                            }
                            #endregion
                        }
                        else
                        {
                            #region 方向，有一个先平后开的问题，这里要非常精细！！
                            if (stateMachine.Flag > 0)
                            {
                                //先打平仓单，只有等平仓单全部成交了，才开仓！！
                                info += "反向,多单全平,开目标空单,";
                                stateMachine.KN = Math.Abs(stateMachine.TargetFlag);
                                stateMachine.KN_Trd = 0;
                                stateMachine.PN = Math.Abs(stateMachine.Flag);
                                stateMachine.PN_Trd = 0;
                                显示当前状态("触发先平后开做空");
                                //把多单全平了
                                //然后开目标空单 
                                LimitOrder(inst, pDepthMarketData.BidPrice1, stateMachine.PN, TThostFtdcDirectionType.THOST_FTDC_D_Sell, "30000");
                            }
                            else if (stateMachine.Flag < 0)
                            {
                                //先打平仓单，只有等平仓单全部成交了，才开仓！！
                                info += "反向,空单全平,开目标多单,";
                                stateMachine.KN = Math.Abs(stateMachine.TargetFlag);
                                stateMachine.KN_Trd = 0;
                                stateMachine.PN = Math.Abs(stateMachine.Flag);
                                stateMachine.PN_Trd = 0;
                                显示当前状态("触发先平后开做多");
                                LimitOrder(inst, pDepthMarketData.AskPrice1, stateMachine.PN, TThostFtdcDirectionType.THOST_FTDC_D_Buy, "30000");
                            }
                            #endregion
                        }
                        #endregion
                    }
                    #endregion
                }
                stateMachine.Flag = stateMachine.TargetFlag;//最终标志位强制设置成目标标志位!!
                Print(info);
                #endregion
            }
        }
        public void 显示当前状态(string info)
        {
            //显示核心信息 
            Print(info);
            Print(stateMachine.ToString());
        }
    
    }

}
