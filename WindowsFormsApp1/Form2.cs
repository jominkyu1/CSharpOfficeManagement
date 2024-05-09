using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private readonly DbConnection dbConnection = new DbConnection();
        private SqlConnection con;
        private SqlCommand cmd;
        private Form2Service form2Service;
        private string currentSelected;
        private DataTable UnionDataTable;

        private static Form2 instance = null;

        public static Form2 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                return new Form2();
            }

            return instance;
        }

        private Form2()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
                GetCommand();
                string sql = @"SELECT DISTINCT CUST_ID, (cust_id + ' :: ' + cust_name) as cust_name
                               FROM LS401T0 
                               WHERE end_date = ''
                               ORDER BY CUST_ID";
                cmd.CommandText = sql;
                using (var reader = cmd.ExecuteReader())
                {
                    makeLog("CONNECT QUERY");
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboCust.DataSource = dt;
                    comboCust.DisplayMember = "CUST_NAME";
                    comboCust.ValueMember = "CUST_ID";
                    lblCount401.Text = comboCust.Items.Count.ToString();
                }
                CloseConnection();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void comboCust_DropDownClosed(object sender, EventArgs e)
        {
            if (comboCust.SelectedValue == null) return;
            
            ClearComponents();
            //Union DataTable 할당
            GetCommand();
            string selectedCustId = comboCust.SelectedValue.ToString();
            makeLog("Selected CustID: " + selectedCustId);
            UnionDataTable = form2Service.UnionQuery(selectedCustId);
            CloseConnection();
            
            //LS404T0 화물계정 있는 지점
            combo404.DataSource = form2Service.Get404Combo();
            combo404.DisplayMember = "agy_name";
            combo404.ValueMember = "agy_id";
            lblCount404.Text = combo404.Items.Count.ToString();

            //LS404T0 화물계정 없는 지점
            combo404_noItem.DataSource = form2Service.Get404Combo(false);
            combo404_noItem.DisplayMember = "agy_name";
            combo404_noItem.ValueMember = "agy_id";
            lblCount404_NoAcc.Text = combo404_noItem.Items.Count.ToString();

            //LS405T0 행낭계정 있는 지점
            combo405.DataSource = form2Service.Get405Combo();
            combo405.DisplayMember = "agy_name";
            combo405.ValueMember = "agy_id";
            lblCount405.Text = combo405.Items.Count.ToString();

            //LS405T0 행낭계정 없는 지점
            combo405_noItem.DataSource = form2Service.Get405Combo(false);
            combo405_noItem.DisplayMember = "agy_name";
            combo405_noItem.ValueMember = "agy_id";
            lblCount405_NoAcc.Text = combo405_noItem.Items.Count.ToString();
        }

        private void combo404_DropDownClosed(object sender, EventArgs e)
        {
            if (combo404.SelectedValue == null) return;

            string custId = comboCust.SelectedValue.ToString();
            string agy_id = combo404.SelectedValue.ToString();
            GridViewInit();

            GetCommand();

            string sql = $@"SELECT USR_ID, PSD, USR_NAME, CRE_DATE 
                            FROM v_ls902t0_usr 
                            WHERE cust_id = {custId} and agy_id = {agy_id} and target_db = 'SA02' 
                            ORDER BY cre_date DESC";
            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                if (!reader.HasRows) dataGridView1.Rows.Add("NO DATA");

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader[0].ToString(),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        reader[3].ToString(),
                        "삭제");
                        
                }
            }

            CloseConnection();
        }

        private void combo405_DropDownClosed(object sender, EventArgs e)
        {
            if (combo405.SelectedValue == null) return;
               
               string custId = comboCust.SelectedValue.ToString();
               string agy_id = combo405.SelectedValue.ToString();
               GridViewInit();
               
               GetCommand();
               
               string sql = $@"SELECT USR_ID, PSD, USR_NAME, CRE_DATE 
                               FROM v_ls902t0_usr 
                               WHERE cust_id = {custId} and agy_id = {agy_id} and target_db = 'SA02' 
                               ORDER BY cre_date DESC";
               cmd.CommandText = sql;
               using (var reader = cmd.ExecuteReader())
               {
                   if (!reader.HasRows) dataGridView1.Rows.Add("NO DATA");
               
                   while (reader.Read())
                   {
                       dataGridView1.Rows.Add(
                           reader[0].ToString(),
                           reader[1].ToString(),
                           reader[2].ToString(),
                           reader[3].ToString(),
                           "삭제");
                   }
               }
               
               CloseConnection();
        }

        private void combo404_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private SqlCommand GetCommand(int ip = 1)
        {
            if (ip == 92)
            {
                con = dbConnection.GetSunghwaConnection92();
            } else {
                con = dbConnection.GetSunghwaConnection();
            }

            cmd = con.CreateCommand();
            con.Open();

            form2Service = Form2Service.GetInstance(cmd); //Service Instance

            makeLog("DB CONNECTED");
            return cmd;
        }

        private void CloseConnection()
        {
            try
            {
                con?.Close();
                cmd?.Dispose();
                makeLog("DB CLOSED");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void makeLog(string str)
        {
            listLog.Items.Add(DateTime.Now + ": " + str);
        }

        private void ClearComponents()
        {
            combo404.DataSource = null;
            combo405.DataSource = null;
            combo404_noItem.DataSource = null;
            combo405_noItem.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
        }

        private void comboCust_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo405_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void combo404_noItem_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void combo404_noItem_DropDownClosed(object sender, EventArgs e)
        {
            if (combo404_noItem.SelectedValue == null) return;
            currentSelected = "404";

            GetCommand(92);
            string agy_id = combo404_noItem.SelectedValue.ToString();
            string cust_id = comboCust.SelectedValue.ToString();

            //계정생성 참고 AGYNO
            cmd.CommandText =
                $@"select top 1 agy_no
                        from SLIS_MASTER.SLIS_MASTER.DBO.LS404T0 where cust_id = '{cust_id}' and agy_id = '{agy_id}'";

            string resultAgyNo = cmd.ExecuteScalar().ToString();

            lblAgyNo.Text = string.IsNullOrEmpty(resultAgyNo) ? "NO AGY_NO" : resultAgyNo;
            CloseConnection();

            ShowRules(cust_id); //최근 계정 생성규칙 확인
            InitCreateGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (e.ColumnIndex == 3 && clickedCell == "생성") //생성버튼 클릭
            {
                string usr_id = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                string psd = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                string cre_date = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();

                if (usr_id == null || psd == null || cre_date == null) 
                {
                    MessageBox.Show("값을 입력하세요.");
                    return;
                }


                string cust_id = comboCust.SelectedValue.ToString();
                string agy_id = "";
                string bra_id = "";

                switch (currentSelected)
                {
                    case "404":
                        agy_id = combo404_noItem.SelectedValue.ToString();
                        bra_id = "A.CH_BRA_ID";
                        break;
                    case "405":
                        agy_id = combo405_noItem.SelectedValue.ToString();
                        bra_id = "A.POU_BRA_ID";
                        break;
                    default:
                        throw new Exception("currentSelected 필드 초기화 안됨.");
                }
                    
                

                GetCommand(92); // DB OPEN

                string sql = $@"INSERT INTO DKLS.dbo.LS902T0
                             SELECT DISTINCT TOP 1
		                     '{usr_id}' as URS_ID, 
                             A.agy_name as USR_NAME, 
                             '{psd}' as PSD, 
                             '{psd}' as PSD_BF, 
                             A.CUST_ID, 
                             {bra_id} as BRA_ID, 
                             '' as PLA_ID, 
                             A.AGY_ID, 
		                     '' as DEPT_ID, 
                             'BA93' as USER_PER, 
                             30 as PSD_CHG, 
                             '{cre_date}' as CRE_DATE, 
                             '' as EDIT_DATE, 
                             '' as END_DATE, 
                             '' as RNK, 
                             '9305011' as TRS_ID, 
                             '조민규' as TRS_NAME, 
                             getDate() as TRS_DATE 
                        from SLIS_MASTER.SLIS_MASTER.DBO.LS{currentSelected}T0 A join SLIS_MASTER.SLIS_MASTER.DBO.LS401T0 B on A.cust_id = B.cust_id
                        where A.cust_id = '{cust_id}' and A.agy_id = '{agy_id}'";
                                    //currentSelected => 404 or 405
                                    //POU_BRA_ID if 405
                cmd.CommandText = sql;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("INSERTED");
                    panelRules.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection(); // DB CLOSE
                }
            } else if (e.ColumnIndex == 4 && clickedCell == "삭제") //삭제버튼
            {
                string usr_id = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                string cust_id = comboCust.SelectedValue?.ToString();
                
                if (usr_id == null || cust_id == null)
                {
                    MessageBox.Show("USR_ID or CUST_ID null");
                    return;
                }

                GetCommand(92);
                string sql = $@"DELETE FROM dkls.dbo.ls902t0 
                                WHERE cust_id= '{cust_id}' and usr_id = '{usr_id}'";
                cmd.CommandText = sql;

                try
                {
                    if (MessageBox.Show("DELETE?", "", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"DELETED \nCUST-ID : {cust_id} \nUSR_ID : {usr_id}");
                    }
                    else
                    {
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, null, 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection();
                }

            }

        }

        private void ShowRules(string cust_id)
        {
            if (cust_id == null)
            {
                MessageBox.Show("최근 생성규칙 불러오기 실패", "", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            GetCommand(92);
            cmd.CommandText = $@"SELECT TOP 20 
                        a.usr_id as usr_id, 
                        a.psd as psd, 
                        a.cre_date as cre_date, 
                        b.agy_no as agy_no
                    FROM dkls.dbo.LS902T0 a 
                    LEFT JOIN SLIS_MASTER.SLIS_MASTER.DBO.LS404T0 b 
                    ON a.cust_id = b.cust_id AND a.usr_name = b.agy_name 
                    WHERE a.cust_id = '{cust_id}'
                    ORDER BY a.cre_date DESC";

            using (var reader = cmd.ExecuteReader())
            {
                listRules.Items.Clear();
                while (reader.Read())
                {
                    string usr_id = reader["usr_id"].ToString();
                    string psd = reader["psd"].ToString();
                    string cre_date = reader["cre_date"].ToString();
                    string agy_no = reader["agy_no"].ToString();
                    listRules.Items.Add("[ID] " + usr_id + " :: [PW] " + psd + ":: [CREATED] " + cre_date + ":: [AGY_NO] " + agy_no);
                }
            }

            panelRules.Visible = true;
            CloseConnection();
        }

        private void lblAgyNo_Click(object sender, EventArgs e)
        {

        }

        private void combo405_noItem_DropDownClosed(object sender, EventArgs e)
        {
            if (combo405_noItem.SelectedValue == null) return;
            currentSelected = "405";

            GetCommand(92);
            string agy_id = combo405_noItem.SelectedValue.ToString();
            string cust_id = comboCust.SelectedValue.ToString();

            //계정생성 참고 AGYNO
            cmd.CommandText =
                $@"select top 1 agy_no
                        from SLIS_MASTER.SLIS_MASTER.DBO.LS405T0 where cust_id = '{cust_id}' and agy_id = '{agy_id}'";

            string resultAgyNo = cmd.ExecuteScalar().ToString();

            lblAgyNo.Text = string.IsNullOrEmpty(resultAgyNo) ? "NO AGY_NO" : resultAgyNo;


            CloseConnection();

            ShowRules(cust_id); //최근 계정 생성규칙 확인
            InitCreateGridView();
        }

        private void InitCreateGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("USR_ID", "USR_ID");
            dataGridView1.Columns.Add("PSD", "PSD");
            dataGridView1.Columns.Add("CRE_DATE", "CRE_DATE");
            dataGridView1.Columns.Add(new DataGridViewButtonColumn());

            dataGridView1.Rows[0].Cells[3].Value = "생성";
            dataGridView1.Rows[0].Selected = true;

            dataGridView1.Rows[0].Cells[1].Value = "1234"; //PW
            dataGridView1.Rows[0].Cells[2].Value = string.Format("{0:yyyyMMdd}", DateTime.Now); //CRE_DATE
        }


        private void GridViewInit()
        {
            panelRules.Visible = false;

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("USR_ID", "USR_ID");
            dataGridView1.Columns.Add("PSD", "PSD");
            dataGridView1.Columns.Add("USR_NAME", "USR_NAME");
            dataGridView1.Columns.Add("CRE_DATE", "CRE_DATE");
            dataGridView1.Columns.Add(new DataGridViewButtonColumn());

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSASwitch_Click(object sender, EventArgs e)
        {
        }

        private void combo405_noItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private bool isFirstCall = true;
        private DataTable originalDataSource;

        private void txtSearchCust_TextChanged(object sender, EventArgs e)
        {

            if (isFirstCall && comboCust.DataSource != null)
            {
                originalDataSource = comboCust.DataSource as DataTable;
                isFirstCall = false;
            }

            if (comboCust.DataSource == null) return;

            List<DataRowView> searchList = new List<DataRowView>();

            var enumerator = comboCust.Items.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var data = enumerator.Current as DataRowView;

                // 0001 :: 코웨이(주)
                string showCustName = data.Row[1].ToString();
                if (showCustName.IndexOf(txtSearchCust.Text, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    searchList.Add(data);
                }
            }

            if (comboCust.DataSource != null && searchList.Count > 0)
            {
                comboCust.DataSource = searchList;
                lblCount401.Text = searchList.Count.ToString();
                lblNotFound.Visible = false;
            }
            else if (txtSearchCust.Text.Trim().Length == 0 )
            {
                lblCount401.Text = originalDataSource.Rows.Count.ToString();
                comboCust.DataSource = originalDataSource;
                lblNotFound.Visible = false;
            }
            else
            {
                lblCount401.Text = originalDataSource.Rows.Count.ToString();
                lblNotFound.Visible = true;
                comboCust.DataSource = originalDataSource;
            }
        }

        private void comboCust_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void combo404_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
