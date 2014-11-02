using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using CTPAPI;
using System.Threading;
using System.Reflection;
using Ats.Core;
using System.IO;
namespace Futures
{
    public partial class Form_Main : Form
    {
        public Exchange Exchangesh;
        public Exchange ExchangeDCE;
        public Exchange Exchangezz;
        public Exchange Exchangezj;
        public Form_ProjName fpn;
        public static int MaxWidth;
        public static int MaxHeight;
       // public string SelectAccount="";
        public AccSeries accountList = new AccSeries();
        public MdAccSeries mdaccountList = new MdAccSeries();
        public List<System.Windows.Forms.ListViewItem> listViewItems = new List<ListViewItem>();
        public List<System.Windows.Forms.ListViewGroup> listViewGroups = new List<ListViewGroup>();
        private int m = 0, mm = 0;
        public List<CThostFtdcInstrumentField> Instruments = new List<CThostFtdcInstrumentField>();
        public ProjectSeries projectList = new ProjectSeries();
        //public List<CThostFtdcOrderField> orders = new List<CThostFtdcOrderField>();
        //private int selectedaccounts=0;
        //public Thread ThreadRefreshPositions;
        //ManualResetEvent RefreshPositionsEventEvent = new ManualResetEvent(false);
        public Form_Main()
        {
            InitializeComponent();
            //this.ExchangeDCE.BaseTime=DateTime.Now;
            //this.ExchangeDCE.CloseTime=Convert.ToDateTime("15:15:00");
            //this.ExchangeDCE.DiffTime
            //this.ExchangeDCE.ExchangeID="DCE";
            //this.ExchangeDCE.ExchangeName="大连期货交易所";
            //this.ExchangeDCE.IsFuture=true;
            //this.ExchangeDCE.OpenTime=Convert.ToDateTime("09:00:00");
                    
        }
        public object Transformation(object obj,Type tp)
        {
            //MessageBox.Show(obj1.ToString());
            if (tp.ToString()=="System.Double")
            {
                //MessageBox.Show(tp.ToString());
                return Convert.ToDouble(obj);
            }
            else if(tp.ToString()=="System.Int32")
            {
                return Convert.ToInt32(obj);
            }
            else if (tp.ToString() == "System.Boolean")
            {
                return Convert.ToBoolean(obj);
            }
            else
                return "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Thread.CurrentThread.ApartmentState = "1";
            //MessageBox.Show(Thread.CurrentThread.Name);
            Form_Main.MaxWidth = this.Width;
            Form_Main.MaxHeight = this.Height;
            this.treeView1.ExpandAll();
            this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes[0];
            this.tabPage1.Hide();
            this.tabControl1.SelectedTab = this.tabPage2;
            // ThreadPool.QueueUserWorkItem(new WaitCallback(RefreshPositions), " nih");
            //ThreadPool.RegisterWaitForSingleObject(RefreshPositionsEventEvent, null, null, 2000, false);
            //RefreshPositionsEventEvent.Reset();
            #region 加载账户
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Account.xml");
            Acc acc, mdacc;
            //Acc ac;
            foreach (XmlNode xmlDoc1 in xmlDoc.ChildNodes)
            {
                if (xmlDoc1.Name == "root")
                {
                    foreach (XmlNode node0 in xmlDoc1.ChildNodes)
                    {
                        if (node0.Name == "broker")
                        {
                            //MessageBox.Show("broker");
                            XmlElement xe = (XmlElement)node0;
                            string[] tdparm = new string[10] { "", "", "", "", "", "", "", "", "", "" };
                            string brokerid = xe.GetAttribute("BrokerID");
                            string brokername = xe.GetAttribute("BrokerName");
                            //string tdserver = "";
                            //string mdserver = "";
                            foreach (XmlNode node in node0.ChildNodes)
                            {

                                #region Server
                                if (node.Name == "Server")
                                {
                                    foreach (XmlNode node1 in node.ChildNodes)
                                    {
                                        if (node1.Name == "Trade")
                                        {
                                            
                                            int jl = 0;
                                            foreach (XmlNode node2 in node1.ChildNodes)
                                            {
                                               
                                                if (node2.InnerText != "")
                                                {
                                                    tdparm[jl++] = "tcp://" + node2.InnerText;

                                                }
                                            }
                                        }
                                        if (node1.Name == "MarketData")
                                        {
                                            string[] parm = new string[10] {"","","","","","","","","","" };
                                            int jl = 0;
                                            
                                            foreach (XmlNode node3 in node1.ChildNodes)
                                            {
                                                //mdserver = node3.InnerText;
                                                if (node3.InnerText != "")
                                                {
                                                    parm[jl++] = "tcp://" + node3.InnerText;

                                                }
                                            }
                                            MDAPI mdapi = new MDAPI(parm, brokerid);
                                            mdacc = new Acc();
                                            mdacc.brokerid = brokerid;
                                            mdacc.brokername = brokername;
                                            //mdacc.mdserver = mdserver;
                                            mdacc.mdapi = mdapi;
                                            mdaccountList.Add(mdacc);
                                            // MessageBox.Show(parm.Length.ToString());
                                        }


                                    }

                                }
                                #endregion Server
                                #region invostors
                                if (node.Name == "invostors")
                                {
                                    //MessageBox.Show("invostors");
                                    foreach (XmlNode node4 in node.ChildNodes)
                                    {
                                        if (node4.Name == "invostor")
                                        {
                                            string invostor = "";
                                            string pwssword = "";
                                            foreach (XmlNode node5 in node4.ChildNodes)
                                            {
                                                if (node5.Name == "id")
                                                {
                                                    invostor = node5.InnerText;
                                                }
                                                if (node5.Name == "pwssword")
                                                {
                                                    pwssword = node5.InnerText;

                                                }

                                            }
                                            TDAPI tdapi = new TDAPI(tdparm,invostor, pwssword, brokerid);
                                            acc = new Acc();
                                            acc.tdapi = tdapi;
                                            acc.pwssword = pwssword;
                                            acc.invostor = invostor;
                                            acc.brokerid = brokerid;
                                            acc.brokername = brokername;
                                            //acc.tdserver = tdserver;
                                           // acc.mdserver = mdserver;
                                            accountList.Add(acc);
                                            //string str = "";
                                            //for (int i = 0; i < accountList.Count; i++)
                                            //{
                                            //    str += accountList[i].tdserver + "\r\n";

                                            //}
                                            //MessageBox.Show(str);
                                        }
                                    }
                                }
                                #endregion invostors

                            }
                        }
                    }

                }
            }
            int i = 0;
            System.Windows.Forms.ListViewGroup listViewGroup = new ListViewGroup("交易账号", System.Windows.Forms.HorizontalAlignment.Left);
            for (; i < this.accountList.Count; i++)
            {
                System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
                                i.ToString(),
                                "",
                                this.accountList[i].brokername,
                                this.accountList[i].invostor,
                                this.accountList[i].state,
                                this.accountList[i].isAuto.ToString()
                                }, -1);
                listViewItem1.Group = listViewGroup;
                this.listView2.Groups.Add(listViewGroup);
                this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
                System.Windows.Forms.CheckBox checkBox1 = new CheckBox();

