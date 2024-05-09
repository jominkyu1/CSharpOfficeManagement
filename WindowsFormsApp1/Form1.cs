using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        private static Form3 sa91Form;
        private static Form2 sa92Form;
        private static frmInvNo saInvForm;
        public MainForm()
        {
            InitializeComponent();
            sa92Form = Form2.GetInstance();
            sa91Form = Form3.GetInstance();
            saInvForm = frmInvNo.GetInstance();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Width = 1300;
            this.Height = 700;
        }


        private void btnSA02_Click(object sender, EventArgs e)
        {
            sa92Form.MdiParent = this;
            sa92Form.WindowState = FormWindowState.Maximized;
            sa92Form.Show();
        }

        private void btnSA01_Click(object sender, EventArgs e)
        {
            sa91Form.MdiParent = this;
            sa91Form.WindowState = FormWindowState.Maximized;
            sa91Form.Show();

            if (sa92Form.comboCust.DataSource == null) return;
            sa91Form.comboCust.DataSource = sa92Form.comboCust.DataSource;
            sa91Form.comboCust.DisplayMember = sa92Form.comboCust.DisplayMember;
            sa91Form.comboCust.ValueMember = sa92Form.comboCust.ValueMember;

            sa91Form.comboCust.SelectedIndex = sa92Form.comboCust.SelectedIndex;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnInvNo_Click(object sender, EventArgs e)
        {
            saInvForm.MdiParent = this;
            saInvForm.WindowState = FormWindowState.Maximized;
            saInvForm.Show();
        }
    }
}
