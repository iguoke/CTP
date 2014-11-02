using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;

namespace Futures
{
    public partial class Form_Strategy : Form
    {
        public Form_Proj fp { set; get; }
        public List<System.Windows.Forms.ListViewItem> listViewItems = new List<ListViewItem>();
        public List<System.Windows.Forms.ListViewGroup> listViewGroups=new List<ListViewGroup>();
        private int m = 0,mm=0;

        public List<Project> projectList { get; set; }
        public Form_Strategy()
        {
            InitializeComponent();
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
                            listViewItems[m].Group = listViewGroups[listViewGroups.Count-1];
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
                project.Mode = "实盘";
                project.State = "准备";
                project.Addrname = this.listView1.SelectedItems[0].Group.Header;
                project.thread = new Thread(project.Run);
                this.projectList.Add(project);
            }
            this.fp.listView1.Items.Clear();

            for (int i = 0; i < this.projectList.Count; i++)
            {
                System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
                                i.ToString(),
                                this.projectList[i].Projname,
                                this.projectList[i].State,
                                this.projectList[i].Mode,
                                }, -1);
                this.fp.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
            }
            this.fp.projectList = this.projectList;
            
            this.fp.Show();
        }

        private void Form_Strategy_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }  
    }
}
