using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.Service;
using Timer = System.Threading.Timer;

namespace WindowsFormsApp1
{
    public partial class frmInvNo : Form
    {
        private readonly frmInvNoService invService;
        private static frmInvNo instance = null;
        private static readonly object lockObject = new Object();

        public static frmInvNo GetInstance()
        {
            lock (lockObject)
            {
                if (instance == null || instance.IsDisposed) instance = new frmInvNo();
                return instance;
            }
        }

        private frmInvNo()
        {
            InitializeComponent();

            this.invService = frmInvNoService.getInstance();
            
        }

        private void frmInvNo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //LS001T0
            DataRow ls001t0 = invService.findInfoByInvNo(txtInvNo.Text);
            ls001t0InfoShow(ls001t0);


            //LS101T0
            DataTable ls101t0 = invService.findScansByInvNo(txtInvNo.Text);
            dataGridView1.DataSource = ls101t0;
            dataGridView1.Columns["TRS_DATE"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.sss";

        }



        private void ls001t0InfoShow(DataRow ls001t0)
        {
            //배송날짜
            lblDlyWntDate.Text = ls001t0["DLY_WNT_DATE"].ToString();
            lblPicDate.Text = ls001t0["PIC_DATE"].ToString();
            lblDmdDate.Text = ls001t0["DMD_DATE"].ToString();

            //받는이
            lblGCust.Text = ls001t0["G_CUST_ID"] + " :: " + ls001t0["G_CUST_NAME"];
            lblDlvBra.Text = ls001t0["DLY_BRA_ID"].ToString();
            lblGAddr.Text = ls001t0["G_ADDR"] + "\n" + ls001t0["G_D_ADDR"];
            lblGPlaId.Text = ls001t0["G_PLA_ID"].ToString();

            //보낸이
            lblSCust.Text = ls001t0["S_CUST_ID"] + " :: " + ls001t0["S_CUST_NAME"];
            lblPicBra.Text = ls001t0["PIC_BRA_ID"].ToString();
            lblSAddr.Text = ls001t0["S_ADDR"] + "\n" + ls001t0["S_D_ADDR"];
            lblSPlaId.Text = ls001t0["S_PLA_ID"].ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Ls101T0DTO> models = new List<Ls101T0DTO>();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                var chkBox = row.Cells[0] as DataGridViewCheckBoxCell;

                if (chkBox.Value as bool? ?? false)
                {
                    Ls101T0DTO dto = new Ls101T0DTO()
                    {
                        InvNo = row.Cells["inv_no"].Value.ToString(),
                        ScannSlt = row.Cells["SCANN_SLT"].Value.ToString(),
                        ScannDate = row.Cells["SCANN_DATE"].Value.ToString(),
                        ScannTime = row.Cells["SCANN_TIME"].Value.ToString(),
                        ScannUsrId = row.Cells["SCANN_USR_ID"].Value.ToString()
                    };
                    models.Add(dto);
                }
            }

            var result = invService.deleteScan(models);
            if (result > 0) MessageBox.Show("DELETED: " + result);

            //Refresh
            btnSearch.PerformClick();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
