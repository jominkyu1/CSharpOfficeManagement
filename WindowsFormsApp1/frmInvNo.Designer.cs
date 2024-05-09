namespace WindowsFormsApp1
{
    partial class frmInvNo
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
            this.txtInvNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDlvBra = new System.Windows.Forms.Label();
            this.lblGAddr = new System.Windows.Forms.Label();
            this.lblGPlaId = new System.Windows.Forms.Label();
            this.lblGCust = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPicBra = new System.Windows.Forms.Label();
            this.lblSAddr = new System.Windows.Forms.Label();
            this.lblSPlaId = new System.Windows.Forms.Label();
            this.lblSCust = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDmdDate = new System.Windows.Forms.Label();
            this.lblPicDate = new System.Windows.Forms.Label();
            this.lblDlyWntDate = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInvNo
            // 
            this.txtInvNo.Location = new System.Drawing.Point(6, 23);
            this.txtInvNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.Size = new System.Drawing.Size(355, 21);
            this.txtInvNo.TabIndex = 0;
            this.txtInvNo.Text = "txtInvNo";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(203, 55);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(158, 24);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInvNo);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(367, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "운송장번호";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.lblDlvBra);
            this.panel1.Controls.Add(this.lblGAddr);
            this.panel1.Controls.Add(this.lblGPlaId);
            this.panel1.Controls.Add(this.lblGCust);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 120);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 177);
            this.panel1.TabIndex = 3;
            // 
            // lblDlvBra
            // 
            this.lblDlvBra.AutoSize = true;
            this.lblDlvBra.Location = new System.Drawing.Point(95, 149);
            this.lblDlvBra.Name = "lblDlvBra";
            this.lblDlvBra.Size = new System.Drawing.Size(56, 14);
            this.lblDlvBra.TabIndex = 7;
            this.lblDlvBra.Text = "lblDlvBra";
            // 
            // lblGAddr
            // 
            this.lblGAddr.Location = new System.Drawing.Point(95, 102);
            this.lblGAddr.Name = "lblGAddr";
            this.lblGAddr.Size = new System.Drawing.Size(234, 37);
            this.lblGAddr.TabIndex = 6;
            this.lblGAddr.Text = "lblGAddr";
            // 
            // lblGPlaId
            // 
            this.lblGPlaId.AutoSize = true;
            this.lblGPlaId.Location = new System.Drawing.Point(95, 65);
            this.lblGPlaId.Name = "lblGPlaId";
            this.lblGPlaId.Size = new System.Drawing.Size(57, 14);
            this.lblGPlaId.TabIndex = 5;
            this.lblGPlaId.Text = "lblGPlaId";
            // 
            // lblGCust
            // 
            this.lblGCust.AutoSize = true;
            this.lblGCust.Location = new System.Drawing.Point(95, 23);
            this.lblGCust.Name = "lblGCust";
            this.lblGCust.Size = new System.Drawing.Size(54, 14);
            this.lblGCust.TabIndex = 4;
            this.lblGCust.Text = "lblGCust";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "수신지점";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "배송영업소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "청구부서";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "수신처";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.lblPicBra);
            this.panel2.Controls.Add(this.lblSAddr);
            this.panel2.Controls.Add(this.lblSPlaId);
            this.panel2.Controls.Add(this.lblSCust);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(588, 120);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 177);
            this.panel2.TabIndex = 4;
            // 
            // lblPicBra
            // 
            this.lblPicBra.AutoSize = true;
            this.lblPicBra.Location = new System.Drawing.Point(101, 149);
            this.lblPicBra.Name = "lblPicBra";
            this.lblPicBra.Size = new System.Drawing.Size(54, 14);
            this.lblPicBra.TabIndex = 8;
            this.lblPicBra.Text = "lblPicBra";
            // 
            // lblSAddr
            // 
            this.lblSAddr.Location = new System.Drawing.Point(101, 102);
            this.lblSAddr.Name = "lblSAddr";
            this.lblSAddr.Size = new System.Drawing.Size(226, 37);
            this.lblSAddr.TabIndex = 7;
            this.lblSAddr.Text = "lblSAddr";
            // 
            // lblSPlaId
            // 
            this.lblSPlaId.AutoSize = true;
            this.lblSPlaId.Location = new System.Drawing.Point(101, 65);
            this.lblSPlaId.Name = "lblSPlaId";
            this.lblSPlaId.Size = new System.Drawing.Size(54, 14);
            this.lblSPlaId.TabIndex = 6;
            this.lblSPlaId.Text = "lblSPlaId";
            // 
            // lblSCust
            // 
            this.lblSCust.AutoSize = true;
            this.lblSCust.Location = new System.Drawing.Point(101, 23);
            this.lblSCust.Name = "lblSCust";
            this.lblSCust.Size = new System.Drawing.Size(51, 14);
            this.lblSCust.TabIndex = 5;
            this.lblSCust.Text = "lblSCust";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 3;
            this.label8.Text = "발신지점";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "집하영업소";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "청구부서";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "발신처";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkDelete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 304);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(908, 251);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chkDelete
            // 
            this.chkDelete.HeaderText = "DELETE";
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Width = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 14);
            this.label9.TabIndex = 6;
            this.label9.Text = "접수일자";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 14);
            this.label10.TabIndex = 7;
            this.label10.Text = "집하일자";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(400, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 14);
            this.label11.TabIndex = 8;
            this.label11.Text = "배송예정";
            // 
            // lblDmdDate
            // 
            this.lblDmdDate.AutoSize = true;
            this.lblDmdDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblDmdDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDmdDate.Location = new System.Drawing.Point(474, 13);
            this.lblDmdDate.Name = "lblDmdDate";
            this.lblDmdDate.Size = new System.Drawing.Size(74, 14);
            this.lblDmdDate.TabIndex = 9;
            this.lblDmdDate.Text = "lblDmdDate";
            // 
            // lblPicDate
            // 
            this.lblPicDate.AutoSize = true;
            this.lblPicDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPicDate.Location = new System.Drawing.Point(474, 43);
            this.lblPicDate.Name = "lblPicDate";
            this.lblPicDate.Size = new System.Drawing.Size(63, 14);
            this.lblPicDate.TabIndex = 10;
            this.lblPicDate.Text = "lblPicDate";
            // 
            // lblDlyWntDate
            // 
            this.lblDlyWntDate.AutoSize = true;
            this.lblDlyWntDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDlyWntDate.Location = new System.Drawing.Point(474, 68);
            this.lblDlyWntDate.Name = "lblDlyWntDate";
            this.lblDlyWntDate.Size = new System.Drawing.Size(88, 14);
            this.lblDlyWntDate.TabIndex = 11;
            this.lblDlyWntDate.Text = "lblDlyWntDate";
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Location = new System.Drawing.Point(776, 562);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(144, 25);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "btnModify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(617, 562);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 25);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmInvNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 602);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblDlyWntDate);
            this.Controls.Add(this.lblPicDate);
            this.Controls.Add(this.lblDmdDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvNo";
            this.ShowIcon = false;
            this.Text = "frmInvNo";
            this.Load += new System.EventHandler(this.frmInvNo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDlvBra;
        private System.Windows.Forms.Label lblGAddr;
        private System.Windows.Forms.Label lblGPlaId;
        private System.Windows.Forms.Label lblGCust;
        private System.Windows.Forms.Label lblPicBra;
        private System.Windows.Forms.Label lblSAddr;
        private System.Windows.Forms.Label lblSPlaId;
        private System.Windows.Forms.Label lblSCust;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDmdDate;
        private System.Windows.Forms.Label lblPicDate;
        private System.Windows.Forms.Label lblDlyWntDate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkDelete;
        private System.Windows.Forms.Button btnDelete;
    }
}