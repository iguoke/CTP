///本文件的转换工具由刘建平提供
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace CTPAPI
{
    /// <summary>
    ///信息分发
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcDisseminationField
    {
        /// <summary>
        ///序列系列号
        /// <summary>
        public short SequenceSeries;
        /// <summary>
        ///序列号
        /// <summary>
        public int SequenceNo;
    }

    /// <summary>
    ///用户登录请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqUserLoginField
    {
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///用户端产品信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        ///接口端产品信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;
        /// <summary>
        ///协议信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;
        /// <summary>
        ///Mac地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        /// <summary>
        ///动态密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OneTimePassword;
        /// <summary>
        ///终端IP地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ClientIPAddress;
    }

    /// <summary>
    ///用户登录应答
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspUserLoginField
    {
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///登录成功时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///交易系统名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;
        /// <summary>
        ///前置编号
        /// <summary>
        public int FrontID;
        /// <summary>
        ///会话编号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///最大报单引用
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MaxOrderRef;
        /// <summary>
        ///上期所时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SHFETime;
        /// <summary>
        ///大商所时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string DCETime;
        /// <summary>
        ///郑商所时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CZCETime;
        /// <summary>
        ///中金所时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string FFEXTime;
    }

    /// <summary>
    ///用户登出请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcUserLogoutField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    ///强制交易员退出
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcForceUserLogoutField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    ///客户端认证请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqAuthenticateField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///用户端产品信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        ///认证码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string AuthCode;
    }

    /// <summary>
    ///客户端认证响应
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspAuthenticateField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///用户端产品信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
    }

    /// <summary>
    ///客户端认证信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcAuthenticationInfoField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///用户端产品信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        ///认证信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string AuthInfo;
        /// <summary>
        ///是否为认证结果
        /// <summary>
        public int IsResult;
    }

    /// <summary>
    ///银期转帐报文头
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferHeaderField
    {
        /// <summary>
        ///版本号，常量，1.0
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string Version;
        /// <summary>
        ///交易代码，必填
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///交易日期，必填，格式：yyyymmdd
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间，必填，格式：hhmmss
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///发起方流水号，N/A
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeSerial;
        /// <summary>
        ///期货公司代码，必填
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string FutureID;
        /// <summary>
        ///银行代码，根据查询银行得到，必填
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分中心代码，根据查询银行得到，必填
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
        /// <summary>
        ///操作员，N/A
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///交易设备类型，N/A
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///记录数，N/A
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string RecordNum;
        /// <summary>
        ///会话编号，N/A
        /// <summary>
        public int SessionID;
        /// <summary>
        ///请求编号，N/A
        /// <summary>
        public int RequestID;
    }

    /// <summary>
    ///银行资金转期货请求，TradeCode=202001
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferBankToFutureReqField
    {
        /// <summary>
        ///期货资金账户
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        /// <summary>
        ///密码标志
        /// <summary>
        public TThostFtdcFuturePwdFlagType FuturePwdFlag;
        /// <summary>
        ///密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string FutureAccPwd;
        /// <summary>
        ///转账金额
        /// <summary>
        public double TradeAmt;
        /// <summary>
        ///客户手续费
        /// <summary>
        public double CustFee;
        /// <summary>
        ///币种：RMB-人民币 USD-美圆 HKD-港元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }

    /// <summary>
    ///银行资金转期货请求响应
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferBankToFutureRspField
    {
        /// <summary>
        ///响应代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string RetCode;
        /// <summary>
        ///响应信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string RetInfo;
        /// <summary>
        ///资金账户
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        /// <summary>
        ///转帐金额
        /// <summary>
        public double TradeAmt;
        /// <summary>
        ///应收客户手续费
        /// <summary>
        public double CustFee;
        /// <summary>
        ///币种
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }

    /// <summary>
    ///期货资金转银行请求，TradeCode=202002
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferFutureToBankReqField
    {
        /// <summary>
        ///期货资金账户
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        /// <summary>
        ///密码标志
        /// <summary>
        public TThostFtdcFuturePwdFlagType FuturePwdFlag;
        /// <summary>
        ///密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string FutureAccPwd;
        /// <summary>
        ///转账金额
        /// <summary>
        public double TradeAmt;
        /// <summary>
        ///客户手续费
        /// <summary>
        public double CustFee;
        /// <summary>
        ///币种：RMB-人民币 USD-美圆 HKD-港元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }

    /// <summary>
    ///期货资金转银行请求响应
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferFutureToBankRspField
    {
        /// <summary>
        ///响应代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string RetCode;
        /// <summary>
        ///响应信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string RetInfo;
        /// <summary>
        ///资金账户
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        /// <summary>
        ///转帐金额
        /// <summary>
        public double TradeAmt;
        /// <summary>
        ///应收客户手续费
        /// <summary>
        public double CustFee;
        /// <summary>
        ///币种
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }

    /// <summary>
    ///查询银行资金请求，TradeCode=204002
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferQryBankReqField
    {
        /// <summary>
        ///期货资金账户
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        /// <summary>
        ///密码标志
        /// <summary>
        public TThostFtdcFuturePwdFlagType FuturePwdFlag;
        /// <summary>
        ///密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string FutureAccPwd;
        /// <summary>
        ///币种：RMB-人民币 USD-美圆 HKD-港元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }

    /// <summary>
    ///查询银行资金请求响应
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferQryBankRspField
    {
        /// <summary>
        ///响应代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string RetCode;
        /// <summary>
        ///响应信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string RetInfo;
        /// <summary>
        ///资金账户
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        /// <summary>
        ///银行余额
        /// <summary>
        public double TradeAmt;
        /// <summary>
        ///银行可用余额
        /// <summary>
        public double UseAmt;
        /// <summary>
        ///银行可取余额
        /// <summary>
        public double FetchAmt;
        /// <summary>
        ///币种
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }

    /// <summary>
    ///查询银行交易明细请求，TradeCode=204999
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferQryDetailReqField
    {
        /// <summary>
        ///期货资金账户
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
    }

    /// <summary>
    ///查询银行交易明细请求响应
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferQryDetailRspField
    {
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///交易代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///期货流水号
        /// <summary>
        public int FutureSerial;
        /// <summary>
        ///期货公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string FutureID;
        /// <summary>
        ///资金帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 22)]
        public string FutureAccount;
        /// <summary>
        ///银行流水号
        /// <summary>
        public int BankSerial;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分中心代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
        /// <summary>
        ///银行账号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CertCode;
        /// <summary>
        ///货币代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
        /// <summary>
        ///发生金额
        /// <summary>
        public double TxAmount;
        /// <summary>
        ///有效标志
        /// <summary>
        public TThostFtdcTransferValidFlagType Flag;
    }

    /// <summary>
    ///响应信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspInfoField
    {
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///交易所
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///交易所名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeName;
        /// <summary>
        ///交易所属性
        /// <summary>
        public TThostFtdcExchangePropertyType ExchangeProperty;
    }

    /// <summary>
    ///产品
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcProductField
    {
        /// <summary>
        ///产品代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
        /// <summary>
        ///产品名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ProductName;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///产品类型
        /// <summary>
        public TThostFtdcProductClassType ProductClass;
        /// <summary>
        ///合约数量乘数
        /// <summary>
        public int VolumeMultiple;
        /// <summary>
        ///最小变动价位
        /// <summary>
        public double PriceTick;
        /// <summary>
        ///市价单最大下单量
        /// <summary>
        public int MaxMarketOrderVolume;
        /// <summary>
        ///市价单最小下单量
        /// <summary>
        public int MinMarketOrderVolume;
        /// <summary>
        ///限价单最大下单量
        /// <summary>
        public int MaxLimitOrderVolume;
        /// <summary>
        ///限价单最小下单量
        /// <summary>
        public int MinLimitOrderVolume;
        /// <summary>
        ///持仓类型
        /// <summary>
        public TThostFtdcPositionTypeType PositionType;
        /// <summary>
        ///持仓日期类型
        /// <summary>
        public TThostFtdcPositionDateTypeType PositionDateType;
        /// <summary>
        ///平仓处理类型
        /// <summary>
        public TThostFtdcCloseDealTypeType CloseDealType;
    }

    /// <summary>
    ///合约
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInstrumentField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///合约名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string InstrumentName;
        /// <summary>
        ///合约在交易所的代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        ///产品代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
        /// <summary>
        ///产品类型
        /// <summary>
        public TThostFtdcProductClassType ProductClass;
        /// <summary>
        ///交割年份
        /// <summary>
        public int DeliveryYear;
        /// <summary>
        ///交割月
        /// <summary>
        public int DeliveryMonth;
        /// <summary>
        ///市价单最大下单量
        /// <summary>
        public int MaxMarketOrderVolume;
        /// <summary>
        ///市价单最小下单量
        /// <summary>
        public int MinMarketOrderVolume;
        /// <summary>
        ///限价单最大下单量
        /// <summary>
        public int MaxLimitOrderVolume;
        /// <summary>
        ///限价单最小下单量
        /// <summary>
        public int MinLimitOrderVolume;
        /// <summary>
        ///合约数量乘数
        /// <summary>
        public int VolumeMultiple;
        /// <summary>
        ///最小变动价位
        /// <summary>
        public double PriceTick;
        /// <summary>
        ///创建日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateDate;
        /// <summary>
        ///上市日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        /// <summary>
        ///到期日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExpireDate;
        /// <summary>
        ///开始交割日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDelivDate;
        /// <summary>
        ///结束交割日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EndDelivDate;
        /// <summary>
        ///合约生命周期状态
        /// <summary>
        public TThostFtdcInstLifePhaseType InstLifePhase;
        /// <summary>
        ///当前是否交易
        /// <summary>
        public int IsTrading;
        /// <summary>
        ///持仓类型
        /// <summary>
        public TThostFtdcPositionTypeType PositionType;
        /// <summary>
        ///持仓日期类型
        /// <summary>
        public TThostFtdcPositionDateTypeType PositionDateType;
        /// <summary>
        ///多头保证金率
        /// <summary>
        public double LongMarginRatio;
        /// <summary>
        ///空头保证金率
        /// <summary>
        public double ShortMarginRatio;
        /// <summary>
        ///是否使用大额单边保证金算法
        /// <summary>
    }

    /// <summary>
    ///经纪公司
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///经纪公司简称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BrokerAbbr;
        /// <summary>
        ///经纪公司名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string BrokerName;
        /// <summary>
        ///是否活跃
        /// <summary>
        public int IsActive;
    }

    /// <summary>
    ///交易所交易员
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTraderField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///安装数量
        /// <summary>
        public int InstallCount;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    ///投资者
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorField
    {
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者分组代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;
        /// <summary>
        ///投资者名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string InvestorName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdentifiedCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///是否活跃
        /// <summary>
        public int IsActive;
        /// <summary>
        ///联系电话
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        ///通讯地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        ///开户日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        /// <summary>
        ///手机
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Mobile;
        /// <summary>
        ///手续费率模板代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;
        /// <summary>
        ///保证金率模板代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;
    }

    /// <summary>
    ///交易编码
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingCodeField
    {
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///客户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        ///是否活跃
        /// <summary>
        public int IsActive;
        /// <summary>
        ///交易编码类型
        /// <summary>
        public TThostFtdcClientIDTypeType ClientIDType;
    }

    /// <summary>
    ///会员编码和经纪公司编码对照表
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcPartBrokerField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///是否活跃
        /// <summary>
        public int IsActive;
    }

    /// <summary>
    ///管理用户
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSuperUserField
    {
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///用户名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;
        /// <summary>
        ///密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///是否活跃
        /// <summary>
        public int IsActive;
    }

    /// <summary>
    ///管理用户功能权限
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSuperUserFunctionField
    {
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///功能代码
        /// <summary>
        public TThostFtdcFunctionCodeType FunctionCode;
    }

    /// <summary>
    ///投资者组
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorGroupField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者分组代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;
        /// <summary>
        ///投资者分组名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string InvestorGroupName;
    }

    /// <summary>
    ///资金账户
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingAccountField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///上次质押金额
        /// <summary>
        public double PreMortgage;
        /// <summary>
        ///上次信用额度
        /// <summary>
        public double PreCredit;
        /// <summary>
        ///上次存款额
        /// <summary>
        public double PreDeposit;
        /// <summary>
        ///上次结算准备金
        /// <summary>
        public double PreBalance;
        /// <summary>
        ///上次占用的保证金
        /// <summary>
        public double PreMargin;
        /// <summary>
        ///利息基数
        /// <summary>
        public double InterestBase;
        /// <summary>
        ///利息收入
        /// <summary>
        public double Interest;
        /// <summary>
        ///入金金额
        /// <summary>
        public double Deposit;
        /// <summary>
        ///出金金额
        /// <summary>
        public double Withdraw;
        /// <summary>
        ///冻结的保证金
        /// <summary>
        public double FrozenMargin;
        /// <summary>
        ///冻结的资金
        /// <summary>
        public double FrozenCash;
        /// <summary>
        ///冻结的手续费
        /// <summary>
        public double FrozenCommission;
        /// <summary>
        ///当前保证金总额
        /// <summary>
        public double CurrMargin;
        /// <summary>
        ///资金差额
        /// <summary>
        public double CashIn;
        /// <summary>
        ///手续费
        /// <summary>
        public double Commission;
        /// <summary>
        ///平仓盈亏
        /// <summary>
        public double CloseProfit;
        /// <summary>
        ///持仓盈亏
        /// <summary>
        public double PositionProfit;
        /// <summary>
        ///期货结算准备金
        /// <summary>
        public double Balance;
        /// <summary>
        ///可用资金
        /// <summary>
        public double Available;
        /// <summary>
        ///可取资金
        /// <summary>
        public double WithdrawQuota;
        /// <summary>
        ///基本准备金
        /// <summary>
        public double Reserve;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
        /// <summary>
        ///信用额度
        /// <summary>
        public double Credit;
        /// <summary>
        ///质押金额
        /// <summary>
        public double Mortgage;
        /// <summary>
        ///交易所保证金
        /// <summary>
        public double ExchangeMargin;
        /// <summary>
        ///投资者交割保证金
        /// <summary>
        public double DeliveryMargin;
        /// <summary>
        ///交易所交割保证金
        /// <summary>
        public double ExchangeDeliveryMargin;
        /// <summary>
        ///保底期货结算准备金
        /// <summary>
        public double ReserveBalance;
    }

    /// <summary>
    ///投资者持仓
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorPositionField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///持仓多空方向
        /// <summary>
        public TThostFtdcPosiDirectionType PosiDirection;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///持仓日期
        /// <summary>
        public TThostFtdcPositionDateType PositionDate;
        /// <summary>
        ///上日持仓
        /// <summary>
        public int YdPosition;
        /// <summary>
        ///今日持仓
        /// <summary>
        public int Position;
        /// <summary>
        ///多头冻结
        /// <summary>
        public int LongFrozen;
        /// <summary>
        ///空头冻结
        /// <summary>
        public int ShortFrozen;
        /// <summary>
        ///开仓冻结金额
        /// <summary>
        public double LongFrozenAmount;
        /// <summary>
        ///开仓冻结金额
        /// <summary>
        public double ShortFrozenAmount;
        /// <summary>
        ///开仓量
        /// <summary>
        public int OpenVolume;
        /// <summary>
        ///平仓量
        /// <summary>
        public int CloseVolume;
        /// <summary>
        ///开仓金额
        /// <summary>
        public double OpenAmount;
        /// <summary>
        ///平仓金额
        /// <summary>
        public double CloseAmount;
        /// <summary>
        ///持仓成本
        /// <summary>
        public double PositionCost;
        /// <summary>
        ///上次占用的保证金
        /// <summary>
        public double PreMargin;
        /// <summary>
        ///占用的保证金
        /// <summary>
        public double UseMargin;
        /// <summary>
        ///冻结的保证金
        /// <summary>
        public double FrozenMargin;
        /// <summary>
        ///冻结的资金
        /// <summary>
        public double FrozenCash;
        /// <summary>
        ///冻结的手续费
        /// <summary>
        public double FrozenCommission;
        /// <summary>
        ///资金差额
        /// <summary>
        public double CashIn;
        /// <summary>
        ///手续费
        /// <summary>
        public double Commission;
        /// <summary>
        ///平仓盈亏
        /// <summary>
        public double CloseProfit;
        /// <summary>
        ///持仓盈亏
        /// <summary>
        public double PositionProfit;
        /// <summary>
        ///上次结算价
        /// <summary>
        public double PreSettlementPrice;
        /// <summary>
        ///本次结算价
        /// <summary>
        public double SettlementPrice;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
        /// <summary>
        ///开仓成本
        /// <summary>
        public double OpenCost;
        /// <summary>
        ///交易所保证金
        /// <summary>
        public double ExchangeMargin;
        /// <summary>
        ///组合成交形成的持仓
        /// <summary>
        public int CombPosition;
        /// <summary>
        ///组合多头冻结
        /// <summary>
        public int CombLongFrozen;
        /// <summary>
        ///组合空头冻结
        /// <summary>
        public int CombShortFrozen;
        /// <summary>
        ///逐日盯市平仓盈亏
        /// <summary>
        public double CloseProfitByDate;
        /// <summary>
        ///逐笔对冲平仓盈亏
        /// <summary>
        public double CloseProfitByTrade;
        /// <summary>
        ///今日持仓
        /// <summary>
        public int TodayPosition;
        /// <summary>
        ///保证金率
        /// <summary>
        public double MarginRateByMoney;
        /// <summary>
        ///保证金率(按手数)
        /// <summary>
        public double MarginRateByVolume;
    }

    /// <summary>
    ///合约保证金率
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInstrumentMarginRateField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///投资者范围
        /// <summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///多头保证金率
        /// <summary>
        public double LongMarginRatioByMoney;
        /// <summary>
        ///多头保证金费
        /// <summary>
        public double LongMarginRatioByVolume;
        /// <summary>
        ///空头保证金率
        /// <summary>
        public double ShortMarginRatioByMoney;
        /// <summary>
        ///空头保证金费
        /// <summary>
        public double ShortMarginRatioByVolume;
        /// <summary>
        ///是否相对交易所收取
        /// <summary>
        public int IsRelative;
    }

    /// <summary>
    ///合约手续费率
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInstrumentCommissionRateField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///投资者范围
        /// <summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///开仓手续费率
        /// <summary>
        public double OpenRatioByMoney;
        /// <summary>
        ///开仓手续费
        /// <summary>
        public double OpenRatioByVolume;
        /// <summary>
        ///平仓手续费率
        /// <summary>
        public double CloseRatioByMoney;
        /// <summary>
        ///平仓手续费
        /// <summary>
        public double CloseRatioByVolume;
        /// <summary>
        ///平今手续费率
        /// <summary>
        public double CloseTodayRatioByMoney;
        /// <summary>
        ///平今手续费
        /// <summary>
        public double CloseTodayRatioByVolume;
    }

    /// <summary>
    ///深度行情
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcDepthMarketDataField
    {
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///合约在交易所的代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        ///最新价
        /// <summary>
        public double LastPrice;
        /// <summary>
        ///上次结算价
        /// <summary>
        public double PreSettlementPrice;
        /// <summary>
        ///昨收盘
        /// <summary>
        public double PreClosePrice;
        /// <summary>
        ///昨持仓量
        /// <summary>
        public double PreOpenInterest;
        /// <summary>
        ///今开盘
        /// <summary>
        public double OpenPrice;
        /// <summary>
        ///最高价
        /// <summary>
        public double HighestPrice;
        /// <summary>
        ///最低价
        /// <summary>
        public double LowestPrice;
        /// <summary>
        ///数量
        /// <summary>
        public int Volume;
        /// <summary>
        ///成交金额
        /// <summary>
        public double Turnover;
        /// <summary>
        ///持仓量
        /// <summary>
        public double OpenInterest;
        /// <summary>
        ///今收盘
        /// <summary>
        public double ClosePrice;
        /// <summary>
        ///本次结算价
        /// <summary>
        public double SettlementPrice;
        /// <summary>
        ///涨停板价
        /// <summary>
        public double UpperLimitPrice;
        /// <summary>
        ///跌停板价
        /// <summary>
        public double LowerLimitPrice;
        /// <summary>
        ///昨虚实度
        /// <summary>
        public double PreDelta;
        /// <summary>
        ///今虚实度
        /// <summary>
        public double CurrDelta;
        /// <summary>
        ///最后修改时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        /// <summary>
        ///最后修改毫秒
        /// <summary>
        public int UpdateMillisec;
        /// <summary>
        ///申买价一
        /// <summary>
        public double BidPrice1;
        /// <summary>
        ///申买量一
        /// <summary>
        public int BidVolume1;
        /// <summary>
        ///申卖价一
        /// <summary>
        public double AskPrice1;
        /// <summary>
        ///申卖量一
        /// <summary>
        public int AskVolume1;
        /// <summary>
        ///申买价二
        /// <summary>
        public double BidPrice2;
        /// <summary>
        ///申买量二
        /// <summary>
        public int BidVolume2;
        /// <summary>
        ///申卖价二
        /// <summary>
        public double AskPrice2;
        /// <summary>
        ///申卖量二
        /// <summary>
        public int AskVolume2;
        /// <summary>
        ///申买价三
        /// <summary>
        public double BidPrice3;
        /// <summary>
        ///申买量三
        /// <summary>
        public int BidVolume3;
        /// <summary>
        ///申卖价三
        /// <summary>
        public double AskPrice3;
        /// <summary>
        ///申卖量三
        /// <summary>
        public int AskVolume3;
        /// <summary>
        ///申买价四
        /// <summary>
        public double BidPrice4;
        /// <summary>
        ///申买量四
        /// <summary>
        public int BidVolume4;
        /// <summary>
        ///申卖价四
        /// <summary>
        public double AskPrice4;
        /// <summary>
        ///申卖量四
        /// <summary>
        public int AskVolume4;
        /// <summary>
        ///申买价五
        /// <summary>
        public double BidPrice5;
        /// <summary>
        ///申买量五
        /// <summary>
        public int BidVolume5;
        /// <summary>
        ///申卖价五
        /// <summary>
        public double AskPrice5;
        /// <summary>
        ///申卖量五
        /// <summary>
        public int AskVolume5;
        /// <summary>
        ///当日均价
        /// <summary>
        public double AveragePrice;
        /// <summary>
        ///业务日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;
    }

    /// <summary>
    ///投资者合约交易权限
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInstrumentTradingRightField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///投资者范围
        /// <summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///交易权限
        /// <summary>
        public TThostFtdcTradingRightType TradingRight;
    }

    /// <summary>
    ///经纪公司用户
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerUserField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///用户名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;
        /// <summary>
        ///用户类型
        /// <summary>
        public TThostFtdcUserTypeType UserType;
        /// <summary>
        ///是否活跃
        /// <summary>
        public int IsActive;
        /// <summary>
        ///是否使用令牌
        /// <summary>
        public int IsUsingOTP;
    }

    /// <summary>
    ///经纪公司用户口令
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerUserPasswordField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
    }

    /// <summary>
    ///经纪公司用户功能权限
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerUserFunctionField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///经纪公司功能代码
        /// <summary>
        public TThostFtdcBrokerFunctionCodeType BrokerFunctionCode;
    }

    /// <summary>
    ///交易所交易员报盘机
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTraderOfferField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///本地报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        ///交易所交易员连接状态
        /// <summary>
        public TThostFtdcTraderConnectStatusType TraderConnectStatus;
        /// <summary>
        ///发出连接请求的日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestDate;
        /// <summary>
        ///发出连接请求的时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestTime;
        /// <summary>
        ///上次报告日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportDate;
        /// <summary>
        ///上次报告时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportTime;
        /// <summary>
        ///完成连接日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectDate;
        /// <summary>
        ///完成连接时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectTime;
        /// <summary>
        ///启动日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDate;
        /// <summary>
        ///启动时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartTime;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///本席位最大成交编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MaxTradeID;
        /// <summary>
        ///本席位最大报单备拷
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string MaxOrderMessageReference;
    }

    /// <summary>
    ///投资者结算结果
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSettlementInfoField
    {
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///序号
        /// <summary>
        public int SequenceNo;
        /// <summary>
        ///消息正文
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string Content;
    }

    /// <summary>
    ///合约保证金率调整
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInstrumentMarginRateAdjustField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///投资者范围
        /// <summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///多头保证金率
        /// <summary>
        public double LongMarginRatioByMoney;
        /// <summary>
        ///多头保证金费
        /// <summary>
        public double LongMarginRatioByVolume;
        /// <summary>
        ///空头保证金率
        /// <summary>
        public double ShortMarginRatioByMoney;
        /// <summary>
        ///空头保证金费
        /// <summary>
        public double ShortMarginRatioByVolume;
        /// <summary>
        ///是否相对交易所收取
        /// <summary>
        public int IsRelative;
    }

    /// <summary>
    ///交易所保证金率
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeMarginRateField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///多头保证金率
        /// <summary>
        public double LongMarginRatioByMoney;
        /// <summary>
        ///多头保证金费
        /// <summary>
        public double LongMarginRatioByVolume;
        /// <summary>
        ///空头保证金率
        /// <summary>
        public double ShortMarginRatioByMoney;
        /// <summary>
        ///空头保证金费
        /// <summary>
        public double ShortMarginRatioByVolume;
    }

    /// <summary>
    ///交易所保证金率调整
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeMarginRateAdjustField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///跟随交易所投资者多头保证金率
        /// <summary>
        public double LongMarginRatioByMoney;
        /// <summary>
        ///跟随交易所投资者多头保证金费
        /// <summary>
        public double LongMarginRatioByVolume;
        /// <summary>
        ///跟随交易所投资者空头保证金率
        /// <summary>
        public double ShortMarginRatioByMoney;
        /// <summary>
        ///跟随交易所投资者空头保证金费
        /// <summary>
        public double ShortMarginRatioByVolume;
        /// <summary>
        ///交易所多头保证金率
        /// <summary>
        public double ExchLongMarginRatioByMoney;
        /// <summary>
        ///交易所多头保证金费
        /// <summary>
        public double ExchLongMarginRatioByVolume;
        /// <summary>
        ///交易所空头保证金率
        /// <summary>
        public double ExchShortMarginRatioByMoney;
        /// <summary>
        ///交易所空头保证金费
        /// <summary>
        public double ExchShortMarginRatioByVolume;
        /// <summary>
        ///不跟随交易所投资者多头保证金率
        /// <summary>
        public double NoLongMarginRatioByMoney;
        /// <summary>
        ///不跟随交易所投资者多头保证金费
        /// <summary>
        public double NoLongMarginRatioByVolume;
        /// <summary>
        ///不跟随交易所投资者空头保证金率
        /// <summary>
        public double NoShortMarginRatioByMoney;
        /// <summary>
        ///不跟随交易所投资者空头保证金费
        /// <summary>
        public double NoShortMarginRatioByVolume;
    }

    /// <summary>
    ///结算引用
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSettlementRefField
    {
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
    }

    /// <summary>
    ///当前时间
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCurrentTimeField
    {
        /// <summary>
        ///当前日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CurrDate;
        /// <summary>
        ///当前时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CurrTime;
        /// <summary>
        ///当前时间（毫秒）
        /// <summary>
        public int CurrMillisec;
        /// <summary>
        ///业务日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;
    }

    /// <summary>
    ///通讯阶段
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCommPhaseField
    {
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///通讯时段编号
        /// <summary>
        public short CommPhaseNo;
        /// <summary>
        ///系统编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string SystemID;
    }

    /// <summary>
    ///登录信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcLoginInfoField
    {
        /// <summary>
        ///前置编号
        /// <summary>
        public int FrontID;
        /// <summary>
        ///会话编号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///登录日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginDate;
        /// <summary>
        ///登录时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;
        /// <summary>
        ///IP地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        /// <summary>
        ///用户端产品信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        ///接口端产品信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;
        /// <summary>
        ///协议信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;
        /// <summary>
        ///系统名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;
        /// <summary>
        ///密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///最大报单引用
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MaxOrderRef;
        /// <summary>
        ///上期所时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SHFETime;
        /// <summary>
        ///大商所时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string DCETime;
        /// <summary>
        ///郑商所时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CZCETime;
        /// <summary>
        ///中金所时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string FFEXTime;
        /// <summary>
        ///Mac地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        /// <summary>
        ///动态密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OneTimePassword;
    }

    /// <summary>
    ///登录信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcLogoutAllField
    {
        /// <summary>
        ///前置编号
        /// <summary>
        public int FrontID;
        /// <summary>
        ///会话编号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///系统名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;
    }

    /// <summary>
    ///前置状态
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcFrontStatusField
    {
        /// <summary>
        ///前置编号
        /// <summary>
        public int FrontID;
        /// <summary>
        ///上次报告日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportDate;
        /// <summary>
        ///上次报告时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportTime;
        /// <summary>
        ///是否活跃
        /// <summary>
        public int IsActive;
    }

    /// <summary>
    ///用户口令变更
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcUserPasswordUpdateField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///原来的口令
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;
        /// <summary>
        ///新的口令
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;
    }

    /// <summary>
    ///输入报单
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInputOrderField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///报单引用
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///报单价格条件
        /// <summary>
        public TThostFtdcOrderPriceTypeType OrderPriceType;
        /// <summary>
        ///买卖方向
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///组合开平标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        //public TThostFtdcOffsetFlagType CombOffsetFlag_0;
        //public TThostFtdcOffsetFlagType CombOffsetFlag_1;
        //public TThostFtdcOffsetFlagType CombOffsetFlag_2;
        //public TThostFtdcOffsetFlagType CombOffsetFlag_3;
        //public TThostFtdcOffsetFlagType CombOffsetFlag_4;
        //public TThostFtdcOffsetFlagType CombOffsetFlag_5;
        //public TThostFtdcOffsetFlagType CombOffsetFlag_6;


        /// <summary>
        ///组合投机套保标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        //public TThostFtdcHedgeFlagType CombHedgeFlag_0;
        //public TThostFtdcHedgeFlagType CombHedgeFlag_1;
        //public TThostFtdcHedgeFlagType CombHedgeFlag_2;


        /// <summary>
        ///价格
        /// <summary>
        public double LimitPrice;
        /// <summary>
        ///数量
        /// <summary>
        public int VolumeTotalOriginal;
        /// <summary>
        ///有效期类型
        /// <summary>
        public TThostFtdcTimeConditionType TimeCondition;
        /// <summary>
        ///GTD日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        /// <summary>
        ///成交量类型
        /// <summary>
        public TThostFtdcVolumeConditionType VolumeCondition;
        /// <summary>
        ///最小成交量
        /// <summary>
        public int MinVolume;
        /// <summary>
        ///触发条件
        /// <summary>
        public TThostFtdcContingentConditionType ContingentCondition;
        /// <summary>
        ///止损价
        /// <summary>
        public double StopPrice;
        /// <summary>
        ///强平原因
        /// <summary>
        public TThostFtdcForceCloseReasonType ForceCloseReason;
        /// <summary>
        ///自动挂起标志
        /// <summary>
        public int IsAutoSuspend;
        /// <summary>
        ///业务单元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///用户强评标志
        /// <summary>
        public int UserForceClose;
        /// <summary>
        ///互换单标志
        /// <summary>
        public int IsSwapOrder;
    }

    /// <summary>
    ///报单
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcOrderField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///报单引用
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///报单价格条件
        /// <summary>
        public TThostFtdcOrderPriceTypeType OrderPriceType;
        /// <summary>
        ///买卖方向
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///组合开平标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        /// <summary>
        ///组合投机套保标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        /// <summary>
        ///价格
        /// <summary>
        public double LimitPrice;
        /// <summary>
        ///数量
        /// <summary>
        public int VolumeTotalOriginal;
        /// <summary>
        ///有效期类型
        /// <summary>
        public TThostFtdcTimeConditionType TimeCondition;
        /// <summary>
        ///GTD日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        /// <summary>
        ///成交量类型
        /// <summary>
        public TThostFtdcVolumeConditionType VolumeCondition;
        /// <summary>
        ///最小成交量
        /// <summary>
        public int MinVolume;
        /// <summary>
        ///触发条件
        /// <summary>
        public TThostFtdcContingentConditionType ContingentCondition;
        /// <summary>
        ///止损价
        /// <summary>
        public double StopPrice;
        /// <summary>
        ///强平原因
        /// <summary>
        public TThostFtdcForceCloseReasonType ForceCloseReason;
        /// <summary>
        ///自动挂起标志
        /// <summary>
        public int IsAutoSuspend;
        /// <summary>
        ///业务单元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///本地报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///客户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        ///合约在交易所的代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///报单提交状态
        /// <summary>
        public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
        /// <summary>
        ///报单提示序号
        /// <summary>
        public int NotifySequence;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
        /// <summary>
        ///报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        ///报单来源
        /// <summary>
        public TThostFtdcOrderSourceType OrderSource;
        /// <summary>
        ///报单状态
        /// <summary>
        public TThostFtdcOrderStatusType OrderStatus;
        /// <summary>
        ///报单类型
        /// <summary>
        public TThostFtdcOrderTypeType OrderType;
        /// <summary>
        ///今成交数量
        /// <summary>
        public int VolumeTraded;
        /// <summary>
        ///剩余数量
        /// <summary>
        public int VolumeTotal;
        /// <summary>
        ///报单日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        /// <summary>
        ///委托时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        /// <summary>
        ///激活时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActiveTime;
        /// <summary>
        ///挂起时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SuspendTime;
        /// <summary>
        ///最后修改时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        /// <summary>
        ///撤销时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        /// <summary>
        ///最后修改交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;
        /// <summary>
        ///结算会员编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        /// <summary>
        ///序号
        /// <summary>
        public int SequenceNo;
        /// <summary>
        ///前置编号
        /// <summary>
        public int FrontID;
        /// <summary>
        ///会话编号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///用户端产品信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        ///状态信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        /// <summary>
        ///用户强评标志
        /// <summary>
        public int UserForceClose;
        /// <summary>
        ///操作用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;
        /// <summary>
        ///经纪公司报单编号
        /// <summary>
        public int BrokerOrderSeq;
        /// <summary>
        ///相关报单
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string RelativeOrderSysID;
        /// <summary>
        ///郑商所成交数量
        /// <summary>
        public int ZCETotalTradedVolume;
        /// <summary>
        ///互换单标志
        /// <summary>
        public int IsSwapOrder;
    }

    /// <summary>
    ///交易所报单
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeOrderField
    {
        /// <summary>
        ///报单价格条件
        /// <summary>
        public TThostFtdcOrderPriceTypeType OrderPriceType;
        /// <summary>
        ///买卖方向
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///组合开平标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        /// <summary>
        ///组合投机套保标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        /// <summary>
        ///价格
        /// <summary>
        public double LimitPrice;
        /// <summary>
        ///数量
        /// <summary>
        public int VolumeTotalOriginal;
        /// <summary>
        ///有效期类型
        /// <summary>
        public TThostFtdcTimeConditionType TimeCondition;
        /// <summary>
        ///GTD日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        /// <summary>
        ///成交量类型
        /// <summary>
        public TThostFtdcVolumeConditionType VolumeCondition;
        /// <summary>
        ///最小成交量
        /// <summary>
        public int MinVolume;
        /// <summary>
        ///触发条件
        /// <summary>
        public TThostFtdcContingentConditionType ContingentCondition;
        /// <summary>
        ///止损价
        /// <summary>
        public double StopPrice;
        /// <summary>
        ///强平原因
        /// <summary>
        public TThostFtdcForceCloseReasonType ForceCloseReason;
        /// <summary>
        ///自动挂起标志
        /// <summary>
        public int IsAutoSuspend;
        /// <summary>
        ///业务单元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///本地报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///客户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        ///合约在交易所的代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///报单提交状态
        /// <summary>
        public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
        /// <summary>
        ///报单提示序号
        /// <summary>
        public int NotifySequence;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
        /// <summary>
        ///报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        ///报单来源
        /// <summary>
        public TThostFtdcOrderSourceType OrderSource;
        /// <summary>
        ///报单状态
        /// <summary>
        public TThostFtdcOrderStatusType OrderStatus;
        /// <summary>
        ///报单类型
        /// <summary>
        public TThostFtdcOrderTypeType OrderType;
        /// <summary>
        ///今成交数量
        /// <summary>
        public int VolumeTraded;
        /// <summary>
        ///剩余数量
        /// <summary>
        public int VolumeTotal;
        /// <summary>
        ///报单日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        /// <summary>
        ///委托时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        /// <summary>
        ///激活时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActiveTime;
        /// <summary>
        ///挂起时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SuspendTime;
        /// <summary>
        ///最后修改时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        /// <summary>
        ///撤销时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        /// <summary>
        ///最后修改交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;
        /// <summary>
        ///结算会员编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        /// <summary>
        ///序号
        /// <summary>
        public int SequenceNo;
    }

    /// <summary>
    ///交易所报单插入失败
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeOrderInsertErrorField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///本地报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///输入报单操作
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInputOrderActionField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///报单操作引用
        /// <summary>
        public int OrderActionRef;
        /// <summary>
        ///报单引用
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///前置编号
        /// <summary>
        public int FrontID;
        /// <summary>
        ///会话编号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        ///操作标志
        /// <summary>
        public TThostFtdcActionFlagType ActionFlag;
        /// <summary>
        ///价格
        /// <summary>
        public double LimitPrice;
        /// <summary>
        ///数量变化
        /// <summary>
        public int VolumeChange;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    ///报单操作
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcOrderActionField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///报单操作引用
        /// <summary>
        public int OrderActionRef;
        /// <summary>
        ///报单引用
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///前置编号
        /// <summary>
        public int FrontID;
        /// <summary>
        ///会话编号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        ///操作标志
        /// <summary>
        public TThostFtdcActionFlagType ActionFlag;
        /// <summary>
        ///价格
        /// <summary>
        public double LimitPrice;
        /// <summary>
        ///数量变化
        /// <summary>
        public int VolumeChange;
        /// <summary>
        ///操作日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        /// <summary>
        ///操作时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///本地报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        ///操作本地编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///客户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        ///业务单元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        ///报单操作状态
        /// <summary>
        public TThostFtdcOrderActionStatusType OrderActionStatus;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///状态信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    ///交易所报单操作
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeOrderActionField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        ///操作标志
        /// <summary>
        public TThostFtdcActionFlagType ActionFlag;
        /// <summary>
        ///价格
        /// <summary>
        public double LimitPrice;
        /// <summary>
        ///数量变化
        /// <summary>
        public int VolumeChange;
        /// <summary>
        ///操作日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        /// <summary>
        ///操作时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///本地报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        ///操作本地编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///客户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        ///业务单元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        ///报单操作状态
        /// <summary>
        public TThostFtdcOrderActionStatusType OrderActionStatus;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    ///交易所报单操作失败
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeOrderActionErrorField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///本地报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        ///操作本地编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///交易所成交
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeTradeField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///成交编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        /// <summary>
        ///买卖方向
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///客户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        ///交易角色
        /// <summary>
        public TThostFtdcTradingRoleType TradingRole;
        /// <summary>
        ///合约在交易所的代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        ///开平标志
        /// <summary>
        public TThostFtdcOffsetFlagType OffsetFlag;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///价格
        /// <summary>
        public double Price;
        /// <summary>
        ///数量
        /// <summary>
        public int Volume;
        /// <summary>
        ///成交时期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///成交时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///成交类型
        /// <summary>
        public TThostFtdcTradeTypeType TradeType;
        /// <summary>
        ///成交价来源
        /// <summary>
        public TThostFtdcPriceSourceType PriceSource;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        ///本地报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        ///结算会员编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        /// <summary>
        ///业务单元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        ///序号
        /// <summary>
        public int SequenceNo;
        /// <summary>
        ///成交来源
        /// <summary>
        public TThostFtdcTradeSourceType TradeSource;
    }

    /// <summary>
    ///成交
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradeField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///报单引用
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///成交编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        /// <summary>
        ///买卖方向
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///客户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        ///交易角色
        /// <summary>
        public TThostFtdcTradingRoleType TradingRole;
        /// <summary>
        ///合约在交易所的代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        ///开平标志
        /// <summary>
        public TThostFtdcOffsetFlagType OffsetFlag;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///价格
        /// <summary>
        public double Price;
        /// <summary>
        ///数量
        /// <summary>
        public int Volume;
        /// <summary>
        ///成交时期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///成交时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///成交类型
        /// <summary>
        public TThostFtdcTradeTypeType TradeType;
        /// <summary>
        ///成交价来源
        /// <summary>
        public TThostFtdcPriceSourceType PriceSource;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        ///本地报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        ///结算会员编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        /// <summary>
        ///业务单元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        ///序号
        /// <summary>
        public int SequenceNo;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
        /// <summary>
        ///经纪公司报单编号
        /// <summary>
        public int BrokerOrderSeq;
        /// <summary>
        ///成交来源
        /// <summary>
        public TThostFtdcTradeSourceType TradeSource;
    }

    /// <summary>
    ///用户会话
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcUserSessionField
    {
        /// <summary>
        ///前置编号
        /// <summary>
        public int FrontID;
        /// <summary>
        ///会话编号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///登录日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginDate;
        /// <summary>
        ///登录时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;
        /// <summary>
        ///IP地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        /// <summary>
        ///用户端产品信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        ///接口端产品信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;
        /// <summary>
        ///协议信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;
        /// <summary>
        ///Mac地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }

    /// <summary>
    ///查询最大报单数量
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQueryMaxOrderVolumeField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///买卖方向
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///开平标志
        /// <summary>
        public TThostFtdcOffsetFlagType OffsetFlag;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///最大允许报单数量
        /// <summary>
        public int MaxVolume;
    }

    /// <summary>
    ///投资者结算结果确认信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSettlementInfoConfirmField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///确认日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConfirmDate;
        /// <summary>
        ///确认时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConfirmTime;
    }

    /// <summary>
    ///出入金同步
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncDepositField
    {
        /// <summary>
        ///出入金流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DepositSeqNo;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///入金金额
        /// <summary>
        public double Deposit;
        /// <summary>
        ///是否强制进行
        /// <summary>
        public int IsForce;
    }

    /// <summary>
    ///经纪公司同步
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerSyncField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    ///正在同步中的投资者
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingInvestorField
    {
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者分组代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;
        /// <summary>
        ///投资者名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string InvestorName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdentifiedCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///是否活跃
        /// <summary>
        public int IsActive;
        /// <summary>
        ///联系电话
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        ///通讯地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        ///开户日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        /// <summary>
        ///手机
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Mobile;
        /// <summary>
        ///手续费率模板代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;
        /// <summary>
        ///保证金率模板代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;
    }

    /// <summary>
    ///正在同步中的交易代码
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingTradingCodeField
    {
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///客户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        ///是否活跃
        /// <summary>
        public int IsActive;
        /// <summary>
        ///交易编码类型
        /// <summary>
        public TThostFtdcClientIDTypeType ClientIDType;
    }

    /// <summary>
    ///正在同步中的投资者分组
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingInvestorGroupField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者分组代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;
        /// <summary>
        ///投资者分组名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string InvestorGroupName;
    }

    /// <summary>
    ///正在同步中的交易账号
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingTradingAccountField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///上次质押金额
        /// <summary>
        public double PreMortgage;
        /// <summary>
        ///上次信用额度
        /// <summary>
        public double PreCredit;
        /// <summary>
        ///上次存款额
        /// <summary>
        public double PreDeposit;
        /// <summary>
        ///上次结算准备金
        /// <summary>
        public double PreBalance;
        /// <summary>
        ///上次占用的保证金
        /// <summary>
        public double PreMargin;
        /// <summary>
        ///利息基数
        /// <summary>
        public double InterestBase;
        /// <summary>
        ///利息收入
        /// <summary>
        public double Interest;
        /// <summary>
        ///入金金额
        /// <summary>
        public double Deposit;
        /// <summary>
        ///出金金额
        /// <summary>
        public double Withdraw;
        /// <summary>
        ///冻结的保证金
        /// <summary>
        public double FrozenMargin;
        /// <summary>
        ///冻结的资金
        /// <summary>
        public double FrozenCash;
        /// <summary>
        ///冻结的手续费
        /// <summary>
        public double FrozenCommission;
        /// <summary>
        ///当前保证金总额
        /// <summary>
        public double CurrMargin;
        /// <summary>
        ///资金差额
        /// <summary>
        public double CashIn;
        /// <summary>
        ///手续费
        /// <summary>
        public double Commission;
        /// <summary>
        ///平仓盈亏
        /// <summary>
        public double CloseProfit;
        /// <summary>
        ///持仓盈亏
        /// <summary>
        public double PositionProfit;
        /// <summary>
        ///期货结算准备金
        /// <summary>
        public double Balance;
        /// <summary>
        ///可用资金
        /// <summary>
        public double Available;
        /// <summary>
        ///可取资金
        /// <summary>
        public double WithdrawQuota;
        /// <summary>
        ///基本准备金
        /// <summary>
        public double Reserve;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
        /// <summary>
        ///信用额度
        /// <summary>
        public double Credit;
        /// <summary>
        ///质押金额
        /// <summary>
        public double Mortgage;
        /// <summary>
        ///交易所保证金
        /// <summary>
        public double ExchangeMargin;
        /// <summary>
        ///投资者交割保证金
        /// <summary>
        public double DeliveryMargin;
        /// <summary>
        ///交易所交割保证金
        /// <summary>
        public double ExchangeDeliveryMargin;
        /// <summary>
        ///保底期货结算准备金
        /// <summary>
        public double ReserveBalance;
    }

    /// <summary>
    ///正在同步中的投资者持仓
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingInvestorPositionField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///持仓多空方向
        /// <summary>
        public TThostFtdcPosiDirectionType PosiDirection;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///持仓日期
        /// <summary>
        public TThostFtdcPositionDateType PositionDate;
        /// <summary>
        ///上日持仓
        /// <summary>
        public int YdPosition;
        /// <summary>
        ///今日持仓
        /// <summary>
        public int Position;
        /// <summary>
        ///多头冻结
        /// <summary>
        public int LongFrozen;
        /// <summary>
        ///空头冻结
        /// <summary>
        public int ShortFrozen;
        /// <summary>
        ///开仓冻结金额
        /// <summary>
        public double LongFrozenAmount;
        /// <summary>
        ///开仓冻结金额
        /// <summary>
        public double ShortFrozenAmount;
        /// <summary>
        ///开仓量
        /// <summary>
        public int OpenVolume;
        /// <summary>
        ///平仓量
        /// <summary>
        public int CloseVolume;
        /// <summary>
        ///开仓金额
        /// <summary>
        public double OpenAmount;
        /// <summary>
        ///平仓金额
        /// <summary>
        public double CloseAmount;
        /// <summary>
        ///持仓成本
        /// <summary>
        public double PositionCost;
        /// <summary>
        ///上次占用的保证金
        /// <summary>
        public double PreMargin;
        /// <summary>
        ///占用的保证金
        /// <summary>
        public double UseMargin;
        /// <summary>
        ///冻结的保证金
        /// <summary>
        public double FrozenMargin;
        /// <summary>
        ///冻结的资金
        /// <summary>
        public double FrozenCash;
        /// <summary>
        ///冻结的手续费
        /// <summary>
        public double FrozenCommission;
        /// <summary>
        ///资金差额
        /// <summary>
        public double CashIn;
        /// <summary>
        ///手续费
        /// <summary>
        public double Commission;
        /// <summary>
        ///平仓盈亏
        /// <summary>
        public double CloseProfit;
        /// <summary>
        ///持仓盈亏
        /// <summary>
        public double PositionProfit;
        /// <summary>
        ///上次结算价
        /// <summary>
        public double PreSettlementPrice;
        /// <summary>
        ///本次结算价
        /// <summary>
        public double SettlementPrice;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
        /// <summary>
        ///开仓成本
        /// <summary>
        public double OpenCost;
        /// <summary>
        ///交易所保证金
        /// <summary>
        public double ExchangeMargin;
        /// <summary>
        ///组合成交形成的持仓
        /// <summary>
        public int CombPosition;
        /// <summary>
        ///组合多头冻结
        /// <summary>
        public int CombLongFrozen;
        /// <summary>
        ///组合空头冻结
        /// <summary>
        public int CombShortFrozen;
        /// <summary>
        ///逐日盯市平仓盈亏
        /// <summary>
        public double CloseProfitByDate;
        /// <summary>
        ///逐笔对冲平仓盈亏
        /// <summary>
        public double CloseProfitByTrade;
        /// <summary>
        ///今日持仓
        /// <summary>
        public int TodayPosition;
        /// <summary>
        ///保证金率
        /// <summary>
        public double MarginRateByMoney;
        /// <summary>
        ///保证金率(按手数)
        /// <summary>
        public double MarginRateByVolume;
    }

    /// <summary>
    ///正在同步中的合约保证金率
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingInstrumentMarginRateField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///投资者范围
        /// <summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///多头保证金率
        /// <summary>
        public double LongMarginRatioByMoney;
        /// <summary>
        ///多头保证金费
        /// <summary>
        public double LongMarginRatioByVolume;
        /// <summary>
        ///空头保证金率
        /// <summary>
        public double ShortMarginRatioByMoney;
        /// <summary>
        ///空头保证金费
        /// <summary>
        public double ShortMarginRatioByVolume;
        /// <summary>
        ///是否相对交易所收取
        /// <summary>
        public int IsRelative;
    }

    /// <summary>
    ///正在同步中的合约手续费率
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingInstrumentCommissionRateField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///投资者范围
        /// <summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///开仓手续费率
        /// <summary>
        public double OpenRatioByMoney;
        /// <summary>
        ///开仓手续费
        /// <summary>
        public double OpenRatioByVolume;
        /// <summary>
        ///平仓手续费率
        /// <summary>
        public double CloseRatioByMoney;
        /// <summary>
        ///平仓手续费
        /// <summary>
        public double CloseRatioByVolume;
        /// <summary>
        ///平今手续费率
        /// <summary>
        public double CloseTodayRatioByMoney;
        /// <summary>
        ///平今手续费
        /// <summary>
        public double CloseTodayRatioByVolume;
    }

    /// <summary>
    ///正在同步中的合约交易权限
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncingInstrumentTradingRightField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///投资者范围
        /// <summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///交易权限
        /// <summary>
        public TThostFtdcTradingRightType TradingRight;
    }

    /// <summary>
    ///查询报单
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryOrderField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        ///开始时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;
        /// <summary>
        ///结束时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;
    }

    /// <summary>
    ///查询成交
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTradeField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///成交编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        /// <summary>
        ///开始时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTimeStart;
        /// <summary>
        ///结束时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTimeEnd;
    }

    /// <summary>
    ///查询投资者持仓
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInvestorPositionField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    ///查询资金账户
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTradingAccountField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    ///查询投资者
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInvestorField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    ///查询交易编码
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTradingCodeField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///客户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        ///交易编码类型
        /// <summary>
        public TThostFtdcClientIDTypeType ClientIDType;
    }

    /// <summary>
    ///投资者组
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInvestorGroupField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    ///查询合约保证金率
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInstrumentMarginRateField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
    }

    /// <summary>
    ///查询手续费率
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInstrumentCommissionRateField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    ///查询合约交易权限
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInstrumentTradingRightField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    ///查询经纪公司
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryBrokerField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    ///查询交易员
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTraderField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }

    /// <summary>
    ///查询管理用户功能权限
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQrySuperUserFunctionField
    {
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    ///查询用户会话
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryUserSessionField
    {
        /// <summary>
        ///前置编号
        /// <summary>
        public int FrontID;
        /// <summary>
        ///会话编号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    ///查询经纪公司会员代码
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryPartBrokerField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
    }

    /// <summary>
    ///查询前置状态
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryFrontStatusField
    {
        /// <summary>
        ///前置编号
        /// <summary>
        public int FrontID;
    }

    /// <summary>
    ///查询交易所报单
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryExchangeOrderField
    {
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///客户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        ///合约在交易所的代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }

    /// <summary>
    ///查询报单操作
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryOrderActionField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }

    /// <summary>
    ///查询交易所报单操作
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryExchangeOrderActionField
    {
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///客户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }

    /// <summary>
    ///查询管理用户
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQrySuperUserField
    {
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    ///查询交易所
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryExchangeField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }

    /// <summary>
    ///查询产品
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryProductField
    {
        /// <summary>
        ///产品代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
    }

    /// <summary>
    ///查询合约
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInstrumentField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///合约在交易所的代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        ///产品代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
    }

    /// <summary>
    ///查询行情
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryDepthMarketDataField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    ///查询经纪公司用户
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryBrokerUserField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    ///查询经纪公司用户权限
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryBrokerUserFunctionField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    ///查询交易员报盘机
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTraderOfferField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }

    /// <summary>
    ///查询出入金流水
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQrySyncDepositField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///出入金流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DepositSeqNo;
    }

    /// <summary>
    ///查询投资者结算结果
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQrySettlementInfoField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
    }

    /// <summary>
    ///查询交易所保证金率
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryExchangeMarginRateField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
    }

    /// <summary>
    ///查询交易所调整保证金率
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryExchangeMarginRateAdjustField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
    }

    /// <summary>
    ///查询报单
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryHisOrderField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        ///开始时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;
        /// <summary>
        ///结束时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
    }

    /// <summary>
    ///市场行情
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataField
    {
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///合约在交易所的代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        ///最新价
        /// <summary>
        public double LastPrice;
        /// <summary>
        ///上次结算价
        /// <summary>
        public double PreSettlementPrice;
        /// <summary>
        ///昨收盘
        /// <summary>
        public double PreClosePrice;
        /// <summary>
        ///昨持仓量
        /// <summary>
        public double PreOpenInterest;
        /// <summary>
        ///今开盘
        /// <summary>
        public double OpenPrice;
        /// <summary>
        ///最高价
        /// <summary>
        public double HighestPrice;
        /// <summary>
        ///最低价
        /// <summary>
        public double LowestPrice;
        /// <summary>
        ///数量
        /// <summary>
        public int Volume;
        /// <summary>
        ///成交金额
        /// <summary>
        public double Turnover;
        /// <summary>
        ///持仓量
        /// <summary>
        public double OpenInterest;
        /// <summary>
        ///今收盘
        /// <summary>
        public double ClosePrice;
        /// <summary>
        ///本次结算价
        /// <summary>
        public double SettlementPrice;
        /// <summary>
        ///涨停板价
        /// <summary>
        public double UpperLimitPrice;
        /// <summary>
        ///跌停板价
        /// <summary>
        public double LowerLimitPrice;
        /// <summary>
        ///昨虚实度
        /// <summary>
        public double PreDelta;
        /// <summary>
        ///今虚实度
        /// <summary>
        public double CurrDelta;
        /// <summary>
        ///最后修改时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        /// <summary>
        ///最后修改毫秒
        /// <summary>
        public int UpdateMillisec;
        /// <summary>
        ///业务日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;
    }

    /// <summary>
    ///行情基础属性
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataBaseField
    {
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///上次结算价
        /// <summary>
        public double PreSettlementPrice;
        /// <summary>
        ///昨收盘
        /// <summary>
        public double PreClosePrice;
        /// <summary>
        ///昨持仓量
        /// <summary>
        public double PreOpenInterest;
        /// <summary>
        ///昨虚实度
        /// <summary>
        public double PreDelta;
    }

    /// <summary>
    ///行情静态属性
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataStaticField
    {
        /// <summary>
        ///今开盘
        /// <summary>
        public double OpenPrice;
        /// <summary>
        ///最高价
        /// <summary>
        public double HighestPrice;
        /// <summary>
        ///最低价
        /// <summary>
        public double LowestPrice;
        /// <summary>
        ///今收盘
        /// <summary>
        public double ClosePrice;
        /// <summary>
        ///涨停板价
        /// <summary>
        public double UpperLimitPrice;
        /// <summary>
        ///跌停板价
        /// <summary>
        public double LowerLimitPrice;
        /// <summary>
        ///本次结算价
        /// <summary>
        public double SettlementPrice;
        /// <summary>
        ///今虚实度
        /// <summary>
        public double CurrDelta;
    }

    /// <summary>
    ///行情最新成交属性
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataLastMatchField
    {
        /// <summary>
        ///最新价
        /// <summary>
        public double LastPrice;
        /// <summary>
        ///数量
        /// <summary>
        public int Volume;
        /// <summary>
        ///成交金额
        /// <summary>
        public double Turnover;
        /// <summary>
        ///持仓量
        /// <summary>
        public double OpenInterest;
    }

    /// <summary>
    ///行情最优价属性
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataBestPriceField
    {
        /// <summary>
        ///申买价一
        /// <summary>
        public double BidPrice1;
        /// <summary>
        ///申买量一
        /// <summary>
        public int BidVolume1;
        /// <summary>
        ///申卖价一
        /// <summary>
        public double AskPrice1;
        /// <summary>
        ///申卖量一
        /// <summary>
        public int AskVolume1;
    }

    /// <summary>
    ///行情申买二、三属性
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataBid23Field
    {
        /// <summary>
        ///申买价二
        /// <summary>
        public double BidPrice2;
        /// <summary>
        ///申买量二
        /// <summary>
        public int BidVolume2;
        /// <summary>
        ///申买价三
        /// <summary>
        public double BidPrice3;
        /// <summary>
        ///申买量三
        /// <summary>
        public int BidVolume3;
    }

    /// <summary>
    ///行情申卖二、三属性
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataAsk23Field
    {
        /// <summary>
        ///申卖价二
        /// <summary>
        public double AskPrice2;
        /// <summary>
        ///申卖量二
        /// <summary>
        public int AskVolume2;
        /// <summary>
        ///申卖价三
        /// <summary>
        public double AskPrice3;
        /// <summary>
        ///申卖量三
        /// <summary>
        public int AskVolume3;
    }

    /// <summary>
    ///行情申买四、五属性
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataBid45Field
    {
        /// <summary>
        ///申买价四
        /// <summary>
        public double BidPrice4;
        /// <summary>
        ///申买量四
        /// <summary>
        public int BidVolume4;
        /// <summary>
        ///申买价五
        /// <summary>
        public double BidPrice5;
        /// <summary>
        ///申买量五
        /// <summary>
        public int BidVolume5;
    }

    /// <summary>
    ///行情申卖四、五属性
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataAsk45Field
    {
        /// <summary>
        ///申卖价四
        /// <summary>
        public double AskPrice4;
        /// <summary>
        ///申卖量四
        /// <summary>
        public int AskVolume4;
        /// <summary>
        ///申卖价五
        /// <summary>
        public double AskPrice5;
        /// <summary>
        ///申卖量五
        /// <summary>
        public int AskVolume5;
    }

    /// <summary>
    ///行情更新时间属性
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataUpdateTimeField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///最后修改时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        /// <summary>
        ///最后修改毫秒
        /// <summary>
        public int UpdateMillisec;
        /// <summary>
        ///业务日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;
    }

    /// <summary>
    ///行情交易所代码属性
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataExchangeField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }

    /// <summary>
    ///指定的合约
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSpecificInstrumentField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    ///合约状态
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInstrumentStatusField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///合约在交易所的代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        ///结算组代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SettlementGroupID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///合约交易状态
        /// <summary>
        public TThostFtdcInstrumentStatusType InstrumentStatus;
        /// <summary>
        ///交易阶段编号
        /// <summary>
        public int TradingSegmentSN;
        /// <summary>
        ///进入本状态时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EnterTime;
        /// <summary>
        ///进入本状态原因
        /// <summary>
        public TThostFtdcInstStatusEnterReasonType EnterReason;
    }

    /// <summary>
    ///查询合约状态
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInstrumentStatusField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///合约在交易所的代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
    }

    /// <summary>
    ///投资者账户
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorAccountField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
    }

    /// <summary>
    ///浮动盈亏算法
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcPositionProfitAlgorithmField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///盈亏算法
        /// <summary>
        public TThostFtdcAlgorithmType Algorithm;
        /// <summary>
        ///备注
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string Memo;
    }

    /// <summary>
    ///会员资金折扣
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcDiscountField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者范围
        /// <summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///资金折扣比例
        /// <summary>
        public double Discount;
    }

    /// <summary>
    ///查询转帐银行
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTransferBankField
    {
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分中心代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
    }

    /// <summary>
    ///转帐银行
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferBankField
    {
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分中心代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
        /// <summary>
        ///银行名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string BankName;
        /// <summary>
        ///是否活跃
        /// <summary>
        public int IsActive;
    }

    /// <summary>
    ///查询投资者持仓明细
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInvestorPositionDetailField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    ///投资者持仓明细
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorPositionDetailField
    {
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///买卖
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///开仓日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        /// <summary>
        ///成交编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        /// <summary>
        ///数量
        /// <summary>
        public int Volume;
        /// <summary>
        ///开仓价
        /// <summary>
        public double OpenPrice;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
        /// <summary>
        ///成交类型
        /// <summary>
        public TThostFtdcTradeTypeType TradeType;
        /// <summary>
        ///组合合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///逐日盯市平仓盈亏
        /// <summary>
        public double CloseProfitByDate;
        /// <summary>
        ///逐笔对冲平仓盈亏
        /// <summary>
        public double CloseProfitByTrade;
        /// <summary>
        ///逐日盯市持仓盈亏
        /// <summary>
        public double PositionProfitByDate;
        /// <summary>
        ///逐笔对冲持仓盈亏
        /// <summary>
        public double PositionProfitByTrade;
        /// <summary>
        ///投资者保证金
        /// <summary>
        public double Margin;
        /// <summary>
        ///交易所保证金
        /// <summary>
        public double ExchMargin;
        /// <summary>
        ///保证金率
        /// <summary>
        public double MarginRateByMoney;
        /// <summary>
        ///保证金率(按手数)
        /// <summary>
        public double MarginRateByVolume;
        /// <summary>
        ///昨结算价
        /// <summary>
        public double LastSettlementPrice;
        /// <summary>
        ///结算价
        /// <summary>
        public double SettlementPrice;
        /// <summary>
        ///平仓量
        /// <summary>
        public int CloseVolume;
        /// <summary>
        ///平仓金额
        /// <summary>
        public double CloseAmount;
    }

    /// <summary>
    ///资金账户口令域
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingAccountPasswordField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
    }

    /// <summary>
    ///交易所行情报盘机
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMDTraderOfferField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///本地报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        ///交易所交易员连接状态
        /// <summary>
        public TThostFtdcTraderConnectStatusType TraderConnectStatus;
        /// <summary>
        ///发出连接请求的日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestDate;
        /// <summary>
        ///发出连接请求的时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestTime;
        /// <summary>
        ///上次报告日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportDate;
        /// <summary>
        ///上次报告时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportTime;
        /// <summary>
        ///完成连接日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectDate;
        /// <summary>
        ///完成连接时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectTime;
        /// <summary>
        ///启动日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDate;
        /// <summary>
        ///启动时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartTime;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///本席位最大成交编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MaxTradeID;
        /// <summary>
        ///本席位最大报单备拷
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string MaxOrderMessageReference;
    }

    /// <summary>
    ///查询行情报盘机
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryMDTraderOfferField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }

    /// <summary>
    ///查询客户通知
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryNoticeField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    ///客户通知
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcNoticeField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///消息正文
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string Content;
        /// <summary>
        ///经纪公司通知内容序列号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        public string SequenceLabel;
    }

    /// <summary>
    ///用户权限
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcUserRightField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///客户权限类型
        /// <summary>
        public TThostFtdcUserRightTypeType UserRightType;
        /// <summary>
        ///是否禁止
        /// <summary>
        public int IsForbidden;
    }

    /// <summary>
    ///查询结算信息确认域
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQrySettlementInfoConfirmField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    ///装载结算信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcLoadSettlementInfoField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    ///经纪公司可提资金算法表
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerWithdrawAlgorithmField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///可提资金算法
        /// <summary>
        public TThostFtdcAlgorithmType WithdrawAlgorithm;
        /// <summary>
        ///资金使用率
        /// <summary>
        public double UsingRatio;
        /// <summary>
        ///可提是否包含平仓盈利
        /// <summary>
        public TThostFtdcIncludeCloseProfitType IncludeCloseProfit;
        /// <summary>
        ///本日无仓且无成交客户是否受可提比例限制
        /// <summary>
        public TThostFtdcAllWithoutTradeType AllWithoutTrade;
        /// <summary>
        ///可用是否包含平仓盈利
        /// <summary>
        public TThostFtdcIncludeCloseProfitType AvailIncludeCloseProfit;
        /// <summary>
        ///是否启用用户事件
        /// <summary>
        public int IsBrokerUserEvent;
    }

    /// <summary>
    ///资金账户口令变更域
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingAccountPasswordUpdateV1Field
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///原来的口令
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;
        /// <summary>
        ///新的口令
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;
    }

    /// <summary>
    ///资金账户口令变更域
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingAccountPasswordUpdateField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///原来的口令
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;
        /// <summary>
        ///新的口令
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;
    }

    /// <summary>
    ///查询组合合约分腿
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryCombinationLegField
    {
        /// <summary>
        ///组合合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
        /// <summary>
        ///单腿编号
        /// <summary>
        public int LegID;
        /// <summary>
        ///单腿合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string LegInstrumentID;
    }

    /// <summary>
    ///查询组合合约分腿
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQrySyncStatusField
    {
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
    }

    /// <summary>
    ///组合交易合约的单腿
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCombinationLegField
    {
        /// <summary>
        ///组合合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
        /// <summary>
        ///单腿编号
        /// <summary>
        public int LegID;
        /// <summary>
        ///单腿合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string LegInstrumentID;
        /// <summary>
        ///买卖方向
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///单腿乘数
        /// <summary>
        public int LegMultiple;
        /// <summary>
        ///派生层数
        /// <summary>
        public int ImplyLevel;
    }

    /// <summary>
    ///数据同步状态
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcSyncStatusField
    {
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///数据同步状态
        /// <summary>
        public TThostFtdcDataSyncStatusType DataSyncStatus;
    }

    /// <summary>
    ///查询联系人
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryLinkManField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    ///联系人
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcLinkManField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///联系人类型
        /// <summary>
        public TThostFtdcPersonTypeType PersonType;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdentifiedCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string PersonName;
        /// <summary>
        ///联系电话
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        ///通讯地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        ///邮政编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        ///优先级
        /// <summary>
        public int Priority;
    }

    /// <summary>
    ///查询经纪公司用户事件
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryBrokerUserEventField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///用户事件类型
        /// <summary>
        public TThostFtdcUserEventTypeType UserEventType;
    }

    /// <summary>
    ///查询经纪公司用户事件
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerUserEventField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///用户事件类型
        /// <summary>
        public TThostFtdcUserEventTypeType UserEventType;
        /// <summary>
        ///用户事件序号
        /// <summary>
        public int EventSequenceNo;
        /// <summary>
        ///事件发生日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EventDate;
        /// <summary>
        ///事件发生时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EventTime;
        /// <summary>
        ///用户事件信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
        public string UserEventInfo;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    ///查询签约银行请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryContractBankField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分中心代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
    }

    /// <summary>
    ///查询签约银行响应
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcContractBankField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分中心代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
        /// <summary>
        ///银行名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string BankName;
    }

    /// <summary>
    ///投资者组合持仓明细
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorPositionCombineDetailField
    {
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///开仓日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///组合编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ComTradeID;
        /// <summary>
        ///撮合编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///买卖
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///持仓量
        /// <summary>
        public int TotalAmt;
        /// <summary>
        ///投资者保证金
        /// <summary>
        public double Margin;
        /// <summary>
        ///交易所保证金
        /// <summary>
        public double ExchMargin;
        /// <summary>
        ///保证金率
        /// <summary>
        public double MarginRateByMoney;
        /// <summary>
        ///保证金率(按手数)
        /// <summary>
        public double MarginRateByVolume;
        /// <summary>
        ///单腿编号
        /// <summary>
        public int LegID;
        /// <summary>
        ///单腿乘数
        /// <summary>
        public int LegMultiple;
        /// <summary>
        ///组合持仓合约编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
        /// <summary>
        ///成交组号
        /// <summary>
    }

    /// <summary>
    ///预埋单
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcParkedOrderField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///报单引用
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///报单价格条件
        /// <summary>
        public TThostFtdcOrderPriceTypeType OrderPriceType;
        /// <summary>
        ///买卖方向
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///组合开平标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        /// <summary>
        ///组合投机套保标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        /// <summary>
        ///价格
        /// <summary>
        public double LimitPrice;
        /// <summary>
        ///数量
        /// <summary>
        public int VolumeTotalOriginal;
        /// <summary>
        ///有效期类型
        /// <summary>
        public TThostFtdcTimeConditionType TimeCondition;
        /// <summary>
        ///GTD日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        /// <summary>
        ///成交量类型
        /// <summary>
        public TThostFtdcVolumeConditionType VolumeCondition;
        /// <summary>
        ///最小成交量
        /// <summary>
        public int MinVolume;
        /// <summary>
        ///触发条件
        /// <summary>
        public TThostFtdcContingentConditionType ContingentCondition;
        /// <summary>
        ///止损价
        /// <summary>
        public double StopPrice;
        /// <summary>
        ///强平原因
        /// <summary>
        public TThostFtdcForceCloseReasonType ForceCloseReason;
        /// <summary>
        ///自动挂起标志
        /// <summary>
        public int IsAutoSuspend;
        /// <summary>
        ///业务单元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///用户强评标志
        /// <summary>
        public int UserForceClose;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///预埋报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderID;
        /// <summary>
        ///用户类型
        /// <summary>
        public TThostFtdcUserTypeType UserType;
        /// <summary>
        ///预埋单状态
        /// <summary>
        public TThostFtdcParkedOrderStatusType Status;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        /// <summary>
        ///互换单标志
        /// <summary>
        public int IsSwapOrder;
    }

    /// <summary>
    ///输入预埋单操作
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcParkedOrderActionField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///报单操作引用
        /// <summary>
        public int OrderActionRef;
        /// <summary>
        ///报单引用
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///前置编号
        /// <summary>
        public int FrontID;
        /// <summary>
        ///会话编号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        ///操作标志
        /// <summary>
        public TThostFtdcActionFlagType ActionFlag;
        /// <summary>
        ///价格
        /// <summary>
        public double LimitPrice;
        /// <summary>
        ///数量变化
        /// <summary>
        public int VolumeChange;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///预埋撤单单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderActionID;
        /// <summary>
        ///用户类型
        /// <summary>
        public TThostFtdcUserTypeType UserType;
        /// <summary>
        ///预埋撤单状态
        /// <summary>
        public TThostFtdcParkedOrderStatusType Status;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///查询预埋单
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryParkedOrderField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }

    /// <summary>
    ///查询预埋撤单
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryParkedOrderActionField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }

    /// <summary>
    ///删除预埋单
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRemoveParkedOrderField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///预埋报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderID;
    }

    /// <summary>
    ///删除预埋撤单
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRemoveParkedOrderActionField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///预埋撤单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderActionID;
    }

    /// <summary>
    ///经纪公司可提资金算法表
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorWithdrawAlgorithmField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者范围
        /// <summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///可提资金比例
        /// <summary>
        public double UsingRatio;
    }

    /// <summary>
    ///查询组合持仓明细
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInvestorPositionCombineDetailField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///组合持仓合约编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
    }

    /// <summary>
    ///成交均价
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarketDataAveragePriceField
    {
        /// <summary>
        ///当日均价
        /// <summary>
        public double AveragePrice;
    }

    /// <summary>
    ///校验投资者密码
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcVerifyInvestorPasswordField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
    }

    /// <summary>
    ///用户IP
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcUserIPField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///IP地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        /// <summary>
        ///IP地址掩码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPMask;
        /// <summary>
        ///Mac地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }

    /// <summary>
    ///用户事件通知信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingNoticeInfoField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///发送时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SendTime;
        /// <summary>
        ///消息正文
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string FieldContent;
        /// <summary>
        ///序列系列号
        /// <summary>
        public short SequenceSeries;
        /// <summary>
        ///序列号
        /// <summary>
        public int SequenceNo;
    }

    /// <summary>
    ///用户事件通知
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingNoticeField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者范围
        /// <summary>
        public TThostFtdcInvestorRangeType InvestorRange;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///序列系列号
        /// <summary>
        public short SequenceSeries;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///发送时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SendTime;
        /// <summary>
        ///序列号
        /// <summary>
        public int SequenceNo;
        /// <summary>
        ///消息正文
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string FieldContent;
    }

    /// <summary>
    ///查询交易事件通知
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTradingNoticeField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    ///查询错误报单
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryErrOrderField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    ///错误报单
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcErrOrderField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///报单引用
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///报单价格条件
        /// <summary>
        public TThostFtdcOrderPriceTypeType OrderPriceType;
        /// <summary>
        ///买卖方向
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///组合开平标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        /// <summary>
        ///组合投机套保标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        /// <summary>
        ///价格
        /// <summary>
        public double LimitPrice;
        /// <summary>
        ///数量
        /// <summary>
        public int VolumeTotalOriginal;
        /// <summary>
        ///有效期类型
        /// <summary>
        public TThostFtdcTimeConditionType TimeCondition;
        /// <summary>
        ///GTD日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        /// <summary>
        ///成交量类型
        /// <summary>
        public TThostFtdcVolumeConditionType VolumeCondition;
        /// <summary>
        ///最小成交量
        /// <summary>
        public int MinVolume;
        /// <summary>
        ///触发条件
        /// <summary>
        public TThostFtdcContingentConditionType ContingentCondition;
        /// <summary>
        ///止损价
        /// <summary>
        public double StopPrice;
        /// <summary>
        ///强平原因
        /// <summary>
        public TThostFtdcForceCloseReasonType ForceCloseReason;
        /// <summary>
        ///自动挂起标志
        /// <summary>
        public int IsAutoSuspend;
        /// <summary>
        ///业务单元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///用户强评标志
        /// <summary>
        public int UserForceClose;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        /// <summary>
        ///互换单标志
        /// <summary>
        public int IsSwapOrder;
    }

    /// <summary>
    ///查询错误报单操作
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcErrorConditionalOrderField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///报单引用
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///报单价格条件
        /// <summary>
        public TThostFtdcOrderPriceTypeType OrderPriceType;
        /// <summary>
        ///买卖方向
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///组合开平标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        /// <summary>
        ///组合投机套保标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        /// <summary>
        ///价格
        /// <summary>
        public double LimitPrice;
        /// <summary>
        ///数量
        /// <summary>
        public int VolumeTotalOriginal;
        /// <summary>
        ///有效期类型
        /// <summary>
        public TThostFtdcTimeConditionType TimeCondition;
        /// <summary>
        ///GTD日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        /// <summary>
        ///成交量类型
        /// <summary>
        public TThostFtdcVolumeConditionType VolumeCondition;
        /// <summary>
        ///最小成交量
        /// <summary>
        public int MinVolume;
        /// <summary>
        ///触发条件
        /// <summary>
        public TThostFtdcContingentConditionType ContingentCondition;
        /// <summary>
        ///止损价
        /// <summary>
        public double StopPrice;
        /// <summary>
        ///强平原因
        /// <summary>
        public TThostFtdcForceCloseReasonType ForceCloseReason;
        /// <summary>
        ///自动挂起标志
        /// <summary>
        public int IsAutoSuspend;
        /// <summary>
        ///业务单元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///本地报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///客户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        ///合约在交易所的代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///报单提交状态
        /// <summary>
        public TThostFtdcOrderSubmitStatusType OrderSubmitStatus;
        /// <summary>
        ///报单提示序号
        /// <summary>
        public int NotifySequence;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
        /// <summary>
        ///报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        ///报单来源
        /// <summary>
        public TThostFtdcOrderSourceType OrderSource;
        /// <summary>
        ///报单状态
        /// <summary>
        public TThostFtdcOrderStatusType OrderStatus;
        /// <summary>
        ///报单类型
        /// <summary>
        public TThostFtdcOrderTypeType OrderType;
        /// <summary>
        ///今成交数量
        /// <summary>
        public int VolumeTraded;
        /// <summary>
        ///剩余数量
        /// <summary>
        public int VolumeTotal;
        /// <summary>
        ///报单日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        /// <summary>
        ///委托时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        /// <summary>
        ///激活时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActiveTime;
        /// <summary>
        ///挂起时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SuspendTime;
        /// <summary>
        ///最后修改时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        /// <summary>
        ///撤销时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        /// <summary>
        ///最后修改交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;
        /// <summary>
        ///结算会员编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        /// <summary>
        ///序号
        /// <summary>
        public int SequenceNo;
        /// <summary>
        ///前置编号
        /// <summary>
        public int FrontID;
        /// <summary>
        ///会话编号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///用户端产品信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        /// <summary>
        ///状态信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        /// <summary>
        ///用户强评标志
        /// <summary>
        public int UserForceClose;
        /// <summary>
        ///操作用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;
        /// <summary>
        ///经纪公司报单编号
        /// <summary>
        public int BrokerOrderSeq;
        /// <summary>
        ///相关报单
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string RelativeOrderSysID;
        /// <summary>
        ///郑商所成交数量
        /// <summary>
        public int ZCETotalTradedVolume;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        /// <summary>
        ///互换单标志
        /// <summary>
        public int IsSwapOrder;
    }

    /// <summary>
    ///查询错误报单操作
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryErrOrderActionField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    ///错误报单操作
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcErrOrderActionField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///报单操作引用
        /// <summary>
        public int OrderActionRef;
        /// <summary>
        ///报单引用
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///前置编号
        /// <summary>
        public int FrontID;
        /// <summary>
        ///会话编号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        /// <summary>
        ///操作标志
        /// <summary>
        public TThostFtdcActionFlagType ActionFlag;
        /// <summary>
        ///价格
        /// <summary>
        public double LimitPrice;
        /// <summary>
        ///数量变化
        /// <summary>
        public int VolumeChange;
        /// <summary>
        ///操作日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        /// <summary>
        ///操作时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        /// <summary>
        ///交易所交易员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///本地报单编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        /// <summary>
        ///操作本地编号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///客户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        /// <summary>
        ///业务单元
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        /// <summary>
        ///报单操作状态
        /// <summary>
        public TThostFtdcOrderActionStatusType OrderActionStatus;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///状态信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///查询交易所状态
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryExchangeSequenceField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }

    /// <summary>
    ///交易所状态
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcExchangeSequenceField
    {
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///序号
        /// <summary>
        public int SequenceNo;
        /// <summary>
        ///合约交易状态
        /// <summary>
        public TThostFtdcInstrumentStatusType MarketStatus;
    }

    /// <summary>
    ///根据价格查询最大报单数量
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQueryMaxOrderVolumeWithPriceField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///买卖方向
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///开平标志
        /// <summary>
        public TThostFtdcOffsetFlagType OffsetFlag;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///最大允许报单数量
        /// <summary>
        public int MaxVolume;
        /// <summary>
        ///报单价格
        /// <summary>
        public double Price;
    }

    /// <summary>
    ///查询经纪公司交易参数
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryBrokerTradingParamsField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    ///经纪公司交易参数
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerTradingParamsField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///保证金价格类型
        /// <summary>
        public TThostFtdcMarginPriceTypeType MarginPriceType;
        /// <summary>
        ///盈亏算法
        /// <summary>
        public TThostFtdcAlgorithmType Algorithm;
        /// <summary>
        ///可用是否包含平仓盈利
        /// <summary>
        public TThostFtdcIncludeCloseProfitType AvailIncludeCloseProfit;
    }

    /// <summary>
    ///查询经纪公司交易算法
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryBrokerTradingAlgosField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    ///经纪公司交易算法
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerTradingAlgosField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///持仓处理算法编号
        /// <summary>
        public TThostFtdcHandlePositionAlgoIDType HandlePositionAlgoID;
        /// <summary>
        ///寻找保证金率算法编号
        /// <summary>
        public TThostFtdcFindMarginRateAlgoIDType FindMarginRateAlgoID;
        /// <summary>
        ///资金处理算法编号
        /// <summary>
        public TThostFtdcHandleTradingAccountAlgoIDType HandleTradingAccountAlgoID;
    }

    /// <summary>
    ///查询经纪公司资金
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQueryBrokerDepositField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }

    /// <summary>
    ///经纪公司资金
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerDepositField
    {
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///会员代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///上次结算准备金
        /// <summary>
        public double PreBalance;
        /// <summary>
        ///当前保证金总额
        /// <summary>
        public double CurrMargin;
        /// <summary>
        ///平仓盈亏
        /// <summary>
        public double CloseProfit;
        /// <summary>
        ///期货结算准备金
        /// <summary>
        public double Balance;
        /// <summary>
        ///入金金额
        /// <summary>
        public double Deposit;
        /// <summary>
        ///出金金额
        /// <summary>
        public double Withdraw;
        /// <summary>
        ///可提资金
        /// <summary>
        public double Available;
        /// <summary>
        ///基本准备金
        /// <summary>
        public double Reserve;
        /// <summary>
        ///冻结的保证金
        /// <summary>
        public double FrozenMargin;
    }

    /// <summary>
    ///查询保证金监管系统经纪公司密钥
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryCFMMCBrokerKeyField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }

    /// <summary>
    ///保证金监管系统经纪公司密钥
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCFMMCBrokerKeyField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///经纪公司统一编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///密钥生成日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateDate;
        /// <summary>
        ///密钥生成时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateTime;
        /// <summary>
        ///密钥编号
        /// <summary>
        public int KeyID;
        /// <summary>
        ///动态密钥
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CurrentKey;
        /// <summary>
        ///动态密钥类型
        /// <summary>
        public TThostFtdcCFMMCKeyKindType KeyKind;
    }

    /// <summary>
    ///保证金监管系统经纪公司资金账户密钥
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCFMMCTradingAccountKeyField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///经纪公司统一编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///密钥编号
        /// <summary>
        public int KeyID;
        /// <summary>
        ///动态密钥
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CurrentKey;
    }

    /// <summary>
    ///请求查询保证金监管系统经纪公司资金账户密钥
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryCFMMCTradingAccountKeyField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }

    /// <summary>
    ///用户动态令牌参数
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerUserOTPParamField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///动态令牌提供商
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        public string OTPVendorsID;
        /// <summary>
        ///动态令牌序列号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string SerialNumber;
        /// <summary>
        ///令牌密钥
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string AuthKey;
        /// <summary>
        ///漂移值
        /// <summary>
        public int LastDrift;
        /// <summary>
        ///成功值
        /// <summary>
        public int LastSuccess;
        /// <summary>
        ///动态令牌类型
        /// <summary>
        public TThostFtdcOTPTypeType OTPType;
    }

    /// <summary>
    ///手工同步用户动态令牌
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcManualSyncBrokerUserOTPField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///动态令牌类型
        /// <summary>
        public TThostFtdcOTPTypeType OTPType;
        /// <summary>
        ///第一个动态密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string FirstOTP;
        /// <summary>
        ///第二个动态密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SecondOTP;
    }

    /// <summary>
    ///投资者手续费率模板
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCommRateModelField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///手续费率模板代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;
        /// <summary>
        ///模板名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string CommModelName;
    }

    /// <summary>
    ///请求查询投资者手续费率模板
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryCommRateModelField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///手续费率模板代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;
    }

    /// <summary>
    ///投资者保证金率模板
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMarginModelField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///保证金率模板代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;
        /// <summary>
        ///模板名称
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string MarginModelName;
    }

    /// <summary>
    ///请求查询投资者保证金率模板
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryMarginModelField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///保证金率模板代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;
    }

    /// <summary>
    ///仓单折抵信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcEWarrantOffsetField
    {
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        /// <summary>
        ///买卖方向
        /// <summary>
        public TThostFtdcDirectionType Direction;
        /// <summary>
        ///投机套保标志
        /// <summary>
        public TThostFtdcHedgeFlagType HedgeFlag;
        /// <summary>
        ///数量
        /// <summary>
        public int Volume;
    }

    /// <summary>
    ///查询仓单折抵信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryEWarrantOffsetField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///交易所代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        /// <summary>
        ///合约代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }

    /// <summary>
    ///查询投资者品种/跨品种保证金
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryInvestorProductGroupMarginField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///品种/跨品种标示
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductGroupID;
    }

    /// <summary>
    ///投资者品种/跨品种保证金
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcInvestorProductGroupMarginField
    {
        /// <summary>
        ///品种/跨品种标示
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductGroupID;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///交易日
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///结算编号
        /// <summary>
        public int SettlementID;
        /// <summary>
        ///冻结的保证金
        /// <summary>
        public double FrozenMargin;
        /// <summary>
        ///多头冻结的保证金
        /// <summary>
        public double LongFrozenMargin;
        /// <summary>
        ///空头冻结的保证金
        /// <summary>
        public double ShortFrozenMargin;
        /// <summary>
        ///占用的保证金
        /// <summary>
        public double UseMargin;
        /// <summary>
        ///多头保证金
        /// <summary>
        public double LongUseMargin;
        /// <summary>
        ///空头保证金
        /// <summary>
        public double ShortUseMargin;
        /// <summary>
        ///交易所保证金
        /// <summary>
        public double ExchMargin;
        /// <summary>
        ///交易所多头保证金
        /// <summary>
        public double LongExchMargin;
        /// <summary>
        ///交易所空头保证金
        /// <summary>
        public double ShortExchMargin;
        /// <summary>
        ///平仓盈亏
        /// <summary>
        public double CloseProfit;
        /// <summary>
        ///冻结的手续费
        /// <summary>
        public double FrozenCommission;
        /// <summary>
        ///手续费
        /// <summary>
        public double Commission;
        /// <summary>
        ///冻结的资金
        /// <summary>
        public double FrozenCash;
        /// <summary>
        ///资金差额
        /// <summary>
        public double CashIn;
        /// <summary>
        ///持仓盈亏
        /// <summary>
        public double PositionProfit;
        /// <summary>
        ///折抵总金额
        /// <summary>
        public double OffsetAmount;
        /// <summary>
        ///多头折抵总金额
        /// <summary>
        public double LongOffsetAmount;
        /// <summary>
        ///空头折抵总金额
        /// <summary>
        public double ShortOffsetAmount;
        /// <summary>
        ///交易所折抵总金额
        /// <summary>
        public double ExchOffsetAmount;
        /// <summary>
        ///交易所多头折抵总金额
        /// <summary>
        public double LongExchOffsetAmount;
        /// <summary>
        ///交易所空头折抵总金额
        /// <summary>
        public double ShortExchOffsetAmount;
    }

    /// <summary>
    ///转帐开户请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqOpenAccountField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///性别
        /// <summary>
        public TThostFtdcGenderType Gender;
        /// <summary>
        ///国家代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        ///邮编
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        ///电话号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        ///手机
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        /// <summary>
        ///传真
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        /// <summary>
        ///电子邮件
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        /// <summary>
        ///资金账户状态
        /// <summary>
        public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///验证客户证件号码标志
        /// <summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///汇钞标志
        /// <summary>
        public TThostFtdcCashExchangeCodeType CashExchangeCode;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货单位帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///期货单位帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        ///银行密码标志
        /// <summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        ///期货资金密码核对标志
        /// <summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    ///转帐销户请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqCancelAccountField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///性别
        /// <summary>
        public TThostFtdcGenderType Gender;
        /// <summary>
        ///国家代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        ///邮编
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        ///电话号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        ///手机
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        /// <summary>
        ///传真
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        /// <summary>
        ///电子邮件
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        /// <summary>
        ///资金账户状态
        /// <summary>
        public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///验证客户证件号码标志
        /// <summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///汇钞标志
        /// <summary>
        public TThostFtdcCashExchangeCodeType CashExchangeCode;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货单位帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///期货单位帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        ///银行密码标志
        /// <summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        ///期货资金密码核对标志
        /// <summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    ///变更银行账户请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqChangeAccountField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///性别
        /// <summary>
        public TThostFtdcGenderType Gender;
        /// <summary>
        ///国家代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        ///邮编
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        ///电话号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        ///手机
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        /// <summary>
        ///传真
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        /// <summary>
        ///电子邮件
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        /// <summary>
        ///资金账户状态
        /// <summary>
        public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///新银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankAccount;
        /// <summary>
        ///新银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///验证客户证件号码标志
        /// <summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///银行密码标志
        /// <summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        ///期货资金密码核对标志
        /// <summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
    }

    /// <summary>
    ///转账请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqTransferField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///期货公司流水号
        /// <summary>
        public int FutureSerial;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///验证客户证件号码标志
        /// <summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///转帐金额
        /// <summary>
        public double TradeAmount;
        /// <summary>
        ///期货可取金额
        /// <summary>
        public double FutureFetchAmount;
        /// <summary>
        ///费用支付标志
        /// <summary>
        public TThostFtdcFeePayFlagType FeePayFlag;
        /// <summary>
        ///应收客户费用
        /// <summary>
        public double CustFee;
        /// <summary>
        ///应收期货公司费用
        /// <summary>
        public double BrokerFee;
        /// <summary>
        ///发送方给接收方的消息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货单位帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///期货单位帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        ///银行密码标志
        /// <summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        ///期货资金密码核对标志
        /// <summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///转账交易状态
        /// <summary>
        public TThostFtdcTransferStatusType TransferStatus;
    }

    /// <summary>
    ///银行发起银行资金转期货响应
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspTransferField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///期货公司流水号
        /// <summary>
        public int FutureSerial;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///验证客户证件号码标志
        /// <summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///转帐金额
        /// <summary>
        public double TradeAmount;
        /// <summary>
        ///期货可取金额
        /// <summary>
        public double FutureFetchAmount;
        /// <summary>
        ///费用支付标志
        /// <summary>
        public TThostFtdcFeePayFlagType FeePayFlag;
        /// <summary>
        ///应收客户费用
        /// <summary>
        public double CustFee;
        /// <summary>
        ///应收期货公司费用
        /// <summary>
        public double BrokerFee;
        /// <summary>
        ///发送方给接收方的消息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货单位帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///期货单位帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        ///银行密码标志
        /// <summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        ///期货资金密码核对标志
        /// <summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///转账交易状态
        /// <summary>
        public TThostFtdcTransferStatusType TransferStatus;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///冲正请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqRepealField
    {
        /// <summary>
        ///冲正时间间隔
        /// <summary>
        public int RepealTimeInterval;
        /// <summary>
        ///已经冲正次数
        /// <summary>
        public int RepealedTimes;
        /// <summary>
        ///银行冲正标志
        /// <summary>
        public TThostFtdcBankRepealFlagType BankRepealFlag;
        /// <summary>
        ///期商冲正标志
        /// <summary>
        public TThostFtdcBrokerRepealFlagType BrokerRepealFlag;
        /// <summary>
        ///被冲正平台流水号
        /// <summary>
        public int PlateRepealSerial;
        /// <summary>
        ///被冲正银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankRepealSerial;
        /// <summary>
        ///被冲正期货流水号
        /// <summary>
        public int FutureRepealSerial;
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///期货公司流水号
        /// <summary>
        public int FutureSerial;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///验证客户证件号码标志
        /// <summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///转帐金额
        /// <summary>
        public double TradeAmount;
        /// <summary>
        ///期货可取金额
        /// <summary>
        public double FutureFetchAmount;
        /// <summary>
        ///费用支付标志
        /// <summary>
        public TThostFtdcFeePayFlagType FeePayFlag;
        /// <summary>
        ///应收客户费用
        /// <summary>
        public double CustFee;
        /// <summary>
        ///应收期货公司费用
        /// <summary>
        public double BrokerFee;
        /// <summary>
        ///发送方给接收方的消息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货单位帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///期货单位帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        ///银行密码标志
        /// <summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        ///期货资金密码核对标志
        /// <summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///转账交易状态
        /// <summary>
        public TThostFtdcTransferStatusType TransferStatus;
    }

    /// <summary>
    ///冲正响应
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspRepealField
    {
        /// <summary>
        ///冲正时间间隔
        /// <summary>
        public int RepealTimeInterval;
        /// <summary>
        ///已经冲正次数
        /// <summary>
        public int RepealedTimes;
        /// <summary>
        ///银行冲正标志
        /// <summary>
        public TThostFtdcBankRepealFlagType BankRepealFlag;
        /// <summary>
        ///期商冲正标志
        /// <summary>
        public TThostFtdcBrokerRepealFlagType BrokerRepealFlag;
        /// <summary>
        ///被冲正平台流水号
        /// <summary>
        public int PlateRepealSerial;
        /// <summary>
        ///被冲正银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankRepealSerial;
        /// <summary>
        ///被冲正期货流水号
        /// <summary>
        public int FutureRepealSerial;
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///期货公司流水号
        /// <summary>
        public int FutureSerial;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///验证客户证件号码标志
        /// <summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///转帐金额
        /// <summary>
        public double TradeAmount;
        /// <summary>
        ///期货可取金额
        /// <summary>
        public double FutureFetchAmount;
        /// <summary>
        ///费用支付标志
        /// <summary>
        public TThostFtdcFeePayFlagType FeePayFlag;
        /// <summary>
        ///应收客户费用
        /// <summary>
        public double CustFee;
        /// <summary>
        ///应收期货公司费用
        /// <summary>
        public double BrokerFee;
        /// <summary>
        ///发送方给接收方的消息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货单位帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///期货单位帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        ///银行密码标志
        /// <summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        ///期货资金密码核对标志
        /// <summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///转账交易状态
        /// <summary>
        public TThostFtdcTransferStatusType TransferStatus;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///查询账户信息请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqQueryAccountField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///期货公司流水号
        /// <summary>
        public int FutureSerial;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///验证客户证件号码标志
        /// <summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货单位帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///期货单位帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        ///银行密码标志
        /// <summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        ///期货资金密码核对标志
        /// <summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
    }

    /// <summary>
    ///查询账户信息响应
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspQueryAccountField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///期货公司流水号
        /// <summary>
        public int FutureSerial;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///验证客户证件号码标志
        /// <summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货单位帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///期货单位帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        ///银行密码标志
        /// <summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        ///期货资金密码核对标志
        /// <summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///银行可用金额
        /// <summary>
        public double BankUseAmount;
        /// <summary>
        ///银行可取金额
        /// <summary>
        public double BankFetchAmount;
    }

    /// <summary>
    ///期商签到签退
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcFutureSignIOField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
    }

    /// <summary>
    ///期商签到响应
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspFutureSignInField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        /// <summary>
        ///PIN密钥
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string PinKey;
        /// <summary>
        ///MAC密钥
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string MacKey;
    }

    /// <summary>
    ///期商签退请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqFutureSignOutField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
    }

    /// <summary>
    ///期商签退响应
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspFutureSignOutField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///查询指定流水号的交易结果请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqQueryTradeResultBySerialField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///流水号
        /// <summary>
        public int Reference;
        /// <summary>
        ///本流水号发布者的机构类型
        /// <summary>
        public TThostFtdcInstitutionTypeType RefrenceIssureType;
        /// <summary>
        ///本流水号发布者机构编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string RefrenceIssure;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///转帐金额
        /// <summary>
        public double TradeAmount;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
    }

    /// <summary>
    ///查询指定流水号的交易结果响应
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspQueryTradeResultBySerialField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        /// <summary>
        ///流水号
        /// <summary>
        public int Reference;
        /// <summary>
        ///本流水号发布者的机构类型
        /// <summary>
        public TThostFtdcInstitutionTypeType RefrenceIssureType;
        /// <summary>
        ///本流水号发布者机构编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string RefrenceIssure;
        /// <summary>
        ///原始返回代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string OriginReturnCode;
        /// <summary>
        ///原始返回码描述
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string OriginDescrInfoForReturnCode;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///转帐金额
        /// <summary>
        public double TradeAmount;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
    }

    /// <summary>
    ///日终文件就绪请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqDayEndFileReadyField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///文件业务功能
        /// <summary>
        public TThostFtdcFileBusinessCodeType FileBusinessCode;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
    }

    /// <summary>
    ///返回结果
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReturnResultField
    {
        /// <summary>
        ///返回代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ReturnCode;
        /// <summary>
        ///返回码描述
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string DescrInfoForReturnCode;
    }

    /// <summary>
    ///验证期货资金密码
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcVerifyFuturePasswordField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
    }

    /// <summary>
    ///验证客户信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcVerifyCustInfoField
    {
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
    }

    /// <summary>
    ///验证期货资金密码和客户信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcVerifyFuturePasswordAndCustInfoField
    {
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
    }

    /// <summary>
    ///验证期货资金密码和客户信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcDepositResultInformField
    {
        /// <summary>
        ///出入金流水号，该流水号为银期报盘返回的流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DepositSeqNo;
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///入金金额
        /// <summary>
        public double Deposit;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///返回代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ReturnCode;
        /// <summary>
        ///返回码描述
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string DescrInfoForReturnCode;
    }

    /// <summary>
    ///交易核心向银期报盘发出密钥同步请求
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcReqSyncKeyField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///交易核心给银期报盘的消息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
    }

    /// <summary>
    ///交易核心向银期报盘发出密钥同步响应
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcRspSyncKeyField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///交易核心给银期报盘的消息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///查询账户信息通知
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcNotifyQueryAccountField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///期货公司流水号
        /// <summary>
        public int FutureSerial;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///验证客户证件号码标志
        /// <summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货单位帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///期货单位帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        ///银行密码标志
        /// <summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        ///期货资金密码核对标志
        /// <summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///银行可用金额
        /// <summary>
        public double BankUseAmount;
        /// <summary>
        ///银行可取金额
        /// <summary>
        public double BankFetchAmount;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///银期转账交易流水表
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTransferSerialField
    {
        /// <summary>
        ///平台流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///交易发起方日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///交易代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///会话编号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///期货公司编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///期货公司帐号类型
        /// <summary>
        public TThostFtdcFutureAccTypeType FutureAccType;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///期货公司流水号
        /// <summary>
        public int FutureSerial;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///交易金额
        /// <summary>
        public double TradeAmount;
        /// <summary>
        ///应收客户费用
        /// <summary>
        public double CustFee;
        /// <summary>
        ///应收期货公司费用
        /// <summary>
        public double BrokerFee;
        /// <summary>
        ///有效标志
        /// <summary>
        public TThostFtdcAvailabilityFlagType AvailabilityFlag;
        /// <summary>
        ///操作员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperatorCode;
        /// <summary>
        ///新银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankNewAccount;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///请求查询转帐流水
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryTransferSerialField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
    }

    /// <summary>
    ///期商签到通知
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcNotifyFutureSignInField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        /// <summary>
        ///PIN密钥
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string PinKey;
        /// <summary>
        ///MAC密钥
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string MacKey;
    }

    /// <summary>
    ///期商签退通知
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcNotifyFutureSignOutField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///交易核心向银期报盘发出密钥同步处理结果的通知
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcNotifySyncKeyField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///交易核心给银期报盘的消息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///请求编号
        /// <summary>
        public int RequestID;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///请求查询银期签约关系
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryAccountregisterField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
    }

    /// <summary>
    ///客户开销户信息表
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcAccountregisterField
    {
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDay;
        /// <summary>
        ///银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///期货公司编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期货公司分支机构编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///开销户类别
        /// <summary>
        public TThostFtdcOpenOrDestroyType OpenOrDestroy;
        /// <summary>
        ///签约日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string RegDate;
        /// <summary>
        ///解约日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OutDate;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
    }

    /// <summary>
    ///银期开户信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcOpenAccountField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///性别
        /// <summary>
        public TThostFtdcGenderType Gender;
        /// <summary>
        ///国家代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        ///邮编
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        ///电话号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        ///手机
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        /// <summary>
        ///传真
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        /// <summary>
        ///电子邮件
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        /// <summary>
        ///资金账户状态
        /// <summary>
        public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///验证客户证件号码标志
        /// <summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///汇钞标志
        /// <summary>
        public TThostFtdcCashExchangeCodeType CashExchangeCode;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货单位帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///期货单位帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        ///银行密码标志
        /// <summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        ///期货资金密码核对标志
        /// <summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///银期销户信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCancelAccountField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///性别
        /// <summary>
        public TThostFtdcGenderType Gender;
        /// <summary>
        ///国家代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        ///邮编
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        ///电话号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        ///手机
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        /// <summary>
        ///传真
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        /// <summary>
        ///电子邮件
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        /// <summary>
        ///资金账户状态
        /// <summary>
        public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///验证客户证件号码标志
        /// <summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///汇钞标志
        /// <summary>
        public TThostFtdcCashExchangeCodeType CashExchangeCode;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///渠道标志
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        /// <summary>
        ///期货单位帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankSecuAccType;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///期货单位帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        /// <summary>
        ///银行密码标志
        /// <summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        ///期货资金密码核对标志
        /// <summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        ///交易柜员
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///用户标识
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///银期变更银行账号信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcChangeAccountField
    {
        /// <summary>
        ///业务功能码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        /// <summary>
        ///银行代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        /// <summary>
        ///银行分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        /// <summary>
        ///期商代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///期商分支机构代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        /// <summary>
        ///交易日期
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        /// <summary>
        ///交易时间
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        /// <summary>
        ///银行流水号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        /// <summary>
        ///交易系统日期 
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        /// <summary>
        ///银期平台消息流水号
        /// <summary>
        public int PlateSerial;
        /// <summary>
        ///最后分片标志
        /// <summary>
        public TThostFtdcLastFragmentType LastFragment;
        /// <summary>
        ///会话号
        /// <summary>
        public int SessionID;
        /// <summary>
        ///客户姓名
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        /// <summary>
        ///证件类型
        /// <summary>
        public TThostFtdcIdCardTypeType IdCardType;
        /// <summary>
        ///证件号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        /// <summary>
        ///性别
        /// <summary>
        public TThostFtdcGenderType Gender;
        /// <summary>
        ///国家代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        /// <summary>
        ///客户类型
        /// <summary>
        public TThostFtdcCustTypeType CustType;
        /// <summary>
        ///地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        /// <summary>
        ///邮编
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        /// <summary>
        ///电话号码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        /// <summary>
        ///手机
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        /// <summary>
        ///传真
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        /// <summary>
        ///电子邮件
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        /// <summary>
        ///资金账户状态
        /// <summary>
        public TThostFtdcMoneyAccountStatusType MoneyAccountStatus;
        /// <summary>
        ///银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        /// <summary>
        ///银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        /// <summary>
        ///新银行帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankAccount;
        /// <summary>
        ///新银行密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankPassWord;
        /// <summary>
        ///投资者帐号
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        /// <summary>
        ///期货密码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        /// <summary>
        ///银行帐号类型
        /// <summary>
        public TThostFtdcBankAccTypeType BankAccType;
        /// <summary>
        ///安装编号
        /// <summary>
        public int InstallID;
        /// <summary>
        ///验证客户证件号码标志
        /// <summary>
        public TThostFtdcYesNoIndicatorType VerifyCertNoFlag;
        /// <summary>
        ///币种代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        /// <summary>
        ///期货公司银行编码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        /// <summary>
        ///银行密码标志
        /// <summary>
        public TThostFtdcPwdFlagType BankPwdFlag;
        /// <summary>
        ///期货资金密码核对标志
        /// <summary>
        public TThostFtdcPwdFlagType SecuPwdFlag;
        /// <summary>
        ///交易ID
        /// <summary>
        public int TID;
        /// <summary>
        ///摘要
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        /// <summary>
        ///错误代码
        /// <summary>
        public int ErrorID;
        /// <summary>
        ///错误信息
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }

    /// <summary>
    ///灾备中心交易权限
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcUserRightsAssignField
    {
        /// <summary>
        ///应用单元代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///交易中心代码
        /// <summary>
        public int DRIdentityID;
    }

    /// <summary>
    ///经济公司是否有在本标示的交易权限
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcBrokerUserRightAssignField
    {
        /// <summary>
        ///应用单元代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///交易中心代码
        /// <summary>
        public int DRIdentityID;
        /// <summary>
        ///能否交易
        /// <summary>
        public int Tradeable;
    }

    /// <summary>
    ///灾备交易转换报文
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcDRTransferField
    {
        /// <summary>
        ///原交易中心代码
        /// <summary>
        public int OrigDRIdentityID;
        /// <summary>
        ///目标交易中心代码
        /// <summary>
        public int DestDRIdentityID;
        /// <summary>
        ///原应用单元代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string OrigBrokerID;
        /// <summary>
        ///目标易用单元代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string DestBrokerID;
    }

    /// <summary>
    ///Fens用户信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcFensUserInfoField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        /// <summary>
        ///登录模式
        /// <summary>
        public TThostFtdcLoginModeType LoginMode;
    }

    /// <summary>
    ///当前银期所属交易中心
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcCurrTransferIdentityField
    {
        /// <summary>
        ///交易中心代码
        /// <summary>
        public int IdentityID;
    }

    /// <summary>
    ///禁止登录用户
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcLoginForbiddenUserField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    ///查询禁止登录用户
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcQryLoginForbiddenUserField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///用户代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }

    /// <summary>
    ///UDP组播组信息
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcMulticastGroupInfoField
    {
        /// <summary>
        ///组播组IP地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string GroupIP;
        /// <summary>
        ///组播组IP端口
        /// <summary>
        public int GroupPort;
        /// <summary>
        ///源地址
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string SourceIP;
    }

    /// <summary>
    ///资金账户基本准备金
    /// <summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CThostFtdcTradingAccountReserveField
    {
        /// <summary>
        ///经纪公司代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        /// <summary>
        ///投资者代码
        /// <summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        /// <summary>
        ///基本准备金
        /// <summary>
        public double Reserve;
    }



    /// <summary>
    ///TFtdcExchangePropertyType是一个交易所属性类型
    /// <summary>
    public enum TThostFtdcExchangePropertyType : byte
    {
        /// <summary>
        ///正常
        /// <summary>
        THOST_FTDC_EXP_Normal = (byte)'0',
        /// <summary>
        ///根据成交生成报单
        /// <summary>
        THOST_FTDC_EXP_GenOrderByTrade = (byte)'1'
    }
    /// <summary>
    ///TFtdcIdCardTypeType是一个证件类型类型
    /// <summary>
    public enum TThostFtdcIdCardTypeType : byte
    {
        /// <summary>
        ///组织机构代码
        /// <summary>
        THOST_FTDC_ICT_EID = (byte)'0',
        /// <summary>
        ///身份证
        /// <summary>
        THOST_FTDC_ICT_IDCard = (byte)'1',
        /// <summary>
        ///军官证
        /// <summary>
        THOST_FTDC_ICT_OfficerIDCard = (byte)'2',
        /// <summary>
        ///警官证
        /// <summary>
        THOST_FTDC_ICT_PoliceIDCard = (byte)'3',
        /// <summary>
        ///士兵证
        /// <summary>
        THOST_FTDC_ICT_SoldierIDCard = (byte)'4',
        /// <summary>
        ///户口簿
        /// <summary>
        THOST_FTDC_ICT_HouseholdRegister = (byte)'5',
        /// <summary>
        ///护照
        /// <summary>
        THOST_FTDC_ICT_Passport = (byte)'6',
        /// <summary>
        ///台胞证
        /// <summary>
        THOST_FTDC_ICT_TaiwanCompatriotIDCard = (byte)'7',
        /// <summary>
        ///回乡证
        /// <summary>
        THOST_FTDC_ICT_HomeComingCard = (byte)'8',
        /// <summary>
        ///营业执照号
        /// <summary>
        THOST_FTDC_ICT_LicenseNo = (byte)'9',
        /// <summary>
        ///税务登记号
        /// <summary>
        THOST_FTDC_ICT_TaxNo = (byte)'A',
        /// <summary>
        ///其他证件
        /// <summary>
        THOST_FTDC_ICT_OtherCard = (byte)'x'
    }
    /// <summary>
    ///TFtdcInvestorRangeType是一个投资者范围类型
    /// <summary>
    public enum TThostFtdcInvestorRangeType : byte
    {
        /// <summary>
        ///所有
        /// <summary>
        THOST_FTDC_IR_All = (byte)'1',
        /// <summary>
        ///投资者组
        /// <summary>
        THOST_FTDC_IR_Group = (byte)'2',
        /// <summary>
        ///单一投资者
        /// <summary>
        THOST_FTDC_IR_Single = (byte)'3'
    }
    /// <summary>
    ///TFtdcDepartmentRangeType是一个投资者范围类型
    /// <summary>
    public enum TThostFtdcDepartmentRangeType : byte
    {
        /// <summary>
        ///所有
        /// <summary>
        THOST_FTDC_DR_All = (byte)'1',
        /// <summary>
        ///组织架构
        /// <summary>
        THOST_FTDC_DR_Group = (byte)'2',
        /// <summary>
        ///单一投资者
        /// <summary>
        THOST_FTDC_DR_Single = (byte)'3'
    }
    /// <summary>
    ///TFtdcDataSyncStatusType是一个数据同步状态类型
    /// <summary>
    public enum TThostFtdcDataSyncStatusType : byte
    {
        /// <summary>
        ///未同步
        /// <summary>
        THOST_FTDC_DS_Asynchronous = (byte)'1',
        /// <summary>
        ///同步中
        /// <summary>
        THOST_FTDC_DS_Synchronizing = (byte)'2',
        /// <summary>
        ///已同步
        /// <summary>
        THOST_FTDC_DS_Synchronized = (byte)'3'
    }
    /// <summary>
    ///TFtdcBrokerDataSyncStatusType是一个经纪公司数据同步状态类型
    /// <summary>
    public enum TThostFtdcBrokerDataSyncStatusType : byte
    {
        /// <summary>
        ///已同步
        /// <summary>
        THOST_FTDC_BDS_Synchronized = (byte)'1',
        /// <summary>
        ///同步中
        /// <summary>
        THOST_FTDC_BDS_Synchronizing = (byte)'2'
    }
    /// <summary>
    ///TFtdcExchangeConnectStatusType是一个交易所连接状态类型
    /// <summary>
    public enum TThostFtdcExchangeConnectStatusType : byte
    {
        /// <summary>
        ///没有任何连接
        /// <summary>
        THOST_FTDC_ECS_NoConnection = (byte)'1',
        /// <summary>
        ///已经发出合约查询请求
        /// <summary>
        THOST_FTDC_ECS_QryInstrumentSent = (byte)'2',
        /// <summary>
        ///已经获取信息
        /// <summary>
        THOST_FTDC_ECS_GotInformation = (byte)'9'
    }
    /// <summary>
    ///TFtdcTraderConnectStatusType是一个交易所交易员连接状态类型
    /// <summary>
    public enum TThostFtdcTraderConnectStatusType : byte
    {
        /// <summary>
        ///没有任何连接
        /// <summary>
        THOST_FTDC_TCS_NotConnected = (byte)'1',
        /// <summary>
        ///已经连接
        /// <summary>
        THOST_FTDC_TCS_Connected = (byte)'2',
        /// <summary>
        ///已经发出合约查询请求
        /// <summary>
        THOST_FTDC_TCS_QryInstrumentSent = (byte)'3',
        /// <summary>
        ///订阅私有流
        /// <summary>
        THOST_FTDC_TCS_SubPrivateFlow = (byte)'4'
    }
    /// <summary>
    ///TFtdcFunctionCodeType是一个功能代码类型
    /// <summary>
    public enum TThostFtdcFunctionCodeType : byte
    {
        /// <summary>
        ///数据异步化
        /// <summary>
        THOST_FTDC_FC_DataAsync = (byte)'1',
        /// <summary>
        ///强制用户登出
        /// <summary>
        THOST_FTDC_FC_ForceUserLogout = (byte)'2',
        /// <summary>
        ///变更管理用户口令
        /// <summary>
        THOST_FTDC_FC_UserPasswordUpdate = (byte)'3',
        /// <summary>
        ///变更经纪公司口令
        /// <summary>
        THOST_FTDC_FC_BrokerPasswordUpdate = (byte)'4',
        /// <summary>
        ///变更投资者口令
        /// <summary>
        THOST_FTDC_FC_InvestorPasswordUpdate = (byte)'5',
        /// <summary>
        ///报单插入
        /// <summary>
        THOST_FTDC_FC_OrderInsert = (byte)'6',
        /// <summary>
        ///报单操作
        /// <summary>
        THOST_FTDC_FC_OrderAction = (byte)'7',
        /// <summary>
        ///同步系统数据
        /// <summary>
        THOST_FTDC_FC_SyncSystemData = (byte)'8',
        /// <summary>
        ///同步经纪公司数据
        /// <summary>
        THOST_FTDC_FC_SyncBrokerData = (byte)'9',
        /// <summary>
        ///批量同步经纪公司数据
        /// <summary>
        THOST_FTDC_FC_BachSyncBrokerData = (byte)'A',
        /// <summary>
        ///超级查询
        /// <summary>
        THOST_FTDC_FC_SuperQuery = (byte)'B',
        /// <summary>
        ///报单插入
        /// <summary>
        THOST_FTDC_FC_ParkedOrderInsert = (byte)'C',
        /// <summary>
        ///报单操作
        /// <summary>
        THOST_FTDC_FC_ParkedOrderAction = (byte)'D',
        /// <summary>
        ///同步动态令牌
        /// <summary>
        THOST_FTDC_FC_SyncOTP = (byte)'E'
    }
    /// <summary>
    ///TFtdcBrokerFunctionCodeType是一个经纪公司功能代码类型
    /// <summary>
    public enum TThostFtdcBrokerFunctionCodeType : byte
    {
        /// <summary>
        ///强制用户登出
        /// <summary>
        THOST_FTDC_BFC_ForceUserLogout = (byte)'1',
        /// <summary>
        ///变更用户口令
        /// <summary>
        THOST_FTDC_BFC_UserPasswordUpdate = (byte)'2',
        /// <summary>
        ///同步经纪公司数据
        /// <summary>
        THOST_FTDC_BFC_SyncBrokerData = (byte)'3',
        /// <summary>
        ///批量同步经纪公司数据
        /// <summary>
        THOST_FTDC_BFC_BachSyncBrokerData = (byte)'4',
        /// <summary>
        ///报单插入
        /// <summary>
        THOST_FTDC_BFC_OrderInsert = (byte)'5',
        /// <summary>
        ///报单操作
        /// <summary>
        THOST_FTDC_BFC_OrderAction = (byte)'6',
        /// <summary>
        ///全部查询
        /// <summary>
        THOST_FTDC_BFC_AllQuery = (byte)'7',
        /// <summary>
        ///系统功能：登入/登出/修改密码等
        /// <summary>
        THOST_FTDC_BFC_log = (byte)'a',
        /// <summary>
        ///基本查询：查询基础数据，如合约，交易所等常量
        /// <summary>
        THOST_FTDC_BFC_BaseQry = (byte)'b',
        /// <summary>
        ///交易查询：如查成交，委托
        /// <summary>
        THOST_FTDC_BFC_TradeQry = (byte)'c',
        /// <summary>
        ///交易功能：报单，撤单
        /// <summary>
        THOST_FTDC_BFC_Trade = (byte)'d',
        /// <summary>
        ///银期转账
        /// <summary>
        THOST_FTDC_BFC_Virement = (byte)'e',
        /// <summary>
        ///风险监控
        /// <summary>
        THOST_FTDC_BFC_Risk = (byte)'f',
        /// <summary>
        ///查询/管理：查询会话，踢人等
        /// <summary>
        THOST_FTDC_BFC_Session = (byte)'g',
        /// <summary>
        ///风控通知控制
        /// <summary>
        THOST_FTDC_BFC_RiskNoticeCtl = (byte)'h',
        /// <summary>
        ///风控通知发送
        /// <summary>
        THOST_FTDC_BFC_RiskNotice = (byte)'i',
        /// <summary>
        ///察看经纪公司资金权限
        /// <summary>
        THOST_FTDC_BFC_BrokerDeposit = (byte)'j',
        /// <summary>
        ///资金查询
        /// <summary>
        THOST_FTDC_BFC_QueryFund = (byte)'k',
        /// <summary>
        ///报单查询
        /// <summary>
        THOST_FTDC_BFC_QueryOrder = (byte)'l',
        /// <summary>
        ///成交查询
        /// <summary>
        THOST_FTDC_BFC_QueryTrade = (byte)'m',
        /// <summary>
        ///持仓查询
        /// <summary>
        THOST_FTDC_BFC_QueryPosition = (byte)'n',
        /// <summary>
        ///行情查询
        /// <summary>
        THOST_FTDC_BFC_QueryMarketData = (byte)'o',
        /// <summary>
        ///用户事件查询
        /// <summary>
        THOST_FTDC_BFC_QueryUserEvent = (byte)'p',
        /// <summary>
        ///风险通知查询
        /// <summary>
        THOST_FTDC_BFC_QueryRiskNotify = (byte)'q',
        /// <summary>
        ///出入金查询
        /// <summary>
        THOST_FTDC_BFC_QueryFundChange = (byte)'r',
        /// <summary>
        ///投资者信息查询
        /// <summary>
        THOST_FTDC_BFC_QueryInvestor = (byte)'s',
        /// <summary>
        ///交易编码查询
        /// <summary>
        THOST_FTDC_BFC_QueryTradingCode = (byte)'t',
        /// <summary>
        ///强平
        /// <summary>
        THOST_FTDC_BFC_ForceClose = (byte)'u',
        /// <summary>
        ///压力测试
        /// <summary>
        THOST_FTDC_BFC_PressTest = (byte)'v',
        /// <summary>
        ///权益反算
        /// <summary>
        THOST_FTDC_BFC_RemainCalc = (byte)'w',
        /// <summary>
        ///净持仓保证金指标
        /// <summary>
        THOST_FTDC_BFC_NetPositionInd = (byte)'x',
        /// <summary>
        ///风险预算
        /// <summary>
        THOST_FTDC_BFC_RiskPredict = (byte)'y',
        /// <summary>
        ///数据导出
        /// <summary>
        THOST_FTDC_BFC_DataExport = (byte)'z',
        /// <summary>
        ///风控指标设置
        /// <summary>
        THOST_FTDC_BFC_RiskTargetSetup = (byte)'A',
        /// <summary>
        ///行情预警
        /// <summary>
        THOST_FTDC_BFC_MarketDataWarn = (byte)'B',
        /// <summary>
        ///业务通知查询
        /// <summary>
        THOST_FTDC_BFC_QryBizNotice = (byte)'C',
        /// <summary>
        ///业务通知模板设置
        /// <summary>
        THOST_FTDC_BFC_CfgBizNotice = (byte)'D',
        /// <summary>
        ///同步动态令牌
        /// <summary>
        THOST_FTDC_BFC_SyncOTP = (byte)'E',
        /// <summary>
        ///发送业务通知
        /// <summary>
        THOST_FTDC_BFC_SendBizNotice = (byte)'F',
        /// <summary>
        ///风险级别标准设置
        /// <summary>
        THOST_FTDC_BFC_CfgRiskLevelStd = (byte)'G',
        /// <summary>
        ///交易终端应急功能
        /// <summary>
        THOST_FTDC_BFC_TbCommand = (byte)'H'
    }
    /// <summary>
    ///TFtdcOrderActionStatusType是一个报单操作状态类型
    /// <summary>
    public enum TThostFtdcOrderActionStatusType : byte
    {
        /// <summary>
        ///已经提交
        /// <summary>
        THOST_FTDC_OAS_Submitted = (byte)'a',
        /// <summary>
        ///已经接受
        /// <summary>
        THOST_FTDC_OAS_Accepted = (byte)'b',
        /// <summary>
        ///已经被拒绝
        /// <summary>
        THOST_FTDC_OAS_Rejected = (byte)'c'
    }
    /// <summary>
    ///TFtdcOrderStatusType是一个报单状态类型
    /// <summary>
    public enum TThostFtdcOrderStatusType : byte
    {
        /// <summary>
        ///全部成交
        /// <summary>
        THOST_FTDC_OST_AllTraded = (byte)'0',
        /// <summary>
        ///部分成交还在队列中
        /// <summary>
        THOST_FTDC_OST_PartTradedQueueing = (byte)'1',
        /// <summary>
        ///部分成交不在队列中
        /// <summary>
        THOST_FTDC_OST_PartTradedNotQueueing = (byte)'2',
        /// <summary>
        ///未成交还在队列中
        /// <summary>
        THOST_FTDC_OST_NoTradeQueueing = (byte)'3',
        /// <summary>
        ///未成交不在队列中
        /// <summary>
        THOST_FTDC_OST_NoTradeNotQueueing = (byte)'4',
        /// <summary>
        ///撤单
        /// <summary>
        THOST_FTDC_OST_Canceled = (byte)'5',
        /// <summary>
        ///未知
        /// <summary>
        THOST_FTDC_OST_Unknown = (byte)'a',
        /// <summary>
        ///尚未触发
        /// <summary>
        THOST_FTDC_OST_NotTouched = (byte)'b',
        /// <summary>
        ///已触发
        /// <summary>
        THOST_FTDC_OST_Touched = (byte)'c'
    }
    /// <summary>
    ///TFtdcOrderSubmitStatusType是一个报单提交状态类型
    /// <summary>
    public enum TThostFtdcOrderSubmitStatusType : byte
    {
        /// <summary>
        ///已经提交
        /// <summary>
        THOST_FTDC_OSS_InsertSubmitted = (byte)'0',
        /// <summary>
        ///撤单已经提交
        /// <summary>
        THOST_FTDC_OSS_CancelSubmitted = (byte)'1',
        /// <summary>
        ///修改已经提交
        /// <summary>
        THOST_FTDC_OSS_ModifySubmitted = (byte)'2',
        /// <summary>
        ///已经接受
        /// <summary>
        THOST_FTDC_OSS_Accepted = (byte)'3',
        /// <summary>
        ///报单已经被拒绝
        /// <summary>
        THOST_FTDC_OSS_InsertRejected = (byte)'4',
        /// <summary>
        ///撤单已经被拒绝
        /// <summary>
        THOST_FTDC_OSS_CancelRejected = (byte)'5',
        /// <summary>
        ///改单已经被拒绝
        /// <summary>
        THOST_FTDC_OSS_ModifyRejected = (byte)'6'
    }
    /// <summary>
    ///TFtdcPositionDateType是一个持仓日期类型
    /// <summary>
    public enum TThostFtdcPositionDateType : byte
    {
        /// <summary>
        ///今日持仓
        /// <summary>
        THOST_FTDC_PSD_Today = (byte)'1',
        /// <summary>
        ///历史持仓
        /// <summary>
        THOST_FTDC_PSD_History = (byte)'2'
    }
    /// <summary>
    ///TFtdcPositionDateTypeType是一个持仓日期类型类型
    /// <summary>
    public enum TThostFtdcPositionDateTypeType : byte
    {
        /// <summary>
        ///使用历史持仓
        /// <summary>
        THOST_FTDC_PDT_UseHistory = (byte)'1',
        /// <summary>
        ///不使用历史持仓
        /// <summary>
        THOST_FTDC_PDT_NoUseHistory = (byte)'2'
    }
    /// <summary>
    ///TFtdcTradingRoleType是一个交易角色类型
    /// <summary>
    public enum TThostFtdcTradingRoleType : byte
    {
        /// <summary>
        ///代理
        /// <summary>
        THOST_FTDC_ER_Broker = (byte)'1',
        /// <summary>
        ///自营
        /// <summary>
        THOST_FTDC_ER_Host = (byte)'2',
        /// <summary>
        ///做市商
        /// <summary>
        THOST_FTDC_ER_Maker = (byte)'3'
    }
    /// <summary>
    ///TFtdcProductClassType是一个产品类型类型
    /// <summary>
    public enum TThostFtdcProductClassType : byte
    {
        /// <summary>
        ///期货
        /// <summary>
        THOST_FTDC_PC_Futures = (byte)'1',
        /// <summary>
        ///期权
        /// <summary>
        THOST_FTDC_PC_Options = (byte)'2',
        /// <summary>
        ///组合
        /// <summary>
        THOST_FTDC_PC_Combination = (byte)'3',
        /// <summary>
        ///即期
        /// <summary>
        THOST_FTDC_PC_Spot = (byte)'4',
        /// <summary>
        ///期转现
        /// <summary>
        THOST_FTDC_PC_EFP = (byte)'5'
    }
    /// <summary>
    ///TFtdcInstLifePhaseType是一个合约生命周期状态类型
    /// <summary>
    public enum TThostFtdcInstLifePhaseType : byte
    {
        /// <summary>
        ///未上市
        /// <summary>
        THOST_FTDC_IP_NotStart = (byte)'0',
        /// <summary>
        ///上市
        /// <summary>
        THOST_FTDC_IP_Started = (byte)'1',
        /// <summary>
        ///停牌
        /// <summary>
        THOST_FTDC_IP_Pause = (byte)'2',
        /// <summary>
        ///到期
        /// <summary>
        THOST_FTDC_IP_Expired = (byte)'3'
    }
    /// <summary>
    ///TFtdcDirectionType是一个买卖方向类型
    /// <summary>
    public enum TThostFtdcDirectionType : byte
    {
        /// <summary>
        ///买
        /// <summary>
        THOST_FTDC_D_Buy = (byte)'0',
        /// <summary>
        ///卖
        /// <summary>
        THOST_FTDC_D_Sell = (byte)'1'
    }
    /// <summary>
    ///TFtdcPositionTypeType是一个持仓类型类型
    /// <summary>
    public enum TThostFtdcPositionTypeType : byte
    {
        /// <summary>
        ///净持仓
        /// <summary>
        THOST_FTDC_PT_Net = (byte)'1',
        /// <summary>
        ///综合持仓
        /// <summary>
        THOST_FTDC_PT_Gross = (byte)'2'
    }
    /// <summary>
    ///TFtdcPosiDirectionType是一个持仓多空方向类型
    /// <summary>
    public enum TThostFtdcPosiDirectionType : byte
    {
        /// <summary>
        ///净
        /// <summary>
        THOST_FTDC_PD_Net = (byte)'1',
        /// <summary>
        ///多头
        /// <summary>
        THOST_FTDC_PD_Long = (byte)'2',
        /// <summary>
        ///空头
        /// <summary>
        THOST_FTDC_PD_Short = (byte)'3'
    }
    /// <summary>
    ///TFtdcSysSettlementStatusType是一个系统结算状态类型
    /// <summary>
    public enum TThostFtdcSysSettlementStatusType : byte
    {
        /// <summary>
        ///不活跃
        /// <summary>
        THOST_FTDC_SS_NonActive = (byte)'1',
        /// <summary>
        ///启动
        /// <summary>
        THOST_FTDC_SS_Startup = (byte)'2',
        /// <summary>
        ///操作
        /// <summary>
        THOST_FTDC_SS_Operating = (byte)'3',
        /// <summary>
        ///结算
        /// <summary>
        THOST_FTDC_SS_Settlement = (byte)'4',
        /// <summary>
        ///结算完成
        /// <summary>
        THOST_FTDC_SS_SettlementFinished = (byte)'5'
    }
    /// <summary>
    ///TFtdcRatioAttrType是一个费率属性类型
    /// <summary>
    public enum TThostFtdcRatioAttrType : byte
    {
        /// <summary>
        ///交易费率
        /// <summary>
        THOST_FTDC_RA_Trade = (byte)'0',
        /// <summary>
        ///结算费率
        /// <summary>
        THOST_FTDC_RA_Settlement = (byte)'1'
    }
    /// <summary>
    ///TFtdcHedgeFlagType是一个投机套保标志类型
    /// <summary>
    public enum TThostFtdcHedgeFlagType : byte
    {
        /// <summary>
        ///投机
        /// <summary>
        THOST_FTDC_HF_Speculation = (byte)'1',
        /// <summary>
        ///套利
        /// <summary>
        THOST_FTDC_HF_Arbitrage = (byte)'2',
        /// <summary>
        ///套保
        /// <summary>
        THOST_FTDC_HF_Hedge = (byte)'3'
    }
    /// <summary>
    ///TFtdcBillHedgeFlagType是一个投机套保标志类型
    /// <summary>
    public enum TThostFtdcBillHedgeFlagType : byte
    {
        /// <summary>
        ///投机
        /// <summary>
        THOST_FTDC_BHF_Speculation = (byte)'1',
        /// <summary>
        ///套利
        /// <summary>
        THOST_FTDC_BHF_Arbitrage = (byte)'2',
        /// <summary>
        ///套保
        /// <summary>
        THOST_FTDC_BHF_Hedge = (byte)'3'
    }
    /// <summary>
    ///TFtdcClientIDTypeType是一个交易编码类型类型
    /// <summary>
    public enum TThostFtdcClientIDTypeType : byte
    {
        /// <summary>
        ///投机
        /// <summary>
        THOST_FTDC_CIDT_Speculation = (byte)'1',
        /// <summary>
        ///套利
        /// <summary>
        THOST_FTDC_CIDT_Arbitrage = (byte)'2',
        /// <summary>
        ///套保
        /// <summary>
        THOST_FTDC_CIDT_Hedge = (byte)'3'
    }
    /// <summary>
    ///TFtdcOrderPriceTypeType是一个报单价格条件类型
    /// <summary>
    public enum TThostFtdcOrderPriceTypeType : byte
    {
        /// <summary>
        ///任意价
        /// <summary>
        THOST_FTDC_OPT_AnyPrice = (byte)'1',
        /// <summary>
        ///限价
        /// <summary>
        THOST_FTDC_OPT_LimitPrice = (byte)'2',
        /// <summary>
        ///最优价
        /// <summary>
        THOST_FTDC_OPT_BestPrice = (byte)'3',
        /// <summary>
        ///最新价
        /// <summary>
        THOST_FTDC_OPT_LastPrice = (byte)'4',
        /// <summary>
        ///最新价浮动上浮1个ticks
        /// <summary>
        THOST_FTDC_OPT_LastPricePlusOneTicks = (byte)'5',
        /// <summary>
        ///最新价浮动上浮2个ticks
        /// <summary>
        THOST_FTDC_OPT_LastPricePlusTwoTicks = (byte)'6',
        /// <summary>
        ///最新价浮动上浮3个ticks
        /// <summary>
        THOST_FTDC_OPT_LastPricePlusThreeTicks = (byte)'7',
        /// <summary>
        ///卖一价
        /// <summary>
        THOST_FTDC_OPT_AskPrice1 = (byte)'8',
        /// <summary>
        ///卖一价浮动上浮1个ticks
        /// <summary>
        THOST_FTDC_OPT_AskPrice1PlusOneTicks = (byte)'9',
        /// <summary>
        ///卖一价浮动上浮2个ticks
        /// <summary>
        THOST_FTDC_OPT_AskPrice1PlusTwoTicks = (byte)'A',
        /// <summary>
        ///卖一价浮动上浮3个ticks
        /// <summary>
        THOST_FTDC_OPT_AskPrice1PlusThreeTicks = (byte)'B',
        /// <summary>
        ///买一价
        /// <summary>
        THOST_FTDC_OPT_BidPrice1 = (byte)'C',
        /// <summary>
        ///买一价浮动上浮1个ticks
        /// <summary>
        THOST_FTDC_OPT_BidPrice1PlusOneTicks = (byte)'D',
        /// <summary>
        ///买一价浮动上浮2个ticks
        /// <summary>
        THOST_FTDC_OPT_BidPrice1PlusTwoTicks = (byte)'E',
        /// <summary>
        ///买一价浮动上浮3个ticks
        /// <summary>
        THOST_FTDC_OPT_BidPrice1PlusThreeTicks = (byte)'F'
    }
    /// <summary>
    ///TFtdcOffsetFlagType是一个开平标志类型
    /// <summary>
    public enum TThostFtdcOffsetFlagType : byte
    {
        /// <summary>
        ///开仓
        /// <summary>
        THOST_FTDC_OF_Open = (byte)'0',
        /// <summary>
        ///平仓
        /// <summary>
        THOST_FTDC_OF_Close = (byte)'1',
        /// <summary>
        ///强平
        /// <summary>
        THOST_FTDC_OF_ForceClose = (byte)'2',
        /// <summary>
        ///平今
        /// <summary>
        THOST_FTDC_OF_CloseToday = (byte)'3',
        /// <summary>
        ///平昨
        /// <summary>
        THOST_FTDC_OF_CloseYesterday = (byte)'4',
        /// <summary>
        ///强减
        /// <summary>
        THOST_FTDC_OF_ForceOff = (byte)'5',
        /// <summary>
        ///本地强平
        /// <summary>
        THOST_FTDC_OF_LocalForceClose = (byte)'6'
    }
    /// <summary>
    ///TFtdcForceCloseReasonType是一个强平原因类型
    /// <summary>
    public enum TThostFtdcForceCloseReasonType : byte
    {
        /// <summary>
        ///非强平
        /// <summary>
        THOST_FTDC_FCC_NotForceClose = (byte)'0',
        /// <summary>
        ///资金不足
        /// <summary>
        THOST_FTDC_FCC_LackDeposit = (byte)'1',
        /// <summary>
        ///客户超仓
        /// <summary>
        THOST_FTDC_FCC_ClientOverPositionLimit = (byte)'2',
        /// <summary>
        ///会员超仓
        /// <summary>
        THOST_FTDC_FCC_MemberOverPositionLimit = (byte)'3',
        /// <summary>
        ///持仓非整数倍
        /// <summary>
        THOST_FTDC_FCC_NotMultiple = (byte)'4',
        /// <summary>
        ///违规
        /// <summary>
        THOST_FTDC_FCC_Violation = (byte)'5',
        /// <summary>
        ///其它
        /// <summary>
        THOST_FTDC_FCC_Other = (byte)'6',
        /// <summary>
        ///自然人临近交割
        /// <summary>
        THOST_FTDC_FCC_PersonDeliv = (byte)'7'
    }
    /// <summary>
    ///TFtdcOrderTypeType是一个报单类型类型
    /// <summary>
    public enum TThostFtdcOrderTypeType : byte
    {
        /// <summary>
        ///正常
        /// <summary>
        THOST_FTDC_ORDT_Normal = (byte)'0',
        /// <summary>
        ///报价衍生
        /// <summary>
        THOST_FTDC_ORDT_DeriveFromQuote = (byte)'1',
        /// <summary>
        ///组合衍生
        /// <summary>
        THOST_FTDC_ORDT_DeriveFromCombination = (byte)'2',
        /// <summary>
        ///组合报单
        /// <summary>
        THOST_FTDC_ORDT_Combination = (byte)'3',
        /// <summary>
        ///条件单
        /// <summary>
        THOST_FTDC_ORDT_ConditionalOrder = (byte)'4',
        /// <summary>
        ///互换单
        /// <summary>
        THOST_FTDC_ORDT_Swap = (byte)'5'
    }
    /// <summary>
    ///TFtdcTimeConditionType是一个有效期类型类型
    /// <summary>
    public enum TThostFtdcTimeConditionType : byte
    {
        /// <summary>
        ///立即完成，否则撤销
        /// <summary>
        THOST_FTDC_TC_IOC = (byte)'1',
        /// <summary>
        ///本节有效
        /// <summary>
        THOST_FTDC_TC_GFS = (byte)'2',
        /// <summary>
        ///当日有效
        /// <summary>
        THOST_FTDC_TC_GFD = (byte)'3',
        /// <summary>
        ///指定日期前有效
        /// <summary>
        THOST_FTDC_TC_GTD = (byte)'4',
        /// <summary>
        ///撤销前有效
        /// <summary>
        THOST_FTDC_TC_GTC = (byte)'5',
        /// <summary>
        ///集合竞价有效
        /// <summary>
        THOST_FTDC_TC_GFA = (byte)'6'
    }
    /// <summary>
    ///TFtdcVolumeConditionType是一个成交量类型类型
    /// <summary>
    public enum TThostFtdcVolumeConditionType : byte
    {
        /// <summary>
        ///任何数量
        /// <summary>
        THOST_FTDC_VC_AV = (byte)'1',
        /// <summary>
        ///最小数量
        /// <summary>
        THOST_FTDC_VC_MV = (byte)'2',
        /// <summary>
        ///全部数量
        /// <summary>
        THOST_FTDC_VC_CV = (byte)'3'
    }
    /// <summary>
    ///TFtdcContingentConditionType是一个触发条件类型
    /// <summary>
    public enum TThostFtdcContingentConditionType : byte
    {
        /// <summary>
        ///立即
        /// <summary>
        THOST_FTDC_CC_Immediately = (byte)'1',
        /// <summary>
        ///止损
        /// <summary>
        THOST_FTDC_CC_Touch = (byte)'2',
        /// <summary>
        ///止赢
        /// <summary>
        THOST_FTDC_CC_TouchProfit = (byte)'3',
        /// <summary>
        ///预埋单
        /// <summary>
        THOST_FTDC_CC_ParkedOrder = (byte)'4',
        /// <summary>
        ///最新价大于条件价
        /// <summary>
        THOST_FTDC_CC_LastPriceGreaterThanStopPrice = (byte)'5',
        /// <summary>
        ///最新价大于等于条件价
        /// <summary>
        THOST_FTDC_CC_LastPriceGreaterEqualStopPrice = (byte)'6',
        /// <summary>
        ///最新价小于条件价
        /// <summary>
        THOST_FTDC_CC_LastPriceLesserThanStopPrice = (byte)'7',
        /// <summary>
        ///最新价小于等于条件价
        /// <summary>
        THOST_FTDC_CC_LastPriceLesserEqualStopPrice = (byte)'8',
        /// <summary>
        ///卖一价大于条件价
        /// <summary>
        THOST_FTDC_CC_AskPriceGreaterThanStopPrice = (byte)'9',
        /// <summary>
        ///卖一价大于等于条件价
        /// <summary>
        THOST_FTDC_CC_AskPriceGreaterEqualStopPrice = (byte)'A',
        /// <summary>
        ///卖一价小于条件价
        /// <summary>
        THOST_FTDC_CC_AskPriceLesserThanStopPrice = (byte)'B',
        /// <summary>
        ///卖一价小于等于条件价
        /// <summary>
        THOST_FTDC_CC_AskPriceLesserEqualStopPrice = (byte)'C',
        /// <summary>
        ///买一价大于条件价
        /// <summary>
        THOST_FTDC_CC_BidPriceGreaterThanStopPrice = (byte)'D',
        /// <summary>
        ///买一价大于等于条件价
        /// <summary>
        THOST_FTDC_CC_BidPriceGreaterEqualStopPrice = (byte)'E',
        /// <summary>
        ///买一价小于条件价
        /// <summary>
        THOST_FTDC_CC_BidPriceLesserThanStopPrice = (byte)'F',
        /// <summary>
        ///买一价小于等于条件价
        /// <summary>
        THOST_FTDC_CC_BidPriceLesserEqualStopPrice = (byte)'H'
    }
    /// <summary>
    ///TFtdcActionFlagType是一个操作标志类型
    /// <summary>
    public enum TThostFtdcActionFlagType : byte
    {
        /// <summary>
        ///删除
        /// <summary>
        THOST_FTDC_AF_Delete = (byte)'0',
        /// <summary>
        ///修改
        /// <summary>
        THOST_FTDC_AF_Modify = (byte)'3'
    }
    /// <summary>
    ///TFtdcTradingRightType是一个交易权限类型
    /// <summary>
    public enum TThostFtdcTradingRightType : byte
    {
        /// <summary>
        ///可以交易
        /// <summary>
        THOST_FTDC_TR_Allow = (byte)'0',
        /// <summary>
        ///只能平仓
        /// <summary>
        THOST_FTDC_TR_CloseOnly = (byte)'1',
        /// <summary>
        ///不能交易
        /// <summary>
        THOST_FTDC_TR_Forbidden = (byte)'2'
    }
    /// <summary>
    ///TFtdcOrderSourceType是一个报单来源类型
    /// <summary>
    public enum TThostFtdcOrderSourceType : byte
    {
        /// <summary>
        ///来自参与者
        /// <summary>
        THOST_FTDC_OSRC_Participant = (byte)'0',
        /// <summary>
        ///来自管理员
        /// <summary>
        THOST_FTDC_OSRC_Administrator = (byte)'1'
    }
    /// <summary>
    ///TFtdcTradeTypeType是一个成交类型类型
    /// <summary>
    public enum TThostFtdcTradeTypeType : byte
    {
        /// <summary>
        ///普通成交
        /// <summary>
        THOST_FTDC_TRDT_Common = (byte)'0',
        /// <summary>
        ///期权执行
        /// <summary>
        THOST_FTDC_TRDT_OptionsExecution = (byte)'1',
        /// <summary>
        ///OTC成交
        /// <summary>
        THOST_FTDC_TRDT_OTC = (byte)'2',
        /// <summary>
        ///期转现衍生成交
        /// <summary>
        THOST_FTDC_TRDT_EFPDerived = (byte)'3',
        /// <summary>
        ///组合衍生成交
        /// <summary>
        THOST_FTDC_TRDT_CombinationDerived = (byte)'4'
    }
    /// <summary>
    ///TFtdcPriceSourceType是一个成交价来源类型
    /// <summary>
    public enum TThostFtdcPriceSourceType : byte
    {
        /// <summary>
        ///前成交价
        /// <summary>
        THOST_FTDC_PSRC_LastPrice = (byte)'0',
        /// <summary>
        ///买委托价
        /// <summary>
        THOST_FTDC_PSRC_Buy = (byte)'1',
        /// <summary>
        ///卖委托价
        /// <summary>
        THOST_FTDC_PSRC_Sell = (byte)'2'
    }
    /// <summary>
    ///TFtdcInstrumentStatusType是一个合约交易状态类型
    /// <summary>
    public enum TThostFtdcInstrumentStatusType : byte
    {
        /// <summary>
        ///开盘前
        /// <summary>
        THOST_FTDC_IS_BeforeTrading = (byte)'0',
        /// <summary>
        ///非交易
        /// <summary>
        THOST_FTDC_IS_NoTrading = (byte)'1',
        /// <summary>
        ///连续交易
        /// <summary>
        THOST_FTDC_IS_Continous = (byte)'2',
        /// <summary>
        ///集合竞价报单
        /// <summary>
        THOST_FTDC_IS_AuctionOrdering = (byte)'3',
        /// <summary>
        ///集合竞价价格平衡
        /// <summary>
        THOST_FTDC_IS_AuctionBalance = (byte)'4',
        /// <summary>
        ///集合竞价撮合
        /// <summary>
        THOST_FTDC_IS_AuctionMatch = (byte)'5',
        /// <summary>
        ///收盘
        /// <summary>
        THOST_FTDC_IS_Closed = (byte)'6'
    }
    /// <summary>
    ///TFtdcInstStatusEnterReasonType是一个品种进入交易状态原因类型
    /// <summary>
    public enum TThostFtdcInstStatusEnterReasonType : byte
    {
        /// <summary>
        ///自动切换
        /// <summary>
        THOST_FTDC_IER_Automatic = (byte)'1',
        /// <summary>
        ///手动切换
        /// <summary>
        THOST_FTDC_IER_Manual = (byte)'2',
        /// <summary>
        ///熔断
        /// <summary>
        THOST_FTDC_IER_Fuse = (byte)'3'
    }
    /// <summary>
    ///TFtdcBatchStatusType是一个处理状态类型
    /// <summary>
    public enum TThostFtdcBatchStatusType : byte
    {
        /// <summary>
        ///未上传
        /// <summary>
        THOST_FTDC_BS_NoUpload = (byte)'1',
        /// <summary>
        ///已上传
        /// <summary>
        THOST_FTDC_BS_Uploaded = (byte)'2',
        /// <summary>
        ///审核失败
        /// <summary>
        THOST_FTDC_BS_Failed = (byte)'3'
    }
    /// <summary>
    ///TFtdcReturnStyleType是一个按品种返还方式类型
    /// <summary>
    public enum TThostFtdcReturnStyleType : byte
    {
        /// <summary>
        ///按所有品种
        /// <summary>
        THOST_FTDC_RS_All = (byte)'1',
        /// <summary>
        ///按品种
        /// <summary>
        THOST_FTDC_RS_ByProduct = (byte)'2'
    }
    /// <summary>
    ///TFtdcReturnPatternType是一个返还模式类型
    /// <summary>
    public enum TThostFtdcReturnPatternType : byte
    {
        /// <summary>
        ///按成交手数
        /// <summary>
        THOST_FTDC_RP_ByVolume = (byte)'1',
        /// <summary>
        ///按留存手续费
        /// <summary>
        THOST_FTDC_RP_ByFeeOnHand = (byte)'2'
    }
    /// <summary>
    ///TFtdcReturnLevelType是一个返还级别类型
    /// <summary>
    public enum TThostFtdcReturnLevelType : byte
    {
        /// <summary>
        ///级别1
        /// <summary>
        THOST_FTDC_RL_Level1 = (byte)'1',
        /// <summary>
        ///级别2
        /// <summary>
        THOST_FTDC_RL_Level2 = (byte)'2',
        /// <summary>
        ///级别3
        /// <summary>
        THOST_FTDC_RL_Level3 = (byte)'3',
        /// <summary>
        ///级别4
        /// <summary>
        THOST_FTDC_RL_Level4 = (byte)'4',
        /// <summary>
        ///级别5
        /// <summary>
        THOST_FTDC_RL_Level5 = (byte)'5',
        /// <summary>
        ///级别6
        /// <summary>
        THOST_FTDC_RL_Level6 = (byte)'6',
        /// <summary>
        ///级别7
        /// <summary>
        THOST_FTDC_RL_Level7 = (byte)'7',
        /// <summary>
        ///级别8
        /// <summary>
        THOST_FTDC_RL_Level8 = (byte)'8',
        /// <summary>
        ///级别9
        /// <summary>
        THOST_FTDC_RL_Level9 = (byte)'9'
    }
    /// <summary>
    ///TFtdcReturnStandardType是一个返还标准类型
    /// <summary>
    public enum TThostFtdcReturnStandardType : byte
    {
        /// <summary>
        ///分阶段返还
        /// <summary>
        THOST_FTDC_RSD_ByPeriod = (byte)'1',
        /// <summary>
        ///按某一标准
        /// <summary>
        THOST_FTDC_RSD_ByStandard = (byte)'2'
    }
    /// <summary>
    ///TFtdcMortgageTypeType是一个质押类型类型
    /// <summary>
    public enum TThostFtdcMortgageTypeType : byte
    {
        /// <summary>
        ///质出
        /// <summary>
        THOST_FTDC_MT_Out = (byte)'0',
        /// <summary>
        ///质入
        /// <summary>
        THOST_FTDC_MT_In = (byte)'1'
    }
    /// <summary>
    ///TFtdcInvestorSettlementParamIDType是一个投资者结算参数代码类型
    /// <summary>
    public enum TThostFtdcInvestorSettlementParamIDType : byte
    {
        /// <summary>
        ///基础保证金
        /// <summary>
        THOST_FTDC_ISPI_BaseMargin = (byte)'1',
        /// <summary>
        ///最低权益标准
        /// <summary>
        THOST_FTDC_ISPI_LowestInterest = (byte)'2',
        /// <summary>
        ///质押比例
        /// <summary>
        THOST_FTDC_ISPI_MortgageRatio = (byte)'4',
        /// <summary>
        ///保证金算法
        /// <summary>
        THOST_FTDC_ISPI_MarginWay = (byte)'5',
        /// <summary>
        ///结算单结存是否包含质押
        /// <summary>
        THOST_FTDC_ISPI_BillDeposit = (byte)'9'
    }
    /// <summary>
    ///TFtdcExchangeSettlementParamIDType是一个交易所结算参数代码类型
    /// <summary>
    public enum TThostFtdcExchangeSettlementParamIDType : byte
    {
        /// <summary>
        ///质押比例
        /// <summary>
        THOST_FTDC_ESPI_MortgageRatio = (byte)'1',
        /// <summary>
        ///分项资金导入项
        /// <summary>
        THOST_FTDC_ESPI_OtherFundItem = (byte)'2',
        /// <summary>
        ///分项资金入交易所出入金
        /// <summary>
        THOST_FTDC_ESPI_OtherFundImport = (byte)'3',
        /// <summary>
        ///中金所开户最低可用金额
        /// <summary>
        THOST_FTDC_ESPI_CFFEXMinPrepa = (byte)'6',
        /// <summary>
        ///郑商所结算方式
        /// <summary>
        THOST_FTDC_ESPI_CZCESettlementType = (byte)'7',
        /// <summary>
        ///交易所交割手续费收取方式
        /// <summary>
        THOST_FTDC_ESPI_ExchDelivFeeMode = (byte)'9',
        /// <summary>
        ///投资者交割手续费收取方式
        /// <summary>
        THOST_FTDC_ESPI_DelivFeeMode = (byte)'0',
        /// <summary>
        ///郑商所组合持仓保证金收取方式
        /// <summary>
        THOST_FTDC_ESPI_CZCEComMarginType = (byte)'A'
    }
    /// <summary>
    ///TFtdcSystemParamIDType是一个系统参数代码类型
    /// <summary>
    public enum TThostFtdcSystemParamIDType : byte
    {
        /// <summary>
        ///投资者代码最小长度
        /// <summary>
        THOST_FTDC_SPI_InvestorIDMinLength = (byte)'1',
        /// <summary>
        ///投资者帐号代码最小长度
        /// <summary>
        THOST_FTDC_SPI_AccountIDMinLength = (byte)'2',
        /// <summary>
        ///投资者开户默认登录权限
        /// <summary>
        THOST_FTDC_SPI_UserRightLogon = (byte)'3',
        /// <summary>
        ///投资者交易结算单成交汇总方式
        /// <summary>
        THOST_FTDC_SPI_SettlementBillTrade = (byte)'4',
        /// <summary>
        ///统一开户更新交易编码方式
        /// <summary>
        THOST_FTDC_SPI_TradingCode = (byte)'5',
        /// <summary>
        ///结算是否判断存在未复核的出入金和分项资金
        /// <summary>
        THOST_FTDC_SPI_CheckFund = (byte)'6',
        /// <summary>
        ///是否启用手续费模板数据权限
        /// <summary>
        THOST_FTDC_SPI_CommModelRight = (byte)'7',
        /// <summary>
        ///是否启用保证金率模板数据权限
        /// <summary>
        THOST_FTDC_SPI_MarginModelRight = (byte)'9',
        /// <summary>
        ///是否规范用户才能激活
        /// <summary>
        THOST_FTDC_SPI_IsStandardActive = (byte)'8',
        /// <summary>
        ///上传的交易所结算文件路径
        /// <summary>
        THOST_FTDC_SPI_UploadSettlementFile = (byte)'U',
        /// <summary>
        ///上报保证金监控中心文件路径
        /// <summary>
        THOST_FTDC_SPI_DownloadCSRCFile = (byte)'D',
        /// <summary>
        ///生成的结算单文件路径
        /// <summary>
        THOST_FTDC_SPI_SettlementBillFile = (byte)'S',
        /// <summary>
        ///证监会文件标识
        /// <summary>
        THOST_FTDC_SPI_CSRCOthersFile = (byte)'C',
        /// <summary>
        ///投资者照片路径
        /// <summary>
        THOST_FTDC_SPI_InvestorPhoto = (byte)'P',
        /// <summary>
        ///全结经纪公司上传文件路径
        /// <summary>
        THOST_FTDC_SPI_CSRCData = (byte)'R',
        /// <summary>
        ///开户密码录入方式
        /// <summary>
        THOST_FTDC_SPI_InvestorPwdModel = (byte)'I',
        /// <summary>
        ///投资者中金所结算文件下载路径
        /// <summary>
        THOST_FTDC_SPI_CFFEXInvestorSettleFile = (byte)'F',
        /// <summary>
        ///投资者代码编码方式
        /// <summary>
        THOST_FTDC_SPI_InvestorIDType = (byte)'a',
        /// <summary>
        ///休眠户最高权益
        /// <summary>
        THOST_FTDC_SPI_FreezeMaxReMain = (byte)'r',
        /// <summary>
        ///手续费相关操作实时上场开关
        /// <summary>
        THOST_FTDC_SPI_IsSync = (byte)'A',
        /// <summary>
        ///解除开仓权限限制
        /// <summary>
        THOST_FTDC_SPI_RelieveOpenLimit = (byte)'O',
        /// <summary>
        ///是否规范用户才能休眠
        /// <summary>
        THOST_FTDC_SPI_IsStandardFreeze = (byte)'X',
        /// <summary>
        ///郑商所是否开放所有品种套保交易
        /// <summary>
        THOST_FTDC_SPI_CZCENormalProductHedge = (byte)'B'
    }
    /// <summary>
    ///TFtdcTradeParamIDType是一个交易系统参数代码类型
    /// <summary>
    public enum TThostFtdcTradeParamIDType : byte
    {
        /// <summary>
        ///系统加密算法
        /// <summary>
        THOST_FTDC_TPID_EncryptionStandard = (byte)'E',
        /// <summary>
        ///系统风险算法
        /// <summary>
        THOST_FTDC_TPID_RiskMode = (byte)'R',
        /// <summary>
        ///系统风险算法是否全局 0-否 1-是
        /// <summary>
        THOST_FTDC_TPID_RiskModeGlobal = (byte)'G',
        /// <summary>
        ///密码加密算法
        /// <summary>
        THOST_FTDC_TPID_modeEncode = (byte)'P',
        /// <summary>
        ///价格小数位数参数
        /// <summary>
        THOST_FTDC_TPID_tickMode = (byte)'T',
        /// <summary>
        ///用户最大会话数
        /// <summary>
        THOST_FTDC_TPID_SingleUserSessionMaxNum = (byte)'S',
        /// <summary>
        ///最大连续登录失败数
        /// <summary>
        THOST_FTDC_TPID_LoginFailMaxNum = (byte)'L',
        /// <summary>
        ///是否强制认证
        /// <summary>
        THOST_FTDC_TPID_IsAuthForce = (byte)'A'
    }
    /// <summary>
    ///TFtdcFileIDType是一个文件标识类型
    /// <summary>
    public enum TThostFtdcFileIDType : byte
    {
        /// <summary>
        ///资金数据
        /// <summary>
        THOST_FTDC_FI_SettlementFund = (byte)'F',
        /// <summary>
        ///成交数据
        /// <summary>
        THOST_FTDC_FI_Trade = (byte)'T',
        /// <summary>
        ///投资者持仓数据
        /// <summary>
        THOST_FTDC_FI_InvestorPosition = (byte)'P',
        /// <summary>
        ///投资者分项资金数据
        /// <summary>
        THOST_FTDC_FI_SubEntryFund = (byte)'O',
        /// <summary>
        ///郑商所组合持仓数据
        /// <summary>
        THOST_FTDC_FI_CZCECombinationPos = (byte)'C',
        /// <summary>
        ///上报保证金监控中心数据
        /// <summary>
        THOST_FTDC_FI_CSRCData = (byte)'R',
        /// <summary>
        ///郑商所平仓了结数据
        /// <summary>
        THOST_FTDC_FI_CZCEClose = (byte)'L',
        /// <summary>
        ///郑商所非平仓了结数据
        /// <summary>
        THOST_FTDC_FI_CZCENoClose = (byte)'N'
    }
    /// <summary>
    ///TFtdcFileTypeType是一个文件上传类型类型
    /// <summary>
    public enum TThostFtdcFileTypeType : byte
    {
        /// <summary>
        ///结算
        /// <summary>
        THOST_FTDC_FUT_Settlement = (byte)'0',
        /// <summary>
        ///核对
        /// <summary>
        THOST_FTDC_FUT_Check = (byte)'1'
    }
    /// <summary>
    ///TFtdcFileFormatType是一个文件格式类型
    /// <summary>
    public enum TThostFtdcFileFormatType : byte
    {
        /// <summary>
        ///文本文件(.txt)
        /// <summary>
        THOST_FTDC_FFT_Txt = (byte)'0',
        /// <summary>
        ///压缩文件(.zip)
        /// <summary>
        THOST_FTDC_FFT_Zip = (byte)'1',
        /// <summary>
        ///DBF文件(.dbf)
        /// <summary>
        THOST_FTDC_FFT_DBF = (byte)'2'
    }
    /// <summary>
    ///TFtdcFileUploadStatusType是一个文件状态类型
    /// <summary>
    public enum TThostFtdcFileUploadStatusType : byte
    {
        /// <summary>
        ///上传成功
        /// <summary>
        THOST_FTDC_FUS_SucceedUpload = (byte)'1',
        /// <summary>
        ///上传失败
        /// <summary>
        THOST_FTDC_FUS_FailedUpload = (byte)'2',
        /// <summary>
        ///导入成功
        /// <summary>
        THOST_FTDC_FUS_SucceedLoad = (byte)'3',
        /// <summary>
        ///导入部分成功
        /// <summary>
        THOST_FTDC_FUS_PartSucceedLoad = (byte)'4',
        /// <summary>
        ///导入失败
        /// <summary>
        THOST_FTDC_FUS_FailedLoad = (byte)'5'
    }
    /// <summary>
    ///TFtdcTransferDirectionType是一个移仓方向类型
    /// <summary>
    public enum TThostFtdcTransferDirectionType : byte
    {
        /// <summary>
        ///移出
        /// <summary>
        THOST_FTDC_TD_Out = (byte)'0',
        /// <summary>
        ///移入
        /// <summary>
        THOST_FTDC_TD_In = (byte)'1'
    }
    /// <summary>
    ///TFtdcBankFlagType是一个银行统一标识类型类型
    /// <summary>
    public enum TThostFtdcBankFlagType : byte
    {
        /// <summary>
        ///工商银行
        /// <summary>
        THOST_FTDC_BF_ICBC = (byte)'1',
        /// <summary>
        ///农业银行
        /// <summary>
        THOST_FTDC_BF_ABC = (byte)'2',
        /// <summary>
        ///中国银行
        /// <summary>
        THOST_FTDC_BF_BC = (byte)'3',
        /// <summary>
        ///建设银行
        /// <summary>
        THOST_FTDC_BF_CBC = (byte)'4',
        /// <summary>
        ///交通银行
        /// <summary>
        THOST_FTDC_BF_BOC = (byte)'5',
        /// <summary>
        ///其他银行
        /// <summary>
        THOST_FTDC_BF_Other = (byte)'Z'
    }
    /// <summary>
    ///TFtdcSpecialCreateRuleType是一个特殊的创建规则类型
    /// <summary>
    public enum TThostFtdcSpecialCreateRuleType : byte
    {
        /// <summary>
        ///没有特殊创建规则
        /// <summary>
        THOST_FTDC_SC_NoSpecialRule = (byte)'0',
        /// <summary>
        ///不包含春节
        /// <summary>
        THOST_FTDC_SC_NoSpringFestival = (byte)'1'
    }
    /// <summary>
    ///TFtdcBasisPriceTypeType是一个挂牌基准价类型类型
    /// <summary>
    public enum TThostFtdcBasisPriceTypeType : byte
    {
        /// <summary>
        ///上一合约结算价
        /// <summary>
        THOST_FTDC_IPT_LastSettlement = (byte)'1',
        /// <summary>
        ///上一合约收盘价
        /// <summary>
        THOST_FTDC_IPT_LaseClose = (byte)'2'
    }
    /// <summary>
    ///TFtdcProductLifePhaseType是一个产品生命周期状态类型
    /// <summary>
    public enum TThostFtdcProductLifePhaseType : byte
    {
        /// <summary>
        ///活跃
        /// <summary>
        THOST_FTDC_PLP_Active = (byte)'1',
        /// <summary>
        ///不活跃
        /// <summary>
        THOST_FTDC_PLP_NonActive = (byte)'2',
        /// <summary>
        ///注销
        /// <summary>
        THOST_FTDC_PLP_Canceled = (byte)'3'
    }
    /// <summary>
    ///TFtdcDeliveryModeType是一个交割方式类型
    /// <summary>
    public enum TThostFtdcDeliveryModeType : byte
    {
        /// <summary>
        ///现金交割
        /// <summary>
        THOST_FTDC_DM_CashDeliv = (byte)'1',
        /// <summary>
        ///实物交割
        /// <summary>
        THOST_FTDC_DM_CommodityDeliv = (byte)'2'
    }
    /// <summary>
    ///TFtdcFundIOTypeType是一个出入金类型类型
    /// <summary>
    public enum TThostFtdcFundIOTypeType : byte
    {
        /// <summary>
        ///出入金
        /// <summary>
        THOST_FTDC_FIOT_FundIO = (byte)'1',
        /// <summary>
        ///银期转帐
        /// <summary>
        THOST_FTDC_FIOT_Transfer = (byte)'2'
    }
    /// <summary>
    ///TFtdcFundTypeType是一个资金类型类型
    /// <summary>
    public enum TThostFtdcFundTypeType : byte
    {
        /// <summary>
        ///银行存款
        /// <summary>
        THOST_FTDC_FT_Deposite = (byte)'1',
        /// <summary>
        ///分项资金
        /// <summary>
        THOST_FTDC_FT_ItemFund = (byte)'2',
        /// <summary>
        ///公司调整
        /// <summary>
        THOST_FTDC_FT_Company = (byte)'3'
    }
    /// <summary>
    ///TFtdcFundDirectionType是一个出入金方向类型
    /// <summary>
    public enum TThostFtdcFundDirectionType : byte
    {
        /// <summary>
        ///入金
        /// <summary>
        THOST_FTDC_FD_In = (byte)'1',
        /// <summary>
        ///出金
        /// <summary>
        THOST_FTDC_FD_Out = (byte)'2'
    }
    /// <summary>
    ///TFtdcFundStatusType是一个资金状态类型
    /// <summary>
    public enum TThostFtdcFundStatusType : byte
    {
        /// <summary>
        ///已录入
        /// <summary>
        THOST_FTDC_FS_Record = (byte)'1',
        /// <summary>
        ///已复核
        /// <summary>
        THOST_FTDC_FS_Check = (byte)'2',
        /// <summary>
        ///已冲销
        /// <summary>
        THOST_FTDC_FS_Charge = (byte)'3'
    }
    /// <summary>
    ///TFtdcPublishStatusType是一个发布状态类型
    /// <summary>
    public enum TThostFtdcPublishStatusType : byte
    {
        /// <summary>
        ///未发布
        /// <summary>
        THOST_FTDC_PS_None = (byte)'1',
        /// <summary>
        ///正在发布
        /// <summary>
        THOST_FTDC_PS_Publishing = (byte)'2',
        /// <summary>
        ///已发布
        /// <summary>
        THOST_FTDC_PS_Published = (byte)'3'
    }
    /// <summary>
    ///TFtdcSystemStatusType是一个系统状态类型
    /// <summary>
    public enum TThostFtdcSystemStatusType : byte
    {
        /// <summary>
        ///不活跃
        /// <summary>
        THOST_FTDC_ES_NonActive = (byte)'1',
        /// <summary>
        ///启动
        /// <summary>
        THOST_FTDC_ES_Startup = (byte)'2',
        /// <summary>
        ///交易开始初始化
        /// <summary>
        THOST_FTDC_ES_Initialize = (byte)'3',
        /// <summary>
        ///交易完成初始化
        /// <summary>
        THOST_FTDC_ES_Initialized = (byte)'4',
        /// <summary>
        ///收市开始
        /// <summary>
        THOST_FTDC_ES_Close = (byte)'5',
        /// <summary>
        ///收市完成
        /// <summary>
        THOST_FTDC_ES_Closed = (byte)'6',
        /// <summary>
        ///结算
        /// <summary>
        THOST_FTDC_ES_Settlement = (byte)'7'
    }
    /// <summary>
    ///TFtdcSettlementStatusType是一个结算状态类型
    /// <summary>
    public enum TThostFtdcSettlementStatusType : byte
    {
        /// <summary>
        ///初始
        /// <summary>
        THOST_FTDC_STS_Initialize = (byte)'0',
        /// <summary>
        ///结算中
        /// <summary>
        THOST_FTDC_STS_Settlementing = (byte)'1',
        /// <summary>
        ///已结算
        /// <summary>
        THOST_FTDC_STS_Settlemented = (byte)'2',
        /// <summary>
        ///结算完成
        /// <summary>
        THOST_FTDC_STS_Finished = (byte)'3'
    }
    /// <summary>
    ///TFtdcInvestorTypeType是一个投资者类型类型
    /// <summary>
    public enum TThostFtdcInvestorTypeType : byte
    {
        /// <summary>
        ///自然人
        /// <summary>
        THOST_FTDC_CT_Person = (byte)'0',
        /// <summary>
        ///法人
        /// <summary>
        THOST_FTDC_CT_Company = (byte)'1',
        /// <summary>
        ///投资基金
        /// <summary>
        THOST_FTDC_CT_Fund = (byte)'2',
        /// <summary>
        ///特殊法人
        /// <summary>
        THOST_FTDC_CT_SpecialOrgan = (byte)'3'
    }
    /// <summary>
    ///TFtdcBrokerTypeType是一个经纪公司类型类型
    /// <summary>
    public enum TThostFtdcBrokerTypeType : byte
    {
        /// <summary>
        ///交易会员
        /// <summary>
        THOST_FTDC_BT_Trade = (byte)'0',
        /// <summary>
        ///交易结算会员
        /// <summary>
        THOST_FTDC_BT_TradeSettle = (byte)'1'
    }
    /// <summary>
    ///TFtdcRiskLevelType是一个风险等级类型
    /// <summary>
    public enum TThostFtdcRiskLevelType : byte
    {
        /// <summary>
        ///低风险客户
        /// <summary>
        THOST_FTDC_FAS_Low = (byte)'1',
        /// <summary>
        ///普通客户
        /// <summary>
        THOST_FTDC_FAS_Normal = (byte)'2',
        /// <summary>
        ///关注客户
        /// <summary>
        THOST_FTDC_FAS_Focus = (byte)'3',
        /// <summary>
        ///风险客户
        /// <summary>
        THOST_FTDC_FAS_Risk = (byte)'4'
    }
    /// <summary>
    ///TFtdcFeeAcceptStyleType是一个手续费收取方式类型
    /// <summary>
    public enum TThostFtdcFeeAcceptStyleType : byte
    {
        /// <summary>
        ///按交易收取
        /// <summary>
        THOST_FTDC_FAS_ByTrade = (byte)'1',
        /// <summary>
        ///按交割收取
        /// <summary>
        THOST_FTDC_FAS_ByDeliv = (byte)'2',
        /// <summary>
        ///不收
        /// <summary>
        THOST_FTDC_FAS_None = (byte)'3',
        /// <summary>
        ///按指定手续费收取
        /// <summary>
        THOST_FTDC_FAS_FixFee = (byte)'4'
    }
    /// <summary>
    ///TFtdcPasswordTypeType是一个密码类型类型
    /// <summary>
    public enum TThostFtdcPasswordTypeType : byte
    {
        /// <summary>
        ///交易密码
        /// <summary>
        THOST_FTDC_PWDT_Trade = (byte)'1',
        /// <summary>
        ///资金密码
        /// <summary>
        THOST_FTDC_PWDT_Account = (byte)'2'
    }
    /// <summary>
    ///TFtdcAlgorithmType是一个盈亏算法类型
    /// <summary>
    public enum TThostFtdcAlgorithmType : byte
    {
        /// <summary>
        ///浮盈浮亏都计算
        /// <summary>
        THOST_FTDC_AG_All = (byte)'1',
        /// <summary>
        ///浮盈不计，浮亏计
        /// <summary>
        THOST_FTDC_AG_OnlyLost = (byte)'2',
        /// <summary>
        ///浮盈计，浮亏不计
        /// <summary>
        THOST_FTDC_AG_OnlyGain = (byte)'3',
        /// <summary>
        ///浮盈浮亏都不计算
        /// <summary>
        THOST_FTDC_AG_None = (byte)'4'
    }
    /// <summary>
    ///TFtdcIncludeCloseProfitType是一个是否包含平仓盈利类型
    /// <summary>
    public enum TThostFtdcIncludeCloseProfitType : byte
    {
        /// <summary>
        ///包含平仓盈利
        /// <summary>
        THOST_FTDC_ICP_Include = (byte)'0',
        /// <summary>
        ///不包含平仓盈利
        /// <summary>
        THOST_FTDC_ICP_NotInclude = (byte)'2'
    }
    /// <summary>
    ///TFtdcAllWithoutTradeType是一个是否受可提比例限制类型
    /// <summary>
    public enum TThostFtdcAllWithoutTradeType : byte
    {
        /// <summary>
        ///无仓无成交不受可提比例限制
        /// <summary>
        THOST_FTDC_AWT_Enable = (byte)'0',
        /// <summary>
        ///受可提比例限制
        /// <summary>
        THOST_FTDC_AWT_Disable = (byte)'2',
        /// <summary>
        ///无仓不受可提比例限制
        /// <summary>
        THOST_FTDC_AWT_NoHoldEnable = (byte)'3'
    }
    /// <summary>
    ///TFtdcFuturePwdFlagType是一个资金密码核对标志类型
    /// <summary>
    public enum TThostFtdcFuturePwdFlagType : byte
    {
        /// <summary>
        ///不核对
        /// <summary>
        THOST_FTDC_FPWD_UnCheck = (byte)'0',
        /// <summary>
        ///核对
        /// <summary>
        THOST_FTDC_FPWD_Check = (byte)'1'
    }
    /// <summary>
    ///TFtdcTransferTypeType是一个银期转账类型类型
    /// <summary>
    public enum TThostFtdcTransferTypeType : byte
    {
        /// <summary>
        ///银行转期货
        /// <summary>
        THOST_FTDC_TT_BankToFuture = (byte)'0',
        /// <summary>
        ///期货转银行
        /// <summary>
        THOST_FTDC_TT_FutureToBank = (byte)'1'
    }
    /// <summary>
    ///TFtdcTransferValidFlagType是一个转账有效标志类型
    /// <summary>
    public enum TThostFtdcTransferValidFlagType : byte
    {
        /// <summary>
        ///无效或失败
        /// <summary>
        THOST_FTDC_TVF_Invalid = (byte)'0',
        /// <summary>
        ///有效
        /// <summary>
        THOST_FTDC_TVF_Valid = (byte)'1',
        /// <summary>
        ///冲正
        /// <summary>
        THOST_FTDC_TVF_Reverse = (byte)'2'
    }
    /// <summary>
    ///TFtdcReasonType是一个事由类型
    /// <summary>
    public enum TThostFtdcReasonType : byte
    {
        /// <summary>
        ///错单
        /// <summary>
        THOST_FTDC_RN_CD = (byte)'0',
        /// <summary>
        ///资金在途
        /// <summary>
        THOST_FTDC_RN_ZT = (byte)'1',
        /// <summary>
        ///其它
        /// <summary>
        THOST_FTDC_RN_QT = (byte)'2'
    }
    /// <summary>
    ///TFtdcSexType是一个性别类型
    /// <summary>
    public enum TThostFtdcSexType : byte
    {
        /// <summary>
        ///未知
        /// <summary>
        THOST_FTDC_SEX_None = (byte)'0',
        /// <summary>
        ///男
        /// <summary>
        THOST_FTDC_SEX_Man = (byte)'1',
        /// <summary>
        ///女
        /// <summary>
        THOST_FTDC_SEX_Woman = (byte)'2'
    }
    /// <summary>
    ///TFtdcUserTypeType是一个用户类型类型
    /// <summary>
    public enum TThostFtdcUserTypeType : byte
    {
        /// <summary>
        ///投资者
        /// <summary>
        THOST_FTDC_UT_Investor = (byte)'0',
        /// <summary>
        ///操作员
        /// <summary>
        THOST_FTDC_UT_Operator = (byte)'1',
        /// <summary>
        ///管理员
        /// <summary>
        THOST_FTDC_UT_SuperUser = (byte)'2'
    }
    /// <summary>
    ///TFtdcRateTypeType是一个费率类型类型
    /// <summary>
    public enum TThostFtdcRateTypeType : byte
    {
        /// <summary>
        ///保证金率
        /// <summary>
        THOST_FTDC_RATETYPE_MarginRate = (byte)'2'
    }
    /// <summary>
    ///TFtdcNoteTypeType是一个通知类型类型
    /// <summary>
    public enum TThostFtdcNoteTypeType : byte
    {
        /// <summary>
        ///交易结算单
        /// <summary>
        THOST_FTDC_NOTETYPE_TradeSettleBill = (byte)'1',
        /// <summary>
        ///交易结算月报
        /// <summary>
        THOST_FTDC_NOTETYPE_TradeSettleMonth = (byte)'2',
        /// <summary>
        ///追加保证金通知书
        /// <summary>
        THOST_FTDC_NOTETYPE_CallMarginNotes = (byte)'3',
        /// <summary>
        ///强行平仓通知书
        /// <summary>
        THOST_FTDC_NOTETYPE_ForceCloseNotes = (byte)'4',
        /// <summary>
        ///成交通知书
        /// <summary>
        THOST_FTDC_NOTETYPE_TradeNotes = (byte)'5',
        /// <summary>
        ///交割通知书
        /// <summary>
        THOST_FTDC_NOTETYPE_DelivNotes = (byte)'6'
    }
    /// <summary>
    ///TFtdcSettlementStyleType是一个结算单方式类型
    /// <summary>
    public enum TThostFtdcSettlementStyleType : byte
    {
        /// <summary>
        ///逐日盯市
        /// <summary>
        THOST_FTDC_SBS_Day = (byte)'1',
        /// <summary>
        ///逐笔对冲
        /// <summary>
        THOST_FTDC_SBS_Volume = (byte)'2'
    }
    /// <summary>
    ///TFtdcSettlementBillTypeType是一个结算单类型类型
    /// <summary>
    public enum TThostFtdcSettlementBillTypeType : byte
    {
        /// <summary>
        ///日报
        /// <summary>
        THOST_FTDC_ST_Day = (byte)'0',
        /// <summary>
        ///月报
        /// <summary>
        THOST_FTDC_ST_Month = (byte)'1'
    }
    /// <summary>
    ///TFtdcUserRightTypeType是一个客户权限类型类型
    /// <summary>
    public enum TThostFtdcUserRightTypeType : byte
    {
        /// <summary>
        ///登录
        /// <summary>
        THOST_FTDC_URT_Logon = (byte)'1',
        /// <summary>
        ///银期转帐
        /// <summary>
        THOST_FTDC_URT_Transfer = (byte)'2',
        /// <summary>
        ///邮寄结算单
        /// <summary>
        THOST_FTDC_URT_EMail = (byte)'3',
        /// <summary>
        ///传真结算单
        /// <summary>
        THOST_FTDC_URT_Fax = (byte)'4',
        /// <summary>
        ///条件单
        /// <summary>
        THOST_FTDC_URT_ConditionOrder = (byte)'5'
    }
    /// <summary>
    ///TFtdcMarginPriceTypeType是一个保证金价格类型类型
    /// <summary>
    public enum TThostFtdcMarginPriceTypeType : byte
    {
        /// <summary>
        ///昨结算价
        /// <summary>
        THOST_FTDC_MPT_PreSettlementPrice = (byte)'1',
        /// <summary>
        ///最新价
        /// <summary>
        THOST_FTDC_MPT_SettlementPrice = (byte)'2',
        /// <summary>
        ///成交均价
        /// <summary>
        THOST_FTDC_MPT_AveragePrice = (byte)'3',
        /// <summary>
        ///开仓价
        /// <summary>
        THOST_FTDC_MPT_OpenPrice = (byte)'4'
    }
    /// <summary>
    ///TFtdcBillGenStatusType是一个结算单生成状态类型
    /// <summary>
    public enum TThostFtdcBillGenStatusType : byte
    {
        /// <summary>
        ///未生成
        /// <summary>
        THOST_FTDC_BGS_None = (byte)'0',
        /// <summary>
        ///生成中
        /// <summary>
        THOST_FTDC_BGS_NoGenerated = (byte)'1',
        /// <summary>
        ///已生成
        /// <summary>
        THOST_FTDC_BGS_Generated = (byte)'2'
    }
    /// <summary>
    ///TFtdcAlgoTypeType是一个算法类型类型
    /// <summary>
    public enum TThostFtdcAlgoTypeType : byte
    {
        /// <summary>
        ///持仓处理算法
        /// <summary>
        THOST_FTDC_AT_HandlePositionAlgo = (byte)'1',
        /// <summary>
        ///寻找保证金率算法
        /// <summary>
        THOST_FTDC_AT_FindMarginRateAlgo = (byte)'2'
    }
    /// <summary>
    ///TFtdcHandlePositionAlgoIDType是一个持仓处理算法编号类型
    /// <summary>
    public enum TThostFtdcHandlePositionAlgoIDType : byte
    {
        /// <summary>
        ///基本
        /// <summary>
        THOST_FTDC_HPA_Base = (byte)'1',
        /// <summary>
        ///大连商品交易所
        /// <summary>
        THOST_FTDC_HPA_DCE = (byte)'2',
        /// <summary>
        ///郑州商品交易所
        /// <summary>
        THOST_FTDC_HPA_CZCE = (byte)'3'
    }
    /// <summary>
    ///TFtdcFindMarginRateAlgoIDType是一个寻找保证金率算法编号类型
    /// <summary>
    public enum TThostFtdcFindMarginRateAlgoIDType : byte
    {
        /// <summary>
        ///基本
        /// <summary>
        THOST_FTDC_FMRA_Base = (byte)'1',
        /// <summary>
        ///大连商品交易所
        /// <summary>
        THOST_FTDC_FMRA_DCE = (byte)'2',
        /// <summary>
        ///郑州商品交易所
        /// <summary>
        THOST_FTDC_FMRA_CZCE = (byte)'3'
    }
    /// <summary>
    ///TFtdcHandleTradingAccountAlgoIDType是一个资金处理算法编号类型
    /// <summary>
    public enum TThostFtdcHandleTradingAccountAlgoIDType : byte
    {
        /// <summary>
        ///基本
        /// <summary>
        THOST_FTDC_HTAA_Base = (byte)'1',
        /// <summary>
        ///大连商品交易所
        /// <summary>
        THOST_FTDC_HTAA_DCE = (byte)'2',
        /// <summary>
        ///郑州商品交易所
        /// <summary>
        THOST_FTDC_HTAA_CZCE = (byte)'3'
    }
    /// <summary>
    ///TFtdcPersonTypeType是一个联系人类型类型
    /// <summary>
    public enum TThostFtdcPersonTypeType : byte
    {
        /// <summary>
        ///指定下单人
        /// <summary>
        THOST_FTDC_PST_Order = (byte)'1',
        /// <summary>
        ///开户授权人
        /// <summary>
        THOST_FTDC_PST_Open = (byte)'2',
        /// <summary>
        ///资金调拨人
        /// <summary>
        THOST_FTDC_PST_Fund = (byte)'3',
        /// <summary>
        ///结算单确认人
        /// <summary>
        THOST_FTDC_PST_Settlement = (byte)'4',
        /// <summary>
        ///法人
        /// <summary>
        THOST_FTDC_PST_Company = (byte)'5',
        /// <summary>
        ///法人代表
        /// <summary>
        THOST_FTDC_PST_Corporation = (byte)'6',
        /// <summary>
        ///投资者联系人
        /// <summary>
        THOST_FTDC_PST_LinkMan = (byte)'7',
        /// <summary>
        ///分户管理资产负责人
        /// <summary>
        THOST_FTDC_PST_Ledger = (byte)'8',
        /// <summary>
        ///托（保）管人
        /// <summary>
        THOST_FTDC_PST_Trustee = (byte)'9',
        /// <summary>
        ///托（保）管机构法人代表
        /// <summary>
        THOST_FTDC_PST_TrusteeCorporation = (byte)'A',
        /// <summary>
        ///托（保）管机构开户授权人
        /// <summary>
        THOST_FTDC_PST_TrusteeOpen = (byte)'B',
        /// <summary>
        ///托（保）管机构联系人
        /// <summary>
        THOST_FTDC_PST_TrusteeContact = (byte)'C'
    }
    /// <summary>
    ///TFtdcQueryInvestorRangeType是一个查询范围类型
    /// <summary>
    public enum TThostFtdcQueryInvestorRangeType : byte
    {
        /// <summary>
        ///所有
        /// <summary>
        THOST_FTDC_QIR_All = (byte)'1',
        /// <summary>
        ///查询分类
        /// <summary>
        THOST_FTDC_QIR_Group = (byte)'2',
        /// <summary>
        ///单一投资者
        /// <summary>
        THOST_FTDC_QIR_Single = (byte)'3'
    }
    /// <summary>
    ///TFtdcInvestorRiskStatusType是一个投资者风险状态类型
    /// <summary>
    public enum TThostFtdcInvestorRiskStatusType : byte
    {
        /// <summary>
        ///正常
        /// <summary>
        THOST_FTDC_IRS_Normal = (byte)'1',
        /// <summary>
        ///警告
        /// <summary>
        THOST_FTDC_IRS_Warn = (byte)'2',
        /// <summary>
        ///追保
        /// <summary>
        THOST_FTDC_IRS_Call = (byte)'3',
        /// <summary>
        ///强平
        /// <summary>
        THOST_FTDC_IRS_Force = (byte)'4',
        /// <summary>
        ///异常
        /// <summary>
        THOST_FTDC_IRS_Exception = (byte)'5'
    }
    /// <summary>
    ///TFtdcUserEventTypeType是一个用户事件类型类型
    /// <summary>
    public enum TThostFtdcUserEventTypeType : byte
    {
        /// <summary>
        ///登录
        /// <summary>
        THOST_FTDC_UET_Login = (byte)'1',
        /// <summary>
        ///登出
        /// <summary>
        THOST_FTDC_UET_Logout = (byte)'2',
        /// <summary>
        ///交易成功
        /// <summary>
        THOST_FTDC_UET_Trading = (byte)'3',
        /// <summary>
        ///交易失败
        /// <summary>
        THOST_FTDC_UET_TradingError = (byte)'4',
        /// <summary>
        ///修改密码
        /// <summary>
        THOST_FTDC_UET_UpdatePassword = (byte)'5',
        /// <summary>
        ///客户端认证
        /// <summary>
        THOST_FTDC_UET_Authenticate = (byte)'6',
        /// <summary>
        ///其他
        /// <summary>
        THOST_FTDC_UET_Other = (byte)'9'
    }
    /// <summary>
    ///TFtdcCloseStyleType是一个平仓方式类型
    /// <summary>
    public enum TThostFtdcCloseStyleType : byte
    {
        /// <summary>
        ///先开先平
        /// <summary>
        THOST_FTDC_ICS_Close = (byte)'0',
        /// <summary>
        ///先平今再平昨
        /// <summary>
        THOST_FTDC_ICS_CloseToday = (byte)'1'
    }
    /// <summary>
    ///TFtdcStatModeType是一个统计方式类型
    /// <summary>
    public enum TThostFtdcStatModeType : byte
    {
        /// <summary>
        ///----
        /// <summary>
        THOST_FTDC_SM_Non = (byte)'0',
        /// <summary>
        ///按合约统计
        /// <summary>
        THOST_FTDC_SM_Instrument = (byte)'1',
        /// <summary>
        ///按产品统计
        /// <summary>
        THOST_FTDC_SM_Product = (byte)'2',
        /// <summary>
        ///按投资者统计
        /// <summary>
        THOST_FTDC_SM_Investor = (byte)'3'
    }
    /// <summary>
    ///TFtdcParkedOrderStatusType是一个预埋单状态类型
    /// <summary>
    public enum TThostFtdcParkedOrderStatusType : byte
    {
        /// <summary>
        ///未发送
        /// <summary>
        THOST_FTDC_PAOS_NotSend = (byte)'1',
        /// <summary>
        ///已发送
        /// <summary>
        THOST_FTDC_PAOS_Send = (byte)'2',
        /// <summary>
        ///已删除
        /// <summary>
        THOST_FTDC_PAOS_Deleted = (byte)'3'
    }
    /// <summary>
    ///TFtdcVirDealStatusType是一个处理状态类型
    /// <summary>
    public enum TThostFtdcVirDealStatusType : byte
    {
        /// <summary>
        ///正在处理
        /// <summary>
        THOST_FTDC_VDS_Dealing = (byte)'1',
        /// <summary>
        ///处理成功
        /// <summary>
        THOST_FTDC_VDS_DeaclSucceed = (byte)'2'
    }
    /// <summary>
    ///TFtdcOrgSystemIDType是一个原有系统代码类型
    /// <summary>
    public enum TThostFtdcOrgSystemIDType : byte
    {
        /// <summary>
        ///综合交易平台
        /// <summary>
        THOST_FTDC_ORGS_Standard = (byte)'0',
        /// <summary>
        ///易盛系统
        /// <summary>
        THOST_FTDC_ORGS_ESunny = (byte)'1',
        /// <summary>
        ///金仕达V6系统
        /// <summary>
        THOST_FTDC_ORGS_KingStarV6 = (byte)'2'
    }
    /// <summary>
    ///TFtdcVirTradeStatusType是一个交易状态类型
    /// <summary>
    public enum TThostFtdcVirTradeStatusType : byte
    {
        /// <summary>
        ///正常处理中
        /// <summary>
        THOST_FTDC_VTS_NaturalDeal = (byte)'0',
        /// <summary>
        ///成功结束
        /// <summary>
        THOST_FTDC_VTS_SucceedEnd = (byte)'1',
        /// <summary>
        ///失败结束
        /// <summary>
        THOST_FTDC_VTS_FailedEND = (byte)'2',
        /// <summary>
        ///异常中
        /// <summary>
        THOST_FTDC_VTS_Exception = (byte)'3',
        /// <summary>
        ///已人工异常处理
        /// <summary>
        THOST_FTDC_VTS_ManualDeal = (byte)'4',
        /// <summary>
        ///通讯异常 ，请人工处理
        /// <summary>
        THOST_FTDC_VTS_MesException = (byte)'5',
        /// <summary>
        ///系统出错，请人工处理
        /// <summary>
        THOST_FTDC_VTS_SysException = (byte)'6'
    }
    /// <summary>
    ///TFtdcVirBankAccTypeType是一个银行帐户类型类型
    /// <summary>
    public enum TThostFtdcVirBankAccTypeType : byte
    {
        /// <summary>
        ///存折
        /// <summary>
        THOST_FTDC_VBAT_BankBook = (byte)'1',
        /// <summary>
        ///储蓄卡
        /// <summary>
        THOST_FTDC_VBAT_BankCard = (byte)'2',
        /// <summary>
        ///信用卡
        /// <summary>
        THOST_FTDC_VBAT_CreditCard = (byte)'3'
    }
    /// <summary>
    ///TFtdcVirementStatusType是一个银行帐户类型类型
    /// <summary>
    public enum TThostFtdcVirementStatusType : byte
    {
        /// <summary>
        ///正常
        /// <summary>
        THOST_FTDC_VMS_Natural = (byte)'0',
        /// <summary>
        ///销户
        /// <summary>
        THOST_FTDC_VMS_Canceled = (byte)'9'
    }
    /// <summary>
    ///TFtdcVirementAvailAbilityType是一个有效标志类型
    /// <summary>
    public enum TThostFtdcVirementAvailAbilityType : byte
    {
        /// <summary>
        ///未确认
        /// <summary>
        THOST_FTDC_VAA_NoAvailAbility = (byte)'0',
        /// <summary>
        ///有效
        /// <summary>
        THOST_FTDC_VAA_AvailAbility = (byte)'1',
        /// <summary>
        ///冲正
        /// <summary>
        THOST_FTDC_VAA_Repeal = (byte)'2'
    }
    /// <summary>
    ///TFtdcVirementTradeCodeType是一个交易代码类型
    /// <summary>
    public enum TThostFtdcVirementTradeCodeType : byte
    {
        /// <summary>
        ///银行发起银行资金转期货
        /// <summary>
        THOST_FTDC_VTC_BankBankToFuture = (byte)'1',
        /// <summary>
        ///银行发起期货资金转银行
        /// <summary>
        THOST_FTDC_VTC_BankFutureToBank = (byte)'2',
        /// <summary>
        ///期货发起银行资金转期货
        /// <summary>
        THOST_FTDC_VTC_FutureBankToFuture = (byte)'3',
        /// <summary>
        ///期货发起期货资金转银行
        /// <summary>
        THOST_FTDC_VTC_FutureFutureToBank = (byte)'4'
    }
    /// <summary>
    ///TFtdcAMLGenStatusType是一个Aml生成方式类型
    /// <summary>
    public enum TThostFtdcAMLGenStatusType : byte
    {
        /// <summary>
        ///程序生成
        /// <summary>
        THOST_FTDC_GEN_Program = (byte)'0',
        /// <summary>
        ///人工生成
        /// <summary>
        THOST_FTDC_GEN_HandWork = (byte)'1'
    }
    /// <summary>
    ///TFtdcCFMMCKeyKindType是一个动态密钥类别(保证金监管)类型
    /// <summary>
    public enum TThostFtdcCFMMCKeyKindType : byte
    {
        /// <summary>
        ///主动请求更新
        /// <summary>
        THOST_FTDC_CFMMCKK_REQUEST = (byte)'R',
        /// <summary>
        ///CFMMC自动更新
        /// <summary>
        THOST_FTDC_CFMMCKK_AUTO = (byte)'A',
        /// <summary>
        ///CFMMC手动更新
        /// <summary>
        THOST_FTDC_CFMMCKK_MANUAL = (byte)'M'
    }
    /// <summary>
    ///TFtdcCertificationTypeType是一个证件类型类型
    /// <summary>
    public enum TThostFtdcCertificationTypeType : byte
    {
        /// <summary>
        ///身份证
        /// <summary>
        THOST_FTDC_CFT_IDCard = (byte)'0',
        /// <summary>
        ///护照
        /// <summary>
        THOST_FTDC_CFT_Passport = (byte)'1',
        /// <summary>
        ///军官证
        /// <summary>
        THOST_FTDC_CFT_OfficerIDCard = (byte)'2',
        /// <summary>
        ///士兵证
        /// <summary>
        THOST_FTDC_CFT_SoldierIDCard = (byte)'3',
        /// <summary>
        ///回乡证
        /// <summary>
        THOST_FTDC_CFT_HomeComingCard = (byte)'4',
        /// <summary>
        ///户口簿
        /// <summary>
        THOST_FTDC_CFT_HouseholdRegister = (byte)'5',
        /// <summary>
        ///营业执照号
        /// <summary>
        THOST_FTDC_CFT_LicenseNo = (byte)'6',
        /// <summary>
        ///组织机构代码证
        /// <summary>
        THOST_FTDC_CFT_InstitutionCodeCard = (byte)'7',
        /// <summary>
        ///临时营业执照号
        /// <summary>
        THOST_FTDC_CFT_TempLicenseNo = (byte)'8',
        /// <summary>
        ///民办非企业登记证书
        /// <summary>
        THOST_FTDC_CFT_NoEnterpriseLicenseNo = (byte)'9',
        /// <summary>
        ///其他证件
        /// <summary>
        THOST_FTDC_CFT_OtherCard = (byte)'x',
        /// <summary>
        ///主管部门批文
        /// <summary>
        THOST_FTDC_CFT_SuperDepAgree = (byte)'a'
    }
    /// <summary>
    ///TFtdcFileBusinessCodeType是一个文件业务功能类型
    /// <summary>
    public enum TThostFtdcFileBusinessCodeType : byte
    {
        /// <summary>
        ///其他
        /// <summary>
        THOST_FTDC_FBC_Others = (byte)'0',
        /// <summary>
        ///转账交易明细对账
        /// <summary>
        THOST_FTDC_FBC_TransferDetails = (byte)'1',
        /// <summary>
        ///客户账户状态对账
        /// <summary>
        THOST_FTDC_FBC_CustAccStatus = (byte)'2',
        /// <summary>
        ///账户类交易明细对账
        /// <summary>
        THOST_FTDC_FBC_AccountTradeDetails = (byte)'3',
        /// <summary>
        ///期货账户信息变更明细对账
        /// <summary>
        THOST_FTDC_FBC_FutureAccountChangeInfoDetails = (byte)'4',
        /// <summary>
        ///客户资金台账余额明细对账
        /// <summary>
        THOST_FTDC_FBC_CustMoneyDetail = (byte)'5',
        /// <summary>
        ///客户销户结息明细对账
        /// <summary>
        THOST_FTDC_FBC_CustCancelAccountInfo = (byte)'6',
        /// <summary>
        ///客户资金余额对账结果
        /// <summary>
        THOST_FTDC_FBC_CustMoneyResult = (byte)'7',
        /// <summary>
        ///其它对账异常结果文件
        /// <summary>
        THOST_FTDC_FBC_OthersExceptionResult = (byte)'8',
        /// <summary>
        ///客户结息净额明细
        /// <summary>
        THOST_FTDC_FBC_CustInterestNetMoneyDetails = (byte)'9',
        /// <summary>
        ///客户资金交收明细
        /// <summary>
        THOST_FTDC_FBC_CustMoneySendAndReceiveDetails = (byte)'a',
        /// <summary>
        ///法人存管银行资金交收汇总
        /// <summary>
        THOST_FTDC_FBC_CorporationMoneyTotal = (byte)'b',
        /// <summary>
        ///主体间资金交收汇总
        /// <summary>
        THOST_FTDC_FBC_MainbodyMoneyTotal = (byte)'c',
        /// <summary>
        ///总分平衡监管数据
        /// <summary>
        THOST_FTDC_FBC_MainPartMonitorData = (byte)'d',
        /// <summary>
        ///存管银行备付金余额
        /// <summary>
        THOST_FTDC_FBC_PreparationMoney = (byte)'e',
        /// <summary>
        ///协办存管银行资金监管数据
        /// <summary>
        THOST_FTDC_FBC_BankMoneyMonitorData = (byte)'f'
    }
    /// <summary>
    ///TFtdcCashExchangeCodeType是一个汇钞标志类型
    /// <summary>
    public enum TThostFtdcCashExchangeCodeType : byte
    {
        /// <summary>
        ///汇
        /// <summary>
        THOST_FTDC_CEC_Exchange = (byte)'1',
        /// <summary>
        ///钞
        /// <summary>
        THOST_FTDC_CEC_Cash = (byte)'2'
    }
    /// <summary>
    ///TFtdcYesNoIndicatorType是一个是或否标识类型
    /// <summary>
    public enum TThostFtdcYesNoIndicatorType : byte
    {
        /// <summary>
        ///是
        /// <summary>
        THOST_FTDC_YNI_Yes = (byte)'0',
        /// <summary>
        ///否
        /// <summary>
        THOST_FTDC_YNI_No = (byte)'1'
    }
    /// <summary>
    ///TFtdcBanlanceTypeType是一个余额类型类型
    /// <summary>
    public enum TThostFtdcBanlanceTypeType : byte
    {
        /// <summary>
        ///当前余额
        /// <summary>
        THOST_FTDC_BLT_CurrentMoney = (byte)'0',
        /// <summary>
        ///可用余额
        /// <summary>
        THOST_FTDC_BLT_UsableMoney = (byte)'1',
        /// <summary>
        ///可取余额
        /// <summary>
        THOST_FTDC_BLT_FetchableMoney = (byte)'2',
        /// <summary>
        ///冻结余额
        /// <summary>
        THOST_FTDC_BLT_FreezeMoney = (byte)'3'
    }
    /// <summary>
    ///TFtdcGenderType是一个性别类型
    /// <summary>
    public enum TThostFtdcGenderType : byte
    {
        /// <summary>
        ///未知状态
        /// <summary>
        THOST_FTDC_GD_Unknown = (byte)'0',
        /// <summary>
        ///男
        /// <summary>
        THOST_FTDC_GD_Male = (byte)'1',
        /// <summary>
        ///女
        /// <summary>
        THOST_FTDC_GD_Female = (byte)'2'
    }
    /// <summary>
    ///TFtdcFeePayFlagType是一个费用支付标志类型
    /// <summary>
    public enum TThostFtdcFeePayFlagType : byte
    {
        /// <summary>
        ///由受益方支付费用
        /// <summary>
        THOST_FTDC_FPF_BEN = (byte)'0',
        /// <summary>
        ///由发送方支付费用
        /// <summary>
        THOST_FTDC_FPF_OUR = (byte)'1',
        /// <summary>
        ///由发送方支付发起的费用，受益方支付接受的费用
        /// <summary>
        THOST_FTDC_FPF_SHA = (byte)'2'
    }
    /// <summary>
    ///TFtdcPassWordKeyTypeType是一个密钥类型类型
    /// <summary>
    public enum TThostFtdcPassWordKeyTypeType : byte
    {
        /// <summary>
        ///交换密钥
        /// <summary>
        THOST_FTDC_PWKT_ExchangeKey = (byte)'0',
        /// <summary>
        ///密码密钥
        /// <summary>
        THOST_FTDC_PWKT_PassWordKey = (byte)'1',
        /// <summary>
        ///MAC密钥
        /// <summary>
        THOST_FTDC_PWKT_MACKey = (byte)'2',
        /// <summary>
        ///报文密钥
        /// <summary>
        THOST_FTDC_PWKT_MessageKey = (byte)'3'
    }
    /// <summary>
    ///TFtdcFBTPassWordTypeType是一个密码类型类型
    /// <summary>
    public enum TThostFtdcFBTPassWordTypeType : byte
    {
        /// <summary>
        ///查询
        /// <summary>
        THOST_FTDC_PWT_Query = (byte)'0',
        /// <summary>
        ///取款
        /// <summary>
        THOST_FTDC_PWT_Fetch = (byte)'1',
        /// <summary>
        ///转帐
        /// <summary>
        THOST_FTDC_PWT_Transfer = (byte)'2',
        /// <summary>
        ///交易
        /// <summary>
        THOST_FTDC_PWT_Trade = (byte)'3'
    }
    /// <summary>
    ///TFtdcFBTEncryModeType是一个加密方式类型
    /// <summary>
    public enum TThostFtdcFBTEncryModeType : byte
    {
        /// <summary>
        ///不加密
        /// <summary>
        THOST_FTDC_EM_NoEncry = (byte)'0',
        /// <summary>
        ///DES
        /// <summary>
        THOST_FTDC_EM_DES = (byte)'1',
        /// <summary>
        ///3DES
        /// <summary>
        THOST_FTDC_EM_3DES = (byte)'2'
    }
    /// <summary>
    ///TFtdcBankRepealFlagType是一个银行冲正标志类型
    /// <summary>
    public enum TThostFtdcBankRepealFlagType : byte
    {
        /// <summary>
        ///银行无需自动冲正
        /// <summary>
        THOST_FTDC_BRF_BankNotNeedRepeal = (byte)'0',
        /// <summary>
        ///银行待自动冲正
        /// <summary>
        THOST_FTDC_BRF_BankWaitingRepeal = (byte)'1',
        /// <summary>
        ///银行已自动冲正
        /// <summary>
        THOST_FTDC_BRF_BankBeenRepealed = (byte)'2'
    }
    /// <summary>
    ///TFtdcBrokerRepealFlagType是一个期商冲正标志类型
    /// <summary>
    public enum TThostFtdcBrokerRepealFlagType : byte
    {
        /// <summary>
        ///期商无需自动冲正
        /// <summary>
        THOST_FTDC_BRORF_BrokerNotNeedRepeal = (byte)'0',
        /// <summary>
        ///期商待自动冲正
        /// <summary>
        THOST_FTDC_BRORF_BrokerWaitingRepeal = (byte)'1',
        /// <summary>
        ///期商已自动冲正
        /// <summary>
        THOST_FTDC_BRORF_BrokerBeenRepealed = (byte)'2'
    }
    /// <summary>
    ///TFtdcInstitutionTypeType是一个机构类别类型
    /// <summary>
    public enum TThostFtdcInstitutionTypeType : byte
    {
        /// <summary>
        ///银行
        /// <summary>
        THOST_FTDC_TS_Bank = (byte)'0',
        /// <summary>
        ///期商
        /// <summary>
        THOST_FTDC_TS_Future = (byte)'1',
        /// <summary>
        ///券商
        /// <summary>
        THOST_FTDC_TS_Store = (byte)'2'
    }
    /// <summary>
    ///TFtdcLastFragmentType是一个最后分片标志类型
    /// <summary>
    public enum TThostFtdcLastFragmentType : byte
    {
        /// <summary>
        ///是最后分片
        /// <summary>
        THOST_FTDC_LF_Yes = (byte)'0',
        /// <summary>
        ///不是最后分片
        /// <summary>
        THOST_FTDC_LF_No = (byte)'1'
    }
    /// <summary>
    ///TFtdcBankAccStatusType是一个银行账户状态类型
    /// <summary>
    public enum TThostFtdcBankAccStatusType : byte
    {
        /// <summary>
        ///正常
        /// <summary>
        THOST_FTDC_BAS_Normal = (byte)'0',
        /// <summary>
        ///冻结
        /// <summary>
        THOST_FTDC_BAS_Freeze = (byte)'1',
        /// <summary>
        ///挂失
        /// <summary>
        THOST_FTDC_BAS_ReportLoss = (byte)'2'
    }
    /// <summary>
    ///TFtdcMoneyAccountStatusType是一个资金账户状态类型
    /// <summary>
    public enum TThostFtdcMoneyAccountStatusType : byte
    {
        /// <summary>
        ///正常
        /// <summary>
        THOST_FTDC_MAS_Normal = (byte)'0',
        /// <summary>
        ///销户
        /// <summary>
        THOST_FTDC_MAS_Cancel = (byte)'1'
    }
    /// <summary>
    ///TFtdcManageStatusType是一个存管状态类型
    /// <summary>
    public enum TThostFtdcManageStatusType : byte
    {
        /// <summary>
        ///指定存管
        /// <summary>
        THOST_FTDC_MSS_Point = (byte)'0',
        /// <summary>
        ///预指定
        /// <summary>
        THOST_FTDC_MSS_PrePoint = (byte)'1',
        /// <summary>
        ///撤销指定
        /// <summary>
        THOST_FTDC_MSS_CancelPoint = (byte)'2'
    }
    /// <summary>
    ///TFtdcSystemTypeType是一个应用系统类型类型
    /// <summary>
    public enum TThostFtdcSystemTypeType : byte
    {
        /// <summary>
        ///银期转帐
        /// <summary>
        THOST_FTDC_SYT_FutureBankTransfer = (byte)'0',
        /// <summary>
        ///银证转帐
        /// <summary>
        THOST_FTDC_SYT_StockBankTransfer = (byte)'1',
        /// <summary>
        ///第三方存管
        /// <summary>
        THOST_FTDC_SYT_TheThirdPartStore = (byte)'2'
    }
    /// <summary>
    ///TFtdcTxnEndFlagType是一个银期转帐划转结果标志类型
    /// <summary>
    public enum TThostFtdcTxnEndFlagType : byte
    {
        /// <summary>
        ///正常处理中
        /// <summary>
        THOST_FTDC_TEF_NormalProcessing = (byte)'0',
        /// <summary>
        ///成功结束
        /// <summary>
        THOST_FTDC_TEF_Success = (byte)'1',
        /// <summary>
        ///失败结束
        /// <summary>
        THOST_FTDC_TEF_Failed = (byte)'2',
        /// <summary>
        ///异常中
        /// <summary>
        THOST_FTDC_TEF_Abnormal = (byte)'3',
        /// <summary>
        ///已人工异常处理
        /// <summary>
        THOST_FTDC_TEF_ManualProcessedForException = (byte)'4',
        /// <summary>
        ///通讯异常 ，请人工处理
        /// <summary>
        THOST_FTDC_TEF_CommuFailedNeedManualProcess = (byte)'5',
        /// <summary>
        ///系统出错，请人工处理
        /// <summary>
        THOST_FTDC_TEF_SysErrorNeedManualProcess = (byte)'6'
    }
    /// <summary>
    ///TFtdcProcessStatusType是一个银期转帐服务处理状态类型
    /// <summary>
    public enum TThostFtdcProcessStatusType : byte
    {
        /// <summary>
        ///未处理
        /// <summary>
        THOST_FTDC_PSS_NotProcess = (byte)'0',
        /// <summary>
        ///开始处理
        /// <summary>
        THOST_FTDC_PSS_StartProcess = (byte)'1',
        /// <summary>
        ///处理完成
        /// <summary>
        THOST_FTDC_PSS_Finished = (byte)'2'
    }
    /// <summary>
    ///TFtdcCustTypeType是一个客户类型类型
    /// <summary>
    public enum TThostFtdcCustTypeType : byte
    {
        /// <summary>
        ///自然人
        /// <summary>
        THOST_FTDC_CUSTT_Person = (byte)'0',
        /// <summary>
        ///机构户
        /// <summary>
        THOST_FTDC_CUSTT_Institution = (byte)'1'
    }
    /// <summary>
    ///TFtdcFBTTransferDirectionType是一个银期转帐方向类型
    /// <summary>
    public enum TThostFtdcFBTTransferDirectionType : byte
    {
        /// <summary>
        ///入金，银行转期货
        /// <summary>
        THOST_FTDC_FBTTD_FromBankToFuture = (byte)'1',
        /// <summary>
        ///出金，期货转银行
        /// <summary>
        THOST_FTDC_FBTTD_FromFutureToBank = (byte)'2'
    }
    /// <summary>
    ///TFtdcOpenOrDestroyType是一个开销户类别类型
    /// <summary>
    public enum TThostFtdcOpenOrDestroyType : byte
    {
        /// <summary>
        ///开户
        /// <summary>
        THOST_FTDC_OOD_Open = (byte)'1',
        /// <summary>
        ///销户
        /// <summary>
        THOST_FTDC_OOD_Destroy = (byte)'0'
    }
    /// <summary>
    ///TFtdcAvailabilityFlagType是一个有效标志类型
    /// <summary>
    public enum TThostFtdcAvailabilityFlagType : byte
    {
        /// <summary>
        ///未确认
        /// <summary>
        THOST_FTDC_AVAF_Invalid = (byte)'0',
        /// <summary>
        ///有效
        /// <summary>
        THOST_FTDC_AVAF_Valid = (byte)'1',
        /// <summary>
        ///冲正
        /// <summary>
        THOST_FTDC_AVAF_Repeal = (byte)'2'
    }
    /// <summary>
    ///TFtdcOrganTypeType是一个机构类型类型
    /// <summary>
    public enum TThostFtdcOrganTypeType : byte
    {
        /// <summary>
        ///银行代理
        /// <summary>
        THOST_FTDC_OT_Bank = (byte)'1',
        /// <summary>
        ///交易前置
        /// <summary>
        THOST_FTDC_OT_Future = (byte)'2',
        /// <summary>
        ///银期转帐平台管理
        /// <summary>
        THOST_FTDC_OT_PlateForm = (byte)'9'
    }
    /// <summary>
    ///TFtdcOrganLevelType是一个机构级别类型
    /// <summary>
    public enum TThostFtdcOrganLevelType : byte
    {
        /// <summary>
        ///银行总行或期商总部
        /// <summary>
        THOST_FTDC_OL_HeadQuarters = (byte)'1',
        /// <summary>
        ///银行分中心或期货公司营业部
        /// <summary>
        THOST_FTDC_OL_Branch = (byte)'2'
    }
    /// <summary>
    ///TFtdcProtocalIDType是一个协议类型类型
    /// <summary>
    public enum TThostFtdcProtocalIDType : byte
    {
        /// <summary>
        ///期商协议
        /// <summary>
        THOST_FTDC_PID_FutureProtocal = (byte)'0',
        /// <summary>
        ///工行协议
        /// <summary>
        THOST_FTDC_PID_ICBCProtocal = (byte)'1',
        /// <summary>
        ///农行协议
        /// <summary>
        THOST_FTDC_PID_ABCProtocal = (byte)'2',
        /// <summary>
        ///中国银行协议
        /// <summary>
        THOST_FTDC_PID_CBCProtocal = (byte)'3',
        /// <summary>
        ///建行协议
        /// <summary>
        THOST_FTDC_PID_CCBProtocal = (byte)'4',
        /// <summary>
        ///交行协议
        /// <summary>
        THOST_FTDC_PID_BOCOMProtocal = (byte)'5',
        /// <summary>
        ///银期转帐平台协议
        /// <summary>
        THOST_FTDC_PID_FBTPlateFormProtocal = (byte)'X'
    }
    /// <summary>
    ///TFtdcConnectModeType是一个套接字连接方式类型
    /// <summary>
    public enum TThostFtdcConnectModeType : byte
    {
        /// <summary>
        ///短连接
        /// <summary>
        THOST_FTDC_CM_ShortConnect = (byte)'0',
        /// <summary>
        ///长连接
        /// <summary>
        THOST_FTDC_CM_LongConnect = (byte)'1'
    }
    /// <summary>
    ///TFtdcSyncModeType是一个套接字通信方式类型
    /// <summary>
    public enum TThostFtdcSyncModeType : byte
    {
        /// <summary>
        ///异步
        /// <summary>
        THOST_FTDC_SRM_ASync = (byte)'0',
        /// <summary>
        ///同步
        /// <summary>
        THOST_FTDC_SRM_Sync = (byte)'1'
    }
    /// <summary>
    ///TFtdcBankAccTypeType是一个银行帐号类型类型
    /// <summary>
    public enum TThostFtdcBankAccTypeType : byte
    {
        /// <summary>
        ///银行存折
        /// <summary>
        THOST_FTDC_BAT_BankBook = (byte)'1',
        /// <summary>
        ///储蓄卡
        /// <summary>
        THOST_FTDC_BAT_SavingCard = (byte)'2',
        /// <summary>
        ///信用卡
        /// <summary>
        THOST_FTDC_BAT_CreditCard = (byte)'3'
    }
    /// <summary>
    ///TFtdcFutureAccTypeType是一个期货公司帐号类型类型
    /// <summary>
    public enum TThostFtdcFutureAccTypeType : byte
    {
        /// <summary>
        ///银行存折
        /// <summary>
        THOST_FTDC_FAT_BankBook = (byte)'1',
        /// <summary>
        ///储蓄卡
        /// <summary>
        THOST_FTDC_FAT_SavingCard = (byte)'2',
        /// <summary>
        ///信用卡
        /// <summary>
        THOST_FTDC_FAT_CreditCard = (byte)'3'
    }
    /// <summary>
    ///TFtdcOrganStatusType是一个接入机构状态类型
    /// <summary>
    public enum TThostFtdcOrganStatusType : byte
    {
        /// <summary>
        ///启用
        /// <summary>
        THOST_FTDC_OS_Ready = (byte)'0',
        /// <summary>
        ///签到
        /// <summary>
        THOST_FTDC_OS_CheckIn = (byte)'1',
        /// <summary>
        ///签退
        /// <summary>
        THOST_FTDC_OS_CheckOut = (byte)'2',
        /// <summary>
        ///对帐文件到达
        /// <summary>
        THOST_FTDC_OS_CheckFileArrived = (byte)'3',
        /// <summary>
        ///对帐
        /// <summary>
        THOST_FTDC_OS_CheckDetail = (byte)'4',
        /// <summary>
        ///日终清理
        /// <summary>
        THOST_FTDC_OS_DayEndClean = (byte)'5',
        /// <summary>
        ///注销
        /// <summary>
        THOST_FTDC_OS_Invalid = (byte)'9'
    }
    /// <summary>
    ///TFtdcCCBFeeModeType是一个建行收费模式类型
    /// <summary>
    public enum TThostFtdcCCBFeeModeType : byte
    {
        /// <summary>
        ///按金额扣收
        /// <summary>
        THOST_FTDC_CCBFM_ByAmount = (byte)'1',
        /// <summary>
        ///按月扣收
        /// <summary>
        THOST_FTDC_CCBFM_ByMonth = (byte)'2'
    }
    /// <summary>
    ///TFtdcCommApiTypeType是一个通讯API类型类型
    /// <summary>
    public enum TThostFtdcCommApiTypeType : byte
    {
        /// <summary>
        ///客户端
        /// <summary>
        THOST_FTDC_CAPIT_Client = (byte)'1',
        /// <summary>
        ///服务端
        /// <summary>
        THOST_FTDC_CAPIT_Server = (byte)'2',
        /// <summary>
        ///交易系统的UserApi
        /// <summary>
        THOST_FTDC_CAPIT_UserApi = (byte)'3'
    }
    /// <summary>
    ///TFtdcLinkStatusType是一个连接状态类型
    /// <summary>
    public enum TThostFtdcLinkStatusType : byte
    {
        /// <summary>
        ///已经连接
        /// <summary>
        THOST_FTDC_LS_Connected = (byte)'1',
        /// <summary>
        ///没有连接
        /// <summary>
        THOST_FTDC_LS_Disconnected = (byte)'2'
    }
    /// <summary>
    ///TFtdcPwdFlagType是一个密码核对标志类型
    /// <summary>
    public enum TThostFtdcPwdFlagType : byte
    {
        /// <summary>
        ///不核对
        /// <summary>
        THOST_FTDC_BPWDF_NoCheck = (byte)'0',
        /// <summary>
        ///明文核对
        /// <summary>
        THOST_FTDC_BPWDF_BlankCheck = (byte)'1',
        /// <summary>
        ///密文核对
        /// <summary>
        THOST_FTDC_BPWDF_EncryptCheck = (byte)'2'
    }
    /// <summary>
    ///TFtdcSecuAccTypeType是一个期货帐号类型类型
    /// <summary>
    public enum TThostFtdcSecuAccTypeType : byte
    {
        /// <summary>
        ///资金帐号
        /// <summary>
        THOST_FTDC_SAT_AccountID = (byte)'1',
        /// <summary>
        ///资金卡号
        /// <summary>
        THOST_FTDC_SAT_CardID = (byte)'2',
        /// <summary>
        ///上海股东帐号
        /// <summary>
        THOST_FTDC_SAT_SHStockholderID = (byte)'3',
        /// <summary>
        ///深圳股东帐号
        /// <summary>
        THOST_FTDC_SAT_SZStockholderID = (byte)'4'
    }
    /// <summary>
    ///TFtdcTransferStatusType是一个转账交易状态类型
    /// <summary>
    public enum TThostFtdcTransferStatusType : byte
    {
        /// <summary>
        ///正常
        /// <summary>
        THOST_FTDC_TRFS_Normal = (byte)'0',
        /// <summary>
        ///被冲正
        /// <summary>
        THOST_FTDC_TRFS_Repealed = (byte)'1'
    }
    /// <summary>
    ///TFtdcSponsorTypeType是一个发起方类型
    /// <summary>
    public enum TThostFtdcSponsorTypeType : byte
    {
        /// <summary>
        ///期商
        /// <summary>
        THOST_FTDC_SPTYPE_Broker = (byte)'0',
        /// <summary>
        ///银行
        /// <summary>
        THOST_FTDC_SPTYPE_Bank = (byte)'1'
    }
    /// <summary>
    ///TFtdcReqRspTypeType是一个请求响应类别类型
    /// <summary>
    public enum TThostFtdcReqRspTypeType : byte
    {
        /// <summary>
        ///请求
        /// <summary>
        THOST_FTDC_REQRSP_Request = (byte)'0',
        /// <summary>
        ///响应
        /// <summary>
        THOST_FTDC_REQRSP_Response = (byte)'1'
    }
    /// <summary>
    ///TFtdcFBTUserEventTypeType是一个银期转帐用户事件类型类型
    /// <summary>
    public enum TThostFtdcFBTUserEventTypeType : byte
    {
        /// <summary>
        ///签到
        /// <summary>
        THOST_FTDC_FBTUET_SignIn = (byte)'0',
        /// <summary>
        ///银行转期货
        /// <summary>
        THOST_FTDC_FBTUET_FromBankToFuture = (byte)'1',
        /// <summary>
        ///期货转银行
        /// <summary>
        THOST_FTDC_FBTUET_FromFutureToBank = (byte)'2',
        /// <summary>
        ///开户
        /// <summary>
        THOST_FTDC_FBTUET_OpenAccount = (byte)'3',
        /// <summary>
        ///销户
        /// <summary>
        THOST_FTDC_FBTUET_CancelAccount = (byte)'4',
        /// <summary>
        ///变更银行账户
        /// <summary>
        THOST_FTDC_FBTUET_ChangeAccount = (byte)'5',
        /// <summary>
        ///冲正银行转期货
        /// <summary>
        THOST_FTDC_FBTUET_RepealFromBankToFuture = (byte)'6',
        /// <summary>
        ///冲正期货转银行
        /// <summary>
        THOST_FTDC_FBTUET_RepealFromFutureToBank = (byte)'7',
        /// <summary>
        ///查询银行账户
        /// <summary>
        THOST_FTDC_FBTUET_QueryBankAccount = (byte)'8',
        /// <summary>
        ///查询期货账户
        /// <summary>
        THOST_FTDC_FBTUET_QueryFutureAccount = (byte)'9',
        /// <summary>
        ///签退
        /// <summary>
        THOST_FTDC_FBTUET_SignOut = (byte)'A',
        /// <summary>
        ///密钥同步
        /// <summary>
        THOST_FTDC_FBTUET_SyncKey = (byte)'B',
        /// <summary>
        ///其他
        /// <summary>
        THOST_FTDC_FBTUET_Other = (byte)'Z'
    }
    /// <summary>
    ///TFtdcDBOperationType是一个记录操作类型类型
    /// <summary>
    public enum TThostFtdcDBOperationType : byte
    {
        /// <summary>
        ///插入
        /// <summary>
        THOST_FTDC_DBOP_Insert = (byte)'0',
        /// <summary>
        ///更新
        /// <summary>
        THOST_FTDC_DBOP_Update = (byte)'1',
        /// <summary>
        ///删除
        /// <summary>
        THOST_FTDC_DBOP_Delete = (byte)'2'
    }
    /// <summary>
    ///TFtdcSyncFlagType是一个同步标记类型
    /// <summary>
    public enum TThostFtdcSyncFlagType : byte
    {
        /// <summary>
        ///已同步
        /// <summary>
        THOST_FTDC_SYNF_Yes = (byte)'0',
        /// <summary>
        ///未同步
        /// <summary>
        THOST_FTDC_SYNF_No = (byte)'1'
    }
    /// <summary>
    ///TFtdcSyncTypeType是一个同步类型类型
    /// <summary>
    public enum TThostFtdcSyncTypeType : byte
    {
        /// <summary>
        ///一次同步
        /// <summary>
        THOST_FTDC_SYNT_OneOffSync = (byte)'0',
        /// <summary>
        ///定时同步
        /// <summary>
        THOST_FTDC_SYNT_TimerSync = (byte)'1',
        /// <summary>
        ///定时完全同步
        /// <summary>
        THOST_FTDC_SYNT_TimerFullSync = (byte)'2'
    }
    /// <summary>
    ///TFtdcNotifyClassType是一个风险通知类型类型
    /// <summary>
    public enum TThostFtdcNotifyClassType : byte
    {
        /// <summary>
        ///正常
        /// <summary>
        THOST_FTDC_NC_NOERROR = (byte)'0',
        /// <summary>
        ///警示
        /// <summary>
        THOST_FTDC_NC_Warn = (byte)'1',
        /// <summary>
        ///追保
        /// <summary>
        THOST_FTDC_NC_Call = (byte)'2',
        /// <summary>
        ///强平
        /// <summary>
        THOST_FTDC_NC_Force = (byte)'3',
        /// <summary>
        ///穿仓
        /// <summary>
        THOST_FTDC_NC_CHUANCANG = (byte)'4',
        /// <summary>
        ///异常
        /// <summary>
        THOST_FTDC_NC_Exception = (byte)'5'
    }
    /// <summary>
    ///TFtdcForceCloseTypeType是一个强平单类型类型
    /// <summary>
    public enum TThostFtdcForceCloseTypeType : byte
    {
        /// <summary>
        ///手工强平
        /// <summary>
        THOST_FTDC_FCT_Manual = (byte)'0',
        /// <summary>
        ///单一投资者辅助强平
        /// <summary>
        THOST_FTDC_FCT_Single = (byte)'1',
        /// <summary>
        ///批量投资者辅助强平
        /// <summary>
        THOST_FTDC_FCT_Group = (byte)'2'
    }
    /// <summary>
    ///TFtdcRiskNotifyMethodType是一个风险通知途径类型
    /// <summary>
    public enum TThostFtdcRiskNotifyMethodType : byte
    {
        /// <summary>
        ///系统通知
        /// <summary>
        THOST_FTDC_RNM_System = (byte)'0',
        /// <summary>
        ///短信通知
        /// <summary>
        THOST_FTDC_RNM_SMS = (byte)'1',
        /// <summary>
        ///邮件通知
        /// <summary>
        THOST_FTDC_RNM_EMail = (byte)'2',
        /// <summary>
        ///人工通知
        /// <summary>
        THOST_FTDC_RNM_Manual = (byte)'3'
    }
    /// <summary>
    ///TFtdcRiskNotifyStatusType是一个风险通知状态类型
    /// <summary>
    public enum TThostFtdcRiskNotifyStatusType : byte
    {
        /// <summary>
        ///未生成
        /// <summary>
        THOST_FTDC_RNS_NotGen = (byte)'0',
        /// <summary>
        ///已生成未发送
        /// <summary>
        THOST_FTDC_RNS_Generated = (byte)'1',
        /// <summary>
        ///发送失败
        /// <summary>
        THOST_FTDC_RNS_SendError = (byte)'2',
        /// <summary>
        ///已发送未接收
        /// <summary>
        THOST_FTDC_RNS_SendOk = (byte)'3',
        /// <summary>
        ///已接收未确认
        /// <summary>
        THOST_FTDC_RNS_Received = (byte)'4',
        /// <summary>
        ///已确认
        /// <summary>
        THOST_FTDC_RNS_Confirmed = (byte)'5'
    }
    /// <summary>
    ///TFtdcRiskUserEventType是一个风控用户操作事件类型
    /// <summary>
    public enum TThostFtdcRiskUserEventType : byte
    {
        /// <summary>
        ///导出数据
        /// <summary>
        THOST_FTDC_RUE_ExportData = (byte)'0'
    }
    /// <summary>
    ///TFtdcConditionalOrderSortTypeType是一个条件单索引条件类型
    /// <summary>
    public enum TThostFtdcConditionalOrderSortTypeType : byte
    {
        /// <summary>
        ///使用最新价升序
        /// <summary>
        THOST_FTDC_COST_LastPriceAsc = (byte)'0',
        /// <summary>
        ///使用最新价降序
        /// <summary>
        THOST_FTDC_COST_LastPriceDesc = (byte)'1',
        /// <summary>
        ///使用卖价升序
        /// <summary>
        THOST_FTDC_COST_AskPriceAsc = (byte)'2',
        /// <summary>
        ///使用卖价降序
        /// <summary>
        THOST_FTDC_COST_AskPriceDesc = (byte)'3',
        /// <summary>
        ///使用买价升序
        /// <summary>
        THOST_FTDC_COST_BidPriceAsc = (byte)'4',
        /// <summary>
        ///使用买价降序
        /// <summary>
        THOST_FTDC_COST_BidPriceDesc = (byte)'5'
    }
    /// <summary>
    ///TFtdcSendTypeType是一个报送状态类型
    /// <summary>
    public enum TThostFtdcSendTypeType : byte
    {
        /// <summary>
        ///未发送
        /// <summary>
        THOST_FTDC_UOAST_NoSend = (byte)'0',
        /// <summary>
        ///已发送
        /// <summary>
        THOST_FTDC_UOAST_Sended = (byte)'1',
        /// <summary>
        ///已生成
        /// <summary>
        THOST_FTDC_UOAST_Generated = (byte)'2',
        /// <summary>
        ///报送失败
        /// <summary>
        THOST_FTDC_UOAST_SendFail = (byte)'3',
        /// <summary>
        ///接收成功
        /// <summary>
        THOST_FTDC_UOAST_Success = (byte)'4',
        /// <summary>
        ///接收失败
        /// <summary>
        THOST_FTDC_UOAST_Fail = (byte)'5',
        /// <summary>
        ///取消报送
        /// <summary>
        THOST_FTDC_UOAST_Cancel = (byte)'6'
    }
    /// <summary>
    ///TFtdcClientIDStatusType是一个交易编码状态类型
    /// <summary>
    public enum TThostFtdcClientIDStatusType : byte
    {
        /// <summary>
        ///未申请
        /// <summary>
        THOST_FTDC_UOACS_NoApply = (byte)'1',
        /// <summary>
        ///已提交申请
        /// <summary>
        THOST_FTDC_UOACS_Submited = (byte)'2',
        /// <summary>
        ///已发送申请
        /// <summary>
        THOST_FTDC_UOACS_Sended = (byte)'3',
        /// <summary>
        ///完成
        /// <summary>
        THOST_FTDC_UOACS_Success = (byte)'4',
        /// <summary>
        ///拒绝
        /// <summary>
        THOST_FTDC_UOACS_Refuse = (byte)'5',
        /// <summary>
        ///已撤销编码
        /// <summary>
        THOST_FTDC_UOACS_Cancel = (byte)'6'
    }
    /// <summary>
    ///TFtdcQuestionTypeType是一个特有信息类型类型
    /// <summary>
    public enum TThostFtdcQuestionTypeType : byte
    {
        /// <summary>
        ///单选
        /// <summary>
        THOST_FTDC_QT_Radio = (byte)'1',
        /// <summary>
        ///多选
        /// <summary>
        THOST_FTDC_QT_Option = (byte)'2',
        /// <summary>
        ///填空
        /// <summary>
        THOST_FTDC_QT_Blank = (byte)'3'
    }
    /// <summary>
    ///TFtdcBusinessTypeType是一个业务类型类型
    /// <summary>
    public enum TThostFtdcBusinessTypeType : byte
    {
        /// <summary>
        ///请求
        /// <summary>
        THOST_FTDC_BT_Request = (byte)'1',
        /// <summary>
        ///应答
        /// <summary>
        THOST_FTDC_BT_Response = (byte)'2',
        /// <summary>
        ///通知
        /// <summary>
        THOST_FTDC_BT_Notice = (byte)'3'
    }
    /// <summary>
    ///TFtdcCfmmcReturnCodeType是一个监控中心返回码类型
    /// <summary>
    public enum TThostFtdcCfmmcReturnCodeType : byte
    {
        /// <summary>
        ///成功
        /// <summary>
        THOST_FTDC_CRC_Success = (byte)'0',
        /// <summary>
        ///该客户已经有流程在处理中
        /// <summary>
        THOST_FTDC_CRC_Working = (byte)'1',
        /// <summary>
        ///监控中客户资料检查失败
        /// <summary>
        THOST_FTDC_CRC_InfoFail = (byte)'2',
        /// <summary>
        ///监控中实名制检查失败
        /// <summary>
        THOST_FTDC_CRC_IDCardFail = (byte)'3',
        /// <summary>
        ///其他错误
        /// <summary>
        THOST_FTDC_CRC_OtherFail = (byte)'4'
    }
    /// <summary>
    ///TFtdcClientTypeType是一个客户类型类型
    /// <summary>
    public enum TThostFtdcClientTypeType : byte
    {
        /// <summary>
        ///所有
        /// <summary>
        THOST_FTDC_CfMMCCT_All = (byte)'0',
        /// <summary>
        ///个人
        /// <summary>
        THOST_FTDC_CfMMCCT_Person = (byte)'1',
        /// <summary>
        ///单位
        /// <summary>
        THOST_FTDC_CfMMCCT_Company = (byte)'2',
        /// <summary>
        ///特殊法人
        /// <summary>
        THOST_FTDC_CfMMCCT_SpecialOrgan = (byte)'4'
    }
    /// <summary>
    ///TFtdcExchangeIDTypeType是一个交易所编号类型
    /// <summary>
    public enum TThostFtdcExchangeIDTypeType : byte
    {
        /// <summary>
        ///上海期货交易所
        /// <summary>
        THOST_FTDC_EIDT_SHFE = (byte)'S',
        /// <summary>
        ///郑州商品交易所
        /// <summary>
        THOST_FTDC_EIDT_CZCE = (byte)'Z',
        /// <summary>
        ///大连商品交易所
        /// <summary>
        THOST_FTDC_EIDT_DCE = (byte)'D',
        /// <summary>
        ///中国金融期货交易所
        /// <summary>
        THOST_FTDC_EIDT_CFFEX = (byte)'J'
    }
    /// <summary>
    ///TFtdcExClientIDTypeType是一个交易编码类型类型
    /// <summary>
    public enum TThostFtdcExClientIDTypeType : byte
    {
        /// <summary>
        ///套保
        /// <summary>
        THOST_FTDC_ECIDT_Hedge = (byte)'1',
        /// <summary>
        ///套利
        /// <summary>
        THOST_FTDC_ECIDT_Arbitrage = (byte)'2',
        /// <summary>
        ///投机
        /// <summary>
        THOST_FTDC_ECIDT_Speculation = (byte)'3'
    }
    /// <summary>
    ///TFtdcUpdateFlagType是一个更新状态类型
    /// <summary>
    public enum TThostFtdcUpdateFlagType : byte
    {
        /// <summary>
        ///未更新
        /// <summary>
        THOST_FTDC_UF_NoUpdate = (byte)'0',
        /// <summary>
        ///更新全部信息成功
        /// <summary>
        THOST_FTDC_UF_Success = (byte)'1',
        /// <summary>
        ///更新全部信息失败
        /// <summary>
        THOST_FTDC_UF_Fail = (byte)'2',
        /// <summary>
        ///更新交易编码成功
        /// <summary>
        THOST_FTDC_UF_TCSuccess = (byte)'3',
        /// <summary>
        ///更新交易编码失败
        /// <summary>
        THOST_FTDC_UF_TCFail = (byte)'4',
        /// <summary>
        ///已丢弃
        /// <summary>
        THOST_FTDC_UF_Cancel = (byte)'5'
    }
    /// <summary>
    ///TFtdcApplyOperateIDType是一个申请动作类型
    /// <summary>
    public enum TThostFtdcApplyOperateIDType : byte
    {
        /// <summary>
        ///开户
        /// <summary>
        THOST_FTDC_AOID_OpenInvestor = (byte)'1',
        /// <summary>
        ///修改身份信息
        /// <summary>
        THOST_FTDC_AOID_ModifyIDCard = (byte)'2',
        /// <summary>
        ///修改一般信息
        /// <summary>
        THOST_FTDC_AOID_ModifyNoIDCard = (byte)'3',
        /// <summary>
        ///申请交易编码
        /// <summary>
        THOST_FTDC_AOID_ApplyTradingCode = (byte)'4',
        /// <summary>
        ///撤销交易编码
        /// <summary>
        THOST_FTDC_AOID_CancelTradingCode = (byte)'5',
        /// <summary>
        ///销户
        /// <summary>
        THOST_FTDC_AOID_CancelInvestor = (byte)'6',
        /// <summary>
        ///账户休眠
        /// <summary>
        THOST_FTDC_AOID_FreezeAccount = (byte)'8',
        /// <summary>
        ///激活休眠账户
        /// <summary>
        THOST_FTDC_AOID_ActiveFreezeAccount = (byte)'9'
    }
    /// <summary>
    ///TFtdcApplyStatusIDType是一个申请状态类型
    /// <summary>
    public enum TThostFtdcApplyStatusIDType : byte
    {
        /// <summary>
        ///未补全
        /// <summary>
        THOST_FTDC_ASID_NoComplete = (byte)'1',
        /// <summary>
        ///已提交
        /// <summary>
        THOST_FTDC_ASID_Submited = (byte)'2',
        /// <summary>
        ///已审核
        /// <summary>
        THOST_FTDC_ASID_Checked = (byte)'3',
        /// <summary>
        ///已拒绝
        /// <summary>
        THOST_FTDC_ASID_Refused = (byte)'4',
        /// <summary>
        ///已删除
        /// <summary>
        THOST_FTDC_ASID_Deleted = (byte)'5'
    }
    /// <summary>
    ///TFtdcSendMethodType是一个发送方式类型
    /// <summary>
    public enum TThostFtdcSendMethodType : byte
    {
        /// <summary>
        ///文件发送
        /// <summary>
        THOST_FTDC_UOASM_ByAPI = (byte)'1',
        /// <summary>
        ///电子发送
        /// <summary>
        THOST_FTDC_UOASM_ByFile = (byte)'2'
    }
    /// <summary>
    ///TFtdcEventModeType是一个操作方法类型
    /// <summary>
    public enum TThostFtdcEventModeType : byte
    {
        /// <summary>
        ///增加
        /// <summary>
        THOST_FTDC_EvM_ADD = (byte)'1',
        /// <summary>
        ///修改
        /// <summary>
        THOST_FTDC_EvM_UPDATE = (byte)'2',
        /// <summary>
        ///删除
        /// <summary>
        THOST_FTDC_EvM_DELETE = (byte)'3',
        /// <summary>
        ///复核
        /// <summary>
        THOST_FTDC_EvM_CHECK = (byte)'4',
        /// <summary>
        ///复制
        /// <summary>
        THOST_FTDC_EvM_COPY = (byte)'5',
        /// <summary>
        ///注销
        /// <summary>
        THOST_FTDC_EvM_CANCEL = (byte)'6',
        /// <summary>
        ///冲销
        /// <summary>
        THOST_FTDC_EvM_Reverse = (byte)'7'
    }
    /// <summary>
    ///TFtdcUOAAutoSendType是一个统一开户申请自动发送类型
    /// <summary>
    public enum TThostFtdcUOAAutoSendType : byte
    {
        /// <summary>
        ///自动发送并接收
        /// <summary>
        THOST_FTDC_UOAA_ASR = (byte)'1',
        /// <summary>
        ///自动发送，不自动接收
        /// <summary>
        THOST_FTDC_UOAA_ASNR = (byte)'2',
        /// <summary>
        ///不自动发送，自动接收
        /// <summary>
        THOST_FTDC_UOAA_NSAR = (byte)'3',
        /// <summary>
        ///不自动发送，也不自动接收
        /// <summary>
        THOST_FTDC_UOAA_NSR = (byte)'4'
    }
    /// <summary>
    ///TFtdcFlowIDType是一个流程ID类型
    /// <summary>
    public enum TThostFtdcFlowIDType : byte
    {
        /// <summary>
        ///投资者对应投资者组设置
        /// <summary>
        THOST_FTDC_EvM_InvestorGroupFlow = (byte)'1',
        /// <summary>
        ///投资者手续费率设置
        /// <summary>
        THOST_FTDC_EvM_InvestorRate = (byte)'2',
        /// <summary>
        ///投资者手续费率模板关系设置
        /// <summary>
        THOST_FTDC_EvM_InvestorCommRateModel = (byte)'3'
    }
    /// <summary>
    ///TFtdcCheckLevelType是一个复核级别类型
    /// <summary>
    public enum TThostFtdcCheckLevelType : byte
    {
        /// <summary>
        ///零级复核
        /// <summary>
        THOST_FTDC_CL_Zero = (byte)'0',
        /// <summary>
        ///一级复核
        /// <summary>
        THOST_FTDC_CL_One = (byte)'1',
        /// <summary>
        ///二级复核
        /// <summary>
        THOST_FTDC_CL_Two = (byte)'2'
    }
    /// <summary>
    ///TFtdcCheckStatusType是一个复核级别类型
    /// <summary>
    public enum TThostFtdcCheckStatusType : byte
    {
        /// <summary>
        ///未复核
        /// <summary>
        THOST_FTDC_CHS_Init = (byte)'0',
        /// <summary>
        ///复核中
        /// <summary>
        THOST_FTDC_CHS_Checking = (byte)'1',
        /// <summary>
        ///已复核
        /// <summary>
        THOST_FTDC_CHS_Checked = (byte)'2',
        /// <summary>
        ///拒绝
        /// <summary>
        THOST_FTDC_CHS_Refuse = (byte)'3',
        /// <summary>
        ///作废
        /// <summary>
        THOST_FTDC_CHS_Cancel = (byte)'4'
    }
    /// <summary>
    ///TFtdcUsedStatusType是一个生效状态类型
    /// <summary>
    public enum TThostFtdcUsedStatusType : byte
    {
        /// <summary>
        ///未生效
        /// <summary>
        THOST_FTDC_CHU_Unused = (byte)'0',
        /// <summary>
        ///已生效
        /// <summary>
        THOST_FTDC_CHU_Used = (byte)'1',
        /// <summary>
        ///生效失败
        /// <summary>
        THOST_FTDC_CHU_Fail = (byte)'2'
    }
    /// <summary>
    ///TFtdcBankAcountOriginType是一个账户来源类型
    /// <summary>
    public enum TThostFtdcBankAcountOriginType : byte
    {
        /// <summary>
        ///手工录入
        /// <summary>
        THOST_FTDC_BAO_ByAccProperty = (byte)'0',
        /// <summary>
        ///银期转账
        /// <summary>
        THOST_FTDC_BAO_ByFBTransfer = (byte)'1'
    }
    /// <summary>
    ///TFtdcMonthBillTradeSumType是一个结算单月报成交汇总方式类型
    /// <summary>
    public enum TThostFtdcMonthBillTradeSumType : byte
    {
        /// <summary>
        ///同日同合约
        /// <summary>
        THOST_FTDC_MBTS_ByInstrument = (byte)'0',
        /// <summary>
        ///同日同合约同价格
        /// <summary>
        THOST_FTDC_MBTS_ByDayInsPrc = (byte)'1',
        /// <summary>
        ///同合约
        /// <summary>
        THOST_FTDC_MBTS_ByDayIns = (byte)'2'
    }
    /// <summary>
    ///TFtdcFBTTradeCodeEnumType是一个银期交易代码枚举类型
    /// <summary>
    public enum TThostFtdcFBTTradeCodeEnumType : byte
    {
        /// <summary>
        ///银行发起银行转期货
        /// <summary>
        THOST_FTDC_FTC_BankLaunchBankToBroker = (byte)'1',
        /// <summary>
        ///期货发起银行转期货
        /// <summary>
        THOST_FTDC_FTC_BrokerLaunchBankToBroker = (byte)'2',
        /// <summary>
        ///银行发起期货转银行
        /// <summary>
        THOST_FTDC_FTC_BankLaunchBrokerToBank = (byte)'3',
        /// <summary>
        ///期货发起期货转银行
        /// <summary>
        THOST_FTDC_FTC_BrokerLaunchBrokerToBank = (byte)'4'
    }
    /// <summary>
    ///TFtdcOTPTypeType是一个动态令牌类型类型
    /// <summary>
    public enum TThostFtdcOTPTypeType : byte
    {
        /// <summary>
        ///无动态令牌
        /// <summary>
        THOST_FTDC_OTP_NONE = (byte)'0',
        /// <summary>
        ///时间令牌
        /// <summary>
        THOST_FTDC_OTP_TOTP = (byte)'1'
    }
    /// <summary>
    ///TFtdcOTPStatusType是一个动态令牌状态类型
    /// <summary>
    public enum TThostFtdcOTPStatusType : byte
    {
        /// <summary>
        ///未使用
        /// <summary>
        THOST_FTDC_OTPS_Unused = (byte)'0',
        /// <summary>
        ///已使用
        /// <summary>
        THOST_FTDC_OTPS_Used = (byte)'1',
        /// <summary>
        ///注销
        /// <summary>
        THOST_FTDC_OTPS_Disuse = (byte)'2'
    }
    /// <summary>
    ///TFtdcBrokerUserTypeType是一个经济公司用户类型类型
    /// <summary>
    public enum TThostFtdcBrokerUserTypeType : byte
    {
        /// <summary>
        ///投资者
        /// <summary>
        THOST_FTDC_BUT_Investor = (byte)'1',
        /// <summary>
        ///操作员
        /// <summary>
        THOST_FTDC_BUT_BrokerUser = (byte)'2'
    }
    /// <summary>
    ///TFtdcFutureTypeType是一个期货类型类型
    /// <summary>
    public enum TThostFtdcFutureTypeType : byte
    {
        /// <summary>
        ///商品期货
        /// <summary>
        THOST_FTDC_FUTT_Commodity = (byte)'1',
        /// <summary>
        ///金融期货
        /// <summary>
        THOST_FTDC_FUTT_Financial = (byte)'2'
    }
    /// <summary>
    ///TFtdcFundEventTypeType是一个资金管理操作类型类型
    /// <summary>
    public enum TThostFtdcFundEventTypeType : byte
    {
        /// <summary>
        ///转账限额
        /// <summary>
        THOST_FTDC_FET_Restriction = (byte)'0',
        /// <summary>
        ///当日转账限额
        /// <summary>
        THOST_FTDC_FET_TodayRestriction = (byte)'1',
        /// <summary>
        ///期商流水
        /// <summary>
        THOST_FTDC_FET_Transfer = (byte)'2',
        /// <summary>
        ///资金冻结
        /// <summary>
        THOST_FTDC_FET_Credit = (byte)'3',
        /// <summary>
        ///投资者可提资金比例
        /// <summary>
        THOST_FTDC_FET_InvestorWithdrawAlm = (byte)'4',
        /// <summary>
        ///单个银行帐户转账限额
        /// <summary>
        THOST_FTDC_FET_BankRestriction = (byte)'5',
        /// <summary>
        ///银期签约账户
        /// <summary>
        THOST_FTDC_FET_Accountregister = (byte)'6',
        /// <summary>
        ///交易所出入金
        /// <summary>
        THOST_FTDC_FET_ExchangeFundIO = (byte)'7',
        /// <summary>
        ///投资者出入金
        /// <summary>
        THOST_FTDC_FET_InvestorFundIO = (byte)'8'
    }
    /// <summary>
    ///TFtdcAccountSourceTypeType是一个资金账户来源类型
    /// <summary>
    public enum TThostFtdcAccountSourceTypeType : byte
    {
        /// <summary>
        ///银期同步
        /// <summary>
        THOST_FTDC_AST_FBTransfer = (byte)'0',
        /// <summary>
        ///手工录入
        /// <summary>
        THOST_FTDC_AST_ManualEntry = (byte)'1'
    }
    /// <summary>
    ///TFtdcCodeSourceTypeType是一个交易编码来源类型
    /// <summary>
    public enum TThostFtdcCodeSourceTypeType : byte
    {
        /// <summary>
        ///统一开户(已规范)
        /// <summary>
        THOST_FTDC_CST_UnifyAccount = (byte)'0',
        /// <summary>
        ///手工录入(未规范)
        /// <summary>
        THOST_FTDC_CST_ManualEntry = (byte)'1'
    }
    /// <summary>
    ///TFtdcUserRangeType是一个操作员范围类型
    /// <summary>
    public enum TThostFtdcUserRangeType : byte
    {
        /// <summary>
        ///所有
        /// <summary>
        THOST_FTDC_UR_All = (byte)'0',
        /// <summary>
        ///单一操作员
        /// <summary>
        THOST_FTDC_UR_Single = (byte)'1'
    }
    /// <summary>
    ///TFtdcByGroupType是一个交易统计表按客户统计方式类型
    /// <summary>
    public enum TThostFtdcByGroupType : byte
    {
        /// <summary>
        ///按投资者统计
        /// <summary>
        THOST_FTDC_BG_Investor = (byte)'2',
        /// <summary>
        ///按类统计
        /// <summary>
        THOST_FTDC_BG_Group = (byte)'1'
    }
    /// <summary>
    ///TFtdcTradeSumStatModeType是一个交易统计表按范围统计方式类型
    /// <summary>
    public enum TThostFtdcTradeSumStatModeType : byte
    {
        /// <summary>
        ///按合约统计
        /// <summary>
        THOST_FTDC_TSSM_Instrument = (byte)'1',
        /// <summary>
        ///按产品统计
        /// <summary>
        THOST_FTDC_TSSM_Product = (byte)'2',
        /// <summary>
        ///按交易所统计
        /// <summary>
        THOST_FTDC_TSSM_Exchange = (byte)'3'
    }
    /// <summary>
    ///TFtdcExprSetModeType是一个日期表达式设置类型类型
    /// <summary>
    public enum TThostFtdcExprSetModeType : byte
    {
        /// <summary>
        ///相对已有规则设置
        /// <summary>
        THOST_FTDC_ESM_Relative = (byte)'1',
        /// <summary>
        ///典型设置
        /// <summary>
        THOST_FTDC_ESM_Typical = (byte)'2'
    }
    /// <summary>
    ///TFtdcRateInvestorRangeType是一个投资者范围类型
    /// <summary>
    public enum TThostFtdcRateInvestorRangeType : byte
    {
        /// <summary>
        ///公司标准
        /// <summary>
        THOST_FTDC_RIR_All = (byte)'1',
        /// <summary>
        ///模板
        /// <summary>
        THOST_FTDC_RIR_Model = (byte)'2',
        /// <summary>
        ///单一投资者
        /// <summary>
        THOST_FTDC_RIR_Single = (byte)'3'
    }
    /// <summary>
    ///TFtdcSyncDataStatusType是一个主次用系统数据同步状态类型
    /// <summary>
    public enum TThostFtdcSyncDataStatusType : byte
    {
        /// <summary>
        ///未同步
        /// <summary>
        THOST_FTDC_SDS_Initialize = (byte)'0',
        /// <summary>
        ///同步中
        /// <summary>
        THOST_FTDC_SDS_Settlementing = (byte)'1',
        /// <summary>
        ///已同步
        /// <summary>
        THOST_FTDC_SDS_Settlemented = (byte)'2'
    }
    /// <summary>
    ///TFtdcTradeSourceType是一个成交来源类型
    /// <summary>
    public enum TThostFtdcTradeSourceType : byte
    {
        /// <summary>
        ///来自交易所普通回报
        /// <summary>
        THOST_FTDC_TSRC_NORMAL = (byte)'0',
        /// <summary>
        ///来自查询
        /// <summary>
        THOST_FTDC_TSRC_QUERY = (byte)'1'
    }
    /// <summary>
    ///TFtdcFlexStatModeType是一个产品合约统计方式类型
    /// <summary>
    public enum TThostFtdcFlexStatModeType : byte
    {
        /// <summary>
        ///产品统计
        /// <summary>
        THOST_FTDC_FSM_Product = (byte)'1',
        /// <summary>
        ///交易所统计
        /// <summary>
        THOST_FTDC_FSM_Exchange = (byte)'2',
        /// <summary>
        ///统计所有
        /// <summary>
        THOST_FTDC_FSM_All = (byte)'3'
    }
    /// <summary>
    ///TFtdcByInvestorRangeType是一个投资者范围统计方式类型
    /// <summary>
    public enum TThostFtdcByInvestorRangeType : byte
    {
        /// <summary>
        ///属性统计
        /// <summary>
        THOST_FTDC_BIR_Property = (byte)'1',
        /// <summary>
        ///统计所有
        /// <summary>
        THOST_FTDC_BIR_All = (byte)'2'
    }
    /// <summary>
    ///TFtdcPropertyInvestorRangeType是一个投资者范围类型
    /// <summary>
    public enum TThostFtdcPropertyInvestorRangeType : byte
    {
        /// <summary>
        ///所有
        /// <summary>
        THOST_FTDC_PIR_All = (byte)'1',
        /// <summary>
        ///投资者属性
        /// <summary>
        THOST_FTDC_PIR_Property = (byte)'2',
        /// <summary>
        ///单一投资者
        /// <summary>
        THOST_FTDC_PIR_Single = (byte)'3'
    }
    /// <summary>
    ///TFtdcFileStatusType是一个文件状态类型
    /// <summary>
    public enum TThostFtdcFileStatusType : byte
    {
        /// <summary>
        ///未生成
        /// <summary>
        THOST_FTDC_FIS_NoCreate = (byte)'0',
        /// <summary>
        ///已生成
        /// <summary>
        THOST_FTDC_FIS_Created = (byte)'1',
        /// <summary>
        ///生成失败
        /// <summary>
        THOST_FTDC_FIS_Failed = (byte)'2'
    }
    /// <summary>
    ///TFtdcFileGenStyleType是一个文件生成方式类型
    /// <summary>
    public enum TThostFtdcFileGenStyleType : byte
    {
        /// <summary>
        ///下发
        /// <summary>
        THOST_FTDC_FGS_FileTransmit = (byte)'0',
        /// <summary>
        ///生成
        /// <summary>
        THOST_FTDC_FGS_FileGen = (byte)'1'
    }
    /// <summary>
    ///TFtdcSysOperModeType是一个系统日志操作方法类型
    /// <summary>
    public enum TThostFtdcSysOperModeType : byte
    {
        /// <summary>
        ///增加
        /// <summary>
        THOST_FTDC_SoM_Add = (byte)'1',
        /// <summary>
        ///修改
        /// <summary>
        THOST_FTDC_SoM_Update = (byte)'2',
        /// <summary>
        ///删除
        /// <summary>
        THOST_FTDC_SoM_Delete = (byte)'3',
        /// <summary>
        ///复制
        /// <summary>
        THOST_FTDC_SoM_Copy = (byte)'4',
        /// <summary>
        ///激活
        /// <summary>
        THOST_FTDC_SoM_AcTive = (byte)'5',
        /// <summary>
        ///注销
        /// <summary>
        THOST_FTDC_SoM_CanCel = (byte)'6',
        /// <summary>
        ///重置
        /// <summary>
        THOST_FTDC_SoM_ReSet = (byte)'7'
    }
    /// <summary>
    ///TFtdcSysOperTypeType是一个系统日志操作类型类型
    /// <summary>
    public enum TThostFtdcSysOperTypeType : byte
    {
        /// <summary>
        ///修改操作员密码
        /// <summary>
        THOST_FTDC_SoT_UpdatePassword = (byte)'0',
        /// <summary>
        ///操作员组织架构关系
        /// <summary>
        THOST_FTDC_SoT_UserDepartment = (byte)'1',
        /// <summary>
        ///角色管理
        /// <summary>
        THOST_FTDC_SoT_RoleManager = (byte)'2',
        /// <summary>
        ///角色功能设置
        /// <summary>
        THOST_FTDC_SoT_RoleFunction = (byte)'3',
        /// <summary>
        ///基础参数设置
        /// <summary>
        THOST_FTDC_SoT_BaseParam = (byte)'4',
        /// <summary>
        ///设置操作员
        /// <summary>
        THOST_FTDC_SoT_SetUserID = (byte)'5',
        /// <summary>
        ///用户角色设置
        /// <summary>
        THOST_FTDC_SoT_SetUserRole = (byte)'6',
        /// <summary>
        ///用户IP限制
        /// <summary>
        THOST_FTDC_SoT_UserIpRestriction = (byte)'7',
        /// <summary>
        ///组织架构管理
        /// <summary>
        THOST_FTDC_SoT_DepartmentManager = (byte)'8',
        /// <summary>
        ///组织架构向查询分类复制
        /// <summary>
        THOST_FTDC_SoT_DepartmentCopy = (byte)'9',
        /// <summary>
        ///交易编码管理
        /// <summary>
        THOST_FTDC_SoT_Tradingcode = (byte)'A',
        /// <summary>
        ///投资者状态维护
        /// <summary>
        THOST_FTDC_SoT_InvestorStatus = (byte)'B',
        /// <summary>
        ///投资者权限管理
        /// <summary>
        THOST_FTDC_SoT_InvestorAuthority = (byte)'C',
        /// <summary>
        ///属性设置
        /// <summary>
        THOST_FTDC_SoT_PropertySet = (byte)'D',
        /// <summary>
        ///重置投资者密码
        /// <summary>
        THOST_FTDC_SoT_ReSetInvestorPasswd = (byte)'E',
        /// <summary>
        ///投资者个性信息维护
        /// <summary>
        THOST_FTDC_SoT_InvestorPersonalityInfo = (byte)'F'
    }
    /// <summary>
    ///TFtdcCSRCDataQueyTypeType是一个上报数据查询类型类型
    /// <summary>
    public enum TThostFtdcCSRCDataQueyTypeType : byte
    {
        /// <summary>
        ///查询当前交易日报送的数据
        /// <summary>
        THOST_FTDC_CSRCQ_Current = (byte)'0',
        /// <summary>
        ///查询历史报送的代理经纪公司的数据
        /// <summary>
        THOST_FTDC_CSRCQ_History = (byte)'1'
    }
    /// <summary>
    ///TFtdcFreezeStatusType是一个休眠状态类型
    /// <summary>
    public enum TThostFtdcFreezeStatusType : byte
    {
        /// <summary>
        ///活跃
        /// <summary>
        THOST_FTDC_FRS_Normal = (byte)'1',
        /// <summary>
        ///休眠
        /// <summary>
        THOST_FTDC_FRS_Freeze = (byte)'0'
    }
    /// <summary>
    ///TFtdcStandardStatusType是一个规范状态类型
    /// <summary>
    public enum TThostFtdcStandardStatusType : byte
    {
        /// <summary>
        ///已规范
        /// <summary>
        THOST_FTDC_STST_Standard = (byte)'0',
        /// <summary>
        ///未规范
        /// <summary>
        THOST_FTDC_STST_NonStandard = (byte)'1'
    }
    /// <summary>
    ///TFtdcRightParamTypeType是一个配置类型类型
    /// <summary>
    public enum TThostFtdcRightParamTypeType : byte
    {
        /// <summary>
        ///休眠户
        /// <summary>
        THOST_FTDC_RPT_Freeze = (byte)'1',
        /// <summary>
        ///激活休眠户
        /// <summary>
        THOST_FTDC_RPT_FreezeActive = (byte)'2',
        /// <summary>
        ///开仓权限限制
        /// <summary>
        THOST_FTDC_RPT_OpenLimit = (byte)'3',
        /// <summary>
        ///解除开仓权限限制
        /// <summary>
        THOST_FTDC_RPT_RelieveOpenLimit = (byte)'4'
    }
    /// <summary>
    ///TFtdcDataStatusType是一个反洗钱审核表数据状态类型
    /// <summary>
    public enum TThostFtdcDataStatusType : byte
    {
        /// <summary>
        ///正常
        /// <summary>
        THOST_FTDC_AMLDS_Normal = (byte)'0',
        /// <summary>
        ///已删除
        /// <summary>
        THOST_FTDC_AMLDS_Deleted = (byte)'1'
    }
    /// <summary>
    ///TFtdcAMLCheckStatusType是一个审核状态类型
    /// <summary>
    public enum TThostFtdcAMLCheckStatusType : byte
    {
        /// <summary>
        ///未复核
        /// <summary>
        THOST_FTDC_AMLCHS_Init = (byte)'0',
        /// <summary>
        ///复核中
        /// <summary>
        THOST_FTDC_AMLCHS_Checking = (byte)'1',
        /// <summary>
        ///已复核
        /// <summary>
        THOST_FTDC_AMLCHS_Checked = (byte)'2',
        /// <summary>
        ///拒绝上报
        /// <summary>
        THOST_FTDC_AMLCHS_RefuseReport = (byte)'3'
    }
    /// <summary>
    ///TFtdcAmlDateTypeType是一个日期类型类型
    /// <summary>
    public enum TThostFtdcAmlDateTypeType : byte
    {
        /// <summary>
        ///检查日期
        /// <summary>
        THOST_FTDC_AMLDT_DrawDay = (byte)'0',
        /// <summary>
        ///发生日期
        /// <summary>
        THOST_FTDC_AMLDT_TouchDay = (byte)'1'
    }
    /// <summary>
    ///TFtdcAmlCheckLevelType是一个审核级别类型
    /// <summary>
    public enum TThostFtdcAmlCheckLevelType : byte
    {
        /// <summary>
        ///零级审核
        /// <summary>
        THOST_FTDC_AMLCL_CheckLevel0 = (byte)'0',
        /// <summary>
        ///一级审核
        /// <summary>
        THOST_FTDC_AMLCL_CheckLevel1 = (byte)'1',
        /// <summary>
        ///二级审核
        /// <summary>
        THOST_FTDC_AMLCL_CheckLevel2 = (byte)'2',
        /// <summary>
        ///三级审核
        /// <summary>
        THOST_FTDC_AMLCL_CheckLevel3 = (byte)'3'
    }
    /// <summary>
    ///TFtdcExportFileTypeType是一个导出文件类型类型
    /// <summary>
    public enum TThostFtdcExportFileTypeType : byte
    {
        /// <summary>
        ///CSV
        /// <summary>
        THOST_FTDC_EFT_CSV = (byte)'0',
        /// <summary>
        ///Excel
        /// <summary>
        THOST_FTDC_EFT_EXCEL = (byte)'1',
        /// <summary>
        ///DBF
        /// <summary>
        THOST_FTDC_EFT_DBF = (byte)'2'
    }
    /// <summary>
    ///TFtdcSettleManagerTypeType是一个结算配置类型类型
    /// <summary>
    public enum TThostFtdcSettleManagerTypeType : byte
    {
        /// <summary>
        ///结算前准备
        /// <summary>
        THOST_FTDC_SMT_Before = (byte)'1',
        /// <summary>
        ///结算
        /// <summary>
        THOST_FTDC_SMT_Settlement = (byte)'2',
        /// <summary>
        ///结算后核对
        /// <summary>
        THOST_FTDC_SMT_After = (byte)'3',
        /// <summary>
        ///结算后处理
        /// <summary>
        THOST_FTDC_SMT_Settlemented = (byte)'4'
    }
    /// <summary>
    ///TFtdcSettleManagerLevelType是一个结算配置等级类型
    /// <summary>
    public enum TThostFtdcSettleManagerLevelType : byte
    {
        /// <summary>
        ///必要
        /// <summary>
        THOST_FTDC_SML_Must = (byte)'1',
        /// <summary>
        ///警告
        /// <summary>
        THOST_FTDC_SML_Alarm = (byte)'2',
        /// <summary>
        ///提示
        /// <summary>
        THOST_FTDC_SML_Prompt = (byte)'3',
        /// <summary>
        ///不检查
        /// <summary>
        THOST_FTDC_SML_Ignore = (byte)'4'
    }
    /// <summary>
    ///TFtdcSettleManagerGroupType是一个模块分组类型
    /// <summary>
    public enum TThostFtdcSettleManagerGroupType : byte
    {
        /// <summary>
        ///交易所核对
        /// <summary>
        THOST_FTDC_SMG_Exhcange = (byte)'1',
        /// <summary>
        ///内部核对
        /// <summary>
        THOST_FTDC_SMG_ASP = (byte)'2',
        /// <summary>
        ///上报数据核对
        /// <summary>
        THOST_FTDC_SMG_CSRC = (byte)'3'
    }
    /// <summary>
    ///TFtdcLimitUseTypeType是一个保值额度使用类型类型
    /// <summary>
    public enum TThostFtdcLimitUseTypeType : byte
    {
        /// <summary>
        ///可重复使用
        /// <summary>
        THOST_FTDC_LUT_Repeatable = (byte)'1',
        /// <summary>
        ///不可重复使用
        /// <summary>
        THOST_FTDC_LUT_Unrepeatable = (byte)'2'
    }
    /// <summary>
    ///TFtdcDataResourceType是一个数据来源类型
    /// <summary>
    public enum TThostFtdcDataResourceType : byte
    {
        /// <summary>
        ///本系统
        /// <summary>
        THOST_FTDC_DAR_Settle = (byte)'1',
        /// <summary>
        ///交易所
        /// <summary>
        THOST_FTDC_DAR_Exchange = (byte)'2',
        /// <summary>
        ///报送数据
        /// <summary>
        THOST_FTDC_DAR_CSRC = (byte)'3'
    }
    /// <summary>
    ///TFtdcMarginTypeType是一个保证金类型类型
    /// <summary>
    public enum TThostFtdcMarginTypeType : byte
    {
        /// <summary>
        ///交易所保证金率
        /// <summary>
        THOST_FTDC_MGT_ExchMarginRate = (byte)'0',
        /// <summary>
        ///投资者保证金率
        /// <summary>
        THOST_FTDC_MGT_InstrMarginRate = (byte)'1',
        /// <summary>
        ///投资者交易保证金率
        /// <summary>
        THOST_FTDC_MGT_InstrMarginRateTrade = (byte)'2'
    }
    /// <summary>
    ///TFtdcActiveTypeType是一个生效类型类型
    /// <summary>
    public enum TThostFtdcActiveTypeType : byte
    {
        /// <summary>
        ///仅当日生效
        /// <summary>
        THOST_FTDC_ACT_Intraday = (byte)'1',
        /// <summary>
        ///长期生效
        /// <summary>
        THOST_FTDC_ACT_Long = (byte)'2'
    }
    /// <summary>
    ///TFtdcMarginRateTypeType是一个冲突保证金率类型类型
    /// <summary>
    public enum TThostFtdcMarginRateTypeType : byte
    {
        /// <summary>
        ///交易所保证金率
        /// <summary>
        THOST_FTDC_MRT_Exchange = (byte)'1',
        /// <summary>
        ///投资者保证金率
        /// <summary>
        THOST_FTDC_MRT_Investor = (byte)'2',
        /// <summary>
        ///投资者交易保证金率
        /// <summary>
        THOST_FTDC_MRT_InvestorTrade = (byte)'3'
    }
    /// <summary>
    ///TFtdcBackUpStatusType是一个备份数据状态类型
    /// <summary>
    public enum TThostFtdcBackUpStatusType : byte
    {
        /// <summary>
        ///未生成备份数据
        /// <summary>
        THOST_FTDC_BUS_UnBak = (byte)'0',
        /// <summary>
        ///备份数据生成中
        /// <summary>
        THOST_FTDC_BUS_BakUp = (byte)'1',
        /// <summary>
        ///已生成备份数据
        /// <summary>
        THOST_FTDC_BUS_BakUped = (byte)'2',
        /// <summary>
        ///备份数据失败
        /// <summary>
        THOST_FTDC_BUS_BakFail = (byte)'3'
    }
    /// <summary>
    ///TFtdcInitSettlementType是一个结算初始化状态类型
    /// <summary>
    public enum TThostFtdcInitSettlementType : byte
    {
        /// <summary>
        ///结算初始化未开始
        /// <summary>
        THOST_FTDC_SIS_UnInitialize = (byte)'0',
        /// <summary>
        ///结算初始化中
        /// <summary>
        THOST_FTDC_SIS_Initialize = (byte)'1',
        /// <summary>
        ///结算初始化完成
        /// <summary>
        THOST_FTDC_SIS_Initialized = (byte)'2'
    }
    /// <summary>
    ///TFtdcReportStatusType是一个报表数据生成状态类型
    /// <summary>
    public enum TThostFtdcReportStatusType : byte
    {
        /// <summary>
        ///未生成报表数据
        /// <summary>
        THOST_FTDC_SRS_NoCreate = (byte)'0',
        /// <summary>
        ///报表数据生成中
        /// <summary>
        THOST_FTDC_SRS_Create = (byte)'1',
        /// <summary>
        ///已生成报表数据
        /// <summary>
        THOST_FTDC_SRS_Created = (byte)'2',
        /// <summary>
        ///生成报表数据失败
        /// <summary>
        THOST_FTDC_SRS_CreateFail = (byte)'3'
    }
    /// <summary>
    ///TFtdcSaveStatusType是一个数据归档状态类型
    /// <summary>
    public enum TThostFtdcSaveStatusType : byte
    {
        /// <summary>
        ///归档未完成
        /// <summary>
        THOST_FTDC_SSS_UnSaveData = (byte)'0',
        /// <summary>
        ///归档完成
        /// <summary>
        THOST_FTDC_SSS_SaveDatad = (byte)'1'
    }
    /// <summary>
    ///TFtdcSettArchiveStatusType是一个结算确认数据归档状态类型
    /// <summary>
    public enum TThostFtdcSettArchiveStatusType : byte
    {
        /// <summary>
        ///未归档数据
        /// <summary>
        THOST_FTDC_SAS_UnArchived = (byte)'0',
        /// <summary>
        ///数据归档中
        /// <summary>
        THOST_FTDC_SAS_Archiving = (byte)'1',
        /// <summary>
        ///已归档数据
        /// <summary>
        THOST_FTDC_SAS_Archived = (byte)'2',
        /// <summary>
        ///归档数据失败
        /// <summary>
        THOST_FTDC_SAS_ArchiveFail = (byte)'3'
    }
    /// <summary>
    ///TFtdcCTPTypeType是一个CTP交易系统类型类型
    /// <summary>
    public enum TThostFtdcCTPTypeType : byte
    {
        /// <summary>
        ///未知类型
        /// <summary>
        THOST_FTDC_CTPT_Unkown = (byte)'0',
        /// <summary>
        ///主中心
        /// <summary>
        THOST_FTDC_CTPT_MainCenter = (byte)'1',
        /// <summary>
        ///备中心
        /// <summary>
        THOST_FTDC_CTPT_BackUp = (byte)'2'
    }
    /// <summary>
    ///TFtdcCloseDealTypeType是一个平仓处理类型类型
    /// <summary>
    public enum TThostFtdcCloseDealTypeType : byte
    {
        /// <summary>
        ///正常
        /// <summary>
        THOST_FTDC_CDT_Normal = (byte)'0',
        /// <summary>
        ///投机平仓优先
        /// <summary>
        THOST_FTDC_CDT_SpecFirst = (byte)'1'
    }
    /// <summary>
    ///TFtdcExStatusType是一个修改状态类型
    /// <summary>
    public enum TThostFtdcExStatusType : byte
    {
        /// <summary>
        ///修改前
        /// <summary>
        THOST_FTDC_EXS_Before = (byte)'0',
        /// <summary>
        ///修改后
        /// <summary>
        THOST_FTDC_EXS_After = (byte)'1'
    }
    /// <summary>
    ///TFtdcStartModeType是一个启动模式类型
    /// <summary>
    public enum TThostFtdcStartModeType : byte
    {
        /// <summary>
        ///正常
        /// <summary>
        THOST_FTDC_SM_Normal = (byte)'1',
        /// <summary>
        ///应急
        /// <summary>
        THOST_FTDC_SM_Emerge = (byte)'2',
        /// <summary>
        ///恢复
        /// <summary>
        THOST_FTDC_SM_Restore = (byte)'3'
    }
    /// <summary>
    ///TFtdcTemplateTypeType是一个模型类型类型
    /// <summary>
    public enum TThostFtdcTemplateTypeType : byte
    {
        /// <summary>
        ///全量
        /// <summary>
        THOST_FTDC_TPT_Full = (byte)'1',
        /// <summary>
        ///增量
        /// <summary>
        THOST_FTDC_TPT_Increment = (byte)'2',
        /// <summary>
        ///备份
        /// <summary>
        THOST_FTDC_TPT_BackUp = (byte)'3'
    }
    /// <summary>
    ///TFtdcLoginModeType是一个登录模式类型
    /// <summary>
    public enum TThostFtdcLoginModeType : byte
    {
        /// <summary>
        ///交易
        /// <summary>
        THOST_FTDC_LM_Trade = (byte)'0',
        /// <summary>
        ///转账
        /// <summary>
        THOST_FTDC_LM_Transfer = (byte)'1'
    }
    /// <summary>
    ///TFtdcPromptTypeType是一个日历提示类型类型
    /// <summary>
    public enum TThostFtdcPromptTypeType : byte
    {
        /// <summary>
        ///合约上下市
        /// <summary>
        THOST_FTDC_CPT_Instrument = (byte)'1',
        /// <summary>
        ///保证金分段生效
        /// <summary>
        THOST_FTDC_CPT_Margin = (byte)'2'
    }
    /// <summary>
    ///TFtdcHasTrusteeType是一个是否有托管人类型
    /// <summary>
    public enum TThostFtdcHasTrusteeType : byte
    {
        /// <summary>
        ///有
        /// <summary>
        THOST_FTDC_HT_Yes = (byte)'1',
        /// <summary>
        ///没有
        /// <summary>
        THOST_FTDC_HT_No = (byte)'0'
    }
    /// <summary>
    ///TFtdcAmTypeType是一个机构类型类型
    /// <summary>
    public enum TThostFtdcAmTypeType : byte
    {
        /// <summary>
        ///银行
        /// <summary>
        THOST_FTDC_AMT_Bank = (byte)'1',
        /// <summary>
        ///证券公司
        /// <summary>
        THOST_FTDC_AMT_Securities = (byte)'2',
        /// <summary>
        ///基金公司
        /// <summary>
        THOST_FTDC_AMT_Fund = (byte)'3',
        /// <summary>
        ///保险公司
        /// <summary>
        THOST_FTDC_AMT_Insurance = (byte)'4',
        /// <summary>
        ///信托公司
        /// <summary>
        THOST_FTDC_AMT_Trust = (byte)'5',
        /// <summary>
        ///其他
        /// <summary>
        THOST_FTDC_AMT_Other = (byte)'9'
    }
    /// <summary>
    ///TFtdcCSRCFundIOTypeType是一个出入金类型类型
    /// <summary>
    public enum TThostFtdcCSRCFundIOTypeType : byte
    {
        /// <summary>
        ///出入金
        /// <summary>
        THOST_FTDC_CFIOT_FundIO = (byte)'0',
        /// <summary>
        ///银期换汇
        /// <summary>
        THOST_FTDC_CFIOT_SwapCurrency = (byte)'1'
    }
    /// <summary>
    ///TFtdcCusAccountTypeType是一个结算账户类型类型
    /// <summary>
    public enum TThostFtdcCusAccountTypeType : byte
    {
        /// <summary>
        ///期货结算账户
        /// <summary>
        THOST_FTDC_CAT_Futures = (byte)'1',
        /// <summary>
        ///资管结算账户
        /// <summary>
        THOST_FTDC_CAT_Assetmgr = (byte)'2'
    }
    /// <summary>
    ///TFtdcClientRegionType是一个开户客户地域类型
    /// <summary>
    public enum TThostFtdcClientRegionType : byte
    {
        /// <summary>
        ///国内客户
        /// <summary>
        THOST_FTDC_CR_Domestic = (byte)'1',
        /// <summary>
        ///港澳台客户
        /// <summary>
        THOST_FTDC_CR_GMT = (byte)'2',
        /// <summary>
        ///国外客户
        /// <summary>
        THOST_FTDC_CR_Foreign = (byte)'3'
    }
    /// <summary>
    ///TFtdcAssetmgrTypeType是一个投资类型类型
    /// <summary>
    public enum TThostFtdcAssetmgrTypeType : byte
    {
        /// <summary>
        ///期货类
        /// <summary>
        THOST_FTDC_ASST_Futures = (byte)'3',
        /// <summary>
        ///综合类
        /// <summary>
        THOST_FTDC_ASST_SpecialOrgan = (byte)'4'
    }
    /// <summary>
    ///TFtdcCheckInstrTypeType是一个合约比较类型类型
    /// <summary>
    public enum TThostFtdcCheckInstrTypeType : byte
    {
        /// <summary>
        ///合约交易所不存在
        /// <summary>
        THOST_FTDC_CIT_HasExch = (byte)'0',
        /// <summary>
        ///合约本系统不存在
        /// <summary>
        THOST_FTDC_CIT_HasATP = (byte)'1',
        /// <summary>
        ///合约比较不一致
        /// <summary>
        THOST_FTDC_CIT_HasDiff = (byte)'2'
    }
    /// <summary>
    ///TFtdcDeliveryTypeType是一个交割类型类型
    /// <summary>
    public enum TThostFtdcDeliveryTypeType : byte
    {
        /// <summary>
        ///手工交割
        /// <summary>
        THOST_FTDC_DT_HandDeliv = (byte)'1',
        /// <summary>
        ///到期交割
        /// <summary>
        THOST_FTDC_DT_PersonDeliv = (byte)'2'
    }
    /// <summary>
    ///TFtdcMaxMarginSideAlgorithmType是一个大额单边保证金算法类型
    /// <summary>
    public enum TThostFtdcMaxMarginSideAlgorithmType : byte
    {
        /// <summary>
        ///不使用大额单边保证金算法
        /// <summary>
        THOST_FTDC_MMSA_NO = (byte)'0',
        /// <summary>
        ///使用大额单边保证金算法
        /// <summary>
        THOST_FTDC_MMSA_YES = (byte)'1'
    }
}