using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;

namespace CTPAPI
{
   public class  TDAPI
    {
        /// <summary>
        /// 保存动态链接库地址
        /// </summary>
        const string strDllFile = @"./CTPTDAPI.dll";
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_investor"></param>
        /// <param name="_pwd"></param>
        /// <param name="_broker"></param>
        /// <param name="_addr"></param>
        public TDAPI(string[] _addr,string _investor="00000076", string _pwd="123456", string _broker = "1035"
            )
		{
			this.FrontAddr = _addr;
			this.BrokerID = _broker;
			this.InvestorID = _investor;
			this.password = _pwd;
		}
        ////////////////////////////////////回调函数//////////////////////////////////////////////////////////////////////
       //前置响应
        [DllImport(strDllFile, EntryPoint = "RegOnFrontConnected", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnFrontConnected(FrontConnected cb);
        FrontConnected frontConnected;
      
        public delegate void FrontConnected();
        
        public event FrontConnected OnFrontConnected
        {
            add { frontConnected += value; regOnFrontConnected(frontConnected); }
            remove { frontConnected -= value; regOnFrontConnected(frontConnected); }

        }
       //诊断响应
        [DllImport(strDllFile, EntryPoint = "RegOnFrontDisconnected", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnFrontDisconnected(FrontDisconnected cb);
        FrontDisconnected frontDisconnected;
        /// <summary>
        /// 
        /// </summary>
        public delegate void FrontDisconnected(int nReason);
        
        public event FrontDisconnected OnFrontDisconnected
        {
            add { frontDisconnected += value; regOnFrontDisconnected(frontDisconnected); }
            remove { frontDisconnected -= value; regOnFrontDisconnected(frontDisconnected); }

        }
       //心跳超时响应

        [DllImport(strDllFile, EntryPoint = "RegOnHeartBeatWarning", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnHeartBeatWarning(HeartBeatWarning cb);
        HeartBeatWarning heartBeatWarning;
        /// <summary>
        /// 
        /// </summary>
        public delegate void HeartBeatWarning(int nTimeLapse);

        public event HeartBeatWarning OnHeartBeatWarning
        {
            add { heartBeatWarning += value; regOnHeartBeatWarning(heartBeatWarning); }
            remove { heartBeatWarning -= value; regOnHeartBeatWarning(heartBeatWarning); }

        }
        //登陆响应
        [DllImport(strDllFile, EntryPoint = "RegOnRspUserLogin", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspUserLogin(RspUserLogin cb);
        RspUserLogin rspUserLogin;

        public delegate void RspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

        public event RspUserLogin OnRspUserLogin
        {
            add { rspUserLogin += value; regOnRspUserLogin(rspUserLogin); }
            remove { rspUserLogin -= value; regOnRspUserLogin(rspUserLogin); }

        }
       //投资者结算结果确认响应
        [DllImport(strDllFile, EntryPoint = "RegOnRspSettlementInfoConfirm", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspSettlementInfoConfirm(RspSettlementInfoConfirm cb);
        RspSettlementInfoConfirm rspSettlementInfoConfirm;

        public delegate void RspSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

        public event RspSettlementInfoConfirm OnRspSettlementInfoConfirm
        {
            add { rspSettlementInfoConfirm += value; regOnRspSettlementInfoConfirm(rspSettlementInfoConfirm); }
            remove { rspSettlementInfoConfirm -= value; regOnRspSettlementInfoConfirm(rspSettlementInfoConfirm); }

        }
       //请求查询投资者结算结果响应
       [DllImport(strDllFile, EntryPoint = "RegOnRspQrySettlementInfo", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspQrySettlementInfo(RspQrySettlementInfo cb);
       RspQrySettlementInfo rspQrySettlementInfo;

       public delegate void RspQrySettlementInfo(ref CThostFtdcSettlementInfoField pSettlementInfo, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

       public event RspQrySettlementInfo OnRspQrySettlementInfo
        {
            add { rspQrySettlementInfo += value; regOnRspQrySettlementInfo(rspQrySettlementInfo); }
            remove { rspQrySettlementInfo -= value; regOnRspQrySettlementInfo(rspQrySettlementInfo); }

        }
       //请求查询合约响应
       [DllImport(strDllFile, EntryPoint = "RegOnRspQryInstrument", CallingConvention = CallingConvention.StdCall)]
       static extern void regOnRspQryInstrument(RspQryInstrument cb);
       RspQryInstrument rspQryInstrument;

       public delegate void RspQryInstrument(ref CThostFtdcInstrumentField pInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

       public event RspQryInstrument OnRspQryInstrument
       {
           add { rspQryInstrument += value; regOnRspQryInstrument(rspQryInstrument); }
           remove { rspQryInstrument -= value; regOnRspQryInstrument(rspQryInstrument); }

       }
       //错误应答
       [DllImport(strDllFile, EntryPoint = "RegOnRspError", CallingConvention = CallingConvention.StdCall)]
       static extern void regOnRspError(RspError cb);
       RspError rspError;

       public delegate void RspError(ref CThostFtdcRspInfoField pRspInfo);

       public event RspError OnRspError
       {
           add { rspError += value; regOnRspError(rspError); }
           remove { rspError -= value; regOnRspError(rspError); }

       }
       //报单响应
       [DllImport(strDllFile, EntryPoint = "RegOnRtnOrder", CallingConvention = CallingConvention.StdCall)]
       static extern void regOnRtnOrder(RtnOrder cb);
       RtnOrder rtnOrder;

       public delegate void RtnOrder(ref CThostFtdcOrderField pOrder);

       public event RtnOrder OnRtnOrder
       {
           add { rtnOrder += value; regOnRtnOrder(rtnOrder); }
           remove { rtnOrder -= value; regOnRtnOrder(rtnOrder); }

       }
       //报单录入响应
       [DllImport(strDllFile, EntryPoint = "RegOnRspOrderInsert", CallingConvention = CallingConvention.StdCall)]
       static extern void regOnRspOrderInsert(RspOrderInsert cb);
       RspOrderInsert rspOrderInsert;

       public delegate void RspOrderInsert(ref CThostFtdcInputOrderField pInputOrder,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

       public event RspOrderInsert OnRspOrderInsert
       {
           add { rspOrderInsert += value; regOnRspOrderInsert(rspOrderInsert); }
           remove { rspOrderInsert -= value; regOnRspOrderInsert(rspOrderInsert); }

       }
       //报单操作响应
       [DllImport(strDllFile, EntryPoint = "RegOnRspOrderAction", CallingConvention = CallingConvention.StdCall)]
       static extern void regOnRspOrderAction(RspOrderAction cb);
       RspOrderAction rspOrderAction;

       public delegate void RspOrderAction(ref CThostFtdcInputOrderActionField pInputOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
       public event RspOrderAction OnRspOrderAction
       {
           add { rspOrderAction += value; regOnRspOrderAction(rspOrderAction); }
           remove { rspOrderAction -= value; regOnRspOrderAction(rspOrderAction); }

       }
       //成交响应
       [DllImport(strDllFile, EntryPoint = "RegOnRtnTrade", CallingConvention = CallingConvention.StdCall)]
       static extern void regOnRtnTrade(RtnTrade cb);
       RtnTrade rtnTrade;

       public delegate void RtnTrade(ref CThostFtdcTradeField pTrade);

       public event RtnTrade OnRtnTrade
       {
           add { rtnTrade += value; regOnRtnTrade(rtnTrade); }
           remove { rtnTrade -= value; regOnRtnTrade(rtnTrade); }

       }
       //报单错误响应
       [DllImport(strDllFile, EntryPoint = "RegOnErrRtnOrderInsert", CallingConvention = CallingConvention.StdCall)]
       static extern void regOnErrRtnOrderInsert(ErrRtnOrderInsert cb);
       ErrRtnOrderInsert errRtnOrderInsert;

       public delegate void ErrRtnOrderInsert(ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo);

       public event ErrRtnOrderInsert OnErrRtnOrderInsert
       {
           add { errRtnOrderInsert += value; regOnErrRtnOrderInsert(errRtnOrderInsert); }
           remove { errRtnOrderInsert -= value; regOnErrRtnOrderInsert(errRtnOrderInsert); }

       }
	///报单操作错误回报
        [DllImport(strDllFile, EntryPoint = "RegOnErrRtnOrderAction", CallingConvention = CallingConvention.StdCall)]
       static extern void regOnErrRtnOrderAction(ErrRtnOrderAction cb);
        ErrRtnOrderAction errRtnOrderAction;

        public delegate void ErrRtnOrderAction(ref CThostFtdcOrderActionField pOrderAction,ref CThostFtdcRspInfoField pRspInfo);

        public event ErrRtnOrderAction OnErrRtnOrderAction
       {
           add { errRtnOrderAction += value; regOnErrRtnOrderAction(errRtnOrderAction); }
           remove { errRtnOrderAction -= value; regOnErrRtnOrderAction(errRtnOrderAction); }

       }
        ///查询投资者持仓响应
        [DllImport(strDllFile, EntryPoint = "RegOnRspQryInvestorPosition", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspQryInvestorPosition(RspQryInvestorPosition cb);
        RspQryInvestorPosition rspQryInvestorPosition;

        public delegate void RspQryInvestorPosition(ref CThostFtdcInvestorPositionField pInvestorPosition,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

        public event RspQryInvestorPosition OnRspQryInvestorPosition
        {
            add { rspQryInvestorPosition += value; regOnRspQryInvestorPosition(rspQryInvestorPosition); }
            remove { rspQryInvestorPosition -= value; regOnRspQryInvestorPosition(rspQryInvestorPosition); }

        }
        ///查询投资者持仓明细响应
        [DllImport(strDllFile, EntryPoint = "RegOnRspQryInvestorPositionDetail", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspQryInvestorPositionDetail(RspQryInvestorPositionDetail cb);
        RspQryInvestorPositionDetail rspQryInvestorPositionDetail;

        public delegate void RspQryInvestorPositionDetail(ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

        public event RspQryInvestorPositionDetail OnRspQryInvestorPositionDetail
        {
            add { rspQryInvestorPositionDetail += value; regOnRspQryInvestorPositionDetail(rspQryInvestorPositionDetail); }
            remove { rspQryInvestorPositionDetail -= value; regOnRspQryInvestorPositionDetail(rspQryInvestorPositionDetail); }

        }
        ///查询报单响应
        [DllImport(strDllFile, EntryPoint = "RegOnRspQryOrder", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspQryOrder(RspQryOrder cb);
        RspQryOrder rspQryOrder;

        public delegate void RspQryOrder(ref CThostFtdcOrderField pOrder,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

        public event RspQryOrder OnRspQryOrder
        {
            add { rspQryOrder += value; regOnRspQryOrder(rspQryOrder); }
            remove { rspQryOrder -= value; regOnRspQryOrder(rspQryOrder); }

        }
        ///查询投资者持仓明细响应Combine
        [DllImport(strDllFile, EntryPoint = "RegOnRspQryInvestorPositionCombineDetail", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspQryInvestorPositionCombineDetail(RspQryInvestorPositionCombineDetail cb);
        RspQryInvestorPositionCombineDetail rspQryInvestorPositionCombineDetail;

        public delegate void RspQryInvestorPositionCombineDetail(ref CThostFtdcInvestorPositionCombineDetailField pInvestorPositionCombineDetail, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);

        public event RspQryInvestorPositionCombineDetail OnRspQryInvestorPositionCombineDetail
        {
            add { rspQryInvestorPositionCombineDetail += value; regOnRspQryInvestorPositionCombineDetail(rspQryInvestorPositionCombineDetail); }
            remove { rspQryInvestorPositionCombineDetail -= value; regOnRspQryInvestorPositionCombineDetail(rspQryInvestorPositionCombineDetail); }

        }
        ////////////////////////////////////命令函数//////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 连接
        /// </summary>
        public void Connect() { connect(this.FrontAddr); }
        [DllImport(strDllFile, EntryPoint = "Connect", CallingConvention = CallingConvention.Cdecl)]
        static extern void connect(string[] pFrontAddr);
        /// <summary>
        /// 登陆
        /// </summary>
        public int UserLogin() { return userLogin(this.BrokerID, this.InvestorID, this.password); }
        [DllImport(strDllFile, EntryPoint = "ReqUserLogin", CallingConvention = CallingConvention.Cdecl)]
        static extern int userLogin(string BROKER_ID, string INVESTOR_ID, string PASSWORD);
        /// <summary>
        /// 请求投资者结算结果确认
        /// </summary>
        public int SettlementInfoConfirm() { return reqSettlementInfoConfirm(this.BrokerID, this.InvestorID, this.password); }
        [DllImport(strDllFile, EntryPoint = "ReqSettlementInfoConfirm", CallingConvention = CallingConvention.Cdecl)]
        static extern int reqSettlementInfoConfirm(string BROKER_ID, string INVESTOR_ID, string PASSWORD);
        
        /// 请求查询投资者结算结果
        /// </summary>
        public int SettlementInfo(string _date = null) { return reqQrySettlementInfo(this.BrokerID, this.InvestorID, _date); }
        [DllImport(strDllFile, EntryPoint = "ReqQrySettlementInfo", CallingConvention = CallingConvention.Cdecl)]
        static extern int reqQrySettlementInfo(string BROKER_ID, string INVESTOR_ID, string TRADING_DAY);
       /// <summary>
       /// 查询合约
       /// </summary>
       /// <param name="_instrument_id"></param>
       /// <returns></returns>
        public int QryInstrument(string _instrument_id="") { return reqQryInstrument(_instrument_id); }
        [DllImport(strDllFile, EntryPoint = "ReqQryInstrument", CallingConvention = CallingConvention.Cdecl)]
        static extern int reqQryInstrument(string INSTRUMENT_ID);
        /// <summary>
        /// 下单:录入报单
        /// </summary>
        /// <param name="order">输入的报单</param>
        public int OrderInsert(CThostFtdcInputOrderField order) { return reqOrderInsert(ref order); }
        [DllImport(strDllFile, EntryPoint = "ReqOrderInsert", CallingConvention = CallingConvention.Cdecl)]
        static extern int reqOrderInsert(ref CThostFtdcInputOrderField req);

        /// <summary>
        /// 报单操作
        /// </summary>
        public int ReqOrderAction(CThostFtdcInputOrderActionField pInputOrderAction) { return reqOrderAction(ref pInputOrderAction); }
        [DllImport(strDllFile, EntryPoint = "ReqOrderAction", CallingConvention = CallingConvention.Cdecl)]
        static extern int reqOrderAction(ref CThostFtdcInputOrderActionField pInputOrderAction);
        /// <summary>
        /// 等待
        /// </summary>
        public int Join() { return join(); }
        [DllImport(strDllFile, EntryPoint = "Join", CallingConvention = CallingConvention.Cdecl)]
        static extern int join();
        /// <summary>
        /// 查询投资者持仓
        /// </summary>
        public int ReqQryInvestorPosition(string InstrumentID) 
        {
            CThostFtdcQryInvestorPositionField ipf= new CThostFtdcQryInvestorPositionField();
            ipf.BrokerID = this.BrokerID;
            ipf.InvestorID = this.InvestorID;
            ipf.InstrumentID = InstrumentID;
            return reqQryInvestorPosition(ref ipf);
        }
        [DllImport(strDllFile, EntryPoint = "ReqQryInvestorPosition", CallingConvention = CallingConvention.Cdecl)]
        static extern int reqQryInvestorPosition(ref CThostFtdcQryInvestorPositionField pQryInvestorPosition);
        /// <summary>
        /// 查询投资者持仓明细
        /// </summary>
        public int ReqQryInvestorPositionDetail(string InstrumentID) 
        {
            CThostFtdcQryInvestorPositionDetailField ipdf = new CThostFtdcQryInvestorPositionDetailField();
            ipdf.BrokerID = this.BrokerID;
            ipdf.InvestorID = this.InvestorID;
            ipdf.InstrumentID = InstrumentID;
            return reqQryInvestorPositionDetail(ref ipdf);
        }
        [DllImport(strDllFile, EntryPoint = "ReqQryInvestorPositionDetail", CallingConvention = CallingConvention.Cdecl)]
        static extern int reqQryInvestorPositionDetail(ref CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail);
        /// <summary>
        /// 查询投资者持仓明细(组合)
        /// </summary>
        public int ReqQryInvestorPositionCombineDetail( string InstrumentID) 
        {
            CThostFtdcQryInvestorPositionCombineDetailField ipcd = new CThostFtdcQryInvestorPositionCombineDetailField();
            ipcd.BrokerID = this.BrokerID;
            ipcd.InvestorID = this.InvestorID;
            ipcd.CombInstrumentID = InstrumentID;
            return reqQryInvestorPositionCombineDetail(ref ipcd);
        }
        [DllImport(strDllFile, EntryPoint = "ReqQryInvestorPositionCombineDetail", CallingConvention = CallingConvention.Cdecl)]
        static extern int reqQryInvestorPositionCombineDetail(ref CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail);

        /// <summary>
        /// 查询报单
        /// </summary>
        public int ReqQryOrder()
        {
            CThostFtdcQryOrderField p = new CThostFtdcQryOrderField();
            p.BrokerID = this.BrokerID;
            p.InvestorID = this.InvestorID;
            return reqQryOrder(ref p);
        }
        public int ReqQryOrder(string inst)
        {
            CThostFtdcQryOrderField p = new CThostFtdcQryOrderField();
            p.BrokerID = this.BrokerID;
            p.InvestorID = this.InvestorID;
            //p.ExchangeID = ex;
            //p.InsertTimeEnd = te;
            //p.InsertTimeStart = ts;
            p.InstrumentID = inst;
            // p.OrderSysID = os;
            return reqQryOrder(ref p);
        }
        public int ReqQryOrder(string inst ,string os)
        {
            CThostFtdcQryOrderField p = new CThostFtdcQryOrderField();
            p.BrokerID = this.BrokerID;
            p.InvestorID = this.InvestorID;
            //p.ExchangeID = ex;
            //p.InsertTimeEnd = te;
            //p.InsertTimeStart = ts;
            p.InstrumentID = inst;
             p.OrderSysID = os;
            return reqQryOrder(ref p);
        }
        [DllImport(strDllFile, EntryPoint = "ReqQryOrder", CallingConvention = CallingConvention.Cdecl)]
        static extern int reqQryOrder(ref CThostFtdcQryOrderField pQryOrder);

       ////////////////////////////////////变量声明//////////////////////////////////////////////////////////////////////

        /// <summary>
        /// 前置地址
        /// </summary>
        public string[] FrontAddr { get; set; }
        /// <summary>
        /// 经纪公司代码ctp-2030;上期-4030;
        /// </summary>
        public string BrokerID { get; set; }
        /// <summary>
        /// 投资者代码 351962-申万
        /// </summary>
        public string InvestorID { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        private string password;
    }
}
