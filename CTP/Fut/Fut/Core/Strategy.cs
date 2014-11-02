using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using CTPAPI;
namespace Fut.Core
{
    public class Strategy //:IStrategy
    {
        private List<BackTestData> BackTestDataList = new List<BackTestData>();
        private BackTestData backTestData=new BackTestData();
        private CThostFtdcTradeField pTrade = new CThostFtdcTradeField();
        private int MaxOrderRef;
        private IFunction _fuction;
        private bool _backtest;//=false;
        private string backtesttime;
        //public  BackTestMarketData backTestMarketData;
        public bool BackTest
        {
            get
            {
                return this._backtest;
            }
            set
            {
                if (this._backtest == false)
                {
                    this._backtest = value;
                    if (this._backtest == true)
                    {
                        this._fuction.MdApi.OnRtnDepthMarketData -= new MDAPI.RtnDepthMarketData(this.OnTick);
                        //this.backTestMarketData += this.OnTick;
                    }
                }
                else
                {
                    this._backtest = value;
                    if (this._backtest == false)
                    {
                        this._fuction.MdApi.OnRtnDepthMarketData += new MDAPI.RtnDepthMarketData(this.OnTick);
                        //this.backTestMarketData -= this.OnTick;
                    }
                }
            }
        }
        public IFunction Fun
        {
            get
            {
                return this._fuction;
            }
            set
            {
                this._fuction = value;
            }
        }
        public virtual void Init()
        {
            //this._fuction = null;
            //this.Fun = null;
            this.MaxOrderRef = 0;
            this._backtest = false;
            this.MdApi_Reg();
            this.TdApi_Reg();
           // this.backTestMarketData = new BackTestMarketData(this.OnTick);
           // this.backTestMarketData -= this.OnTick;
           
        }
        public virtual void Exit()
        { 
            
        }
        public virtual void OnTick(ref CThostFtdcDepthMarketDataField pDepthMarketData)
        {
            this.Print("行情响应Tick");
            if (_backtest == true)
            {
                backtesttime = pDepthMarketData.UpdateTime;
            }
        }
        public virtual void MdApi_OnFrontConnected()
        {
            Print("行情前置响应");

        }
        public virtual void MdApi_OnFrontDisconnected(int n)
        {
            Print("行情连接诊断响应");            
        }
        public virtual void MdApi_OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Print("行情登陆响应");                        
        }
        public virtual void MdApi_OnRspError(ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Print("行情错误响应");  
        }
        public virtual void MdApi_OnRspUserLogout(ref CThostFtdcUserLogoutField pUserLogout, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Print("行情登出响应"); 
        }
        public virtual void MdApi_OnRspSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Print("行情订阅响应");                         
        }
        public virtual void MdApi_OnRspUnSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Print("行情退订响应");             
        }
        public virtual void MdApi_OnHeartBeatWarning(int n)
        {
            Print("行情心跳超时响应");                         
        }
        public void Print(string msg)
        {
            if (this._fuction != null)
            {
                //if (this._backtest==false)
                {
                    this._fuction.Print(msg);
                }
            }
        }
        public void PrintError(string msg)
        {
            if (this._fuction != null)
            {
                this._fuction.PrintError(msg);
            }
        }
        public void PrintWarning(string msg)
        {
            if (this._fuction != null)
            {
                this._fuction.PrintWarning(msg);
            }
        }
        public string SendMessage(string msg)
        {
            if (this._fuction != null && this._backtest == false)
            {
                return this._fuction.SendMessage(msg);
            }
            else
            {
                return "0";
            }
        }
        public int MdApi_Join()
        {
            if (this._fuction != null)
            {
                if (this._fuction.MdApi != null)
                {
                    return this._fuction.MdApi.Join();
                }
                else
                {
                    PrintError("MdApi_Join->this._fuction.MdApi为空指针");
                    return 1;
                }
            }
            else
            {
                PrintError("MdApi_Join->this._fuction为空指针");
                return 1;
            }
        }
        public void MdApi_Release()
        {
            if (this._fuction != null)
            {
                if (this._fuction.MdApi != null)
                {
                    this._fuction.MdApi.Release();
                }
                else
                    PrintError("MdApi_Release->_fuction.MdApi为空指针");
            }
            else
            {
                PrintError("MdApi_Release->_fuction为空指针");
                
            }
        }
        public string MdApi_GetTradingDay()
        {
            if (this._fuction != null)
            {
                if (this._fuction.MdApi!=null)
                {
                    return this._fuction.MdApi.GetTradingDay();
                }
                else
                {
                    PrintError("MdApi_GetTradingDay->_fuction.MdApi为空指针");
                    return null;    
                }
            }
            else
            {
                PrintError("MdApi_GetTradingDay->_fuction为空指针");
                return null;
            }
        }
        public void MdApi_Connect()
        {
            if (this._fuction != null)
            {
                if (this._fuction.MdApi!=null)
                {
                    this._fuction.MdApi.Connect();
                }
                else
                    PrintError("MdApi_Connect->_fuction.MdApi为空指针");            
            }
            else
            {
                PrintError("MdApi_Connect->_fuction为空指针");            
            }
        }
        public int MdApi_UserLogin()
        {
            if (this._fuction != null)
            {
                if (this._fuction.MdApi!=null)
                {
                    return this._fuction.MdApi.UserLogin();
                }
                else
                {
                    PrintError("MdApi_UserLogin->_fuction.MdApi为空指针");            
                    return 1;
                }
            }
            else
            {
                PrintError("MdApi_UserLogin->_fuction为空指针");            
                return 1;
            }
        }
        public int MdApi_UserLogout()
        {
            if (this._fuction != null)
            {
                if (this._fuction.MdApi!=null)
                {
                    return this._fuction.MdApi.UserLogout();
                }
                else
                {
                    PrintError("MdApi_UserLogout->_fuction.MdApi为空指针");            
                    return 1;
                }
            }
            else
            {
                PrintError("MdApi_UserLogout->_fuction为空指针");            
                return 1;
            }
        }
        public int MdApi_SubMarketData(params string[] instruments)
        {
            if (this._fuction != null)
            {
                if (this._fuction.MdApi!=null)
                {
                    return this._fuction.MdApi.SubMarketData(instruments);
                }
                else
                {
                    PrintError("MdApi_SubMarketData->_fuction.MdApi为空指针");            
                    return 1;  
                }
            }
            else
            {
                PrintError("MdApi_SubMarketData->_fuction为空指针");            
                return 1;
            }
        }
        public int MdApi_UnSubMarketData(params string[] instruments)
        {
            if (this._fuction != null)
            {
                if (this._fuction.MdApi!=null)
                {
                    return this._fuction.MdApi.UnSubMarketData(instruments);
                }
                else
                {
                    PrintError("MdApi_UnSubMarketData->_fuction.MdApi为空指针");
                    return 1;
                }
            }
            else
            {
                PrintError("MdApi_UnSubMarketData->_fuction为空指针");
                return 1;
            }
        }
        public void MdApi_Reg()
        {
            if (this._fuction != null)
            {
                if (this._fuction.MdApi != null)
                {
                    this._fuction.MdApi.OnFrontConnected += new CTPAPI.MDAPI.FrontConnected(this.MdApi_OnFrontConnected);
                    this._fuction.MdApi.OnRtnDepthMarketData += new MDAPI.RtnDepthMarketData(this.OnTick);
                    this._fuction.MdApi.OnFrontDisconnected += new MDAPI.FrontDisconnected(this.MdApi_OnFrontDisconnected);
                    this._fuction.MdApi.OnRspError += new MDAPI.RspError(MdApi_OnRspError);
                    this._fuction.MdApi.OnRspUserLogin += new MDAPI.RspUserLogin(MdApi_OnRspUserLogin);
                    this._fuction.MdApi.OnRspUserLogout += new MDAPI.RspUserLogout(MdApi_OnRspUserLogout);
                    this._fuction.MdApi.OnRspUnSubMarketData += new MDAPI.RspUnSubMarketData(MdApi_OnRspUnSubMarketData);
                    this._fuction.MdApi.OnRspSubMarketData += new MDAPI.RspSubMarketData(MdApi_OnRspSubMarketData);
                    this._fuction.MdApi.OnHeartBeatWarning += new MDAPI.HeartBeatWarning(MdApi_OnHeartBeatWarning);
                }
                else
                {
                    PrintError("MdApi_Reg->_fuction.MdApi为空指针");

                }
            }
            else
            {
                PrintError("MdApi_Reg->_fuction为空指针");
            }
        }

        public void TdApi_Connect()
        {
            if (this._fuction != null)
            {
                if (this._fuction.TdApi!=null)
                {
                    this._fuction.TdApi.Connect();
                }
                else
                {
                    PrintError("TdApi_Connect->_fuction.TdApi为空指针");                                                    
                }
            }
            else
            {
                PrintError("TdApi_Connect->_fuction为空指针");                                
            }
        }
        public int TdApi_UserLogin()
        {
            if (this._fuction != null)
            {
                if (this._fuction.TdApi!=null)
                {
                    return this._fuction.TdApi.UserLogin();
                }
                else
                {
                    PrintError("TdApi_UserLogin->_fuction.TdApi为空指针");
                    return 1;              
                }
            }
            else
            {
                PrintError("TdApi_UserLogin->_fuction为空指针");
                return 1;              
            }
        }
        public virtual void TdApi_OnFrontConnected()
        {
            Print("交易前置响应");                                     
        }
        public virtual void TdApi_OnFrontDisconnected(int n)
        {
            Print("交易诊断响应");
        }
        public virtual void TdApi_OnRspError(ref CThostFtdcRspInfoField pRspInfo)
        {
            PrintError("错误->" + pRspInfo.ErrorMsg);
        }
        public virtual void TdApi_OnHeartBeatWarning(int nTimeLapse)
        {
            Print("交易心跳超时响应");
        }
        public virtual void TdApi_OnRspQryInstrument(ref CThostFtdcInstrumentField pInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Print("交易查询合约响应");
        }
        public virtual void TdApi_OnRspQrySettlementInfo(ref CThostFtdcSettlementInfoField pSettlementInfo, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Print("交易结算单响应");
        }
        public virtual void TdApi_OnRspSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Print("交易确认结算单响应");
        }
        public virtual void TdApi_OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Print("交易登陆响应");
        }
        public virtual void OnOrder(ref CThostFtdcOrderField pOrder)
        {
            Print("交易报单响应");
        }
        public virtual void OnTrade(ref CThostFtdcTradeField pTrade)
        {
            Print("交易成交响应");
        }
        public virtual void TdApi_OnErrRtnOrderInsert(ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo)
        {
            Print("交易报单错误响应");
        }
        public virtual void TdApi_OnRspOrderInsert(ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Print("交易报单录入响应");            
        }
        public virtual void TdApi_OnRspOrderAction(ref CThostFtdcInputOrderActionField pInputOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Print("交易报单操作响应");                        
        }
        public virtual void TdApi_OnRspOrderAction(ref CThostFtdcOrderActionField pOrderAction, ref CThostFtdcRspInfoField pRspInfo)
        {
            Print("交易报单操作错误响应");                        
            
        }
        public void TdApi_Reg()
        {
            if (this._fuction!=null)
            {
                if (this._fuction.TdApi != null)
                {
                    this._fuction.TdApi.OnFrontConnected += new TDAPI.FrontConnected(TdApi_OnFrontConnected);
                    this._fuction.TdApi.OnFrontDisconnected += new TDAPI.FrontDisconnected(TdApi_OnFrontDisconnected);
                    this._fuction.TdApi.OnRspError += new TDAPI.RspError(TdApi_OnRspError);
                    this._fuction.TdApi.OnHeartBeatWarning += new TDAPI.HeartBeatWarning(TdApi_OnHeartBeatWarning);
                    this._fuction.TdApi.OnRspQryInstrument += new TDAPI.RspQryInstrument(TdApi_OnRspQryInstrument);
                    this._fuction.TdApi.OnRspQrySettlementInfo += new TDAPI.RspQrySettlementInfo(TdApi_OnRspQrySettlementInfo);
                    this._fuction.TdApi.OnRspSettlementInfoConfirm += new TDAPI.RspSettlementInfoConfirm(TdApi_OnRspSettlementInfoConfirm);
                    this._fuction.TdApi.OnRspUserLogin += new TDAPI.RspUserLogin(TdApi_OnRspUserLogin);
                    this._fuction.TdApi.OnRtnOrder += new TDAPI.RtnOrder(OnOrder);
                    this._fuction.TdApi.OnRtnTrade += new TDAPI.RtnTrade(OnTrade);
                    this._fuction.TdApi.OnErrRtnOrderInsert += new TDAPI.ErrRtnOrderInsert(TdApi_OnErrRtnOrderInsert);
                    this._fuction.TdApi.OnRspOrderInsert += new TDAPI.RspOrderInsert(TdApi_OnRspOrderInsert);
                    this._fuction.TdApi.OnRspOrderAction += new TDAPI.RspOrderAction(TdApi_OnRspOrderAction);
                    this._fuction.TdApi.OnRspOrderAction += new TDAPI.RspOrderAction(TdApi_OnRspOrderAction);
                }
                else
                {
                    PrintError("TdApi_Reg->_fuction.TdApi为空指针");                                    
                }
            }
            else
            {
                PrintError("TdApi_Reg->_fuction为空指针");                
            }
        }
 
        public int TdApi_QryInstrument(string _instrument_id = "")
        {
            if(this._fuction!=null)
            {
                if (this._fuction.TdApi!=null)
                {
                    return this._fuction.TdApi.QryInstrument(_instrument_id);
                }
                else
                {
                    PrintError("TdApi_QryInstrument->_fuction为空指针");                
                    return 1;                                
                }
            }
            else
            {
                PrintError("TdApi_QryInstrument->_fuction为空指针");                
                return 1;                    
            }
        }
        public int TdApi_SettlementInfo(string _date = null)
        {
            if (this._fuction!=null)
            {
                if (this._fuction.TdApi!=null)
                {
                    return  this._fuction.TdApi.SettlementInfo(_date);
                }
                else
                {
                    PrintError("TdApi_SettlementInfo->_fuction.TdApi为空指针");                
                    return 1;
                }
            }
            else
            {
                PrintError("TdApi_SettlementInfo->_fuction为空指针");                
                return 1;
            }
        }
        public int TdApi_SettlementInfoConfirm()
        {
            if (this._fuction!=null)
            {
                if (this._fuction.TdApi!=null)
                {
                    return this._fuction.TdApi.SettlementInfoConfirm();
                }
                else
                {
                    PrintError("TdApi_SettlementInfoConfirm->_fuction.TdApi为空指针");
                    return 1;
                }
            }
            else
            {
                PrintError("TdApi_SettlementInfoConfirm->_fuction为空指针");                
                return 1;
            }
        }
        public int LimitOrder(string Instrument,double Price,int Qty,TThostFtdcDirectionType Direction,string Offset)
        {
            
            CThostFtdcInputOrderField order=new CThostFtdcInputOrderField();
            order.BrokerID = this._fuction.TdApi.BrokerID;
            order.BusinessUnit = "";
           order.CombHedgeFlag ="11110";
            order.CombOffsetFlag = Offset;
            order.InstrumentID = Instrument;
            order.InvestorID = this._fuction.TdApi.InvestorID;
            order.LimitPrice = Price;
            order.MinVolume = 1;
            order.VolumeTotalOriginal = Qty;
            order.IsAutoSuspend = 0;
            order.UserForceClose = 0;
            order.ContingentCondition = TThostFtdcContingentConditionType.THOST_FTDC_CC_Immediately;
            order.Direction = Direction;
            order.ForceCloseReason = TThostFtdcForceCloseReasonType.THOST_FTDC_FCC_NotForceClose;
            order.GTDDate = TThostFtdcTimeConditionType.THOST_FTDC_TC_GFD.ToString();
            order.OrderPriceType = TThostFtdcOrderPriceTypeType.THOST_FTDC_OPT_LimitPrice;
            order.TimeCondition = TThostFtdcTimeConditionType.THOST_FTDC_TC_GFD;
            order.OrderRef = (++this.MaxOrderRef).ToString();
            //order.IsSwapOrder = 0;
            order.IsAutoSuspend=0;
            //order.StopPrice=
            //order.RequestID=
            order.VolumeCondition = TThostFtdcVolumeConditionType.THOST_FTDC_VC_AV;
            order.UserID = "";
            order.ForceCloseReason = TThostFtdcForceCloseReasonType.THOST_FTDC_FCC_NotForceClose;
            if (this._fuction!=null)
            {
                if(this._fuction.TdApi!=null)
                {
                    if (this._backtest == false)
                    {
                        return this._fuction.TdApi.OrderInsert(order);
                    }
                    else
                    {
                        if(order.CombOffsetFlag=="00000")
                        {
                            backTestData.InstrumentID = order.InstrumentID;
                            backTestData.OpenDirection = order.Direction;
                            backTestData.OpenTime = backtesttime;
                            backTestData.OpenPrice = order.LimitPrice;
                            BackTestDataList.Add(backTestData);
                            pTrade.OffsetFlag = TThostFtdcOffsetFlagType.THOST_FTDC_OF_Open;
                        }
                        else if (order.CombOffsetFlag == "10000" || order.CombOffsetFlag == "30000")
                        {
                            for (int i = 0; i < BackTestDataList.Count; i++)
                            {
                                if (BackTestDataList[i].InstrumentID == order.InstrumentID && BackTestDataList[i].CloseTime == "" && BackTestDataList[i].ClosePrice==0)
                                {
                                    if (BackTestDataList[i].OpenDirection == TThostFtdcDirectionType.THOST_FTDC_D_Buy && order.Direction == TThostFtdcDirectionType.THOST_FTDC_D_Sell)
                                 {
                                     BackTestDataList[i].CloseDirection = order.Direction;
                                     BackTestDataList[i].ClosePrice = order.LimitPrice;
                                     BackTestDataList[i].CloseTime = backtesttime;

                                 }
                                    else if (BackTestDataList[i].OpenDirection == TThostFtdcDirectionType.THOST_FTDC_D_Sell && order.Direction == TThostFtdcDirectionType.THOST_FTDC_D_Buy)
                                    {
                                        BackTestDataList[i].CloseDirection = order.Direction;
                                        BackTestDataList[i].ClosePrice = order.LimitPrice;
                                        BackTestDataList[i].CloseTime = backtesttime;
                                    }
                                }

                            }
                                backTestData.CloseTime = backtesttime;
                            backTestData.CloseDirection = order.Direction;
                            backTestData.ClosePrice = order.LimitPrice;

                            pTrade.OffsetFlag = TThostFtdcOffsetFlagType.THOST_FTDC_OF_Close;
                        }
                        pTrade.OrderSysID = "";
                        pTrade.BrokerID = order.BrokerID;
                        pTrade.OrderRef = order.OrderRef;
                        pTrade.InstrumentID = order.InstrumentID;
                        pTrade.Price = order.LimitPrice;
                        pTrade.Direction = order.Direction;
                        pTrade.Volume = order.VolumeTotalOriginal;
                        this.OnTrade(ref pTrade);
                        this._fuction.BackTestData(BackTestDataList);
                        return 0;
                    }
                }
                else
                {
                    PrintError("LimitOrder->_fuction.TdApi为空指针");                
                    return 1;
                }
            }
            else
            {
                PrintError("LimitOrder->_fuction为空指针");                
                return 1;
            }
        }
        public int CancelOrder(CThostFtdcInputOrderActionField order)
        {
            
            order.BrokerID = this._fuction.TdApi.BrokerID;
            order.InvestorID = this._fuction.TdApi.InvestorID;
            order.ActionFlag =TThostFtdcActionFlagType.THOST_FTDC_AF_Delete;
            //order.ExchangeID="SHFE";
            //order.OrderSysID = OrderSysID;
            if (this._fuction!=null)
            {
                if (this._fuction.TdApi != null)
                {
                    return this._fuction.TdApi.ReqOrderAction(order);
                }
                else
                {
                    PrintError("CancelOrder->_fuction.TdApi为空指针");
                    return 1;
                }
            }
            else
            {
                PrintError("CancelOrder->_fuction为空指针");                
                return 1;
            }

        }
        public void GetBackTestMarketData(CThostFtdcDepthMarketDataField md)
        {
            this.OnTick(ref md);
            //this.backTestMarketData(ref md);
            
        }
    }

}
