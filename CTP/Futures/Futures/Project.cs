using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ats.Core;
using CTPAPI;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;
 
namespace Futures
{
    
    public class FutureOrder : Order
    {
        public override  void Copy(Order order)
        { 
            
        }
    }
   public  class Project:IFunction
    {
       //播放音乐的
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        public static extern bool PlaySound(string pszSound, int hmod, int fdwSound);
        public const int SND_FILENAME = 0x00020000;
        public const int SND_ASYNC = 0x0001;

       private Future oldfuture;
       private  Queue<Tuple<string,object,object >> queue;
       private bool queueFlag=false;
       private PropertyInfo propertyFun;
       private MethodInfo methodInit;
       private MethodInfo methodOnTick;
       private MethodInfo methodOnTrade;
       private MethodInfo methodOnOrder;
       private MethodInfo methodInfoOnOrderRejected;
       private MethodInfo methodInfoOnOrderCanceled;
       private MethodInfo methodInfoOnCancelOrderFailed;
       private MethodInfo methodInfoOnSysWarning;
       private MethodInfo methodInfoExit;
       private MethodInfo methodInfoOnBar;
       private FutureSeries futureSeries;
       private Thread queuethread;
       private Thread mdthread;

       private Form_Main _fm;
       public Form_Main form_Main
       {
           get { return this._fm; }
           set { this._fm = value; }
       }
       private Thread _thread;
       public Thread thread 
       {
           get {return  this._thread; }
           set { this._thread = value; }
       }
       private bool _isRun;
       public bool isRun
       {
           get { return this._isRun; }
           set { this._isRun = value; }

       }
       private string _Classname;
       public string Classname
       {
           get { return this._Classname;}
           set { this._Classname=value; }
       }
       private string _Projname;
       public string Projname 
       {
           get { return this._Projname; }
           set { this._Projname = value; }
       }
       private string _Addrname;
       public string Addrname 
       {
           get { return this._Addrname; }
           set { this._Addrname=value;}
       }
       private string _DriveInstrument;
       public string DriveInstrument 
       {
           get{return this._DriveInstrument;}
           set { this._DriveInstrument=value; }
       }
       private Assembly _assm;
       public Assembly assm
       { 
           get { return this._assm; }
           set { this._assm = value; }
       }
       private Type[] _types;
       public Type[] types 
       {
           get { return this._types; }
           set { this._types = value; }
       }
       private FieldInfo[] _fieldInfos;
       public FieldInfo[] fieldInfos 
       {
           get { return this._fieldInfos; }
           set { this._fieldInfos = value; }
       }
       private object _obj;
       public object obj 
       {
           get { return this._obj; }
           set { this._obj = value; }

       }

       public AccSeries accountList=new AccSeries();

       public MdAccSeries mdaccountList = new MdAccSeries();
       
