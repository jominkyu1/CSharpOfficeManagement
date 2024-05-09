namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSA02 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSA01 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInvNo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSA02,
            this.btnSA01,
            this.btnInvNo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 19, 0, 19);
            this.menuStrip1.Size = new System.Drawing.Size(200, 524);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnSA02
            // 
            this.btnSA02.AutoSize = false;
            this.btnSA02.Name = "btnSA02";
            this.btnSA02.Size = new System.Drawing.Size(199, 35);
            this.btnSA02.Text = "SA02 -  WEB";
            this.btnSA02.Click += new System.EventHandler(this.btnSA02_Click);
            // 
            // btnSA01
            // 
            this.btnSA01.AutoSize = false;
            this.btnSA01.Name = "btnSA01";
            this.btnSA01.Size = new System.Drawing.Size(199, 35);
            this.btnSA01.Text = "SA01 - Program";
            this.btnSA01.Click += new System.EventHandler(this.btnSA01_Click);
            // 
            // btnInvNo
            // 
            this.btnInvNo.AutoSize = false;
            this.btnInvNo.Name = "btnInvNo";
            this.btnInvNo.Size = new System.Drawing.Size(199, 35);
            this.btnInvNo.Text = "INV_NO";
            this.btnInvNo.Click += new System.EventHandler(this.btnInvNo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 524);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSA02;
        private System.Windows.Forms.ToolStripMenuItem btnSA01;
        private System.Windows.Forms.ToolStripMenuItem btnInvNo;
    }
}