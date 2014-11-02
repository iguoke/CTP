namespace Futures
{
    partial class Form_Control
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("账户关联");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("账户管理", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("策略列表");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("工程列表");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("策略管理", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CausesValidation = false;
            this.treeView1.Location = new System.Drawing.Point(0, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "账户关联";
            treeNode2.Name = "节点0";
            treeNode2.Text = "账户管理";
            treeNode3.Name = "节点1";
            treeNode3.Text = "策略列表";
            treeNode4.Name = "节点2";
            treeNode4.Text = "工程列表";
            treeNode5.Name = "节点2";
            treeNode5.Text = "策略管理";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(116, 142);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(116, 154);
            this.ControlBox = false;
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Control";
            this.ShowInTaskbar = false;
            this.Text = "Form_Control";
            this.Load += new System.EventHandler(this.Form_Control_Load);
            this.Move += new System.EventHandler(this.Form_Control_Move);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}