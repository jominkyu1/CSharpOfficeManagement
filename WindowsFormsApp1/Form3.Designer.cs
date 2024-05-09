namespace WindowsFormsApp1
{
    partial class Form3
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
            this.Label1 = new System.Windows.Forms.Label();
            this.comboCust = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listRules = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAgyNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listAgys = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRulesCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.txtSearchAgy = new System.Windows.Forms.TextBox();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.lblAgyCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 14);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "SA01";
            // 
            // comboCust
            // 
            this.comboCust.FormattingEnabled = true;
            this.comboCust.Location = new System.Drawing.Point(14, 59);
            this.comboCust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboCust.Name = "comboCust";
            this.comboCust.Size = new System.Drawing.Size(242, 22);
            this.comboCust.TabIndex = 3;
            this.comboCust.SelectedIndexChanged += new System.EventHandler(this.comboCust_SelectedIndexChanged);
            this.comboCust.DataSourceChanged += new System.EventHandler(this.comboCust_DataSourceChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "CustID";
            // 
            // listRules
            // 
            this.listRules.FormattingEnabled = true;
            this.listRules.ItemHeight = 14;
            this.listRules.Location = new System.Drawing.Point(272, 170);
            this.listRules.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listRules.Name = "listRules";
            this.listRules.Size = new System.Drawing.Size(591, 284);
            this.listRules.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.comboRole);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtPW);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblAgyNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(14, 170);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 285);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "PW";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 233);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(3, 139);
            this.txtPW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(148, 21);
            this.txtPW.TabIndex = 3;
            this.txtPW.Text = "1234";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(3, 88);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(148, 21);
            this.txtID.TabIndex = 2;
            // 
            // lblAgyNo
            // 
            this.lblAgyNo.AutoSize = true;
            this.lblAgyNo.Location = new System.Drawing.Point(55, 15);
            this.lblAgyNo.Name = "lblAgyNo";
            this.lblAgyNo.Size = new System.Drawing.Size(58, 14);
            this.lblAgyNo.TabIndex = 1;
            this.lblAgyNo.Text = "lblAgyNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "agy_no";
            // 
            // listAgys
            // 
            this.listAgys.FormattingEnabled = true;
            this.listAgys.Location = new System.Drawing.Point(12, 119);
            this.listAgys.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listAgys.Name = "listAgys";
            this.listAgys.Size = new System.Drawing.Size(244, 22);
            this.listAgys.TabIndex = 7;
            this.listAgys.SelectedIndexChanged += new System.EventHandler(this.listAgys_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "AgyID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "TOTAL";
            // 
            // lblRulesCount
            // 
            this.lblRulesCount.AutoSize = true;
            this.lblRulesCount.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRulesCount.Location = new System.Drawing.Point(321, 153);
            this.lblRulesCount.Name = "lblRulesCount";
            this.lblRulesCount.Size = new System.Drawing.Size(106, 13);
            this.lblRulesCount.TabIndex = 10;
            this.lblRulesCount.Text = "lblRulesCount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Role";
            // 
            // comboRole
            // 
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Location = new System.Drawing.Point(3, 196);
            this.comboRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(148, 22);
            this.comboRole.TabIndex = 8;
            // 
            // txtSearchAgy
            // 
            this.txtSearchAgy.Location = new System.Drawing.Point(272, 118);
            this.txtSearchAgy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchAgy.Name = "txtSearchAgy";
            this.txtSearchAgy.Size = new System.Drawing.Size(155, 21);
            this.txtSearchAgy.TabIndex = 11;
            this.txtSearchAgy.TextChanged += new System.EventHandler(this.txtSearchAgy_TextChanged);
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNotFound.ForeColor = System.Drawing.Color.Red;
            this.lblNotFound.Location = new System.Drawing.Point(339, 100);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(85, 12);
            this.lblNotFound.TabIndex = 12;
            this.lblNotFound.Text = "NOT FOUND";
            this.lblNotFound.Visible = false;
            // 
            // lblAgyCount
            // 
            this.lblAgyCount.AutoSize = true;
            this.lblAgyCount.Location = new System.Drawing.Point(245, 102);
            this.lblAgyCount.Name = "lblAgyCount";
            this.lblAgyCount.Size = new System.Drawing.Size(11, 14);
            this.lblAgyCount.TabIndex = 13;
            this.lblAgyCount.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 14);
            this.label9.TabIndex = 14;
            this.label9.Text = "Count";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 472);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAgyCount);
            this.Controls.Add(this.lblNotFound);
            this.Controls.Add(this.txtSearchAgy);
            this.Controls.Add(this.lblRulesCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listAgys);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listRules);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboCust);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listRules;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAgyNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox listAgys;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRulesCount;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchAgy;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.Label lblAgyCount;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox comboCust;
    }
}