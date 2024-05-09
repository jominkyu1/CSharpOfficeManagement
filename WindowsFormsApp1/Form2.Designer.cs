namespace WindowsFormsApp1
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConnect = new System.Windows.Forms.Button();
            this.comboCust = new System.Windows.Forms.ComboBox();
            this.listLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo404 = new System.Windows.Forms.ComboBox();
            this.combo405 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCount405 = new System.Windows.Forms.Label();
            this.lblCount404 = new System.Windows.Forms.Label();
            this.lblCount401 = new System.Windows.Forms.Label();
            this.combo404_noItem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCount404_NoAcc = new System.Windows.Forms.Label();
            this.combo405_noItem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCount405_NoAcc = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelRules = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.listRules = new System.Windows.Forms.ListBox();
            this.lblAgyNo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelRules.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(430, 284);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnConnect.Location = new System.Drawing.Point(12, 14);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(86, 27);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // comboCust
            // 
            this.comboCust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboCust.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCust.FormattingEnabled = true;
            this.comboCust.Location = new System.Drawing.Point(12, 104);
            this.comboCust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboCust.Name = "comboCust";
            this.comboCust.Size = new System.Drawing.Size(176, 22);
            this.comboCust.TabIndex = 8;
            this.comboCust.SelectedIndexChanged += new System.EventHandler(this.comboCust_SelectedIndexChanged);
            this.comboCust.DropDownClosed += new System.EventHandler(this.comboCust_DropDownClosed);
            this.comboCust.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboCust_KeyDown);
            // 
            // listLog
            // 
            this.listLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 14;
            this.listLog.Location = new System.Drawing.Point(709, 13);
            this.listLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(353, 312);
            this.listLog.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "거래처";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "화물";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "행낭";
            // 
            // combo404
            // 
            this.combo404.FormattingEnabled = true;
            this.combo404.Location = new System.Drawing.Point(14, 183);
            this.combo404.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo404.Name = "combo404";
            this.combo404.Size = new System.Drawing.Size(174, 22);
            this.combo404.TabIndex = 13;
            this.combo404.SelectedIndexChanged += new System.EventHandler(this.combo404_SelectedIndexChanged_1);
            this.combo404.DropDownClosed += new System.EventHandler(this.combo404_DropDownClosed);
            // 
            // combo405
            // 
            this.combo405.FormattingEnabled = true;
            this.combo405.Location = new System.Drawing.Point(12, 270);
            this.combo405.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo405.Name = "combo405";
            this.combo405.Size = new System.Drawing.Size(176, 22);
            this.combo405.TabIndex = 14;
            this.combo405.DropDownClosed += new System.EventHandler(this.combo405_DropDownClosed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total";
            // 
            // lblCount405
            // 
            this.lblCount405.AutoSize = true;
            this.lblCount405.Location = new System.Drawing.Point(160, 252);
            this.lblCount405.Name = "lblCount405";
            this.lblCount405.Size = new System.Drawing.Size(14, 14);
            this.lblCount405.TabIndex = 18;
            this.lblCount405.Text = "0";
            // 
            // lblCount404
            // 
            this.lblCount404.AutoSize = true;
            this.lblCount404.Location = new System.Drawing.Point(159, 166);
            this.lblCount404.Name = "lblCount404";
            this.lblCount404.Size = new System.Drawing.Size(14, 14);
            this.lblCount404.TabIndex = 19;
            this.lblCount404.Text = "0";
            // 
            // lblCount401
            // 
            this.lblCount401.AutoSize = true;
            this.lblCount401.Location = new System.Drawing.Point(160, 86);
            this.lblCount401.Name = "lblCount401";
            this.lblCount401.Size = new System.Drawing.Size(14, 14);
            this.lblCount401.TabIndex = 20;
            this.lblCount401.Text = "0";
            // 
            // combo404_noItem
            // 
            this.combo404_noItem.FormattingEnabled = true;
            this.combo404_noItem.Location = new System.Drawing.Point(233, 183);
            this.combo404_noItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo404_noItem.Name = "combo404_noItem";
            this.combo404_noItem.Size = new System.Drawing.Size(211, 22);
            this.combo404_noItem.TabIndex = 22;
            this.combo404_noItem.SelectedIndexChanged += new System.EventHandler(this.combo404_noItem_SelectedIndexChanged);
            this.combo404_noItem.DropDownClosed += new System.EventHandler(this.combo404_noItem_DropDownClosed);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 14);
            this.label7.TabIndex = 23;
            this.label7.Text = "화물_계정없음";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 24;
            this.label8.Text = "Total";
            // 
            // lblCount404_NoAcc
            // 
            this.lblCount404_NoAcc.AutoSize = true;
            this.lblCount404_NoAcc.Location = new System.Drawing.Point(381, 166);
            this.lblCount404_NoAcc.Name = "lblCount404_NoAcc";
            this.lblCount404_NoAcc.Size = new System.Drawing.Size(14, 14);
            this.lblCount404_NoAcc.TabIndex = 25;
            this.lblCount404_NoAcc.Text = "0";
            // 
            // combo405_noItem
            // 
            this.combo405_noItem.FormattingEnabled = true;
            this.combo405_noItem.Location = new System.Drawing.Point(233, 270);
            this.combo405_noItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo405_noItem.Name = "combo405_noItem";
            this.combo405_noItem.Size = new System.Drawing.Size(211, 22);
            this.combo405_noItem.TabIndex = 26;
            this.combo405_noItem.SelectedIndexChanged += new System.EventHandler(this.combo405_noItem_SelectedIndexChanged);
            this.combo405_noItem.DropDownClosed += new System.EventHandler(this.combo405_noItem_DropDownClosed);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 14);
            this.label9.TabIndex = 27;
            this.label9.Text = "행낭_계정없음";
            // 
            // lblCount405_NoAcc
            // 
            this.lblCount405_NoAcc.AutoSize = true;
            this.lblCount405_NoAcc.Location = new System.Drawing.Point(381, 252);
            this.lblCount405_NoAcc.Name = "lblCount405_NoAcc";
            this.lblCount405_NoAcc.Size = new System.Drawing.Size(14, 14);
            this.lblCount405_NoAcc.TabIndex = 29;
            this.lblCount405_NoAcc.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(346, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 14);
            this.label11.TabIndex = 28;
            this.label11.Text = "Total";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panelRules
            // 
            this.panelRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRules.Controls.Add(this.label10);
            this.panelRules.Controls.Add(this.listRules);
            this.panelRules.Location = new System.Drawing.Point(452, 382);
            this.panelRules.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelRules.Name = "panelRules";
            this.panelRules.Size = new System.Drawing.Size(610, 239);
            this.panelRules.TabIndex = 30;
            this.panelRules.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 14);
            this.label10.TabIndex = 1;
            this.label10.Text = "생성규칙 최근20";
            // 
            // listRules
            // 
            this.listRules.FormattingEnabled = true;
            this.listRules.ItemHeight = 14;
            this.listRules.Location = new System.Drawing.Point(6, 32);
            this.listRules.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listRules.Name = "listRules";
            this.listRules.Size = new System.Drawing.Size(604, 200);
            this.listRules.TabIndex = 0;
            // 
            // lblAgyNo
            // 
            this.lblAgyNo.AutoSize = true;
            this.lblAgyNo.Location = new System.Drawing.Point(346, 13);
            this.lblAgyNo.Name = "lblAgyNo";
            this.lblAgyNo.Size = new System.Drawing.Size(58, 14);
            this.lblAgyNo.TabIndex = 31;
            this.lblAgyNo.Text = "lblAgyNo";
            this.lblAgyNo.Click += new System.EventHandler(this.lblAgyNo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 14);
            this.label12.TabIndex = 32;
            this.label12.Text = "agy_no";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 14);
            this.label13.TabIndex = 33;
            this.label13.Text = "SA02 [WEB]";
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.Location = new System.Drawing.Point(233, 103);
            this.txtSearchCust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.Size = new System.Drawing.Size(211, 21);
            this.txtSearchCust.TabIndex = 35;
            this.txtSearchCust.TextChanged += new System.EventHandler(this.txtSearchCust_TextChanged);
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNotFound.ForeColor = System.Drawing.Color.Red;
            this.lblNotFound.Location = new System.Drawing.Point(349, 82);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(97, 15);
            this.lblNotFound.TabIndex = 37;
            this.lblNotFound.Text = "NO RESULT";
            this.lblNotFound.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lblAgyNo);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(14, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 326);
            this.panel1.TabIndex = 38;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 629);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNotFound);
            this.Controls.Add(this.txtSearchCust);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.panelRules);
            this.Controls.Add(this.lblCount405_NoAcc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo405_noItem);
            this.Controls.Add(this.lblCount404_NoAcc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combo404_noItem);
            this.Controls.Add(this.lblCount401);
            this.Controls.Add(this.lblCount404);
            this.Controls.Add(this.lblCount405);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo405);
            this.Controls.Add(this.combo404);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCust);
            this.Controls.Add(this.btnConnect);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelRules.ResumeLayout(false);
            this.panelRules.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo404;
        private System.Windows.Forms.ComboBox combo405;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCount405;
        private System.Windows.Forms.Label lblCount404;
        private System.Windows.Forms.Label lblCount401;
        private System.Windows.Forms.ComboBox combo404_noItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCount404_NoAcc;
        private System.Windows.Forms.ComboBox combo405_noItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCount405_NoAcc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelRules;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listRules;
        private System.Windows.Forms.Label lblAgyNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.Label lblNotFound;
        internal System.Windows.Forms.ComboBox comboCust;
        private System.Windows.Forms.Panel panel1;
    }
}