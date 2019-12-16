namespace Task
{
    partial class vendors
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
            this.Updatebtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.prod_com = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPP = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExtBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(387, 364);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(117, 23);
            this.Updatebtn.TabIndex = 50;
            this.Updatebtn.Text = "UPDATE";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(618, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(542, 636);
            this.dataGridView2.TabIndex = 49;
            this.dataGridView2.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(57, 364);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(134, 23);
            this.btnShow.TabIndex = 48;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(233, 364);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(117, 23);
            this.btnInsert.TabIndex = 47;
            this.btnInsert.Text = "SUBMIT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(285, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(54, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Product Release Date";
            // 
            // prod_com
            // 
            this.prod_com.AutoCompleteCustomSource.AddRange(new string[] {
            "Telecommunications Services",
            "Cloud computing services(IaaS,SaaS,PaaS)",
            "ISV(AWS)"});
            this.prod_com.FormattingEnabled = true;
            this.prod_com.Items.AddRange(new object[] {
            "Telecommunications Services",
            "Cloud computing services(IaaS,SaaS,PaaS)",
            "ISV(AWS)"});
            this.prod_com.Location = new System.Drawing.Point(285, 150);
            this.prod_com.Name = "prod_com";
            this.prod_com.Size = new System.Drawing.Size(219, 21);
            this.prod_com.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(54, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Product Type";
            // 
            // txtPP
            // 
            this.txtPP.Location = new System.Drawing.Point(285, 286);
            this.txtPP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPP.Name = "txtPP";
            this.txtPP.Size = new System.Drawing.Size(219, 20);
            this.txtPP.TabIndex = 42;
            this.txtPP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPP_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(285, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 20);
            this.txtName.TabIndex = 41;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(54, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Product Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(54, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Product Name";
            // 
            // ExtBtn
            // 
            this.ExtBtn.Location = new System.Drawing.Point(1, -3);
            this.ExtBtn.Name = "ExtBtn";
            this.ExtBtn.Size = new System.Drawing.Size(45, 23);
            this.ExtBtn.TabIndex = 51;
            this.ExtBtn.Text = "EXIT";
            this.ExtBtn.UseVisualStyleBackColor = true;
            this.ExtBtn.Click += new System.EventHandler(this.ExtBtn_Click);
            // 
            // vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1172, 649);
            this.Controls.Add(this.ExtBtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prod_com);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPP);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "vendors";
            this.Text = "vendors";
            this.Load += new System.EventHandler(this.vendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox prod_com;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPP;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExtBtn;
    }
}