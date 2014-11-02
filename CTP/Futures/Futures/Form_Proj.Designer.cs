namespace Futures
{
    partial class Form_Proj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(542, 262);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名称";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "状态";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "模式";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.停止ToolStripMenuItem,
            this.暂停ToolStripMenuItem,
            this.属性ToolStripMenuItem,
            this.参数ToolStripMenuItem,
            this.属性ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 114);
            // 
            // 停止ToolStripMenuItem
            // 
            this.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            this.停止ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.停止ToolStripMenuItem.Text = "停止";
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.暂停ToolStripMenuItem.Text = "暂停";
            // 
            // 属性ToolStripMenuItem
            // 
            this.属性ToolStripMenuItem.Name = "属性ToolStripMenuItem";
            this.属性ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.属性ToolStripMenuItem.Text = "删除";
            // 
            // 参数ToolStripMenuItem
            // 
            this.参数ToolStripMenuItem.Name = "参数ToolStripMenuItem";
            this.参数ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.参数ToolStripMenuItem.Text = "参数";
            // 
            // 属性ToolStripMenuItem1
            // 
            this.属性ToolStripMenuItem1.Name = "属性ToolStripMenuItem1";
            this.属性ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.属性ToolStripMenuItem1.Text = "属性";
            this.属性ToolStripMenuItem1.Click += new System.EventHandler(this.属性ToolStripMenuItem1_Click);
            // 
            // Form_Proj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 262);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Proj";
            this.Text = "工程列表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Proj_FormClosing);
            this.Load += new System.EventHandler(this.Form_Proj_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public  System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 属性ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 属性ToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem 参数ToolStripMenuItem;
        public System.Windows.Forms.ColumnHeader columnHeader4;
    }
}