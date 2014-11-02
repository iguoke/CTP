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
namespace Futures
{
     
    public partial class Form_Control : Form
    {
        
        public Form_Account fa;
        public Form_Proj fp=new Form_Proj();
        public List<Acc> accountList = new List<Acc>();
        public List<Project> projectList = new List<Project>();
        public Form_Strategy fs;
        public XmlReader xml;
        public Form_Control()
        {
            
            InitializeComponent();
        }

        private void Form_Control_Move(object sender, EventArgs e)
        {
            if (this.Left < 0)
            {
                this.Left = 0;
            }
            if (this.Top < 0)
            {
                this.Top = 0;
            }
            if (this.Left > Form_Main.MaxWidth - this.Width - 10)
            {
                this.Left = Form_Main.MaxWidth - this.Width - 10;
            }
            if (this.Top > Form_Main.MaxHeight - this.Width - 60)
            {
                this.Top = Form_Main.MaxHeight - this.Width -60;
            }


        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (this.treeView1.SelectedNode.Text)
            { 
                case "策略列表":
                    if (fs == null)
                    {
                        fs = new Form_Strategy();
                        fs.MdiParent = this.MdiParent;
                        fs.fp = this.fp;
                        fs.Show();
                        fs.Focus();
                        fs.projectList = this.projectList;
                    }
                    else
                    {
                        fs.Show();
                        fs.Focus();
                        fs.projectList = this.projectList;
                    }
                    break;
                case "工程列表":
                    if (fp == null)
                    {
                        //fp = new Form_Proj();
                        fp.MdiParent = this.MdiParent;
                        fp.Focus();
                        fp.Show();
                        fp.projectList = this.projectList;
                    }
                    else
                    {
                        this.fp.listView1.Items.Clear();
                        if (fs != null)
                        {
                            for (int i = 0; i < this.fs.projectList.Count; i++)
                            {
                                System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
                                    i.ToString(),
                                    this.fs.projectList[i].Projname,
                                    this.fs.projectList[i].State,
                                    this.fs.projectList[i].Mode,
                                    }, -1);
                                this.fp.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
                            }
                        }
                        fp.projectList = this.projectList;
                        fp.accountList = this.accountList;
                        fp.Show();
                        fp.Focus();
                    }
                //MessageBox.Show(this.treeView1.SelectedNode.Text);
                    break;
                case "账户关联":
                    if (fa == null)
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load("TradeAccount.xml");
                        Acc acc;
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
                                        
                                        string brokerid = xe.GetAttribute("BrokerID");
                                        string brokername = xe.GetAttribute("BrokerName");
                                        string tdserver = "";
                                        string mdserver = "";
                                        foreach (XmlNode node in node0.ChildNodes)
                                        {
                                            
                                            #region Server
                                            if (node.Name == "Server")
                                            {
                                                foreach (XmlNode node1 in node.ChildNodes)
                                                {
                                                    if (node1.Name == "Trade")
                                                    {
                                                        foreach (XmlNode node2 in node1.ChildNodes)
                                                        {
                                                            tdserver = node2.InnerText;
                                                        }
                                                    }
                                                    if (node1.Name == "MarketData")
                                                    {
                                                        foreach (XmlNode node3 in node1.ChildNodes)
                                                        {
                                                            mdserver = node3.InnerText;
                                                        }
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
                                                        string invostor="";
                                                        string pwssword="";
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
                                                        TDAPI tdapi = new TDAPI(invostor, pwssword, brokerid, "tcp://" + tdserver);
                                                        acc = new Acc();
                                                        acc.tdapi = tdapi;
                                                        acc.pwssword = pwssword;
                                                        acc.invostor = invostor;
                                                        acc.brokerid = brokerid;
                                                        acc.brokername = brokername;
                                                        acc.tdserver = tdserver;
                                                        acc.mdserver = mdserver;
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
                        fa = new Form_Account();
                        fa.MdiParent = this.MdiParent;
                       
                        fa.Show();
                        for (int i = 0; i < this.accountList.Count; i++)
                        {
                            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
                                   i.ToString(),
                                    "",
                                    this.accountList[i].brokername,
                                    this.accountList[i].invostor,
                                    this.accountList[i].state,
                                    this.accountList[i].isAuto.ToString()
                                    }, -1);
                            this.fa.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
                            System.Windows.Forms.CheckBox checkBox1 = new CheckBox();

                            checkBox1.Size = new Size(this.fa.listView1.Items[i].SubItems[1].Bounds.Width,
                            this.fa.listView1.Items[i].SubItems[1].Bounds.Height);
                            checkBox1.Visible = true;
                            checkBox1.Name = "账户" + i.ToString();
                            checkBox1.Location = new Point(this.fa.listView1.Items[i].SubItems[1].Bounds.Left,
                                 this.fa.listView1.Items[i].SubItems[1].Bounds.Top);

                            this.fa.listView1.Controls.Add(checkBox1);
                        }
                        //this.accountList[0].tdapi.OnFrontConnected += new TDAPI.FrontConnected(delegate()
                        //{
                        //    this.Invoke((MethodInvoker)delegate()
                        //    {
                        //        MessageBox.Show("连接前置成功");

                        //    });
                        //});
                        //this.accountList[0].tdapi.Connect();
                        fa.accountList = this.accountList;
                    }
                    else
                    {
                        fa.Show();
                    }
                        break;
                default: 
                    break;
            }
        }

        private void Form_Control_Load(object sender, EventArgs e)
        {
            this.fp.MdiParent = this.MdiParent;
            this.treeView1.ExpandAll();
        }
    }
}
