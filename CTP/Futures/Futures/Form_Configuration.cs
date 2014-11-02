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
    public partial class Form_Configuration : Form
    {
        public string name;
        private Project pri;
        public Project project
        {
            get { return this.pri; }
            set { this.pri = value; }
        }
        public Form_Configuration()
        { 
            this.name = "工程配置：";
            InitializeComponent();
        }

        private void Form_Configuration_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void Form_Configuration_Load(object sender, EventArgs e)
        {
            this.Text = this.name;
            this.treeView1.ExpandAll();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode != null)
            {
                if (this.textBox1.Text == "")
                {
                    MessageBox.Show("添加合约为空");
                    return;
                }
                System.Windows.Forms.TreeNode treeNodex = new System.Windows.Forms.TreeNode(this.textBox1.Text);
                bool ifexit = false;
                if (this.treeView1.SelectedNode.Text == "期货品种")
                    {
                        for (int i = 0; i < this.treeView1.Nodes[0].Nodes.Count; i++)
                        {
                            if (this.treeView1.Nodes[0].Nodes[i].Text == this.textBox1.Text)
                            {
                                ifexit = true;
                            }
                        }
                        if (this.treeView1.Nodes[1].Nodes[0].Text == this.textBox1.Text)
                        {
                            ifexit = true;
                        }
                        if (ifexit == true)
                        {
                            MessageBox.Show("合约已添加");
                        }
                        else
                        {
                            this.treeView1.Nodes[0].Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNodex });
                        }
                    }
                   else if (this.treeView1.SelectedNode.Text == "驱动品种")
                    {
                        this.treeView1.Nodes[1].Nodes.Remove(this.treeView1.Nodes[1].Nodes[0]);
                        this.treeView1.Nodes[1].Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNodex });
                    }
            }
            else
            {
                MessageBox.Show("请选择添加的位置");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode == null || this.treeView1.SelectedNode.Text == "期货品种" || this.treeView1.SelectedNode.Text == "驱动品种")
            {
                MessageBox.Show("请选择要移除的合约");
                return;
            }
            this.treeView1.Nodes[0].Nodes.Remove(this.treeView1.SelectedNode);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.pri.Tdapi=
        }
    }
}
