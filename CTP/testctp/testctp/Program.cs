using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CTPAPI;
namespace testctp
{
    class api
    {
        public void md_OnFrontConnected()
        {
            Console.WriteLine("连接行情前置成功");
        }
        public void td_OnFrontConnected()
        {
            Console.WriteLine("连接交易前置成功");
            td.UserLogin();
        }
        void td_OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (bIsLast && pRspInfo.ErrorID == 0)
            {
                Console.WriteLine("交易登陆成功 账户：{0}", pRspUserLogin.UserID);
                //this.BeginInvoke(new Action(subAllInstruments));
            }
            else
            {
                Console.WriteLine("交易登陆不成功{0}", pRspInfo.ErrorMsg);
                
            }
               // MessageBox.Show(pRspInfo.ErrorID + ":" + pRspInfo.ErrorMsg);
        }
        public api()
        {
            
            md = new MDAPI();
            td = new TDAPI();

            md.OnFrontConnected += new MDAPI.FrontConnected(md_OnFrontConnected);
            td.OnFrontConnected+=new TDAPI.FrontConnected(td_OnFrontConnected);
            td.OnRspUserLogin+=new TDAPI.RspUserLogin(td_OnRspUserLogin);
        }
       
        public MDAPI md = null;
        public TDAPI td = null;
    }
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("hello ctp");
            api ap=new api();
            ap.md.Connect();
            ap.td.Connect();
            Console.ReadLine();
            //this.show();  
        }

       
    }
}