                checkBox1.Size = new Size(this.listView2.Items[i].SubItems[1].Bounds.Width,
                this.listView2.Items[i].SubItems[1].Bounds.Height);
                checkBox1.Visible = true;
                checkBox1.Name = "交易账户" + i.ToString();
                checkBox1.Location = new Point(this.listView2.Items[i].SubItems[1].Bounds.Left,
                        this.listView2.Items[i].SubItems[1].Bounds.Top);

                this.listView2.Controls.Add(checkBox1);
            }
            System.Windows.Forms.ListViewGroup listViewGroup1 = new ListViewGroup("行情账号", System.Windows.Forms.HorizontalAlignment.Left);
            for (int j = 0; j < this.mdaccountList.Count; j++)
            {
                System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
                                j.ToString(),
                                "",
                                this.mdaccountList[j].brokername,
                                "",
                                this.mdaccountList[j].state,
                                this.mdaccountList[j].isAuto.ToString()
                                }, -1);
                listViewItem2.Group = listViewGroup1;
                this.listView2.Groups.Add(listViewGroup1);
                this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem2 });
                System.Windows.Forms.CheckBox checkBox2 = new CheckBox();

                checkBox2.Size = new Size(this.listView2.Items[i + j].SubItems[1].Bounds.Width,
                this.listView2.Items[i + j].SubItems[1].Bounds.Height);
                checkBox2.Visible = true;
                checkBox2.Name = "行情账户" + j.ToString();
                checkBox2.Location = new Point(this.listView2.Items[i + j].SubItems[1].Bounds.Left,
                 this.listView2.Items[i + j].SubItems[1].Bounds.Top);

                this.listView2.Controls.Add(checkBox2);
            }
            #endregion 加载账户
            //this.splitContainer3.Panel1.Hide();
        }

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            Form_Main.MaxWidth = this.Width;
            Form_Main.MaxHeight = this.Height;
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Focus();
            System.Environment.Exit(0); 
            //Application.Exit();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (this.treeView1.SelectedNode.Text)
            {
                case "策略列表":
                    this.tabControl1.SelectedTab = this.tabPage1;
                    break;
                case "工程列表":
                    this.tabControl1.SelectedTab = this.tabPage3;
                    break;
                case "账户关联":
                    this.tabControl1.SelectedTab = this.tabPage2;
                    break;
                default:
                    break;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "文档(*.dll)|*.dll";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string st in openFileDialog1.FileNames)
                {

                    if (st != "")
                    {
                        listViewGroups.Add(new System.Windows.Forms.ListViewGroup(st, System.Windows.Forms.HorizontalAlignment.Left));

                        Assembly assm = Assembly.LoadFrom(@openFileDialog1.FileName);//用库类地址和文件名引用动态链接库
                        Type[] types = assm.GetTypes();

                        for (int i = 0; i < types.Length; i++)
                        {
                            listViewItems.Add(new System.Windows.Forms.ListViewItem(new string[] {
                            i.ToString(),
                               types[i].Name,
                            "b"}, -1));
                            listViewItems[m].Group = listViewGroups[listViewGroups.Count - 1];
                            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItems[m] });
                            m++;
                        }
                        this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { listViewGroups[mm++] });
                    }

                }

            }
            this.listView1.GridLines = true;
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection c = listView1.SelectedIndices;

            bool ifExist = false;
            for (int i = 0; i < this.projectList.Count; i++)
            {
                if (this.projectList[i].Projname == this.listView1.SelectedItems[0].SubItems[1].Text)
                    ifExist = true;
            }
            if (ifExist == true)
            {
                MessageBox.Show("工程已经存在");
                return;
            }
            else
            {
                Project project = new Project();
                project.Projname = this.listView1.SelectedItems[0].SubItems[1].Text;
                //project.Mode = "实盘";
                //project.State = "准备";
                project.Addrname = this.listView1.SelectedItems[0].Group.Header;
                project.thread = new Thread(project.Run);
                this.projectList.Add(project);
            }
            this.listView1.Items.Clear();

            for (int i = 0; i < this.projectList.Count; i++)
            {
                System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
                                i.ToString(),
                                this.projectList[i].Projname,
                                }, -1);
                this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.listView2.Controls.Count; i++)
            {
                System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)this.listView2.Controls[i];
                if (cb.Checked == true)
                {
                    this.listView2.Items[i].SubItems[4].Text = "开启";
                    if (this.listView2.Items[i].Group.Header == "交易账号")
                    {
                        this.Reg(i);
                        this.accountList[i].tdapi.Connect();
                        Thread.Sleep(500);
                    }
                    if (this.listView2.Items[i].Group.Header == "行情账号")
                    {
                        this.mdReg(i-this.accountList.Count);
                        this.mdaccountList[i - this.accountList.Count].mdapi.Connect();
                        Thread.Sleep(500);
                    }
                    
                    //TDAPI td = new TDAPI("202800020", "162510", "20000", "tcp://180.169.124.109:41213");
                    //td.Connect();
                    //MessageBox.Show(this.components.Components.Count.ToString());
                }
                
            }
        }
        public void mdReg(int i)
        {
            this.mdaccountList[i].mdapi.OnFrontConnected += new MDAPI.FrontConnected(delegate()
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    //MessageBox.Show(Thread.CurrentThread.Name);
                    this.listView2.Items[this.accountList.Count+i].SubItems[5].Text = "连接前置成功";
                    
                    this.mdaccountList[i].mdapi.UserLogin();
                    this.listView2.Update();
                    //MessageBox.Show("");

                });
            });
            this.mdaccountList[i].mdapi.OnFrontDisconnected += new MDAPI.FrontDisconnected(delegate(int n)
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    this.listView2.Items[this.accountList.Count + i].SubItems[5].Text = "网络诊断:" + n.ToString();

                    this.mdaccountList[i].mdapi.Connect();
                    this.listView2.Update();

                });
            });
            this.mdaccountList[i].mdapi.OnRspUserLogin += new MDAPI.RspUserLogin(delegate(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
            {
               //MessageBox.Show (pRspUserLogin.FrontID.ToString());
               //MessageBox.Show(pRspUserLogin.SessionID.ToString());
               //MessageBox.Show(pRspUserLogin.SystemName);

                CThostFtdcRspInfoField Info = pRspInfo;
                this.Invoke((MethodInvoker)delegate()
                {
                    if (Info.ErrorID != 0)
                    {
                        this.listView2.Items[this.accountList.Count + i].SubItems[5].Text = "登录失败：" + Info.ErrorMsg;
                        this.mdaccountList[i].mdapi.UserLogin();
                        this.listView2.Update();
                    }
                    else
                    {

                        this.mdaccountList[i].state = "运行中...";
                        this.listView2.Items[this.accountList.Count + i].SubItems[5].Text = this.mdaccountList[i].state;
                        this.listView2.Update();

                    }

                });
            });
        }
        public void Reg(int i)
        {
            this.accountList[i].tdapi.OnRspQryInvestorPositionDetail += new TDAPI.RspQryInvestorPositionDetail(delegate(ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
                {
                    //MessageBox.Show(this.accountList[i].InvestorPositionDetailFields.Count.ToString());
                    if (pInvestorPositionDetail.CloseVolume == 0)
                    {
                        //string mes = "|" + pInvestorPositionDetail.BrokerID + "|" + pInvestorPositionDetail.CloseAmount
                        //    + "|" + pInvestorPositionDetail.CloseProfitByDate + "|" + pInvestorPositionDetail.CloseProfitByTrade + "|" + pInvestorPositionDetail.CloseVolume
                        //    + "|" + pInvestorPositionDetail.CombInstrumentID + "|" + pInvestorPositionDetail.Direction + "|" + pInvestorPositionDetail.ExchangeID
                        //    + "|" + pInvestorPositionDetail.ExchMargin + "|" + pInvestorPositionDetail.HedgeFlag + "|" + pInvestorPositionDetail.InstrumentID
                        //    + "|" + pInvestorPositionDetail.InvestorID + "|" + pInvestorPositionDetail.LastSettlementPrice + "|" + pInvestorPositionDetail.Margin
                        //    + "|" + pInvestorPositionDetail.MarginRateByMoney + "|" + pInvestorPositionDetail.MarginRateByVolume + "|" + pInvestorPositionDetail.OpenDate
                        //    + "|" + pInvestorPositionDetail.OpenPrice + "|" + pInvestorPositionDetail.PositionProfitByDate + "|" + pInvestorPositionDetail.PositionProfitByTrade
                        //    + "|" + pInvestorPositionDetail.SettlementID + "|" + pInvestorPositionDetail.SettlementPrice + "|" + pInvestorPositionDetail.TradeID
                        //    + "|" + pInvestorPositionDetail.TradeType + "|" + pInvestorPositionDetail.TradingDay + "|" + pInvestorPositionDetail.Volume;
                        //    ;

                        bool ifcz = false;
                        for (int j = 0; j < this.accountList[i].InvestorPositionDetailFields.Count; j++)
                        {
                            //if (this.accountList[i].InvestorPositionDetailFields[j].InstrumentID == p.InstrumentID && this.accountList[i].InvestorPositionDetailFields[j].Volumn == p.Volumn && this.accountList[i].InvestorPositionDetailFields[j].PosiDirection == p.PosiDirection && this.accountList[i].InvestorPositionDetailFields[j].PositionDate == p.PositionDate)
                            //{
                            //    return;
                            //}
                            if (this.accountList[i].InvestorPositionDetailFields[j].TradeID == pInvestorPositionDetail.TradeID)
                            {
                                ifcz = true;
                                break;
                                //return;
                            }
                        }
                        //MessageBox.Show(ifcz.ToString());
                        if (ifcz==true)
                        {
                           // MessageBox.Show("cunzai");
                        }
                        else
                        {
                            //PrintDisk("Position.txt", mes);
                            this.accountList[i].InvestorPositionDetailFields.Add(pInvestorPositionDetail);
                        }
                        
                    } 
                }
                );
            this.accountList[i].tdapi.OnRspQryInvestorPosition += new TDAPI.RspQryInvestorPosition(delegate(ref CThostFtdcInvestorPositionField pInvestorPosition, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
               {
                   
                    if (pInvestorPosition.PositionCost >0)
                    {
                        //StreamWriter swFromFile = new StreamWriter("PositionFields.txt", true);
                        //swFromFile.WriteLine("合约" + pInvestorPosition.InstrumentID + "多空方向" + pInvestorPosition.PosiDirection + "投机套保标志" + pInvestorPosition.HedgeFlag + "持仓日期" + pInvestorPosition.PositionDate +
                        //    "上日持仓" + pInvestorPosition.YdPosition + "今日持仓" + pInvestorPosition.TodayPosition + "开仓量" + pInvestorPosition.OpenVolume + "平仓量" + pInvestorPosition.CloseVolume + "持仓成本" + pInvestorPosition.PositionCost +
                        //    "手续费" + pInvestorPosition.Commission + "交易日" + pInvestorPosition.TradingDay + "开仓成本" + pInvestorPosition.OpenCost + "组合持仓" + pInvestorPosition.CombPosition
                        //    + "\r\n");
                        //swFromFile.Flush();
                        //swFromFile.Close();
                        bool ifcz = false;
                        for (int j = 0; j < this.accountList[i].PositionFields.Count; j++)
                        {
                            if (this.accountList[i].PositionFields[j].Equals(pInvestorPosition))
                            {
                                ifcz = true;
                                break;
                            }
                        }
                        if (!ifcz)
                        {
                            this.accountList[i].PositionFields.Add(pInvestorPosition);
                        }
                    }
                
               });
            this.accountList[i].tdapi.OnFrontConnected += new TDAPI.FrontConnected(delegate()
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    this.listView2.Items[i].SubItems[5].Text = "连接前置成功";
                    this.accountList[i].tdapi.UserLogin();
                    this.listView2.Update();

                });
            });
            this.accountList[i].tdapi.OnFrontDisconnected += new TDAPI.FrontDisconnected(delegate(int n)
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    this.listView2.Items[i].SubItems[5].Text = "网络诊断:" + n.ToString();
                    
                    this.accountList[i].tdapi.Connect();
                    this.listView2.Update();

                });
            });
            this.accountList[i].tdapi.OnRspUserLogin += new TDAPI.RspUserLogin(delegate(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
            {
                CThostFtdcRspInfoField Info = pRspInfo;
                this.Invoke((MethodInvoker)delegate()
                {
                    if (Info.ErrorID != 0)
                    {
                        this.listView2.Items[i].SubItems[5].Text = "登录失败：" + Info.ErrorMsg;
                        this.accountList[i].tdapi.UserLogin();
                        this.listView2.Update();
                    }
                    else
                    {
                        
                        this.accountList[i].state = "登录成功";
                        this.listView2.Items[i].SubItems[5].Text = this.accountList[i].state;
                       
                        this.accountList[i].tdapi.SettlementInfoConfirm();
                        this.listView2.Update();

                    }

                });
            });
            this.accountList[i].tdapi.OnRspSettlementInfoConfirm += new TDAPI.RspSettlementInfoConfirm(delegate(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    this.accountList[i].tdapi.ReqQryInvestorPosition(" ");
                    this.accountList[i].tdapi.ReqQryInvestorPositionDetail(" ");
                    //this.accountList[i].InvestorPositionDetailFields.Clear();
                    this.accountList[i].state = "运行中...";
                    this.accountList[i].tdapi.ReqQryOrder();
                    this.accountList[i].tdapi.QryInstrument();
                    this.listView2.Items[i].SubItems[5].Text = this.accountList[i].state;
                    this.listView2.Update();
                });
            });
            this.accountList[i].tdapi.OnRspQryOrder += new TDAPI.RspQryOrder(delegate(ref CThostFtdcOrderField pOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
            {
                if (pOrder.StatusMsg == "未成交" && pOrder.OrderSysID != "")
                {
                    //StreamWriter swFromFile = new StreamWriter("orders.txt", true);
                    //swFromFile.WriteLine("合约" + pOrder.InstrumentID + "方向" + pOrder.Direction + "开平" + pOrder.CombOffsetFlag + "数量" + pOrder.VolumeTotalOriginal.ToString() + "报单编号" + pOrder.OrderSysID + "报单状态" + pOrder.OrderStatus + "状态信息" + pOrder.StatusMsg
                    //    + "成交数量" + pOrder.VolumeTraded + "剩余数量" + pOrder.VolumeTotal.ToString()
                    //    + "\r\n");
                    //swFromFile.Flush();
                    //swFromFile.Close();
                    bool ifcz = false;
                    foreach (CThostFtdcOrderField o in this.accountList[i].orders)
                    {
                        if (o.OrderSysID == pOrder.OrderSysID)
                        {
                            ifcz = true;
                            break;
                        }
                    }
                    if (!ifcz)
                        this.accountList[i].orders.Add(pOrder);
                }
            });
            this.accountList[i].tdapi.OnRspQryInstrument += new TDAPI.RspQryInstrument(delegate(ref CThostFtdcInstrumentField pInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
            {
                bool ifcz = false;
                foreach (CThostFtdcInstrumentField ist in this.Instruments)
                {
                    if (ist.InstrumentID == pInstrument.InstrumentID)
                    {
                        ifcz = true;
                        break;
                    }
                }
                if(!ifcz)
                    this.Instruments.Add(pInstrument);
                //this.accountList[i].tdapi.QryInstrument();
            });
            this.accountList[i].tdapi.OnRspError += new TDAPI.RspError(delegate(ref CThostFtdcRspInfoField pRspInfo)
            {
                CThostFtdcRspInfoField Info = pRspInfo;
                this.Invoke((MethodInvoker)delegate()
                {
                    this.listView2.Items[i].SubItems[5].Text = "错误-> "+Info.ErrorMsg;
                    this.listView2.Update();
                });
            });

        }
        
        private void 创建工程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             fpn = new Form_ProjName(this);
            //fpn.MdiParent = this;
            fpn.ShowDialog();
           
        }
        
        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( this.listView3.SelectedItems.Count==1)
            {
                this.label2.Text = this.listView3.SelectedItems[0].SubItems[1].Text;
                if (this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].isRun == false)
                {

                    this.button4.Enabled = true;
                    this.button5.Enabled = false;
                    this.button6.Enabled = true;
                    this.button7.Enabled = true;
                    this.button8.Enabled = false;
                    this.treeView2.Enabled = false;
                    this.dataGridView1.Enabled = false;
                }
                else
                {
                    this.button4.Enabled = false;
                    this.button5.Enabled = true;
                    this.button6.Enabled = false;
                    this.button7.Enabled = false;
                    this.button8.Enabled = true;
                    this.treeView2.Enabled = false;
                    this.dataGridView1.Enabled = false;
                }

            }
            else
                return;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].isRun == false)
            {

                this.button4.Enabled = true;
                this.button5.Enabled = false;
                this.button6.Enabled = true;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.treeView2.Enabled = true;
                this.dataGridView1.Enabled = true;
            }
            else
            {
                this.button4.Enabled = false;
                this.button5.Enabled = true;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = true;
                this.treeView2.Enabled = false;
                this.dataGridView1.Enabled = false;
            }
            #region 属性
            
            this.treeView2.Show();
            this.treeView2.CheckBoxes = true;
            this.treeView2.Nodes[0].Checked = false;
            this.treeView2.Nodes[1].Checked = false;
            this.treeView2.Nodes[2].Checked = false;
            this.treeView2.Nodes[0].Nodes.Clear();
            this.treeView2.Nodes[1].Nodes.Clear();
            this.treeView2.Nodes[2].Nodes.Clear();
            this.treeView2.Controls.Clear();
            for (int i = 0; i < this.accountList.Count; i++)
            {
                if (this.accountList[i].state == "运行中..." || this.accountList[i].state == "综合交易平台：重复的登录")
                {
                    System.Windows.Forms.TreeNode treeNodex = new System.Windows.Forms.TreeNode(this.accountList[i].invostor);
                    this.treeView2.Nodes[0].Nodes.Add(treeNodex);
                }
                
            }
            for (int i = 0; i < this.mdaccountList.Count; i++)
            {
                if (this.mdaccountList[i].state == "运行中..." || this.mdaccountList[i].state == "综合交易平台：重复的登录")
                {
                    System.Windows.Forms.TreeNode treeNodex1 = new System.Windows.Forms.TreeNode(this.mdaccountList[i].brokername);
                    this.treeView2.Nodes[1].Nodes.Add(treeNodex1);
                }

            }
            for (int n=0;n<this.treeView2.Nodes.Count;n++)
            {
                if (this.treeView2.Nodes[n].Text == "交易品种")
                {
                    System.Windows.Forms.TextBox textbox = new System.Windows.Forms.TextBox();
                    //textbox.Height = this.treeView2.Nodes[n].Bounds.Height - 10;
                    //textbox.Width = this.treeView2.Nodes[n].Bounds.Width + 40;
                    textbox.Size = new Size(this.treeView2.Nodes[n].Bounds.Width + 40, this.treeView2.Nodes[n].Bounds.Height - 10);
                    textbox.Visible = true;
                    textbox.TextChanged += new EventHandler(this.ChoiceInst);
                    textbox.Name = "合约选择器";
                    textbox.Text = "IF";
                    textbox.Location = new Point(this.treeView2.Nodes[n].Bounds.Left + 80, this.treeView2.Nodes[n].Bounds.Top-5);
                    this.treeView2.Controls.Add(textbox);
                    
                }
                if (this.treeView2.Nodes[n].Text == "驱动品种")
                {
                    System.Windows.Forms.TextBox textbox1 = new System.Windows.Forms.TextBox();
                    textbox1.Size = new Size(this.treeView2.Nodes[n].Bounds.Width + 40, this.treeView2.Nodes[n].Bounds.Height - 10);
                    textbox1.Visible = true;
                    textbox1.TextChanged += new EventHandler(this.ChoiceDvInst);
                    textbox1.Name = "驱动合约选择器";
                    textbox1.Text = "IF";
                    textbox1.Location = new Point(this.treeView2.Nodes[n].Bounds.Left + 80, this.treeView2.Nodes[n].Bounds.Top+5);
                    this.treeView2.Controls.Add(textbox1);
                }
            }
            
             this.treeView2.ExpandAll();
             #endregion 属性
             #region 参数
             this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].assm = null;
             this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].types = null;
             this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].obj = null;
             this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos = null;
             this.dataGridView1.Rows.Clear();
             this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].assm = Assembly.LoadFrom(this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Addrname);//用库类地址和文件名引用动态链接库
             this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].types = this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].assm.GetTypes();
             for (int j = 0; j < this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].types.Length; j++)
           {
               if (this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].types[j].Name == this.listView3.SelectedItems[0].SubItems[2].Text)
               {
                   if (this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].obj == null)
                   {

                       this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].obj = this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].assm.CreateInstance(this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].types[j].FullName, true);
                   }

                   this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos = this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].types[j].GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                   for (int k = 0; k < this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos.LongLength; k++)
                   {

                       foreach (Attribute att in this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos[k].GetCustomAttributes(false))
                      {
                          if (att is ParameterAttribute)
                          {
                              ParameterAttribute cc = att as ParameterAttribute;
                              string[] row = { this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos[k].Name, this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos[k].GetValue(this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].obj).ToString(), cc.Display };
                              this.dataGridView1.Rows.Add(row);
                          }
                      }
                  }
               }
           }
            #endregion 参数
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            //this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList.Clear();
           // this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].mdaccountList.Clear();
            if (e.Action == TreeViewAction.ByKeyboard || e.Action == TreeViewAction.ByMouse) 
            {
                //MessageBox.Show(this.treeView2.SelectedNode.ToString());
                if (this.treeView2.SelectedNode != null)
                {
                    e.Node.Checked = true;

                    if (e.Node.Parent != null)
                    {
                        e.Node.Parent.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("treeView2没有父节点");
                        return ;
                    }
                    //e.Node.Parent.Checked = true;
                   // this.SelectAccount = e.Node.Text;
                    bool ifhv = false;
                    for (int y = 0; y < this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList.Count; y++)
                    {
                        if (this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList[y].invostor == e.Node.Text)
                        {
                            ifhv = true;
                            break;
                        }
                    }
                    if (!ifhv)
                    {
                        for (int i = 0; i < this.accountList.Count; i++)
                        {
                            if (e.Node.Text != "" && this.accountList[i].invostor == e.Node.Text)
                            {
                                this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList.Add(this.accountList[i]);
                                
                            }
                        }
                    }
                       
                    //foreach (TreeNode node in this.treeView2.Nodes[0].Nodes)
                    //{
                    //    if (node.Text != e.Node.Text)
                    //    {
                    //        node.Checked = false;
                    //    }
                    //}
                    //this.SelectAccount = e.Node.Text;
                    bool ifhv1 = false;
                    for (int z = 0; z < this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].mdaccountList.Count; z++)
                    {
                        if (this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].mdaccountList[z].brokername == e.Node.Text)
                        {
                            ifhv1 = true;
                            break;
                        }
                    }
                    if (!ifhv1)
                    {
                        for (int zz = 0; zz < this.mdaccountList.Count; zz++)
                        {
                            if (e.Node.Text != "" && this.mdaccountList[zz].brokername == e.Node.Text)
                            {
                               
                                this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].mdaccountList.Add(this.mdaccountList[zz]);
                            }
                        }
                    }
                    bool ifhv2 = false;
                    for (int m = 0; m < this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Instruments.Count; m++)
                    { 
                        if(this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Instruments[m].InstrumentID==e.Node.Text)
                        {
                            ifhv2 = true;
                            break;
                        }
                    }
                    if (!ifhv2)
                    {
                        for (int zz = 0; zz < this.Instruments.Count; zz++)
                        {
                            if (e.Node.Text != "" && this.Instruments[zz].InstrumentID == e.Node.Text)
                            {

                                this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Instruments.Add(this.Instruments[zz]);
                            }
                        }
                    }
                    if(e.Node.Parent.Text=="驱动品种")
                    {
                        this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].DriveInstrument = e.Node.Text;
                        foreach (TreeNode tn in this.treeView2.Nodes[3].Nodes)
                        {
                            tn.Checked = false;
                        }
                        e.Node.Checked = true;
                    }
                }
                
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].obj != null
                    &&this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].assm != null
                    && this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos != null
                    && this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].types != null)
            {
                if (this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].isRun == false)
                {
                    this.button4.Enabled = false;
                    this.button5.Enabled = true;
                    this.button6.Enabled = false;
                    this.button7.Enabled = false;
                    this.button8.Enabled = true;
                    this.treeView2.Enabled = false;
                    this.dataGridView1.Enabled = false;
                    this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].isRun = true;
                }


                bool ifcj = false;
                foreach (Control c in this.tabControl1.Controls)
                {

                    if (c.Text == this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Projname)
                    {
                        ifcj = true;
                        // MessageBox.Show("工程：" + this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Projname + "已经创建显示窗口");
                        break;
                    }

                }
                if (!ifcj)
                {
                    TabPage tabPage = new System.Windows.Forms.TabPage();
                    RichTextBox richTextBox = new System.Windows.Forms.RichTextBox();
                    tabPage.Name = this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Projname;
                    tabPage.Text = this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Projname;
                    tabPage.Controls.Add(richTextBox);
                    richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
                    richTextBox.BackColor = System.Drawing.Color.Black;
                    richTextBox.ForeColor = System.Drawing.Color.Lime;
                    richTextBox.ReadOnly = true;
                    this.tabControl1.Controls.Add(tabPage);
                    this.tabControl1.SelectedTab = tabPage;
                    this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].richTextBox = richTextBox;
                }
                //this.RefreshPositions(); 
                //this.RrfreshOrders();
                //this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].RefreshPositions();
                //this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].RrfreshOrders();
                this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Run();
                
            }
            else
            {
                MessageBox.Show("请先设置参数");
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (this.listView3.SelectedItems.Count == 1)
                {
                    if( this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos!=null)
                    {
                        for (int i = 0; i < this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos.LongLength; i++)
                        {
                            if (this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos[i].Name == this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
                            {
                                object ob = this.Transformation(this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue, this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos[i].FieldType);
                                this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos[i].SetValue(this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].obj, ob);
                               //MessageBox.Show(this.projectList[this.listView3.SelectedIndices[0]].fieldInfos[i].GetValue(this.projectList[this.listView3.SelectedIndices[0]].obj).ToString());
                            }

                        }
                    }
                }
                //else
                //    MessageBox.Show("请选择工程");
            }
        }
        private void RefreshPositions()
        {
           
            this.Invoke((MethodInvoker)delegate()
            {
                this.listView4.Items.Clear();
                if (this.listView3.SelectedItems.Count == 1)
                {
                      //List<System.Windows.Forms.ListViewGroup> listViewGroups1 = new List<ListViewGroup>();
                      //List<System.Windows.Forms.ListViewItem> listViewItems1 = new List<ListViewItem>();
                         foreach(Acc acc in this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList)
                         {
                             System.Windows.Forms.ListViewGroup listViewGroup = new ListViewGroup(acc.invostor, System.Windows.Forms.HorizontalAlignment.Left);
                             //MessageBox.Show(this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].GetFuturePositions(acc.invostor).Count.ToString());
                             foreach (Position p in this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].GetFuturePositions(acc.invostor))
                             {
                                 System.Windows.Forms.ListViewItem listViewItem = new System.Windows.Forms.ListViewItem(
                                  new string[] {
                                        p.InstrumentID,
                                        "",
                                        p.Volumn.ToString()
                                        }, -1);
                                 listViewItem.Group=listViewGroup;
                                 this.listView4.Groups.Add(listViewGroup);
                                 this.listView4.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem });
                                // MessageBox.Show(p.InstrumentID + "  " + p.Volumn);
                             }

                         }
                }
            });
            //RefreshPositionsEventEvent.Reset();
        }
        private void RrfreshOrders()
        {
            this.Invoke((MethodInvoker)delegate()
            {
                this.listView5.Items.Clear();
                if (this.listView3.SelectedItems.Count == 1)
                {
                    foreach (Acc acc in this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList)
                    {
                        System.Windows.Forms.ListViewGroup listViewGroup = new ListViewGroup(acc.invostor, System.Windows.Forms.HorizontalAlignment.Left);
                        foreach (Order o in this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].GetCanCancelFutureOrders(acc.invostor))
                        {
                            System.Windows.Forms.ListViewItem listViewItem = new System.Windows.Forms.ListViewItem(
                             new string[] {
                                        o.InstrumentID,
                                        o.Volume.ToString()
                                        }, -1);
                            listViewItem.Group = listViewGroup;
                            this.listView5.Groups.Add(listViewGroup);
                            this.listView5.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem });
                            // MessageBox.Show(p.InstrumentID + "  " + p.Volumn);
                        }
                    }
                }
            });
        }
        public void PrintDisk(string fileName, string textToAdd)
        {
            StreamWriter swFromFile = new StreamWriter(fileName, true);
            swFromFile.WriteLine(textToAdd);
            swFromFile.Flush();
            swFromFile.Close();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form_Main_Shown(object sender, EventArgs e)
        {

        }

        private void listView3_MouseLeave(object sender, EventArgs e)
        {
            //this.button4.Enabled = false;
            //this.button5.Enabled = false;
            //this.button6.Enabled = false;
            //this.button7.Enabled = false;
            //this.button8.Enabled = false;
            //this.treeView2.Enabled = false;
            //this.dataGridView1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.tabControl1.Controls)
            {
                if (c.Name == this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Projname)
                {
                    this.tabControl1.Controls.Remove(c);
                }
            }
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;
            this.button8.Enabled = false;
            this.treeView2.Enabled = false;
            this.dataGridView1.Enabled = false;

            for (int i = 0; i < this.projectList.Count; i++)
            {
                System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(
                       new string[] {
                                i.ToString(),
                                this.projectList[i].Projname,
                                this.projectList[i].Classname,
                                this.projectList[i].Addrname
                                }, -1);
                this.listView3.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
            }
            this.projectList.Remove(this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)]);
            this.listView3.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Stop();
            this.button4.Enabled = true;
            this.button5.Enabled = false;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.treeView2.Enabled = false;
            this.dataGridView1.Enabled = false;
            this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].isRun = false;
        }

        private void treeView2_Resize(object sender, EventArgs e)
        {
            TreeView tv = (TreeView)sender;
            for (int n = 0; n < tv.Nodes.Count; n++)
            {
                if (this.treeView2.Nodes[n].Text == "交易品种")
                {
                    foreach (Control c in tv.Controls)
                    {
                        if (c.Name == "合约选择器")
                        {
                            c.Location = new Point(tv.Nodes[n].Bounds.Left + 80, tv.Nodes[n].Bounds.Top-5);
                            //this.treeView2.Controls.Add(c);
                        }
                    }
                }
                if (this.treeView2.Nodes[n].Text == "驱动品种")
                {
                    foreach (Control c in tv.Controls)
                    {
                        if (c.Name == "驱动合约选择器")
                        {
                            c.Location = new Point(tv.Nodes[n].Bounds.Left + 80, tv.Nodes[n].Bounds.Top+5);
                            //this.treeView2.Controls.Add(c);
                        }
                    }
                }
            }
        }

        private void ChoiceInst(object sender, EventArgs e)
        {
            TextBox t=(TextBox)sender;
            this.treeView2.Nodes[2].Nodes.Clear();
            for (int i = 0; i < this.Instruments.Count; i++)
            {
                if (this.Instruments[i].InstrumentID.Contains(t.Text.ToLower()) || this.Instruments[i].InstrumentID.Contains(t.Text.ToUpper()))
                {
                    System.Windows.Forms.TreeNode treeNodex = new System.Windows.Forms.TreeNode(this.Instruments[i].InstrumentID);
                    this.treeView2.Nodes[2].Nodes.Add(treeNodex);
                }
            }
            this.treeView2.Update();
            this.treeView2.Nodes[2].ExpandAll();
        }
        private void ChoiceDvInst(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            this.treeView2.Nodes[3].Nodes.Clear();
            for (int i = 0; i < this.Instruments.Count; i++)
            {
                if (this.Instruments[i].InstrumentID.Contains(t.Text.ToLower()) || this.Instruments[i].InstrumentID.Contains(t.Text.ToUpper()))
                {
                    System.Windows.Forms.TreeNode treeNodex = new System.Windows.Forms.TreeNode(this.Instruments[i].InstrumentID);
                    this.treeView2.Nodes[3].Nodes.Add(treeNodex);
                }
            }
            this.treeView2.Update();
            this.treeView2.Nodes[3].ExpandAll();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.listView3.SelectedItems.Count == 1)
            {
                XmlDocument doc = new XmlDocument(); // 创建dom对象
                XmlElement project = doc.CreateElement("Project");
                
                doc.AppendChild(project);
                XmlElement strategy = doc.CreateElement("Strategy");  // 创建preview元素
                strategy.SetAttribute("class", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Classname);
                strategy.SetAttribute("path", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Addrname);
                project.AppendChild(strategy);
                XmlElement parameters = doc.CreateElement("Parameters");
                strategy.AppendChild(parameters);
                for (int k = 0; k < this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos.LongLength; k++)
                {
                    foreach (Attribute att in this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos[k].GetCustomAttributes(false))
                    {
                        if (att is ParameterAttribute)
                        {
                            XmlElement parameter = doc.CreateElement("Parameter");
                            parameter.SetAttribute("name", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos[k].Name);
                            parameter.SetAttribute("value", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos[k].GetValue(this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].obj).ToString());
                            parameters.AppendChild(parameter);

                        }
                    }
                }
                XmlElement accounts = doc.CreateElement("Accounts");
                project.AppendChild(accounts);
                XmlElement tdAccounts = doc.CreateElement("TdAccounts");
                XmlElement defaulttdAccount = doc.CreateElement("DefaulttdAccount");
                defaulttdAccount.SetAttribute("broker", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList[0].brokerid);
                defaulttdAccount.SetAttribute("invostor", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList[0].invostor);
                defaulttdAccount.SetAttribute("brokername", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList[0].brokername);
                tdAccounts.AppendChild(defaulttdAccount);
                for (int l = 1; l < this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList.Count; l++)
                {
                    XmlElement tdAccount = doc.CreateElement("TdAccount");
                    tdAccount.SetAttribute("broker", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList[l].brokerid);
                    tdAccount.SetAttribute("invostor", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList[l].invostor);
                    tdAccount.SetAttribute("brokername", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList[l].brokername);
                    tdAccounts.AppendChild(tdAccount);
                }
                XmlElement mdAccounts = doc.CreateElement("MdAccounts");
                XmlElement defaultmdAccount = doc.CreateElement("DefaultmdAccount");
                defaultmdAccount.SetAttribute("broker", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].mdaccountList[0].brokerid);
                //defaultmdAccount.SetAttribute("invostor", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList[0].invostor);
                defaultmdAccount.SetAttribute("brokername", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].mdaccountList[0].brokername);
                mdAccounts.AppendChild(defaultmdAccount);
                for (int l = 1; l < this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].mdaccountList.Count; l++)
                {
                    XmlElement mdAccount = doc.CreateElement("MdAccount");
                    mdAccount.SetAttribute("broker", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].mdaccountList[l].brokerid);
                    //mdAccount.SetAttribute("invostor", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList[l].invostor);
                    mdAccount.SetAttribute("brokername", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].mdaccountList[l].brokername);
                    mdAccounts.AppendChild(mdAccount);
                }
                accounts.AppendChild(mdAccounts);
                accounts.AppendChild(tdAccounts);

                XmlElement instruments = doc.CreateElement("Instruments");
                project.AppendChild(instruments);
                XmlElement driveInstrument = doc.CreateElement("DriveInstrument");
                driveInstrument.SetAttribute("name", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].DriveInstrument);
                driveInstrument.SetAttribute("id", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].DriveInstrument);
                instruments.AppendChild(driveInstrument);
                XmlElement defaultInstrument = doc.CreateElement("DefaultInstrument");
                defaultInstrument.SetAttribute("name", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].AllFutures[0].Name);
                defaultInstrument.SetAttribute("id", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].AllFutures[0].ID);
                instruments.AppendChild(defaultInstrument);
                for (int m = 1; m < this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].AllFutures.Count; m++)
                {
                    XmlElement instrument = doc.CreateElement("Instrument");
                    instrument.SetAttribute("name", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].AllFutures[m].Name);
                    instrument.SetAttribute("id", this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].AllFutures[m].ID);
                    instruments.AppendChild(instrument);
                }
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "保存";
                saveFileDialog1.Filter = "文档(*.xml)|*.xml";
                saveFileDialog1.DefaultExt = "xml";
                saveFileDialog1.InitialDirectory = "./Project";
                saveFileDialog1.FileName = this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].Projname;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string addr = saveFileDialog1.InitialDirectory = saveFileDialog1.FileName;
                    project.SetAttribute("name",addr.Substring(addr.LastIndexOf("\\")+1));
                    doc.Save(@addr);   // 保存文件
                }
            }
            else
            {
                MessageBox.Show("请先选择需要保存的工程");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
             OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "文档(*.xml)|*.xml";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string st in openFileDialog1.FileNames)
                {

                    if (st != "")
                    {
                         
                        Project pro = new Project();
                        #region 读取工程数据
                        bool ifcz = false;
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(st);
                        XmlNode xn = xmlDoc.SelectSingleNode("Project");
                        pro.Projname = xn.Attributes["name"].InnerText;
                       
                        foreach (Project p in this.projectList)
                        {
                            if (p.Projname == pro.Projname)
                            {
                                MessageBox.Show("已经打开工程: " + pro.Projname);
                                ifcz = true;
                                return;
                            }
                        }
                        if (!ifcz)
                        {

                            XmlNodeList xnl = xn.ChildNodes;
                            foreach (XmlNode xnf in xnl)
                            {
                                XmlElement xe = (XmlElement)xnf;
                                switch (xe.Name)
                                { 
                                    case "Strategy":
                                        pro.Addrname = xe.Attributes["path"].InnerText;
                                        pro.Classname = xe.Attributes["class"].InnerText;
                                        pro.form_Main = this;
                                        pro.assm = Assembly.LoadFrom( xe.Attributes["path"].InnerText);//用库类地址和文件名引用动态链接库
                                        pro.types = pro.assm.GetTypes();
                                        foreach (Type te in pro.types)
                                        {
                                            if (te.Name == pro.Classname)
                                            {
                                                pro.obj = pro.assm.CreateInstance(te.FullName, true);
                                                pro.fieldInfos = te.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                                                if (pro.fieldInfos != null)
                                                {
                                                    XmlNode parameters = xe.SelectSingleNode("Parameters");
                                                    for (int k = 0; k < pro.fieldInfos.LongLength; k++)
                                                    {

                                                        foreach (Attribute att in pro.fieldInfos[k].GetCustomAttributes(false))
                                                        {
                                                            if (att is ParameterAttribute)
                                                            {
                                                               // ParameterAttribute cc = att as ParameterAttribute;
                                                                XmlNodeList parameterlist = parameters.ChildNodes;
                                                                foreach (XmlNode parameter in parameterlist)
                                                                {
                                                                   
                                                                   // XmlElement a = (XmlElement)parameter;
                                                                    if (parameter.Attributes["name"].InnerText == pro.fieldInfos[k].Name)
                                                                    { 
                                                                        object ob = this.Transformation(parameter.Attributes["value"].InnerText, pro.fieldInfos[k].FieldType);
                                                                        pro.fieldInfos[k].SetValue(pro.obj,ob);
                                                                    }
                                                                }
                                                               
                                                            }
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                        break;
                                    case "Accounts":
                                       
                                        XmlNodeList tdaccounts = xe.SelectSingleNode("TdAccounts").ChildNodes;
                                        foreach (XmlNode tdaccount in tdaccounts)
                                        {
                                            bool iftdcz = false;

                                            foreach (Acc acc in this.accountList)
                                            {
                                                if (acc.brokerid == tdaccount.Attributes["broker"].InnerText)
                                                {
                                                    if (acc.invostor == tdaccount.Attributes["invostor"].InnerText)
                                                    {
                                                        if (acc.state == "运行中...")
                                                        {

                                                            pro.accountList.Add(acc);
                                                            iftdcz = true; ;
                                                        }
                                                    }
                                                }
                                            }
                                            if (!iftdcz)
                                            {
                                                MessageBox.Show("请先登陆交易账号：" +tdaccount.Attributes["brokername"].InnerText+ "  ;  "+ tdaccount.Attributes["broker"].InnerText + "  ;  " + tdaccount.Attributes["invostor"].InnerText);
                                                return;
                                            }
                                        }
                                        for(int x=0;x<pro.accountList.Count;x++)
                                        { 
                                             foreach (XmlNode tdaccount in tdaccounts)
                                             {
                                                 if (tdaccount.Name == "DefaulttdAccount" && pro.accountList[x].invostor == tdaccount.Attributes["invostor"].InnerText && pro.accountList[x].brokerid == tdaccount.Attributes["broker"].InnerText)
                                                 {
                                                     Acc dacc = pro.accountList[0];
                                                     pro.accountList[0] = pro.accountList[x];
                                                     pro.accountList[x] = dacc;
                                                 }
                                             }
                                        }
                                         #region MdAccounts
                                         XmlNodeList mdaccounts = xe.SelectSingleNode("MdAccounts").ChildNodes;
                                        foreach (XmlNode mdaccount in mdaccounts)
                                        {
                                            bool ifmdcz = false;

                                            foreach (Acc acc in this.mdaccountList)
                                            {
                                                if (acc.brokerid == mdaccount.Attributes["broker"].InnerText)
                                                {
                                                  
                                                    if (acc.state == "运行中...")
                                                    {

                                                        pro.mdaccountList.Add(acc);
                                                        ifmdcz = true; ;
                                                    }
                                                   
                                                }
                                            }
                                            if (!ifmdcz)
                                            {
                                                MessageBox.Show("请先登陆行情账号：" + mdaccount.Attributes["brokername"].InnerText+" ; " + mdaccount.Attributes["broker"].InnerText);
                                                return;
                                            }
                                        }
                                        for(int x=0;x<pro.mdaccountList.Count;x++)
                                        { 
                                             foreach (XmlNode mdaccount in mdaccounts)
                                             {
                                                 if (mdaccount.Name == "DefaultmdAccount"&& pro.mdaccountList[x].brokerid == mdaccount.Attributes["broker"].InnerText)
                                                 {
                                                     Acc dacc = pro.mdaccountList[0];
                                                     pro.mdaccountList[0] = pro.mdaccountList[x];
                                                     pro.mdaccountList[x] = dacc;
                                                 }
                                             }
                                        }
                                         #endregion MdAccounts
                                        break;
                                    case "Instruments":
                                         //pro.DriveInstrument=xe.SelectSingleNode("DriveInstrument").Attributes["id"].InnerText;
                                         //pro.DriveInstrument=xe.SelectSingleNode("DriveInstrument").Attributes["id"].InnerText;
                                        XmlNodeList inss = xe.ChildNodes;
                                        foreach (XmlNode instrument in inss)
                                         {
                                             if (instrument.Name == "DriveInstrument")
                                             { 
                                                pro.DriveInstrument=instrument.Attributes["id"].InnerText;
                                             }
                                             
                                             else
                                             {
                                                 foreach (CThostFtdcInstrumentField ist in this.Instruments)
                                                 {
                                                     if (ist.InstrumentID == instrument.Attributes["id"].InnerText)
                                                     {
                                                         pro.Instruments.Add(ist);
                                                     }
                                                 }
                                             }

                                         }
              
                                            for (int xx = 0; xx < pro.Instruments.Count; xx++)
                                            {
                                                foreach (XmlNode ins in inss)
                                                {
                                                    if (ins.Name == "DefaultInstrument" && this.Instruments[xx].InstrumentID == ins.Attributes["id"].InnerText && this.Instruments[xx].InstrumentName == ins.Attributes["name"].InnerText)
                                                    {
                                                        CThostFtdcInstrumentField ist = pro.Instruments[0];
                                                        pro.Instruments[0] = pro.Instruments[xx];
                                                        pro.Instruments[xx] = ist;

                                                    }
                                                }

                                            }
                                        break;
                                    default:
                                        break;

                                }
                                //Console.WriteLine(xe.GetAttribute("genre"));
                            }
                        }
                        #endregion 读取工程数据
                        #region 刷新工程显示
                        this.projectList.Add(pro);
                        this.listView3.Items.Clear();

                        for (int i = 0; i < this.projectList.Count; i++)
                        {
                            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(
                                   new string[] {
                                i.ToString(),
                                this.projectList[i].Projname,
                                this.projectList[i].Classname,
 
                                this.projectList[i].Addrname
                                }, -1);
                            this.listView3.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
                        }
                        for (int i = 0; i < this.projectList.Count; i++)
                        {
                            if (this.projectList[i].Projname == pro.Projname)
                            {
                                this.listView3.Items[i].Selected = true;
                            }
                        }
                        this.tabControl1.SelectedTab = this.tabPage3;
                        #endregion 刷新工程显示
                         #region 显示参数属性
                        this.button4.Enabled = true;
                        this.button5.Enabled = false;
                        this.button6.Enabled = true;
                        this.button7.Enabled = true;
                        this.button8.Enabled = true;
                        
                        #region 属性

                        this.treeView2.Show();
                        this.treeView2.CheckBoxes = true;
                        this.treeView2.Nodes[0].Checked = false;
                        this.treeView2.Nodes[1].Checked = false;
                        this.treeView2.Nodes[2].Checked = false;
                        this.treeView2.Nodes[0].Nodes.Clear();
                        this.treeView2.Nodes[1].Nodes.Clear();
                        this.treeView2.Nodes[2].Nodes.Clear();
                        this.treeView2.Controls.Clear();
                        for (int i = 0; i < this.accountList.Count; i++)
                        {
                            if (this.accountList[i].state == "运行中..." || this.accountList[i].state == "综合交易平台：重复的登录")
                            {
                                foreach(Acc acc in this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].accountList)
                                {
                                    if (acc.invostor == this.accountList[i].invostor && acc.brokerid == this.accountList[i].brokerid)
                                    {
                                        System.Windows.Forms.TreeNode treeNodex = new System.Windows.Forms.TreeNode(this.accountList[i].invostor);
                                        treeNodex.Checked = true;
                                        this.treeView2.Nodes[0].Nodes.Add(treeNodex);
                                        this.treeView2.Nodes[0].Checked = true;
                                    }
                                }
                                
                            }

                        }
                        for (int i = 0; i < this.mdaccountList.Count; i++)
                        {
                            if (this.mdaccountList[i].state == "运行中..." || this.mdaccountList[i].state == "综合交易平台：重复的登录")
                            {
                                foreach (Acc acc in pro.mdaccountList)
                                {
                                    if (acc.brokerid == this.mdaccountList[i].brokerid && acc.brokername == this.mdaccountList[i].brokername)
                                    {
                                        System.Windows.Forms.TreeNode treeNodex1 = new System.Windows.Forms.TreeNode(this.mdaccountList[i].brokername);
                                        treeNodex1.Checked = true;
                                        this.treeView2.Nodes[1].Nodes.Add(treeNodex1);
                                        this.treeView2.Nodes[1].Checked = true;
                                    }
                                }
                            }

                        }
                        for (int n = 0; n < this.treeView2.Nodes.Count; n++)
                        {
                            if (this.treeView2.Nodes[n].Text == "交易品种")
                            {
                                this.treeView2.Nodes[2].Nodes.Clear();
                                if (pro.DriveInstrument == pro.Instruments[0].InstrumentID)
                                    {
                                        System.Windows.Forms.TreeNode treeNodex = new System.Windows.Forms.TreeNode(pro.DriveInstrument);
                                        treeNodex.Checked = true;
                                        this.treeView2.Nodes[2].Nodes.Add(treeNodex);
                                        this.treeView2.Nodes[2].Checked = true;
                                    }
                                foreach (CThostFtdcInstrumentField ins in pro.Instruments)
                                {
                                    if (ins.InstrumentID != pro.DriveInstrument)
                                    {
                                        System.Windows.Forms.TreeNode treeNodex = new System.Windows.Forms.TreeNode(ins.InstrumentID);
                                        treeNodex.Checked = true;
                                        this.treeView2.Nodes[2].Nodes.Add(treeNodex);
                                        this.treeView2.Nodes[2].Checked = true;
                                    }
                                    
                                }

                            }
                            if (this.treeView2.Nodes[n].Text == "驱动品种")
                            {
                                this.treeView2.Nodes[3].Nodes.Clear();
                                foreach(CThostFtdcInstrumentField ins in pro.Instruments)
                                {
                                    if (ins.InstrumentID == pro.DriveInstrument)
                                    {
                                        System.Windows.Forms.TreeNode treeNodex = new System.Windows.Forms.TreeNode(ins.InstrumentID);
                                        treeNodex.Checked = true;
                                        this.treeView2.Nodes[3].Nodes.Add(treeNodex);
                                        this.treeView2.Nodes[3].Checked = true;
                                    }
                                }  
                            }
                        }

                        this.treeView2.ExpandAll();
                        #endregion 属性
                        #region 参数
                        //this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].assm = null;
                        //this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].types = null;
                        //this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].obj = null;
                        //this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].fieldInfos = null;
                        this.dataGridView1.Rows.Clear();
                        //this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].assm = Assembly.LoadFrom(this.listView3.SelectedItems[0].SubItems[5].Text);//用库类地址和文件名引用动态链接库
                        //this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].types = this.projectList[Convert.ToInt32(this.listView3.SelectedItems[0].SubItems[0].Text)].assm.GetTypes();
                        for (int j = 0; j < pro.types.Length; j++)
                        {
                            if (pro.types[j].Name == this.listView3.SelectedItems[0].SubItems[2].Text)
                            {
                                if (pro.obj == null)
                                {

                                   pro.obj = pro.assm.CreateInstance(pro.types[j].FullName, true);
                                }

                               pro.fieldInfos =pro.types[j].GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                                for (int k = 0; k <pro.fieldInfos.LongLength; k++)
                                {

                                    foreach (Attribute att in pro.fieldInfos[k].GetCustomAttributes(false))
                                    {
                                        if (att is ParameterAttribute)
                                        {
                                            ParameterAttribute cc = att as ParameterAttribute;
                                            string[] row = { pro.fieldInfos[k].Name, pro.fieldInfos[k].GetValue(pro.obj).ToString(), cc.Display };
                                            this.dataGridView1.Rows.Add(row);
                                        }
                                    }
                                }
                            }
                        }
                        this.treeView2.Enabled = false;
                        this.dataGridView1.Enabled = false;
                        #endregion 参数
                         #endregion 显示参数属性
                    }
                }
            }
        }
      
    }
}