       private List<CThostFtdcInstrumentField> _Instruments;
       public List<CThostFtdcInstrumentField> Instruments
       {
           get { return this._Instruments; }
           set { this._Instruments = value; }
       }
       private RichTextBox _richTextBox;
       public RichTextBox richTextBox
       {
           get { return this._richTextBox; }
           set { this._richTextBox = value; }
       }
       private Exchange _DCEExchange;
       public Exchange DCEExchange
       {
           get { return this._DCEExchange; }
           set { this._DCEExchange = value; }
       }
       private Exchange _SHFEExchange;
       public Exchange SHFEExchange
       {
           get { return this._SHFEExchange; }
           set { this._SHFEExchange = value; }
       }
       private Exchange _CZCEExchange;
       public Exchange CZCEExchange
       {
           get { return this._CZCEExchange; }
           set { this._CZCEExchange = value; }
       }
       private Exchange _CFFEXExchange;
       public Exchange CFFEXExchange
       {
           get { return this._CFFEXExchange; }
           set { this._CFFEXExchange = value; }
       }
       private List<Exchange> exchanges; 
       public Project()
       {
           this.propertyFun=null;
           this.methodInit=null;
           this.methodOnTick=null;
           this.methodOnTrade=null;
           this.methodOnOrder=null;
           this.methodInfoOnOrderRejected=null;
           this.methodInfoOnOrderCanceled=null;
           this.methodInfoOnCancelOrderFailed=null;
           this.methodInfoOnSysWarning=null;
           this.methodInfoExit=null;
           this.methodInfoOnBar=null;
           this.queue = new Queue<Tuple<string, object, object>>();
           this.futureSeries = new FutureSeries();
           this.mdthread = null;
           this.queuethread = null;
           this.oldfuture = new Future();

           this._thread = null;
           this._isRun = false;
           this._Classname = "";
           this._Projname = "";
           this._Addrname = "";
           this._DriveInstrument = "";
           this._assm = null;
           this._types = null;
           this._fieldInfos = null;
           this._obj = null;
           //this._accountList = new List<Acc>();
           //this._mdaccountList = new List<Acc>();
           this._Instruments = new List<CThostFtdcInstrumentField>();
           this._richTextBox = new System.Windows.Forms.RichTextBox();
           this._DCEExchange = new Exchange();
           this._DCEExchange.BaseTime=this.Now;
           this._DCEExchange.CloseTime=Convert.ToDateTime("15:00:00");   
           this._DCEExchange.DiffTime= this.Now-this.Now;
           this._DCEExchange.ExchangeID="DCE";
           this._DCEExchange.ExchangeName="大商所";
           this._DCEExchange.IsFuture=true;
           this._DCEExchange.OpenTime=Convert.ToDateTime("09:00:00");

           this._SHFEExchange = new Exchange();
           this._SHFEExchange.BaseTime = this.Now;
           this._SHFEExchange.CloseTime = Convert.ToDateTime("15:00:00");
           this._SHFEExchange.DiffTime = this.Now - this.Now;
           this._SHFEExchange.ExchangeID = "SHFE";
           this._SHFEExchange.ExchangeName = "上期所";
           this._SHFEExchange.IsFuture = true;
           this._SHFEExchange.OpenTime = Convert.ToDateTime("09:00:00");

           this._CZCEExchange = new Exchange();
           this._CZCEExchange.BaseTime = this.Now;
           this._CZCEExchange.CloseTime = Convert.ToDateTime("15:00:00");
           this._CZCEExchange.DiffTime = this.Now - this.Now;
           this._CZCEExchange.ExchangeID = "CZCE";
           this._CZCEExchange.ExchangeName = "郑商所";
           this._CZCEExchange.IsFuture = true;
           this._CZCEExchange.OpenTime = Convert.ToDateTime("09:00:00");

           this._CFFEXExchange = new Exchange();
           this._CFFEXExchange.BaseTime = this.Now;
           this._CFFEXExchange.CloseTime = Convert.ToDateTime("15:15:00");
           this._CFFEXExchange.DiffTime = this.Now - this.Now;
           this._CFFEXExchange.ExchangeID = "CFFEX";
           this._CFFEXExchange.ExchangeName = "中金所";
           this._CFFEXExchange.IsFuture = true;
           this._CFFEXExchange.OpenTime = Convert.ToDateTime("09:15:00");
            
           this.exchanges = new List<Exchange>();
           this.exchanges.Add(this.DCEExchange);
           this.exchanges.Add(this.SHFEExchange);
           this.exchanges.Add(this.CZCEExchange);
           this.exchanges.Add(this.CFFEXExchange);
       }
       public void Stop()
       {
           this.thread.Abort();
           this.mdthread.Abort();
           this.queuethread.Abort();
           if (methodInfoExit != null)
           {
               methodInfoExit.Invoke(this.obj, null);
           }
           else
           {
               Print("methodInfoExit为空！");
           }
           foreach (Acc acc in this.mdaccountList)
           {
              
               acc.mdapi.UnSubMarketData(this.TriggerInstrument);
               foreach (CThostFtdcInstrumentField inst in this.Instruments)
               {
                   acc.mdapi.UnSubMarketData(inst.InstrumentID);
               }
               //if (acc.mdapi != null)
               //{
               //    acc.mdapi.Release();
               //}
           }
           //foreach (Acc acc in this.accountList)
           //{
           //    if (acc.tdapi != null)
           //    acc.tdapi.();
           //}
           Print("停止工程");
       }
       public void Run()
       {
           PlaySound(EnumSound.ring);
          // Print(this.accountList[0].orderSeries[].ToString());
           if (this.Instruments.Count > 0)
           {
               foreach (CThostFtdcInstrumentField inst in this.Instruments)
               {
                   Future f = new Future();
                   //f.ExchangeID = inst.ExchangeID;
                   //f.ExpireDate =Convert.ToDateTime( inst.ExpireDate.Insert(4, "/").Insert(7, "/"));
                   //f.ID = inst.InstrumentID;
                   //f.LastPrice = 1;
                   //f.LastTick = new Tick();
                   //f.PreClose =120 ;
                   //f.PreSettlementPrice = 120;
                   //f.UpLimit = 1;
                   //f.DropLimit = 1;
                   //f.FutureType = EnumFutureType.Normal;
                   //f.IsArbitrage = false;
                   //f.RealFuture = new Future();
                   //f.OnTick();
                   //f.TickEvent+=new TickEventHandler(f_TickEvent);
                   f.LifeStatus = EnumLifeStatus.上市;
                   f.LongMarginRatio = inst.LongMarginRatio;
                   f.MaxLimitOrderVolume = inst.MaxLimitOrderVolume;
                   f.MaxMarketOrderVolume = inst.MaxMarketOrderVolume;
                   f.MinLimitOrderVolume = inst.MinLimitOrderVolume;
                   f.MinMarketOrderVolume = inst.MinMarketOrderVolume;
                   f.Name = inst.InstrumentName;
                   f.OpenDate = Convert.ToDateTime(inst.CreateDate.Insert(4, "/").Insert(7, "/"));
                   f.PriceTick = inst.PriceTick;
                   f.ProductClass = EnumProductClass.Futures;
                   f.ProductID = inst.ProductID;
                   f.ShortMarginRatio = inst.ShortMarginRatio;
                   f.VolumeMultiple = inst.VolumeMultiple;
                   f.ID = inst.InstrumentID;
                   this.futureSeries.Add(f);
               }
           }
           Print("***************************工程信息*************************************************************");
           Print("*程序集信息：");
           Print("*" + this.assm.FullName.ToString());
           Print("*命名空间.类名：");
           Print("*" + this.obj.ToString());
           Print("*本工程名：");
           Print("*" + this.Projname);
           Print("*本工程交易账号列表：");
           foreach(Acc acc in this.accountList)
           {
               Print("*经纪商名：" + acc.brokername + "; 经纪商编号: " + acc.brokerid + "; 账号: " + acc.invostor);
           }
           Print("*默认交易账号列表:");
           Print("*经纪商名：" + this.accountList[0].brokername + "; 经纪商编号:" + this.accountList[0].brokerid + "; 账号:" + this.accountList[0].invostor);
           Print("*本工程行情账号：");
           foreach (Acc acc in this.mdaccountList)
           {
               Print("*经纪商名：" + acc.brokername + "; 经纪商编号:" + acc.brokerid);
           }
           Print("*默认行情账号:");
           Print("*经纪商名：" + this.mdaccountList[0].brokername + "; 经纪商编号: " + this.mdaccountList[0].brokerid);
           Print("*订阅合约列表:");
           foreach(Future f in this.AllFutures)
           {
               Print("*"+f.ID);
           }
           Print("*默认合约");
           Print("*" + this.AllFutures[0].ID);
           Print("*驱动合约：");
           Print("*" + this.TriggerInstrument);
           //Print(this.types[0].ToString());
           Print("*参数列表：");
           foreach(FieldInfo fi in this.fieldInfos)
           {
               foreach (Attribute att in fi.GetCustomAttributes(false))
               {
                   if (att is ParameterAttribute)
                   {
                       Print("*" + fi.Name + "=" + fi.GetValue(this.obj).ToString());
                   }
               }
           }
           Print("***************************工程信息*************************************************************");
           //Print("当前线程名：");
          
            foreach (Type type in this.types)
           {
               if (type.Name == this.Classname)
               {
                   methodInfoOnBar = type.GetMethod("OnBar", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                   methodInfoExit = type.GetMethod("Exit", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                   methodInfoOnSysWarning = type.GetMethod("OnSysWarning", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                   methodInfoOnCancelOrderFailed = type.GetMethod("OnCancelOrderFailed", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                   methodInfoOnOrderCanceled = type.GetMethod("OnOrderCanceled", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                   methodInfoOnOrderRejected = type.GetMethod("OnOrderRejected", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                   methodOnOrder = type.GetMethod("OnOrder", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                   methodOnTrade = type.GetMethod("OnTrade", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                   methodOnTick = type.GetMethod("OnTick", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                   methodInit = type.GetMethod("Init", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                   propertyFun = type.GetProperty("Fun");
                   //this.AllFutures = new FutureSeries();
                   if (propertyFun != null)
                   {
                       propertyFun.SetValue(this.obj, this, null);
                   }
                   else
                       Print("pi为空");
               }
            }
            
           if (methodInit != null)
           {
               methodInit.Invoke(this.obj, null);
           }
           else
           {
               Print("methodInit为空！");
           }
          
           this.thread = new Thread(this.StrategyRun);
           this.thread.Name = "thread";
           this.mdthread = new Thread(this.MdRun);
           this.mdthread.Name = "mdthread";
           this.queuethread = new Thread(this.QueueRun);

           this.thread.Start();
           this.mdthread.Start();
           this.queuethread.Start();
       }
        // Methods
       private void QueueRun()
       {
           while (true)
           {
               lock (this.queue) // Lock关键字保证了什么，请大家看前面对lock的介绍           
               {
                   //if (!queueFlag)//如果现在不可读取               
                   //{
                   //    //Monitor.Wait(this.queue);
                   //}
                   //else
                   //{
                      if (this.queue != null && this.queue.Count > 0)
                       {
                           Tuple<string, object, object> tup;
                           tup = this.queue.Dequeue();
                           //tup.Item1.
                           switch (tup.Item1)
                           {
                               case "SendLimitFutureOrder":
                                   if (tup.Item3 is int)
                                   {
                                       this.accountList[(int)tup.Item3].tdapi.OrderInsert((CThostFtdcInputOrderField)tup.Item2);
                                       //Print("");
                                   }
                                   else if (tup.Item3 is string)
                                   {
                                       this.accountList[(int)tup.Item3].tdapi.OrderInsert((CThostFtdcInputOrderField)tup.Item2);
                                   }
                                   break;
                               case "CancelFutureOrder":
                                   if (tup.Item3 is int)
                                   {
                                       this.accountList[(int)tup.Item3].tdapi.ReqOrderAction((CThostFtdcInputOrderActionField)tup.Item2);
                                   }
                                   else if (tup.Item3 is string)
                                   {
                                       this.accountList[(string)tup.Item3].tdapi.ReqOrderAction((CThostFtdcInputOrderActionField)tup.Item2);
                                   }
                                   break;
                           }
                       }
                       queueFlag = false;
                  // }
                   //Monitor.Pulse(this.queue); 
               }

           }
       }
       private void MdReg(Acc acc)
       {
           acc.mdapi.OnHeartBeatWarning += new MDAPI.HeartBeatWarning(delegate(int nTimeLapse)
               {
                   Print("超时: nTimeLapse=" + nTimeLapse.ToString());
               });
           acc.mdapi.OnFrontDisconnected += new MDAPI.FrontDisconnected(delegate(int n)
               {
                   acc.mdapi.Connect();
               });
           acc.mdapi.OnFrontConnected += new MDAPI.FrontConnected(delegate()
               {
                   acc.mdapi.UserLogin();
               });
           acc.mdapi.OnRspSubMarketData += new MDAPI.RspSubMarketData(delegate(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
               {
                  // MessageBox.Show(pSpecificInstrument.InstrumentID);
               });
           acc.mdapi.OnRtnDepthMarketData += new MDAPI.RtnDepthMarketData(delegate(ref CThostFtdcDepthMarketDataField pDepthMarketData)
           {
               //Print("当前线程名：" + Thread.CurrentThread.Name);
               this.RrfreshOrders();
               this.RefreshPositions();
               #region 坏点过滤
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
               #endregion
              
                Quote quote = new Quote();
                quote.AskPrice1 = pDepthMarketData.AskPrice1;
                quote.AskVolume1 = pDepthMarketData.AskVolume1;
                quote.BidPrice1 = pDepthMarketData.BidPrice1;
                quote.BidVolume1 = pDepthMarketData.BidVolume1;
                       
                Tick tick = new Tick();
                tick.Quote = quote;
                tick.InstrumentID = pDepthMarketData.InstrumentID;
                tick.OpenInterest = pDepthMarketData.OpenInterest;
                tick.LastPrice = pDepthMarketData.LastPrice;
                tick.LowPrice = pDepthMarketData.LowestPrice;
                tick.OpenPrice = pDepthMarketData.OpenPrice;
                tick.PreClosePrice = pDepthMarketData.PreClosePrice;
                tick.PreSettlementPrice = pDepthMarketData.PreSettlementPrice;
                tick.UpLimit = pDepthMarketData.UpperLimitPrice;
                tick.Turnover = pDepthMarketData.Turnover;
                tick.Volume = pDepthMarketData.Volume;
                tick.HighPrice = pDepthMarketData.HighestPrice;
                tick.DropLimit = pDepthMarketData.LowerLimitPrice;
                tick.ExchangeID = pDepthMarketData.ExchangeID;
                tick.DateTime = Convert.ToDateTime(pDepthMarketData.UpdateTime).AddMilliseconds((double)pDepthMarketData.UpdateMillisec);;
                tick.PreOpenInterest = pDepthMarketData.PreOpenInterest;
              
                if (tick.InstrumentID == this.TriggerInstrument)
                {
                    this.futureSeries[pDepthMarketData.InstrumentID].OnTick(tick);
                    if (this.methodOnTick != null)
                    {
                        //Tick tick = new Tick();
                        //tick.InstrumentID = "ddddd";
                        object[] invokeArgs = new object[] { tick /* #1 variable */ };
                        this.methodOnTick.Invoke(this.obj, invokeArgs);
                    }
                    else
                    {
                        Print("methodOnTick为空！");
                    }
                }
                else
                {
                    this.futureSeries[pDepthMarketData.InstrumentID].OnTick(tick);
                }

           });
       }
       private void MdRun()
       {
           foreach (Acc acc in this.mdaccountList)
           {
               this.MdReg(acc);
               acc.mdapi.SubMarketData(this.TriggerInstrument);
               foreach (CThostFtdcInstrumentField inst in this.Instruments)
               {
                   acc.mdapi.SubMarketData(inst.InstrumentID);
               }
               //acc.mdapi.SubMarketData("ag1406", "au1406");
              acc.mdapi.Join();
           }
           //MessageBox.Show("1");
          // this.mdaccountList[0].mdapi.Join();
           //MessageBox.Show("2");
       }
       private void TdReg(Acc acc)
       {
           acc.tdapi.OnFrontConnected += new TDAPI.FrontConnected(delegate()
               {
                   acc.tdapi.UserLogin();
               });
           acc.tdapi.OnFrontDisconnected += new TDAPI.FrontDisconnected(delegate(int n)
               {
                   acc.tdapi.Connect();
               });
           acc.tdapi.OnHeartBeatWarning += new TDAPI.HeartBeatWarning(delegate(int nTimeLapse)
               {
                   Print("超时: nTimeLapse=" + nTimeLapse.ToString());
               });
           acc.tdapi.OnRspQryInvestorPosition += new TDAPI.RspQryInvestorPosition(delegate(ref CThostFtdcInvestorPositionField pInvestorPosition, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
               {
                   //if (pInvestorPosition.CloseVolume==0)
                   //{
                   //    bool ifcz = false;
                   //    for (int j = 0; j < acc.PositionFields.Count; j++)
                   //    {
                   //        if (acc.PositionFields[j].Equals(pInvestorPosition))
                   //        {
                   //            ifcz = true;
                   //            break;
                   //        }
                   //    }
                   //    if (!ifcz)
                   //    {
                   //        acc.PositionFields.Add(pInvestorPosition);
                   //    }
                   //}
                   
               });
           acc.tdapi.OnErrRtnOrderAction+=new TDAPI.ErrRtnOrderAction(delegate(ref CThostFtdcOrderActionField pOrderAction, ref CThostFtdcRspInfoField pRspInfo)
               {
                  
                   if (methodInfoOnCancelOrderFailed != null)
                   {
                       Order o = new FutureOrder();
                       o.BrokerID = pOrderAction.BrokerID;
                       //o.ContingentCondition = pOrderAction.;
                       //o.Direction = pOrderAction;
                       o.ExchangeID = pOrderAction.ExchangeID;
                       //o.HedgeFlag = pOrderAction;
                       //o.InsertTime = pOrderAction.ti;
                       o.InstrumentID = pOrderAction.InstrumentID;
                       o.InstrumentType = EnumMarket.期货;
                       o.InvestorID = pOrderAction.InvestorID;
                       o.LimitPrice = pOrderAction.LimitPrice;
                       //o.OpenOrClose = pOrderAction.;
                       //o.OrderRejectReason = pRspInfo.ErrorMsg;
                       //o.OrderStatus = pOrderAction.StatusMsg;
                       //o.OrderSubmitStatus = pOrderAction.;
                       o.OrderSysID = pOrderAction.OrderSysID;
                       //o.StopPrice = pOrderAction.BrokerID;
                       //o.Volume = pOrderAction.VolumeChange ;

                       object[] invokeArgs = new object[] { o, pRspInfo.ErrorMsg };
                       methodInfoOnCancelOrderFailed.Invoke(this.obj, invokeArgs);
                   }
                   else
                   {
                       Print("methodInfoOnCancelOrderFailed为空！");
                   }
                   Print("撤单错误：" + pOrderAction.StatusMsg);
               });
           acc.tdapi.OnErrRtnOrderInsert += new TDAPI.ErrRtnOrderInsert(delegate(ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo)
           {

               Print("报单错误：" + pInputOrder.RequestID.ToString());
           });
           acc.tdapi.OnRspOrderAction += new TDAPI.RspOrderAction(delegate(ref CThostFtdcInputOrderActionField pInputOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
               {
                   Print("撤单响应：" + pInputOrderAction.OrderSysID);
               });
           acc.tdapi.OnRspOrderInsert += new TDAPI.RspOrderInsert(delegate(ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
           {
               Print("报单响应：" + pInputOrder.RequestID.ToString());
           });
           
           acc.tdapi.OnRspError += new TDAPI.RspError(delegate(ref CThostFtdcRspInfoField pRspInfo)
               {
                   if (pRspInfo.ErrorID == 26)
                   {
                       
                   }
                   Print("错误# 错误ID= " + pRspInfo.ErrorID.ToString() + " , 错误信息: " + pRspInfo.ErrorMsg);
               });
           acc.tdapi.OnRspOrderAction += new TDAPI.RspOrderAction(delegate(ref CThostFtdcInputOrderActionField pInputOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
               { 
                  // pInputOrderAction.
               });
           acc.tdapi.OnRtnOrder += new TDAPI.RtnOrder(delegate(ref CThostFtdcOrderField pOrder)
               {
                  // Print(pOrder.CombOffsetFlag);
                   Order o = new FutureOrder(); ;
                   o.BrokerID = pOrder.BrokerID;
                   switch (pOrder.ContingentCondition)
                   {
                       case TThostFtdcContingentConditionType.THOST_FTDC_CC_Immediately :
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
                  switch(pOrder.Direction)
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
                 
                   o .ExchangeID= pOrder.ExchangeID;
                   o.HedgeFlag = EnumHedgeFlag.Arbitrage;
                   o.InsertTime = Convert.ToDateTime(pOrder.InsertTime);
                   o .InstrumentID= pOrder.InstrumentID;
                   o.InstrumentType = EnumMarket.期货;
                   o .InvestorID= pOrder.InvestorID;
                   o .LimitPrice= pOrder.LimitPrice;
                   //Print(pOrder.CombOffsetFlag);
                   switch(pOrder.CombOffsetFlag)
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
                       default:
                           break;
                   }
                  // o.OrderRejectReason = EnumRejectReason;
                   switch(pOrder.OrderStatus)
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
                  
                   o .OrderSysID= pOrder.OrderSysID;
                   switch(pOrder.OrderType)
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
                  
                   o .StatusMsg= pOrder.StatusMsg;
                   o .StopPrice= pOrder.StopPrice;
                   o .TradingDay= pOrder.TradingDay;
                   o .Volume= pOrder.VolumeTotal;
                   //o.VolumeLeft = pOrder.VolumeTotal - pOrder.VolumeTraded;
                   o .VolumeTraded= pOrder.VolumeTraded;
                   //acc.orderSeries.Add(o);
                   ////////////////////////////////////////////////////////////////////////////
                   if (o.OrderStatus == EnumOrderStatus.Canceled)
                   {
                       if (o.OrderStatus == EnumOrderStatus.Canceled && o.StatusMsg == "已撤单")
                       {
                           if (this.methodInfoOnOrderCanceled != null)
                           {

                               object[] invokeArgs = new object[] { o };
                               this.methodInfoOnOrderCanceled.Invoke(this.obj, invokeArgs);
                           }
                           else
                           {
                               Print("methodInfoOnOrderCanceled为空！");
                           }
                       }
                       else
                       {
                           if (this.methodInfoOnOrderRejected != null)
                           {

                               object[] invokeArgs = new object[] { o };
                               this.methodInfoOnOrderRejected.Invoke(this.obj, invokeArgs);
                           }
                           else
                           {
                               Print("methodInfoOnOrderRejected为空！");
                           }
                       }
                   }
                   else
                   {

                       if (this.methodOnOrder != null)
                       {

                           object[] invokeArgs = new object[] { o };
                           this.methodOnOrder.Invoke(this.obj, invokeArgs);
                       }
                       else
                       {
                           Print("methodOnOrder为空！");
                       }
                   }
                   /////////////////////////////////////////////////////////////
                   //lock (acc.orders)
                   //{
                   //    if (acc.ordersFlag)
                   //    {
                   //        Monitor.Wait(acc.orders);
                   //    }
                       #region
                       if (pOrder.OrderSysID != "")
                       {
                           bool ifocz = false;
                           for (int or = 0; or < acc.orders.Count; or++)
                           {
                               if (acc.orders[or].OrderSysID == pOrder.OrderSysID)
                               {
                                   if (pOrder.OrderStatus == TThostFtdcOrderStatusType.THOST_FTDC_OST_Canceled || pOrder.OrderStatus == TThostFtdcOrderStatusType.THOST_FTDC_OST_AllTraded || pOrder.OrderStatus == TThostFtdcOrderStatusType.THOST_FTDC_OST_PartTradedNotQueueing)
                                   {
                                       acc.orders.RemoveAt(or);
                                       ifocz = true;
                                       break;
                                   }
                                   else if (pOrder.OrderStatus == TThostFtdcOrderStatusType.THOST_FTDC_OST_PartTradedQueueing)
                                   {
                                       acc.orders[or] = pOrder;
                                       ifocz = true;
                                       break;
                                   }
                                   ifocz = true;
                                   break;
                               }
                           }
                           if (!ifocz)
                           {
                               //MessageBox.Show(acc.orderSeries.Count.ToString());
                               //acc.orders.RemoveAt(0);
                               acc.orders.Add(pOrder);
                              
                           }
                       }
                       #endregion
                      // acc.ordersFlag = true;
                       //Monitor.Pulse(acc.orders);
                  // }
                  
               });
           acc.tdapi.OnRtnTrade += new TDAPI.RtnTrade(delegate(ref CThostFtdcTradeField pTrade)
               {
                   Trade trade = new Trade();
                   trade.BrokerID = pTrade.BrokerID;
                   trade.BrokerOrderSeq = pTrade.BrokerOrderSeq;
                   if (TThostFtdcDirectionType.THOST_FTDC_D_Buy == pTrade.Direction)
                   {
                       trade.Direction = EnumBuySell.买入;
                   }
                   else
                   trade.Direction = EnumBuySell.卖出;
                   trade.ExchangeID = pTrade.ExchangeID;
                   trade.HedgeFlag = EnumHedgeFlag.Hedge;
                   trade.InstrumentID = pTrade.InstrumentID;
                   trade.InstrumentType = EnumMarket.期货;
                   trade.InvestorID = pTrade.InvestorID;
                   if (TThostFtdcOffsetFlagType.THOST_FTDC_OF_Open == pTrade.OffsetFlag)
                   {
                       trade.OpenOrClose = EnumOpenClose.开仓;
                   }
                   else if (TThostFtdcOffsetFlagType.THOST_FTDC_OF_CloseToday == pTrade.OffsetFlag)
                   {
                       trade.OpenOrClose = EnumOpenClose.平今仓;
                   }
                   else if (TThostFtdcOffsetFlagType.THOST_FTDC_OF_Close == pTrade.OffsetFlag)
                   {
                       trade.OpenOrClose = EnumOpenClose.平仓;
                   }
                   

                   trade.OrderSysID = pTrade.OrderSysID;
                   trade.Price = pTrade.Price;
                   if(TThostFtdcPriceSourceType.THOST_FTDC_PSRC_LastPrice==pTrade.PriceSource)
                   {
                    trade.PriceSource =EnumPriceSource.LastPrice;
                   }
                   else if(TThostFtdcPriceSourceType.THOST_FTDC_PSRC_Buy==pTrade.PriceSource)
                   {
                        trade.PriceSource =EnumPriceSource.Buy;
                   }
                   else
                   trade.PriceSource =EnumPriceSource.Sell;
                   trade.SequenceNo = pTrade.SequenceNo;
                   trade.SettlementID = pTrade.SettlementID;
                  //trade.TradeBalance = pTrade;
                   trade.TradeID = pTrade.TradeID;
                   trade .TradeTime= Convert.ToDateTime(pTrade.TradeTime);
                  // string str = pTrade.TradingDay.Insert(4, "/").Insert(7, "/");
                   trade.TradingDay = Convert.ToDateTime(pTrade.TradingDay.Insert(4, "/").Insert(7, "/"));
                   trade .Volume= pTrade.Volume;
                   
                   if (this.methodOnTrade != null)
                   {
                      
                       object[] invokeArgs = new object[] { trade };
                       this.methodOnTrade.Invoke(this.obj, invokeArgs);
                   }
                   else
                   {
                       Print("methodOnTrade为空！");
                   }
                   CThostFtdcInvestorPositionField pf = new CThostFtdcInvestorPositionField();
                   pf.BrokerID = pTrade.BrokerID;
                 
                   pf.HedgeFlag = TThostFtdcHedgeFlagType.THOST_FTDC_HF_Speculation;
                   pf.InstrumentID = pTrade.InstrumentID;
                   pf.InvestorID = pTrade.InvestorID;
                  
                   switch (pTrade.OffsetFlag)
                   {
                       case TThostFtdcOffsetFlagType.THOST_FTDC_OF_Open:
                           pf.CloseVolume = 0;
                           pf.OpenVolume = pTrade.Volume;
                           pf.Position = pTrade.Volume;
                           break;
                       case TThostFtdcOffsetFlagType.THOST_FTDC_OF_Close:
                           pf.CloseVolume =  pTrade.Volume;
                           pf.OpenVolume =0;
                           pf.Position = pTrade.Volume;
                           break;
                       case TThostFtdcOffsetFlagType.THOST_FTDC_OF_CloseToday:
                           pf.CloseVolume = pTrade.Volume;
                           pf.OpenVolume = 0;
                           pf.Position = pTrade.Volume;
                           break;
                       case TThostFtdcOffsetFlagType.THOST_FTDC_OF_CloseYesterday:
                           pf.CloseVolume = pTrade.Volume;
                           pf.OpenVolume = 0;
                           pf.Position = pTrade.Volume;
                           break;
                   }
                   
                   switch(pTrade.Direction)
                   {
                       case TThostFtdcDirectionType.THOST_FTDC_D_Buy:
                           pf.PosiDirection = TThostFtdcPosiDirectionType.THOST_FTDC_PD_Long;
                           break;
                       case TThostFtdcDirectionType.THOST_FTDC_D_Sell:
                           pf.PosiDirection = TThostFtdcPosiDirectionType.THOST_FTDC_PD_Short;
                           break;
                   }
                   pf.Position = pTrade.Volume;
                  
                   pf.PositionDate = TThostFtdcPositionDateType.THOST_FTDC_PSD_Today; ;
                   
                   pf.TodayPosition = pTrade.Volume;
                   pf.TradingDay = pTrade.TradeDate;
                   pf.OpenCost = pTrade.Price;
                   pf.YdPosition = 0;
                   bool ifpocz = false;
                  
                         #region
                   for (int po = 0; po < acc.PositionFields.Count; po++)
                   {
                       //MessageBox.Show(po.ToString());
                       if (acc.PositionFields[po].InstrumentID == pf.InstrumentID)
                       {
                           if (pTrade.OffsetFlag == TThostFtdcOffsetFlagType.THOST_FTDC_OF_Open && acc.PositionFields[po].PosiDirection == pf.PosiDirection)
                           {

                               CThostFtdcInvestorPositionField pof = new CThostFtdcInvestorPositionField();
                               pof = acc.PositionFields[po];
                               pof.OpenVolume += pf.OpenVolume;
                               pof.Position += pf.Position;
                               pof.TodayPosition += pf.TodayPosition;
                               pof.OpenCost = pTrade.Price;//(pof.OpenCost * pof.Position + pf.OpenCost * pf.OpenVolume)/(pof.Position+pf.Position);
                               acc.PositionFields[po] = pof;
                               ifpocz = true;
                               break;
                           }
                           else if ((pTrade.OffsetFlag == TThostFtdcOffsetFlagType.THOST_FTDC_OF_CloseToday || pTrade.OffsetFlag == TThostFtdcOffsetFlagType.THOST_FTDC_OF_Close || pTrade.OffsetFlag == TThostFtdcOffsetFlagType.THOST_FTDC_OF_CloseYesterday) && ((acc.PositionFields[po].PosiDirection == TThostFtdcPosiDirectionType.THOST_FTDC_PD_Long && pf.PosiDirection == TThostFtdcPosiDirectionType.THOST_FTDC_PD_Short)||(acc.PositionFields[po].PosiDirection == TThostFtdcPosiDirectionType.THOST_FTDC_PD_Short && pf.PosiDirection == TThostFtdcPosiDirectionType.THOST_FTDC_PD_Long)))
                           {
                               if (acc.PositionFields[po].Position == pf.Position)
                               {
                                   acc.PositionFields.Remove(acc.PositionFields[po]);
                                   ifpocz = true;
                                   break;
                               }
                               else if (acc.PositionFields[po].Position > pf.Position)
                               {
                                   CThostFtdcInvestorPositionField pof = new CThostFtdcInvestorPositionField();
                                   pof = acc.PositionFields[po];
                                   pof.CloseVolume += pf.CloseVolume;
                                   pof.Position -= pf.Position;
                                   pof.TodayPosition -= pf.TodayPosition;
                                   acc.PositionFields[po] = pof;
                                   ifpocz = true;
                                   break;
                               }
                           }
                           
                       }
                       
                   }
                   if (!ifpocz)
                   {
                       acc.PositionFields.Add(pf);
                   }
                   #endregion
                        //acc.PositionFlag = true;
                        //Monitor.Pulse(acc.PositionFields);
                   //}
               });
       }
       private void StrategyRun()
       {
           
            foreach (Acc acc in this.accountList)
            {
                this.TdReg(acc);
               // acc.tdapi.ReqQryInvestorPosition(" ");
                acc.tdapi.Join();
            }
            //MessageBox.Show("1");
           // this.accountList[0].tdapi.Join();
           //MessageBox.Show("2");
       }
       public void RefreshPositions()
       {
           form_Main.Invoke((MethodInvoker)delegate()
           {
               form_Main.listView4.Items.Clear();
               if (form_Main.listView3.SelectedItems.Count == 1)
               {
                   //List<System.Windows.Forms.ListViewGroup> listViewGroups1 = new List<ListViewGroup>();
                   //List<System.Windows.Forms.ListViewItem> listViewItems1 = new List<ListViewItem>();
                   foreach (Acc acc in form_Main.projectList[Convert.ToInt32(form_Main.listView3.SelectedItems[0].SubItems[0].Text)].accountList)
                   {
                       System.Windows.Forms.ListViewGroup listViewGroup = new ListViewGroup(acc.invostor, System.Windows.Forms.HorizontalAlignment.Left);
                       //MessageBox.Show(this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].GetFuturePositions(acc.invostor).Count.ToString());
                       foreach (Position p in form_Main.projectList[Convert.ToInt32(form_Main.listView3.SelectedItems[0].SubItems[0].Text)].GetFuturePositions(acc.invostor))
                       {
                           System.Windows.Forms.ListViewItem listViewItem = new System.Windows.Forms.ListViewItem(
                            new string[] {
                                        p.InstrumentID,
                                        p.PosiDirection.ToString(),
                                        p.Volumn.ToString(),
                                        p.TodayPosition.ToString(),
                                        p.EnableVolumn.ToString(),
                                        (p.PositionCost/p.Volumn).ToString()
                                        }, -1);
                           listViewItem.Group = listViewGroup;
                           form_Main.listView4.Groups.Add(listViewGroup);
                           form_Main.listView4.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem });
                           // MessageBox.Show(p.InstrumentID + "  " + p.Volumn);
                       }

                   }
               }
           });
       }
       public void RrfreshOrders()
       {
           form_Main.Invoke((MethodInvoker)delegate()
           {
               form_Main.listView5.Items.Clear();
               if (form_Main.listView3.SelectedItems.Count == 1)
               {
                   foreach (Acc acc in form_Main.projectList[Convert.ToInt32(form_Main.listView3.SelectedItems[0].SubItems[0].Text)].accountList)
                   {
                       System.Windows.Forms.ListViewGroup listViewGroup = new ListViewGroup(acc.invostor, System.Windows.Forms.HorizontalAlignment.Left);
                       foreach (Order o in form_Main.projectList[Convert.ToInt32(form_Main.listView3.SelectedItems[0].SubItems[0].Text)].GetCanCancelFutureOrders(acc.invostor))
                       {
                           System.Windows.Forms.ListViewItem listViewItem = new System.Windows.Forms.ListViewItem(
                            new string[] {
                                        o.InstrumentID,
                                        o.Volume.ToString(),
                                        o.Direction.ToString (),
                                        o.OpenOrClose.ToString(),
                                        o.OrderSysID,
                                        o.LimitPrice.ToString (),
                                        o.InsertTime.ToShortTimeString()
                                        }, -1);
                           listViewItem.Group = listViewGroup;
                           form_Main.listView5.Groups.Add(listViewGroup);
                           form_Main.listView5.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem });
                           // MessageBox.Show(p.InstrumentID + "  " + p.Volumn);
                       }
                   }
               }
           });
       }


        #region 接口实现
        public void AddIndicator(Indicator indicator) { }
        public Tick AgoFutureTick(string FutureID, int n) { return new Tick(); }
        public DateTime AgoMarketTime(double seconds, Exchange exchange) { return new DateTime(); }
        public Tick AgoStockTick(string StockCode, int n) { return new Tick(); }
        public Order BuyStock(string StockCode, int Amount, double Price) { return new FutureOrder(); }
        public bool CancelFutureOrder(Order order) 
        {
            CThostFtdcInputOrderActionField OrderAction = new CThostFtdcInputOrderActionField();
            OrderAction.ActionFlag = TThostFtdcActionFlagType.THOST_FTDC_AF_Delete;
            OrderAction.BrokerID = order.BrokerID;
            OrderAction.ExchangeID = order.ExchangeID;
            //OrderAction.FrontID = order.;
            OrderAction.InstrumentID = order.InstrumentID;
            OrderAction.InvestorID = order.InvestorID;
           // OrderAction.LimitPrice = order.LimitPrice;
            //OrderAction.OrderActionRef = order;
           // OrderAction.OrderRef = order;
            OrderAction.OrderSysID = order.OrderSysID;
            //OrderAction.RequestID = order.r;
            //OrderAction.SessionID = order.sess;
           // OrderAction.UserID = order.user;
           // OrderAction.VolumeChange = order.v;
            //lock (this.queue)
            //{
                //if (queueFlag)
                //{
                //    // Monitor.Wait(this.queue);
                //}
                //else
                //{
                    queue.Enqueue(new Tuple<string, object, object>("CancelFutureOrder", OrderAction, 0));
                    queueFlag = true;
                //}
                //Monitor.Pulse(this.queue);
           // }
            
            return true;
        }
        public bool CancelStockOrder(Order order) { return true; }
        public bool DictContains(string key) { return false; }
        public DateTime ExchangeTime(EnumExchange exchange) 
        {
            return new DateTime(); 
        }
        public int FutureAccountIDToIdx(string accid) { return 0; }
        public string FutureAccountIdxToID(int idx) { return ""; }
        public OrderSeries GetCanCancelFutureOrders(int idx)
        {
            return this.accountList[idx].orderSeries; 
        }
        public OrderSeries GetCanCancelFutureOrders(string accid) 
        {
            return this.accountList[accid].orderSeries; 
        }
        public OrderSeries GetCanCancelStockOrders() { return new OrderSeries(); }
        public string GetDict(string key) { return ""; }
        public Exchange GetExchange(EnumExchange exchange)
        {
            Exchange exch = null;
            foreach (Exchange ex in this.exchanges)
            {
                if (ex.ExchangeEnum == exchange)
                {
                    exch = ex;
                }
            }
            return exch;
        }
        public Exchange GetExchange(string exchangeid) 
        {
            Exchange exch = null;
            foreach (Exchange ex in this.exchanges)
            {
                if (ex.ExchangeID == exchangeid)
                {
                    exch = ex;
                }
            }
            return exch;
        }
        public FutureAccount GetFutureAccount(int idx) { return new FutureAccount(); }
        public FutureAccount GetFutureAccount(string accid) { return new FutureAccount(); }
        public BarSeries GetFutureBarSeries(string FutureID, int Interval, EnumBarType bar, DateTime beginTime, EnumRestoration restore) { return new BarSeries(); }
        public BarSeries GetFutureBarSeries(string FutureID, int Interval, EnumBarType bar, int MaxLength, EnumRestoration restore) { return new BarSeries(); }
        public double GetFutureBuyOrderHigh(string futurecode, int idx) { return 0; }
        public double GetFutureBuyOrderHigh(string futurecode, string accid) { return 0; }
        public OrderSeries GetFutureOrders(int idx)
        {
            
            return new OrderSeries();
        }
        public OrderSeries GetFutureOrders(string accid) { return new OrderSeries(); }
        public PositionSeries GetFuturePositions(int idx)
        {
            return this.accountList[idx].PositionSeries; 
           
        }
        public PositionSeries GetFuturePositions(string accid)
        {
            return this.accountList[accid].PositionSeries;
            
        }
        public double GetFutureSellOrderLow(string futurecode, int idx) { return 0; }
        public double GetFutureSellOrderLow(string futurecode, string accid) { return 0; }
        public TickSeries GetFutureTickBuffer() { return new TickSeries(); }
        public TradeSeries GetFutureTrades(int idx) { return new TradeSeries(); }
        public TradeSeries GetFutureTrades(string accid) { return new TradeSeries(); }
        public DateTime GetPreTradingDay(DateTime t) { return new DateTime(); }
        public DataSeries GetPriceBuffer() { return new DataSeries(); }
        public StockAccount GetStockAccount() { return new StockAccount(); }
        public BarSeries GetStockBarSeries(string StockCode, int Interval, EnumBarType bar, EnumRestoration restore, DateTime beginTime) { return new BarSeries(); }
        public BarSeries GetStockBarSeries(string StockCode, int Interval, EnumBarType bar, EnumRestoration restore, int MaxLength) { return new BarSeries(); }
        public List<StockDivideItem> GetStockDivide(string StockCode, DateTime from, DateTime to) { return new List<StockDivideItem>(); }
        public OrderSeries GetStockOrders() { return new OrderSeries(); }
        public PositionSeries GetStockPositions() { return new PositionSeries(); }
        public TradeSeries GetStockTrades() { return new TradeSeries(); }
        public List<DateTime> GetTradingDays() { return new List<DateTime>(); }
        public bool IsTradingDay(DateTime t) 
        {
            return true;
        }
        public bool MarketCanTrade(EnumExchange exchange) 
        {

            Exchange exch = null;
            foreach (Exchange ex in this.exchanges)
            {
                if (ex.ExchangeEnum == exchange)
                {
                    exch = ex;
                }
            }
            if (exch != null)
            {
                return exch.CanTrade;
            }
            else
                return false;
        }
        public DateTime MarketCloseTime(EnumExchange exchange) 
        {
            Exchange exch = null;
            foreach (Exchange ex in this.exchanges)
            {
                if (ex.ExchangeEnum == exchange)
                {
                    exch = ex;
                }
            }
            if (exch != null)
            {
                return exch.CloseTime;
            }
            else
                return Convert.ToDateTime("12:12:12");
        }
        public DateTime MarketOpenTime(EnumExchange exchange)
        {
            Exchange exch = null;
            foreach (Exchange ex in this.exchanges)
            {
                if (ex.ExchangeEnum == exchange)
                {
                    exch = ex;
                }
            }
            if (exch != null)
            {
                return exch.OpenTime;
            }
            else
                return Convert.ToDateTime("12:12:12");
        }
        public void ModifyFutureMoney(double money) { }
        public void ModifyStockMoney(double money) { }
        public void PlaySound(EnumSound sound)
        {
            switch (sound)
            {
                case EnumSound.alarm:
                    PlaySound("./wav.alarm.wav", 0, SND_ASYNC | SND_FILENAME);
                    break;
                case EnumSound.beep:
                    PlaySound("./wav.beep.wav", 0, SND_ASYNC | SND_FILENAME);
                    break;
                case EnumSound.chimes:
                    PlaySound("./wav.chimes.wav", 0, SND_ASYNC | SND_FILENAME);
                    break;
                case EnumSound.clear:
                    PlaySound("./wav.clear.wav", 0, SND_ASYNC | SND_FILENAME);
                    break;
                case EnumSound.ding:
                    PlaySound("./wav.ding.wav", 0, SND_ASYNC | SND_FILENAME);
                    break;
                case EnumSound.error:
                    PlaySound("./wav.error.wav", 0, SND_ASYNC | SND_FILENAME);
                    break;
                case EnumSound.logout:
                    PlaySound("./wav.logout.wav", 0, SND_ASYNC | SND_FILENAME);
                    break;
                case EnumSound.notenough:
                    PlaySound("./wav.notenough.wav", 0, SND_ASYNC | SND_FILENAME);
                    break;
                case EnumSound.notify:
                    PlaySound("./wav.notify.wav", 0, SND_ASYNC | SND_FILENAME);
                    break;
                case EnumSound.ring:
                    PlaySound("./wav.ring.wav", 0, SND_ASYNC | SND_FILENAME);
                    break;
            }

        }
        public void Print(string msg)
        {

            //Application.OpenForms["Form_Main"].Controls["richTextBox1"].Text = "1231231";
            this.richTextBox.Invoke((MethodInvoker)delegate()
            {
                this.richTextBox.AppendText(msg + "\r\n");
                this.richTextBox.Update();
            });
            //this.BeginInvoke((MethodInvoker)delegate()
            //{
            //    this.richTextBox.AppendText(msg + "\r\n");
            //    this.richTextBox.Update();
            //});
           
        }
        public void PrintError(string msg) { }
        public void PrintLabel(string msg) { }
        public void PrintWarning(string msg) { }
        public void Probe(string insID, EnumBuySell direction, EnumMarket market, double life, int capacity) { }
        public Order SellStock(string StockCode, int Amount, double Price) { return new FutureOrder(); }
        public Order SendLimitFutureOrder(string futurecode, int qty, double price, EnumBuySell buysell, EnumOpenClose openorclose, EnumHedgeFlag hedgeflag, int idx)
        {
            //Print("当前线程名：" + Thread.CurrentThread.Name);
            CThostFtdcInputOrderField order = new CThostFtdcInputOrderField();
            order.BrokerID = this.accountList[idx].brokerid;
            order.BusinessUnit = "";
           
            order.CombHedgeFlag = "11110";
            switch (buysell)
            {
                case EnumBuySell.买入:
                    order.Direction = TThostFtdcDirectionType.THOST_FTDC_D_Buy;
                    break;
                case EnumBuySell.卖出:
                    order.Direction = TThostFtdcDirectionType.THOST_FTDC_D_Sell;
                    break;
            }
            switch (openorclose)
            { 
                case EnumOpenClose.开仓:
                    order.CombOffsetFlag = "000000";
                    break;
                case EnumOpenClose.平仓:
                    order.CombOffsetFlag = "300000";
                    break;
                case EnumOpenClose.平今仓:
                    order.CombOffsetFlag = "100000";
                    break;
            }
            
            order.InstrumentID = futurecode;
            order.InvestorID = this.accountList[idx].invostor;
            order.LimitPrice = price;
            order.MinVolume = 1;
            order.VolumeTotalOriginal = qty;
            order.IsAutoSuspend = 0;
            order.UserForceClose = 0;
            order.ContingentCondition = TThostFtdcContingentConditionType.THOST_FTDC_CC_Immediately;
            order.ForceCloseReason = TThostFtdcForceCloseReasonType.THOST_FTDC_FCC_NotForceClose;
            order.GTDDate = TThostFtdcTimeConditionType.THOST_FTDC_TC_GFD.ToString();
            order.OrderPriceType = TThostFtdcOrderPriceTypeType.THOST_FTDC_OPT_LimitPrice;
            order.TimeCondition = TThostFtdcTimeConditionType.THOST_FTDC_TC_GFD;
            //order.OrderRef = (++this.MaxOrderRef).ToString();
            //order.IsSwapOrder = 0;
            order.IsAutoSuspend = 0;
            //order.StopPrice=
            //order.RequestID=
            order.VolumeCondition = TThostFtdcVolumeConditionType.THOST_FTDC_VC_AV;
            order.UserID = "";
            order.ForceCloseReason = TThostFtdcForceCloseReasonType.THOST_FTDC_FCC_NotForceClose;
            //lock (this.queue)
            //{
                //if (queueFlag)
                //{
                //    //  Monitor.Wait(this.queue);
                //}
                //else
                //{
                    queue.Enqueue(new Tuple<string, object, object>("SendLimitFutureOrder", order, idx));
                    queueFlag = true;
               // }
               // Monitor.Pulse(this.queue);
           // }
            Order o = new FutureOrder();
            o.BrokerID = this.accountList[idx].brokerid;
            o.ContingentCondition = EnumContingentCondition.Immediately;
            o.Direction = buysell;
            //o.ExchangeID = this.accountList[idx];
            o.HedgeFlag = EnumHedgeFlag.Arbitrage;
            o.InstrumentID = futurecode;
            o.InstrumentType = EnumMarket.期货;
            o.InvestorID = this.accountList[idx].invostor;
            o.LimitPrice = price;
            o.OpenOrClose=openorclose;
            //o.OrderRejectReason = EnumRejectReason;
            //o.OrderSysID = pOrder.OrderSysID;
            //o.StatusMsg = pOrder.StatusMsg;
            //o.StopPrice = pOrder.StopPrice;
            //o.TradingDay = pOrder.TradingDay;
            o.Volume = qty;
            //o.VolumeLeft = pOrder.VolumeTotal - pOrder.VolumeTraded;
            //o.VolumeTraded = pOrder.VolumeTraded;
           return o;
        }
        public Order SendLimitFutureOrder(string futurecode, int qty, double price, EnumBuySell buysell, EnumOpenClose openorclose, EnumHedgeFlag hedgeflag, string accid) 
        {
            CThostFtdcInputOrderField order = new CThostFtdcInputOrderField();
            order.BrokerID = this.accountList[accid].brokerid;
            order.BusinessUnit = "";

            order.CombHedgeFlag = "11110";
            switch (buysell)
            {
                case EnumBuySell.买入:
                    order.Direction = TThostFtdcDirectionType.THOST_FTDC_D_Buy;
                    break;
                case EnumBuySell.卖出:
                    order.Direction = TThostFtdcDirectionType.THOST_FTDC_D_Sell;
                    break;
            }
            switch (openorclose)
            {
                case EnumOpenClose.开仓:
                    order.CombOffsetFlag = "000000";
                    break;
                case EnumOpenClose.平仓:
                    order.CombOffsetFlag = "300000";
                    break;
                case EnumOpenClose.平今仓:
                    order.CombOffsetFlag = "100000";
                    break;
            }

            order.InstrumentID = futurecode;
            order.InvestorID = this.accountList[accid].invostor;
            order.LimitPrice = price;
            order.MinVolume = 1;
            order.VolumeTotalOriginal = qty;
            order.IsAutoSuspend = 0;
            order.UserForceClose = 0;
            order.ContingentCondition = TThostFtdcContingentConditionType.THOST_FTDC_CC_Immediately;
            order.ForceCloseReason = TThostFtdcForceCloseReasonType.THOST_FTDC_FCC_NotForceClose;
            order.GTDDate = TThostFtdcTimeConditionType.THOST_FTDC_TC_GFD.ToString();
            order.OrderPriceType = TThostFtdcOrderPriceTypeType.THOST_FTDC_OPT_LimitPrice;
            order.TimeCondition = TThostFtdcTimeConditionType.THOST_FTDC_TC_GFD;
            //order.OrderRef = (++this.MaxOrderRef).ToString();
            //order.IsSwapOrder = 0;
            order.IsAutoSuspend = 0;
            //order.StopPrice=
            //order.RequestID=
            order.VolumeCondition = TThostFtdcVolumeConditionType.THOST_FTDC_VC_AV;
            order.UserID = "";
            order.ForceCloseReason = TThostFtdcForceCloseReasonType.THOST_FTDC_FCC_NotForceClose;

            //lock (this.queue)
            //{
                //if (queueFlag)
                //{
                //    //Monitor.Wait(this.queue);
                //}
                //else
                //{
                    queue.Enqueue(new Tuple<string, object, object>("SendLimitFutureOrder", order, accid));
                    queueFlag = true;
                //}
                //Monitor.Pulse(this.queue);
           // }
            Order o = new FutureOrder();
            o.BrokerID = this.accountList[accid].brokerid;
            o.ContingentCondition = EnumContingentCondition.Immediately;
            o.Direction = buysell;
            //o.ExchangeID = this.accountList[idx];
            o.HedgeFlag = EnumHedgeFlag.Arbitrage;
            o.InstrumentID = futurecode;
            o.InstrumentType = EnumMarket.期货;
            o.InvestorID = this.accountList[accid].invostor;
            o.LimitPrice = price;
            o.OpenOrClose = openorclose;
            //o.OrderRejectReason = EnumRejectReason;
            //o.OrderSysID = pOrder.OrderSysID;
            //o.StatusMsg = pOrder.StatusMsg;
            //o.StopPrice = pOrder.StopPrice;
            //o.TradingDay = pOrder.TradingDay;
            o.Volume = qty;
            //o.VolumeLeft = pOrder.VolumeTotal - pOrder.VolumeTraded;
            //o.VolumeTraded = pOrder.VolumeTraded;
            return o;
        }
        public Order SendMarketFutureOrder(string futurecode, int qty, EnumBuySell buysell, EnumOpenClose openorclose, EnumHedgeFlag hedgeflag, int idx) { return new FutureOrder(); }
        public Order SendMarketFutureOrder(string futurecode, int qty, EnumBuySell buysell, EnumOpenClose openorclose, EnumHedgeFlag hedgeflag, string accid) { return new FutureOrder(); }
        public void SetDict(string key, string value) { }
        public void ShowMessage(string message) { }
        public void SwitchTriggerInstrument(string instrumentid) { }
        public TimeSpan TotalTimeSpan(Exchange exchange) { return new TimeSpan(); }
        public void Wait(int T) { }

        // Properties
        public FutureSeries AllFutures 
        {
            get
            {
               
                return this.futureSeries;
            }
        }
        public StockSeries AllStocks 
        { 
            get
            { 
                return new StockSeries();
            }
        }
        public int FutureAccountCount 
        {
            get
            {
                return this.accountList.Count;
            }
        }
        public FutureAccount MyFutureAccount 
        {
            get 
            {
                FutureAccount fa = new FutureAccount();
                //fa.BrokerID = this.accountList[0].brokerid;
                //fa.Available = this.accountList[0];
                //fa.Balance = this.accountList[0];
                //fa.CloseProfit = this.accountList[0];
                //fa.Commission = this.accountList[0];
                //fa.CurrMargin = this.accountList[0];
                //fa.Deposit = this.accountList[0];
                //fa.FrozenCommission = this.accountList[0];
                //fa.FrozenMargin = this.accountList[0];
                //fa.ID = this.accountList[0];
                //fa.PositionProfit = this.accountList[0];
                //fa.PreBalance = this.accountList[0];
                //fa.PreDeposit = this.accountList[0]; 
                //fa.PreMargin = this.accountList[0];
                //fa.Risk = this.accountList[0];
                //fa.Withdraw = this.accountList[0];
               
                return fa; 
            }
        }
        public PositionSeries MyFuturePositions 
        {
            get 
            {
               return this.GetFuturePositions(0);
            }
        }
        public StockAccount MyStockAccount
        { 
            get
            { 
                return new StockAccount(); 
            } 
        }
        public PositionSeries MyStockPositions
        { 
            get
            { 
                return new PositionSeries(); 
            } 
        }
        public DateTime Now 
        {
            get
            { 
                return DateTime.Now; 
            }
        }
        public string TriggerInstrument 
        {
            get
            {

                return this.DriveInstrument;
               
            }
        }
        #endregion 接口实现
    }
   public class ProjectSeries : List<Project>
   {
       public Project this[string projectname]
       {
           get 
           {
               foreach (Project pro in this)
               {
                   if (pro.Projname == projectname)
                   {
                       return pro;
                   }
               }
               return null;
           }
           set 
           {
               for (int n = 0; n < this.Count;n++ )
               {
                   if (this[n].Projname == projectname)
                   {
                       this[n] = value;
                   }
               }
           }
       }
   }
}
