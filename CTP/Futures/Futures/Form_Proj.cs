using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Futures
{
    public partial class Form_Proj : Form
    {
        public List<Acc> accountList { get; set; }
        public List<Project> projectList { get; set; }
        public Form_Configuration fc=new Form_Configuration();
        public Form_Proj()
        {
            InitializeComponent();
        }

        private void Form_Proj_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.listView1.SelectedItems.Count==1)      
            {  
                if (e.Button == MouseButtons.Right)
                {
                    this.contextMenuStrip1.Show();
                    for(int i=0;i<this.projectList.Count;i++)
                    {
                        if(this.projectList[i].Projname==this.listView1.SelectedItems[0].SubItems[1].Text)
                            this.fc.project = this.projectList[i];
                    }
                    
                }     
            } 
        }

        private void 属性ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.fc.Show();
            for (int i = 0; i < this.accountList.Count; i++)
            {
                this.fc.comboBox1.Items.Add(this.accountList[i].invostor);
            }
        }

        private void Form_Proj_Load(object sender, EventArgs e)
        {
            this.fc.MdiParent = this.MdiParent;
        }

    }
}
