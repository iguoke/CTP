using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fut.Core;
using System.Reflection;
using CTPAPI;
using System.Net;
using System.IO;
using System.Text;
using System.Threading;
namespace test
{
    class Program
    {
        public void BackTestReadTick(object a)
        {
            Strategy deomtest = (Deomtest)a;
            CThostFtdcDepthMarketDataField md = new CThostFtdcDepthMarketDataField();
            FileStream fs = new FileStream(@"F:/1.txt", FileMode.Open, FileAccess.Read);
            //读取
            StreamReader reader = new StreamReader(fs, Encoding.GetEncoding("GB2312"));
            string str = "";
            string strline = "";
            int row = reader.ReadToEnd().Split('\n').Length;
            fs.Position = 0;
            for (int i = 0; i < row - 1; i++)
            {
                // Console.WriteLine(i.ToString());
                strline = reader.ReadLine();
                if (strline.Contains("序号"))
                {
                    continue;
                }
               
                strline = strline.Substring(0, strline.LastIndexOf(","));
                strline = strline.Substring(0, strline.LastIndexOf(","));
                strline = strline.Substring(0, strline.LastIndexOf(","));
                strline = strline.Substring(0, strline.LastIndexOf(","));
                strline = strline.Substring(0, strline.LastIndexOf(","));
                strline = strline.Substring(0, strline.LastIndexOf(","));
                strline = strline.Substring(0, strline.LastIndexOf(","));
                strline = strline.Substring(0, strline.LastIndexOf(","));
                strline = strline.Substring(0, strline.LastIndexOf(","));
                str = strline;
                str = str.Substring(str.LastIndexOf(",") + 1);
                md.AskPrice1 = Convert.ToDouble(str);
                strline = strline.Substring(0, strline.LastIndexOf(","));
                str = strline;
                str = str.Substring(str.LastIndexOf(",") + 1);
                md.BidPrice1  = Convert.ToDouble(str);
                strline = strline.Substring(0, strline.LastIndexOf(","));
                strline = strline.Substring(0, strline.LastIndexOf(","));
                str = strline.Substring(strline.LastIndexOf(",") + 1);
                //Console.WriteLine(str);
                md.LastPrice = Convert.ToDouble(str);
                //deomtest.backTestMarketData(ref md);
                deomtest.GetBackTestMarketData(md);
            }
        }
        static void Main(string[] args)
        {
            
            ////a.Print("你好");
            //Assembly assm = Assembly.LoadFrom(@"F:\myc#\CTP\Fut\DeomStrategy\bin\Debug\DeomStrategy.dll");//用库类地址和文件名引用动态链接库
            //Object obj = assm.CreateInstance("Fut.Core.Deomtest", true);//创建对象，构造函数自动调用
            //Type type = assm.GetType("Fut.Core.Deomtest");//获取类类型
            //PropertyInfo pi = type.GetProperty("Fun");
            //pi.SetValue(obj, new A(), null);
            
            //MethodInfo methodInfo = type.GetMethod("Init");//用方法名引用方法
            //methodInfo.Invoke(obj, null); //调用方法
            Deomtest deomtest = new Deomtest();
            IFunction a = new A(new MDAPI("202800020", "162510", "20000", "tcp://180.169.124.109:41213"/*"00000076", "123456", "1035", "tcp://27.17.62.149:40213"*/), new TDAPI("202800020", "162510", "20000", "tcp://180.169.124.109:41205")); 
            deomtest.Fun=a;
            deomtest.Init();
            //deomtest.MdApi_Reg();
            deomtest.MdApi_Connect();
            deomtest.TdApi_Connect();
            //deomtest.BackTest = true;
            //Program p = new Program();
            //Thread oThread = new Thread(p.BackTestReadTick);
            //oThread.Start((object)deomtest);
            
            
            //deomtest.UserLogin();
            //deomtest.SubMarketData();
            //deomtest.show();
           // deomtest.BackTest = true;
            Console.ReadLine();
        }
    }
    class A : IFunction
    {
        private CTPAPI.MDAPI _MdApi;
        public CTPAPI.MDAPI MdApi
        {
            get
            {
                return this._MdApi;
            }
            set
            {
                this._MdApi = value; 
            }
        }
        private CTPAPI.TDAPI _TdApi;
        public CTPAPI.TDAPI TdApi
        {
            get
            {
                return this._TdApi;
            }
            set
            {
                this._TdApi = value;
            }
        }
        public A(MDAPI MdApi, TDAPI TdApi)
        {
            this._MdApi = MdApi;
            this._TdApi = TdApi;
        }
        
        public void Print(string msg)
        {
            Console.WriteLine("Out: " + msg);            
        }
        public void PrintWarning(string msg)
        {
            Console.WriteLine("Warning: " + msg);
        }
        public void PrintError(string msg)
        {
            //this.SendMessage(msg);
            Console.WriteLine("Error: " + msg);
        }
        public string SendMessage(string msg)
        {
            return this.GetHtmlFromUrl(msg);
        }
        public void BackTestData(List<BackTestData> btl)
        {
            Console.WriteLine(btl[btl.Count-1].OpenPrice.ToString()+btl[btl.Count-1].ClosePrice.ToString()+btl[btl.Count-1].Profit.ToString());
            //Console.WriteLine("价格：{0} 方向：{1} 开平：{2}", order.LimitPrice.ToString(),order.Direction,order.CombOffsetFlag);
            //Console.WriteLine(this.GetHtmlFromUrl(url));
        }
        
        //调用时只需要把拼成的URL传给该函数即可。判断返回值即可
        public string GetHtmlFromUrl(string mes)
        {
        string strRet = null;
        string url = "http://utf8.sms.webchinese.cn/?Uid=iguoke&Key=64e7b266189465508eb1&smsMob=18628196059&smsText=" + mes+" 时间："+ DateTime.Now.ToString();
        if(url==null || url.Trim().ToString()=="")
        {
        return strRet;
        }
        string targeturl = url.Trim().ToString();
        try
        {
        HttpWebRequest hr = (HttpWebRequest)WebRequest.Create(targeturl);
        hr.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";
        hr.Method = "GET";
        hr.Timeout = 30 * 60 * 1000;
        WebResponse hs = hr.GetResponse();
        Stream sr = hs.GetResponseStream();
        StreamReader ser = new StreamReader(sr, Encoding.Default);
        strRet = ser.ReadToEnd(); 
        }
        catch (Exception ex)
        {
        strRet = null;
        }
        return strRet;
        }
    }
     
}
