using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CTPAPI;
namespace Fut.Core
{
   public  class BackTestData
    {
       public BackTestData()
       { 
        
       }
        public string InstrumentID;
        //public int TradeID;
        public double OpenPrice;
        public string OpenTime;
        public TThostFtdcDirectionType OpenDirection;
        public double ClosePrice;
        public string CloseTime;
        public double Profit
        {
            get 
            {
                if (this.OpenDirection == TThostFtdcDirectionType.THOST_FTDC_D_Buy)
                {
                    return this.OpenPrice - this.ClosePrice;
                }
                else
                    return this.ClosePrice - this.OpenPrice;
            }
        }
        public TThostFtdcDirectionType CloseDirection;

    }
}
