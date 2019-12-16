namespace Task
{
    partial class User
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.prod_com1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPP1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Showbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(643, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(456, 390);
            this.dataGridView2.TabIndex = 48;
            this.dataGridView2.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(394, 406);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(134, 52);
            this.btnShow.TabIndex = 47;
            this.btnShow.Text = "Show Product Pictures";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(239, 406);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(117, 52);
            this.btnInsert.TabIndex = 46;
            this.btnInsert.Text = "SUBMIT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(305, 201);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(223, 20);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(78, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Product Release Date";
            // 
            // prod_com1
            // 
            this.prod_com1.AutoCompleteCustomSource.AddRange(new string[] {
            "Telecommunications Services",
            "Cloud computing services(IaaS,SaaS,PaaS)",
            "ISV(AWS)"});
            this.prod_com1.FormattingEnabled = true;
            this.prod_com1.Items.AddRange(new object[] {
            "Telecommunications Services",
            "Cloud computing services(IaaS,SaaS,PaaS)",
            "ISV(AWS)"});
            this.prod_com1.Location = new System.Drawing.Point(305, 109);
            this.prod_com1.Name = "prod_com1";
            this.prod_com1.Size = new System.Drawing.Size(231, 21);
            this.prod_com1.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(78, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Product_Type";
            // 
            // txtPP1
            // 
            this.txtPP1.Location = new System.Drawing.Point(305, 274);
            this.txtPP1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPP1.Name = "txtPP1";
            this.txtPP1.Size = new System.Drawing.Size(223, 20);
            this.txtPP1.TabIndex = 41;
            this.txtPP1.TextChanged += new System.EventHandler(this.txtPP1_TextChanged);
            this.txtPP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPP1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(78, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Product Price";
            // 
            // Showbtn
            // 
            this.Showbtn.Location = new System.Drawing.Point(81, 406);
            this.Showbtn.Name = "Showbtn";
            this.Showbtn.Size = new System.Drawing.Size(117, 52);
            this.Showbtn.TabIndex = 49;
            this.Showbtn.Text = "SHOW";
            this.Showbtn.UseVisualStyleBackColor = true;
            this.Showbtn.Click += new System.EventHandler(this.Showbtn_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1153, 655);
            this.Controls.Add(this.Showbtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prod_com1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPP1);
            this.Controls.Add(this.label2);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox prod_com1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Showbtn;
    }
}