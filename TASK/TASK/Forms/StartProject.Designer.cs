namespace Task
{
    partial class StartProject
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1161, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDUSERToolStripMenuItem,
            this.loginDetailsToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // aDDUSERToolStripMenuItem
            // 
            this.aDDUSERToolStripMenuItem.Name = "aDDUSERToolStripMenuItem";
            this.aDDUSERToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aDDUSERToolStripMenuItem.Text = "Registration";
            this.aDDUSERToolStripMenuItem.Click += new System.EventHandler(this.aDDUSERToolStripMenuItem_Click);
            // 
            // loginDetailsToolStripMenuItem
            // 
            this.loginDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userLoginToolStripMenuItem,
            this.adminLoginToolStripMenuItem,
            this.vendorLoginToolStripMenuItem});
            this.loginDetailsToolStripMenuItem.Name = "loginDetailsToolStripMenuItem";
            this.loginDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginDetailsToolStripMenuItem.Text = "Login";
            this.loginDetailsToolStripMenuItem.Click += new System.EventHandler(this.loginDetailsToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Logout";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // userLoginToolStripMenuItem
            // 
            this.userLoginToolStripMenuItem.Name = "userLoginToolStripMenuItem";
            this.userLoginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userLoginToolStripMenuItem.Text = "UserLogin";
            this.userLoginToolStripMenuItem.Click += new System.EventHandler(this.userLoginToolStripMenuItem_Click);
            // 
            // adminLoginToolStripMenuItem
            // 
            this.adminLoginToolStripMenuItem.Name = "adminLoginToolStripMenuItem";
            this.adminLoginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adminLoginToolStripMenuItem.Text = "AdminLogin";
            this.adminLoginToolStripMenuItem.Click += new System.EventHandler(this.adminLoginToolStripMenuItem_Click);
            // 
            // vendorLoginToolStripMenuItem
            // 
            this.vendorLoginToolStripMenuItem.Name = "vendorLoginToolStripMenuItem";
            this.vendorLoginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendorLoginToolStripMenuItem.Text = "VendorLogin";
            this.vendorLoginToolStripMenuItem.Click += new System.EventHandler(this.vendorLoginToolStripMenuItem_Click);
            // 
            // StartProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1161, 564);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StartProject";
            this.Text = "StartProject";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDUSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorLoginToolStripMenuItem;
    }
}