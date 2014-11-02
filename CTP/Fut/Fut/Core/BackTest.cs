using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CTPAPI;
namespace Fut.Core
{
    public delegate void BackTestMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData);
    
    //class BackTest
    //{
    //    //public  void regOnRtnDepthMarketData(RtnDepthMarketData cb);
    //    //RtnDepthMarketData rtnDepthMarketData;

    //    /// <param name="pDepthMarketData"></param>
    //    public delegate void BackTestMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData);
    
    //    //public event RtnDepthMarketData OnRtnDepthMarketData
    //    //{
    //    //    add { rtnDepthMarketData += value; regOnRtnDepthMarketData(rtnDepthMarketData); }
    //    //    remove { rtnDepthMarketData -= value; regOnRtnDepthMarketData(rtnDepthMarketData); }
    //    //}
    //}
}
