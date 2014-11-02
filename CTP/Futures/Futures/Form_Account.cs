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

namespace Futures
{
    public partial class Form_Account : Form
    {
        public List<Acc> accountList { get; set; }
        public Form_Account()
        {
            InitializeComponent();
        }
        public void Reg(int i)
        {

            this.accountList[i].tdapi.OnFrontConnected+= new TDAPI.FrontConnected(delegate()
                {
                    this.Invoke((MethodInvoker)delegate()
                    {
                        this.listView1.Items[i].SubItems[4].Text = "连接前置成功";
                        this.accountList[i].tdapi.UserLogin();

                    });
                });
            this.accountList[i].tdapi.OnFrontDisconnected += new TDAPI.FrontDisconnected(delegate(int n)
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    this.listView1.Items[i].SubItems[4].Text = "网络诊断:"+n.ToString();
                    this.accountList[i].tdapi.UserLogin();

                });
            });
            this.accountList[i].tdapi.OnRspUserLogin += new TDAPI.RspUserLogin(delegate(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
            {
                CThostFtdcRspInfoField Info=pRspInfo;
                this.Invoke((MethodInvoker)delegate()
                {
                    if (Info.ErrorID != 0)
                    {
                        this.listView1.Items[i].SubItems[4].Text = "登录失败：" + Info.ErrorMsg;
                        this.accountList[i].tdapi.UserLogin();
                    }
                    else
                    {
                        this.listView1.Items[i].SubItems[4].Text = "登录成功";
                        this.accountList[i].tdapi.SettlementInfoConfirm();
                        
                    }

                });
            });
            this.accountList[i].tdapi.OnRspSettlementInfoConfirm += new TDAPI.RspSettlementInfoConfirm(delegate(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    this.listView1.Items[i].SubItems[4].Text = "运行中...";
                });
            });
            this.accountList[i].tdapi.OnRspError += new TDAPI.RspError(delegate(ref CThostFtdcRspInfoField pRspInfo)
            {
                CThostFtdcRspInfoField Info = pRspInfo;
                this.Invoke((MethodInvoker)delegate()
                {
                    this.listView1.Items[i].SubItems[4].Text =Info.ErrorMsg;
                });
            });

        }
        private void Form_Account_Load(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.listView1.Controls.Count;i++ )
            {
                System.Windows.Forms.CheckBox cb=(System.Windows.Forms.CheckBox)this.listView1.Controls[i];
                if (cb.Checked == true)
                {
                    this.listView1.Items[i].SubItems[5].Text = "开启";
                    this.Reg(i);
                    this.accountList[i].tdapi.Connect();
                    Thread.Sleep(100); 
                    //TDAPI td = new TDAPI("202800020", "162510", "20000", "tcp://180.169.124.109:41213");
                    //td.Connect();
                    //MessageBox.Show(this.components.Components.Count.ToString());
                }
            }
            
        }

        private void Form_Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        
    }
}
