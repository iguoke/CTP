using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CTPAPI;
using Ats.Core;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace Futures
{
    public class Acc
    {
        public List<CThostFtdcInvestorPositionDetailField> InvestorPositionDetailFields { get; set; }
        
        public string invostor { get; set; }
        public string pwssword { get; set; }
        public string brokerid { get; set; }
        public string brokername { get; set; }
        //public string mdserver { get; set; }
        //public string tdserver { get; set; }
        public string state { get; set; }
        public bool isAuto { get; set; }
        public TDAPI tdapi { get; set; }
        public MDAPI mdapi { get; set; }
        public List<CThostFtdcOrderField> orders { get; set; }
        public bool ordersFlag = false;
        public List<CThostFtdcInvestorPositionField> PositionFields { get; set; }
        public bool PositionFlag = false;
        public OrderSeries orderSeries
        {
            get
            {
                OrderSeries Os = new OrderSeries();
                //lock (this.orders) // Lock关键字保证了什么，请大家看前面对lock的介绍           
                //{
                //    if (!ordersFlag)//如果现在不可读取               
                //    {
                //        Monitor.Wait(this.orders);
                //    }
                    
                     #region
                        for (int i = 0; i < this.orders.Count; i++)
                        {
                            Order o = new FutureOrder();
                            o.BrokerID = this.orders[i].BrokerID;
                            switch (this.orders[i].ContingentCondition)
                            {
                                case TThostFtdcContingentConditionType.THOST_FTDC_CC_Immediately:
                                    o.ContingentCondition = EnumContingentCondition.Immediately;
                                    break;
                                case TThostFtdcContingentConditionType.THOST_FTDC_CC_Touch:
                                    o.ContingentCondition = EnumContingentCondition.Touch;
                                    break;
                                case TThostFtdcContingentConditionType.THOST_FTDC_CC_TouchProfit:
                                    o.ContingentCondition = EnumContingentCondition.TouchProfit;
                                    break;
                                default:
                                    break;
                            }
                            switch (this.orders[i].Direction)
                            {
                                case TThostFtdcDirectionType.THOST_FTDC_D_Buy:
                                    o.Direction = EnumBuySell.买入;
                                    break;
                                case TThostFtdcDirectionType.THOST_FTDC_D_Sell:
                                    o.Direction = EnumBuySell.卖出;
                                    break;
                                default:
                                    break;
                            }

                            o.ExchangeID = this.orders[i].ExchangeID;
                            o.HedgeFlag = EnumHedgeFlag.Arbitrage;
                            o.InsertTime = Convert.ToDateTime(this.orders[i].InsertTime);
                            o.InstrumentID = this.orders[i].InstrumentID;
                            o.InstrumentType = EnumMarket.期货;
                            o.InvestorID = this.orders[i].InvestorID;
                            o.LimitPrice = this.orders[i].LimitPrice;
                            switch (this.orders[i].CombOffsetFlag)
                            {
                                case "0000":
                                    o.OpenOrClose = EnumOpenClose.开仓;
                                    break;
                                case "1000":
                                    o.OpenOrClose = EnumOpenClose.平仓;
                                    break;
                                case "3000":
                                    o.OpenOrClose = EnumOpenClose.平今仓;
                                    break;
                                case "2":
                                    o.OpenOrClose = EnumOpenClose.强平;
                                    break;
                                case "5":
                                    o.OpenOrClose = EnumOpenClose.强减;
                                    break;
                                default:
                                    break;
                            }
                            //o.OrderRejectReason = EnumRejectReason;
                            switch (this.orders[i].OrderStatus)
                            {
                                case TThostFtdcOrderStatusType.THOST_FTDC_OST_AllTraded:
                                    o.OrderStatus = EnumOrderStatus.AllTraded;
                                    break;
                                case TThostFtdcOrderStatusType.THOST_FTDC_OST_Canceled:
                                    o.OrderStatus = EnumOrderStatus.Canceled;
                                    break;
                                case TThostFtdcOrderStatusType.THOST_FTDC_OST_NoTradeNotQueueing:
                                    o.OrderStatus = EnumOrderStatus.NoTradeNotQueueing;
                                    break;
                                case TThostFtdcOrderStatusType.THOST_FTDC_OST_NoTradeQueueing:
                                    o.OrderStatus = EnumOrderStatus.NoTradeQueueing;
                                    break;
                                case TThostFtdcOrderStatusType.THOST_FTDC_OST_NotTouched:
                                    o.OrderStatus = EnumOrderStatus.NotTouched;
                                    break;
                                case TThostFtdcOrderStatusType.THOST_FTDC_OST_PartTradedNotQueueing:
                                    o.OrderStatus = EnumOrderStatus.PartTradedNotQueueing;
                                    break;
                                case TThostFtdcOrderStatusType.THOST_FTDC_OST_PartTradedQueueing:
                                    o.OrderStatus = EnumOrderStatus.PartTradedQueueing;
                                    break;
                                case TThostFtdcOrderStatusType.THOST_FTDC_OST_Touched:
                                    o.OrderStatus = EnumOrderStatus.Touched;
                                    break;
                                case TThostFtdcOrderStatusType.THOST_FTDC_OST_Unknown:
                                    o.OrderStatus = EnumOrderStatus.Unknown;
                                    break;
                                default:
                                    break;
                            }

                            o.OrderSysID = this.orders[i].OrderSysID;
                            switch (this.orders[i].OrderType)
                            {
                                case TThostFtdcOrderTypeType.THOST_FTDC_ORDT_Swap:
                                    o.OrderType = EnumOrderType.Swap;
                                    break;
                                case TThostFtdcOrderTypeType.THOST_FTDC_ORDT_Normal:
                                    o.OrderType = EnumOrderType.Normal;
                                    break;
                                case TThostFtdcOrderTypeType.THOST_FTDC_ORDT_DeriveFromQuote:
                                    o.OrderType = EnumOrderType.DeriveFromQuote;
                                    break;
                                case TThostFtdcOrderTypeType.THOST_FTDC_ORDT_DeriveFromCombination:
                                    o.OrderType = EnumOrderType.DeriveFromCombination;
                                    break;
                                case TThostFtdcOrderTypeType.THOST_FTDC_ORDT_ConditionalOrder:
                                    o.OrderType = EnumOrderType.ConditionalOrder;
                                    break;
                                case TThostFtdcOrderTypeType.THOST_FTDC_ORDT_Combination:
                                    o.OrderType = EnumOrderType.Combination;
                                    break;
                                default:
                                    break;
                            }

                            o.StatusMsg = this.orders[i].StatusMsg;
                            o.StopPrice = this.orders[i].StopPrice;
                            o.TradingDay = this.orders[i].TradingDay;
                            o.Volume = this.orders[i].VolumeTotalOriginal;
                            //o.VolumeLeft = pOrder.VolumeTotal;
                            o.VolumeTraded = this.orders[i].VolumeTraded;
                            //MessageBox.Show("");
                            if (o.VolumeLeft > 0)
                            {
                                Os.Add(o);
                            }
                        }
                        #endregion
                    //rdersFlag = false;

                    //Monitor.Pulse(this.orders); 
               // }
                
                return Os;
            }
        }
        public PositionSeries PositionSeries
        {
            get
            {
                PositionSeries Ps = new PositionSeries();
                // lock (this.PositionFields) // Lock关键字保证了什么，请大家看前面对lock的介绍           
                //{
                //    if (!PositionFlag)//如果现在不可读取               
                //    {
                //        Monitor.Wait(this.PositionFields);
                //    }
                    #region
                for (int i=0;i<this.PositionFields.Count;i++)
                {
                    //StreamWriter swFromFile = new StreamWriter("PositionFields.txt", true);
                    //swFromFile.WriteLine(pdf.InstrumentID + " : " + pdf.OpenVolume+"\r\n");
                    //swFromFile.Flush();
                    //swFromFile.Close();
                    //Application.OpenForms["Form_Main"]..PrintDisk("PositionFields",); 
                    Position p = new Position();
                    p.BrokerID = this.PositionFields[i].BrokerID;
                    p.CloseProfit = this.PositionFields[i].CloseProfitByTrade;
                    p.CombPosition = this.PositionFields[i].CombPosition;
                    
                    //this.accountList[0].orders
                    //p.EnableVolumn = ;
                    p.HedgeFlag = EnumHedgeFlag.Speculation;
                    p.InstrumentID = this.PositionFields[i].InstrumentID;
                    p.InstrumentType = EnumMarket.期货;
                    p.InvestorID = this.PositionFields[i].InvestorID;
                   
                    switch (this.PositionFields[i].PosiDirection)
                    {
                        case TThostFtdcPosiDirectionType.THOST_FTDC_PD_Long:
                            p.PosiDirection = EnumPositionDirection.多头;
                            break;
                        case TThostFtdcPosiDirectionType.THOST_FTDC_PD_Short:
                            p.PosiDirection = EnumPositionDirection.空头;
                            break;
                        case TThostFtdcPosiDirectionType.THOST_FTDC_PD_Net:
                            p.PosiDirection = EnumPositionDirection.净持仓;
                            break;
                        default:
                            break;
                    }
                    p.PositionCost = this.PositionFields[i].PositionCost;
                    if (Convert.ToDateTime(this.PositionFields[i].TradingDay.Insert(4, "/").Insert(7, "/")) == DateTime.Now.Date)
                    {
                        p.PositionDate = EnumPositionDate.Today;
                    }
                    else
                        p.PositionDate = EnumPositionDate.History;
                    p.PositionProfit = this.PositionFields[i].PositionProfit;
                    p.Price = this.PositionFields[i].OpenCost;
                    p.SettlementPrice = this.PositionFields[i].SettlementPrice;
                    p.TodayPosition = this.PositionFields[i].TodayPosition;
                    p.UseMargin = this.PositionFields[i].UseMargin;
                    p.Volumn = this.PositionFields[i].Position;
                    p.YdPosition = this.PositionFields[i].YdPosition;
                    p.EnableVolumn = this.PositionFields[i].Position;
                    foreach (FutureOrder fo in this.orderSeries)
                    {
                        if (p.InstrumentID == fo.InstrumentID)
                        {
                            if (fo.OpenOrClose == EnumOpenClose.平仓 || fo.OpenOrClose == EnumOpenClose.平今仓)
                            {
                                if ((p.PosiDirection == EnumPositionDirection.多头 && fo.Direction == EnumBuySell.卖出) || (p.PosiDirection == EnumPositionDirection.空头 && fo.Direction == EnumBuySell.买入))
                                {
                                    p.EnableVolumn = p.Volumn - fo.VolumeLeft;
                                    //MessageBox.Show(p.EnableVolumn.ToString());
                                }
                            }
                        }
                    }
                    //bool ifcz = false;
                    //for (int m = 0; m < Ps.Count;m++ )
                    //{
                    //    if (Ps[m].InstrumentID == p.InstrumentID)
                    //    {
                    //        if (Ps[m].PosiDirection == p.PosiDirection)
                    //        {
                    //            Ps[m].Volumn += p.Volumn;
                    //            Ps[m].YdPosition += p.YdPosition;
                    //            foreach (FutureOrder fo in this.orderSeries)
                    //            {
                    //                if (Ps[m].InstrumentID == fo.InstrumentID)
                    //                {
                    //                    if ((Ps[m].PosiDirection == EnumPositionDirection.多头 && fo.Direction == EnumBuySell.买入) || (Ps[m].PosiDirection == EnumPositionDirection.空头 && fo.Direction == EnumBuySell.卖出))
                    //                    {
                    //                        Ps[m].EnableVolumn = Ps[m].Volumn - fo.VolumeLeft;
                    //                    }
                    //                }
                    //            }
                    //            //Ps[m].EnableVolumn += p.EnableVolumn;
                    //            Ps[m].Price = (Ps[m].Price * Ps[m].Volumn + p.Volumn * p.Price) / Ps[m].Volumn;
                    //            ifcz = true;
                    //            break;
                    //        }
                            
                    //    }
                    //}
                    //if (!ifcz)
                    //    Ps.Add(p);
                    Ps.Add(p);
                }
                #endregion
                  // PositionFlag = false;
                  // Monitor.Pulse(this.PositionFields);
               // }
                return Ps;
            }
        }
        public Acc()
        {
            this.Clear();
        }
        public void Clear()
        {
            this.InvestorPositionDetailFields = new List<CThostFtdcInvestorPositionDetailField>();
            this.orders = new List<CThostFtdcOrderField>();
            this.PositionFields= new List<CThostFtdcInvestorPositionField>(); 
            this.brokerid = "";
            this.brokername = "";
            this.invostor = "";
            //this.mdserver = "";
            this.pwssword = "";
            //this.tdserver = "";
            this.state = "断开";
            this.isAuto = false;
            this.tdapi = null;
        }
    }
    public class AccSeries : List<Acc>
    {
        public Acc this[string broker, string invstor]
        {
            get
            {
                foreach (Acc acc in this)
                {
                    if (acc.brokerid == broker && acc.invostor == invstor)
                    {
                        return acc;
                    }
                }
                return null;
            }
            set 
            {
                for (int n = 0; n < this.Count; n++)
                {
                    if (this[n].brokerid == broker && this[n].invostor == invstor)
                    {
                        this[n] = value;
                    }
                }

            }
        }
        public Acc this[string invstor]
        {
            get
            {
                foreach (Acc acc in this)
                {
                    if (acc.invostor == invstor)
                    {
                        return acc;
                    }
                }
                return null;
            }
            set
            {
                for (int n = 0; n < this.Count; n++)
                {
                    if ( this[n].invostor == invstor)
                    {
                        this[n] = value;
                    }
                }

            }
        }
        
        
    }
    public class MdAccSeries : List<Acc>
    {
        //private List<Acc> _mdaccountList = new List<Acc>();
        public Acc this[string broker]
        {
            get
            {
                foreach (Acc acc in this)
                {
                    if (acc.brokerid == broker)
                    {
                        return acc;
                    }
                }
                return null;
            }
            set
            {
                for (int n = 0; n < this.Count; n++)
                {
                    if (this[n].brokerid == broker)
                    {
                        this[n] = value;
                    }
                }

            }
        }
    }

}
