using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CTPAPI;
namespace Fut.Core
{
    public interface IFunction
    {
        CTPAPI.MDAPI MdApi { get; set; }
        CTPAPI.TDAPI TdApi { get; set; }

        void BackTestData(List<BackTestData> btl);
        //void BackTestReadTick();
        void Print(string msg);
        void PrintError(string msg);
        void PrintWarning(string msg);
        string SendMessage(string msg);
    }
}
