using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Futures
{

    public partial class Form_ProjName : Form
    {

        public Form_Main f_Form { get; set; }
        public Form_ProjName(Form_Main f)
        {
            InitializeComponent();
            this.f_Form = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                ListView.SelectedIndexCollection c = this.f_Form.listView1.SelectedIndices;
                bool ifExist = false;

                if (this.f_Form.listView1.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < this.f_Form.projectList.Count; i++)
                    {
                        if (this.f_Form.projectList[i].Projname == this.textBox1.Text)
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
                        project.Classname = this.f_Form.listView1.SelectedItems[0].SubItems[1].Text;
                        project.Projname = this.textBox1.Text;
                        project.Addrname = this.f_Form.listView1.SelectedItems[0].Group.Name;
                        project.Addrname = this.f_Form.listView1.SelectedItems[0].Group.Header;
                        project.thread = new Thread(project.Run);
                        project.form_Main = this.f_Form;
                        this.f_Form.projectList.Add(project);

                    }
                    this.f_Form.listView3.Items.Clear();

                    for (int i = 0; i < this.f_Form.projectList.Count; i++)
                    {
                        System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(
                               new string[] {
                                i.ToString(),
                                this.f_Form.projectList[i].Projname,
                                this.f_Form.projectList[i].Classname,
                                this.f_Form.projectList[i].Addrname
                                }, -1);
                        this.f_Form.listView3.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
                    }
                    this.f_Form.tabControl1.SelectedTab = this.f_Form.tabPage3;
                    this.Close();
                }
                else
                    return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
