namespace Futures
{
    partial class Form_Account
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, -1);
            this.listView1.MaximumSize = new System.Drawing.Size(683, 168);
            this.listView1.MinimumSize = new System.Drawing.Size(683, 168);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(683, 168);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "序号";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "选择";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "期货经纪商";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "账户";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 5;
            this.columnHeader4.Text = "状态";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "自动交易";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "登出";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 258);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 296);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(710, 296);
            this.Name = "Form_Account";
            this.Text = "账户关联";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Account_FormClosing);
            this.Load += new System.EventHandler(this.Form_Account_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}