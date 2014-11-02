using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CTPAPI;
using System.Threading; 
namespace CTPTEST
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            md.OnFrontConnected+=new TDAPI.FrontConnected(md_OnFrontConnected);
            md.OnRspUserLogin+=new TDAPI.RspUserLogin(md_OnRspUserLogin);
            md.OnRspSettlementInfoConfirm+=new TDAPI.RspSettlementInfoConfirm(md_OnRspSettlementInfoConfirm);
            md.OnRspQrySettlementInfo+=new TDAPI.RspQrySettlementInfo(md_OnRspQrySettlementInfo);
            md.OnRspError+=new TDAPI.RspError(md_OnRspError);
            md.OnRspQryInstrument+=new TDAPI.RspQryInstrument(md_OnRspQryInstrument);
            InitializeComponent();
        }
        //public MDAPI md = new MDAPI("00000076", "123456");
       
       // private delegate void textBox1CallBack();

        public TDAPI md = new TDAPI();
        //public MDAPI md = new MDAPI("202800020", "162510", "20000", "tcp://180.169.124.109:41213");
        public void md_OnRspQryInstrument(ref CThostFtdcInstrumentField pInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            CThostFtdcInstrumentField str = pInstrument;
            textBox1.Invoke((MethodInvoker)delegate() { this.textBox1.Text += "合约查询响应: " + str.InstrumentID + "\r\n"; });
            //textBox1.Invoke((MethodInvoker)delegate() { this.textBox1.Text += "查询合约应答/r/n"; });
            Thread.Sleep(20000);
            md.ToString();
            
        }
        public void md_OnRspError(ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //this.textBox1.Text += "错误响应: " + "\r\n";
            textBox1.Invoke((MethodInvoker)delegate() { this.textBox1.Text += "错误响应: " +  "\r\n"; });
        }
        public void md_OnRspQrySettlementInfo(ref CThostFtdcSettlementInfoField pSettlementInfo, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            CThostFtdcSettlementInfoField st;
            st = pSettlementInfo;
            string str = pSettlementInfo.Content;
            md.QryInstrument("");
            textBox1.Invoke((MethodInvoker)delegate() { this.textBox1.Text +=st.Content+ "请求查询投资者结算结果响应RegOnRspQrySettlementInfo: "+str+"\r\n"; });
            
        }
        public void md_OnRspSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            CThostFtdcSettlementInfoConfirmField str = pSettlementInfoConfirm;
            md.SettlementInfo();
            //md.QryInstrument();
            //string str = pSettlementInfoConfirm.ConfirmDate + pSettlementInfoConfirm.ConfirmTime + pRspInfo.ErrorMsg;
            textBox1.Invoke((MethodInvoker)delegate() { this.textBox1.Text += str.InvestorID+str.ConfirmTime+" 投资者结算结果确认响应:RegOnRspSettlementInfoConfirm\r\n"; });
        }
        public void md_OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            string str = pRspUserLogin.UserID;
            md.SettlementInfoConfirm();
            //this.textBox1.Text += "";
            textBox1.Invoke((MethodInvoker)delegate() { this.textBox1.Text += str+"  登陆行情账户成功\r\n"; });
        }
        public void md_OnFrontConnected()
        {
            //textBox1CallBack textBox1CBack = delegate()
            //{
            //    this.textBox1.Text = "连接前置成功";

            //};
            //textBox1.Invoke(textBox1CBack);
            md.UserLogin();
            textBox1.Invoke((MethodInvoker)delegate() {this.textBox1.AppendText("连接行情前置成功\r\n");});
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread mdThread = new Thread(new ThreadStart(mdThreadfun));
            mdThread.Start();
            
        }
        public void mdThreadfun()
        {
            md.Connect();
        }
    }
}
