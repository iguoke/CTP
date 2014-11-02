using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;

namespace CTPAPI
{
    /// <summary>
    /// 行情接口
    /// </summary>
    public class MDAPI
    {
        /// <summary>
        /// 保存动态链接库地址
        /// </summary>
        const string strDllFile = @"./CTPMDAPI.dll";
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_investor"></param>
        /// <param name="_pwd"></param>
        /// <param name="_broker"></param>
        /// <param name="_addr"></param>
        public MDAPI( string[] _addr,string _investor = "00000076", string _pwd = "123456", string _broker = "1035")
        {
            this.FrontAddr = _addr;
            this.BrokerID = _broker;
            this.InvestorID = _investor;
            this.password = _pwd;
        }
        /// <summary>
        /// 获取交易日
        /// </summary>
        /// <returns></returns>
        public string GetTradingDay() { return getTradingDay(); }
        [DllImport(strDllFile, EntryPoint = "GetTradingDay", CallingConvention = CallingConvention.Cdecl)]
        static extern string getTradingDay();
        /// <summary>
        /// 连接
        /// </summary>
        public void Connect() { connect(this.FrontAddr); }
        [DllImport(strDllFile, EntryPoint = "Connect", CallingConvention = CallingConvention.Cdecl)]
        static extern void connect(string[] pFrontAddr);
        /// <summary>
        /// 断开连接
        /// </summary>
        public void Release() { release(); }
        [DllImport(strDllFile, EntryPoint = "Release", CallingConvention = CallingConvention.Cdecl)]
        static extern void release();
        /// <summary>
        /// 等待接口线程结束运行
        /// </summary>
        /// <returns></returns>
        public int Join() { return join(); }
        [DllImport(strDllFile, EntryPoint = "Join", CallingConvention = CallingConvention.Cdecl)]
        static extern int join();
        /// <summary>
        /// 登陆
        /// </summary>
        public int UserLogin() { return userLogin(this.BrokerID, this.InvestorID, this.password); }
        [DllImport(strDllFile, EntryPoint = "ReqUserLogin", CallingConvention = CallingConvention.Cdecl)]
        static extern int userLogin(string BROKER_ID, string INVESTOR_ID, string PASSWORD);
        /// <summary>
        /// 登出
        /// </summary>
        public int UserLogout() { return userLogout(this.BrokerID, this.InvestorID); }
        [DllImport(strDllFile, EntryPoint = "ReqUserLogout", CallingConvention = CallingConvention.Cdecl)]
        static extern int userLogout(string BROKER_ID, string INVESTOR_ID);
        /// <summary>
        /// 行情订阅
        /// </summary>
        /// <param name="instruments"></param>
        public int SubMarketData(params string[] instruments) { return subMarketData(instruments, instruments == null ? 0 : instruments.Length); }
        [DllImport(strDllFile, EntryPoint = "SubMarketData", CallingConvention = CallingConvention.Cdecl)]
        static extern int subMarketData(string[] instrumentsID, int nCount);
        /// <summary>
        /// 行情退订
        /// </summary>
        /// <param name="instruments"></param>
        public int UnSubMarketData(params string[] instruments) { return unSubMarketData(instruments, instruments == null ? 0 : instruments.Length); }
        [DllImport(strDllFile, EntryPoint = "UnSubscribeMarketData", CallingConvention = CallingConvention.Cdecl)]
        static extern int unSubMarketData(string[] ppInstrumentID, int nCount);

       
        //回调函数 ==================================================================================================================
        #region 错误响应
        [DllImport(strDllFile, EntryPoint = "RegOnRspError", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspError(RspError cb);
        RspError rspError;
        public delegate void RspError(ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        public event RspError OnRspError
        {
            add { rspError += value; regOnRspError(rspError); }
            remove { rspError -= value; regOnRspError(rspError); }

        }
        #endregion

        #region 心跳响应
        [DllImport(strDllFile, EntryPoint = "RegOnHeartBeatWarning", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnHeartBeatWarning(HeartBeatWarning cb);
        HeartBeatWarning heartBeatWarning;
        /// <summary>
        /// 
        /// </summary>
        public delegate void HeartBeatWarning(int nTimeLapse);
        /// <summary>
        /// 心跳响应
        /// </summary>
        public event HeartBeatWarning OnHeartBeatWarning
        {
            add { heartBeatWarning += value; regOnHeartBeatWarning(heartBeatWarning); }
            remove { heartBeatWarning -= value; regOnHeartBeatWarning(heartBeatWarning); }

        }
        #endregion

        #region 连接响应
        [DllImport(strDllFile, EntryPoint = "RegOnFrontConnected", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnFrontConnected(FrontConnected cb);
        FrontConnected frontConnected;
        /// <summary>
        /// 
        /// </summary>
        public delegate void FrontConnected();
        /// <summary>
        /// 连接响应
        /// </summary>
        public event FrontConnected OnFrontConnected
        {
            add { frontConnected += value; regOnFrontConnected(frontConnected); }
            remove { frontConnected -= value; regOnFrontConnected(frontConnected); }

        }
        #endregion

        #region 断开应答
        [DllImport(strDllFile, EntryPoint = "RegOnFrontDisconnected", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnFrontDisconnected(FrontDisconnected cb);
        FrontDisconnected frontDisconnected;
        /// <summary>
        /// 
        /// </summary>
        public delegate void FrontDisconnected(int nReason);
        /// <summary>
        /// 断开应答
        /// </summary>
        public event FrontDisconnected OnFrontDisconnected
        {
            add { frontDisconnected += value; regOnFrontDisconnected(frontDisconnected); }
            remove { frontDisconnected -= value; regOnFrontDisconnected(frontDisconnected); }
        }
        #endregion

        #region 登入请求应答
        [DllImport(strDllFile, EntryPoint = "RegOnRspUserLogin", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspUserLogin(RspUserLogin cb);
        RspUserLogin rspUserLogin;
        /// <summary>
        /// 
        /// </summary>
        public delegate void RspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        /// <summary>
        /// 登入请求应答
        /// </summary>
        public event RspUserLogin OnRspUserLogin
        {
            add { rspUserLogin += value; regOnRspUserLogin(rspUserLogin); }
            remove { rspUserLogin -= value; regOnRspUserLogin(rspUserLogin); }
        }
        #endregion

        #region 登出请求应答
        [DllImport(strDllFile, EntryPoint = "RegOnRspUserLogout", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspUserLogout(RspUserLogout cb);
        RspUserLogout rspUserLogout;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pUserLogout"></param>
        /// <param name="pRspInfo"></param>
        /// <param name="nRequestID"></param>
        /// <param name="bIsLast"></param>
        public delegate void RspUserLogout(ref CThostFtdcUserLogoutField pUserLogout, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        /// <summary>
        /// 登出请求应答
        /// </summary>
        public event RspUserLogout OnRspUserLogout
        {
            add { rspUserLogout += value; regOnRspUserLogout(rspUserLogout); }
            remove { rspUserLogout -= value; regOnRspUserLogout(rspUserLogout); }
        }
        #endregion

        #region 订阅行情应答
        [DllImport(strDllFile, EntryPoint = "RegOnRspSubMarketData", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspSubMarketData(RspSubMarketData cb);
        RspSubMarketData rspSubMarketData;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSpecificInstrument"></param>
        /// <param name="pRspInfo"></param>
        /// <param name="nRequestID"></param>
        /// <param name="bIsLast"></param>
        public delegate void RspSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        /// <summary>
        /// 订阅行情应答
        /// </summary>
        public event RspSubMarketData OnRspSubMarketData
        {
            add { rspSubMarketData += value; regOnRspSubMarketData(rspSubMarketData); }
            remove { rspSubMarketData -= value; regOnRspSubMarketData(rspSubMarketData); }
        }
        #endregion

        #region 退订请求应答
        [DllImport(strDllFile, EntryPoint = "RegOnRspUnSubMarketData", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspUnSubMarketData(RspUnSubMarketData cb);
        RspUnSubMarketData rspUnSubMarketData;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSpecificInstrument"></param>
        /// <param name="pRspInfo"></param>
        /// <param name="nRequestID"></param>
        /// <param name="bIsLast"></param>
        public delegate void RspUnSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        /// <summary>
        /// 退订请求应答
        /// </summary>
        public event RspUnSubMarketData OnRspUnSubMarketData
        {
            add { rspUnSubMarketData += value; regOnRspUnSubMarketData(rspUnSubMarketData); }
            remove { rspUnSubMarketData -= value; regOnRspUnSubMarketData(rspUnSubMarketData); }
        }
        #endregion

        #region 深度行情通知
        [DllImport(strDllFile, EntryPoint = "RegOnRtnDepthMarketData", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRtnDepthMarketData(RtnDepthMarketData cb);
        RtnDepthMarketData rtnDepthMarketData;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDepthMarketData"></param>
        public delegate void RtnDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData);
        /// <summary>
        /// 深度行情通知
        /// </summary>
        public event RtnDepthMarketData OnRtnDepthMarketData
        {
            add { rtnDepthMarketData += value; regOnRtnDepthMarketData(rtnDepthMarketData); }
            remove { rtnDepthMarketData -= value; regOnRtnDepthMarketData(rtnDepthMarketData); }
        }
        #endregion
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
