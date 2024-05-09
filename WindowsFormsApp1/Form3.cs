using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private readonly DbConnection dbConnection = new DbConnection();
        private Form3Service form3Service = new Form3Service();
        private DataTable idDT = new DataTable();
        private SqlCommand cmd;
        private SqlConnection con;
        
        private static Form3 instance=null;
        public static Form3 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Form3();
            }

            return instance;
        }

        private Form3()
        {
            var roleSource = new[]
            {
                new { Text = "거래처관리자 BA91 ", Value = "BA91" },
                new { Text = "거래처사용자 BA92", Value = "BA92" },
                new { Text = "거래처일반사용자 BA93", Value = "BA93" }

            };

            InitializeComponent();
            comboRole.DataSource = roleSource;
            comboRole.DisplayMember = "Text";
            comboRole.ValueMember = "Value";
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            listRules.HorizontalScrollbar = true;
            

            GetCommand();
            string sql = $@"
            SELECT ls902t0.cust_id, usr_id, usr_name, psd, ls404t0.agy_no, ls902t0.cre_Date, ls902t0.USR_PER 
            FROM ls902t0 left join ls404t0 on ls902t0.agy_id = ls404t0.agy_id   
                                           and ls902t0.cust_id = ls404t0.cust_id  
            WHERE ls902t0.cust_id != '' 
            ORDER BY ls902t0.cre_date desc";

            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                idDT.Load(reader);
            }
            CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCust.SelectedValue == null) return;
            listRules.Items.Clear();
            string cust_id = comboCust.SelectedValue.ToString();

            var result = 
                idDT.Select($"cust_id = '{cust_id}'", "cre_date desc");

            //생성된 계정이 없을경우
            if (result.Length == 0)
            {
                lblRulesCount.Text = "0";
                lblAgyCount.Text = "0";
                listAgys.DataSource = null;
                listRules.Items.Add("NO ID");
                return;
            }

            //listRules Count
            lblRulesCount.Text = result.Length.ToString();

            foreach (DataRow row in result)
            {
                listRules.Items.Add($"ID: {row[1]} :: NAME: {row[2]} :: PSD: {row[3]} :: AGY_NO: {row[4]} :: CRE_DATE: {row[5]} :: USR_PER: {row[6]}");
            }

            //listAgys
            BringAgyList(cust_id);
        }

        private void BringAgyList(string cust_id)
        {
            GetCommand();
            string sql = $@"
            select ls404t0.cust_id, ls404t0.agy_id, ls404t0.agy_no, (ls404t0.agy_id + ' :: ' + agy_name) as agy_name
            from ls404t0 
            left join ls902t0 on ls404t0.cust_id = ls902t0.cust_id and ls902t0.agy_id = ls404t0.agy_id 
            where ls404t0.cust_id = '{cust_id}' and ISNULL(ls902t0.usr_id, '') = '' 
            order by ls404t0.agy_id ";

            cmd.CommandText = sql;
            using (var reader = cmd.ExecuteReader())
            {
                DataTable temp = new DataTable();
                temp.Load(reader);

                listAgys.DataSource = temp;
                listAgys.DisplayMember = "AGY_NAME";
                listAgys.ValueMember = "AGY_ID";

                //Agy_ID Count
                lblAgyCount.Text = listAgys.Items.Count.ToString();
            }

            CloseConnection();
        }

        private SqlCommand GetCommand(int ip = 1)
        {
            if (ip == 92)
            {
                con = dbConnection.GetSunghwaConnection92();
            }
            else
            {
                con = dbConnection.GetSunghwaConnection();
            }

            cmd = con.CreateCommand();
            con.Open();

            return cmd;
        }
        private void CloseConnection()
        {
            try
            {
                con?.Close();
                cmd?.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboCust_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void listAgys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAgys.SelectedValue == null || con.State == ConnectionState.Open) return;

            GetCommand();
            string sql =
                $"SELECT agy_no FROM ls404t0 WHERE cust_id = '{comboCust.SelectedValue}'" +
                $"                                 and agy_id = '{listAgys.SelectedValue}'";

            cmd.CommandText = sql;
            lblAgyNo.Text = cmd.ExecuteScalar() as string;
            CloseConnection();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtPW.Text))
            {
                MessageBox.Show("ID, PW 모두 입력");
                return;
            }

            GetCommand();
            string sql = $@"INSERT INTO ls902t0 
                        SELECT TOP 1 
                                '{txtID.Text}' as USR_ID,
                                A.agy_name as USR_NAME,
                                '{txtPW.Text}' as PSD,
                                '{txtPW.Text}' as PSD_BF,
                                A.CUST_ID,
                                A.CAD_BRA_ID as BRA_ID,
                                B.PLA_ID,
                                A.AGY_ID,
                                '{comboRole.SelectedValue.ToString()}' as USR_PER,
                                30 as PSD_CHG,
                                format(getDate(), 'yyyyMMdd') as CRE_DATE,
                                '' as EDIT_DATE,
                                '' as END_DATE,
                                '' as RNK,
                                '9305011' as TRS_ID,
                                '조민규' as TRS_NAME,
                                getDate() as TRS_DATE
                        FROM ls404t0 A inner join ls401t0 B on A.cust_id = B.cust_id 
                        WHERE A.cust_id='{comboCust.SelectedValue}' 
                              and A.agy_id = '{listAgys.SelectedValue}'";
            cmd.CommandText = sql;
            var result = cmd.ExecuteNonQuery();
            if (result == 1) MessageBox.Show("계정생성 완료");

            string sql2 = $@"INSERT INTO 소화물_거래처
                                (거래처, 청구부서, 아이디, 체크, 처리시간, 별도지점, RT) 
                             VALUES 
                                ('{comboCust.SelectedValue}', '01', '{txtID.Text}', '1', getDate(), 0, 0)";
            cmd.CommandText = sql2;

            try /* 소화물_거래처 자동 생성되어있는경우 SqlException 발생 */
            {
                var result2 = cmd.ExecuteNonQuery();
                if (result2 == 1) MessageBox.Show("소화물_거래처 입력완료");
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show($"예외발생: {sqlException.Message}");
            }
            finally
            {
                CloseConnection();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private bool isFirstCall = true;
        private DataTable originalDataSource;

        private void txtSearchAgy_TextChanged(object sender, EventArgs e)
        {
            if (isFirstCall && listAgys.DataSource != null)
            {
                originalDataSource = listAgys.DataSource as DataTable;
                isFirstCall = false;
            }

            if (listAgys.DataSource == null) return;

            List<DataRowView> searchList = new List<DataRowView>();

            var enumerator = listAgys.Items.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var data = enumerator.Current as DataRowView;

                // 0001 :: 코웨이(주)
                string showAgyName = data.Row["agy_name"].ToString();
                if (showAgyName.IndexOf(txtSearchAgy.Text, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    searchList.Add(data);
                }
            }

            if (listAgys.DataSource != null && searchList.Count > 0)
            {
                listAgys.DataSource = searchList;
                lblAgyCount.Text = searchList.Count.ToString();
                lblNotFound.Visible = false;
            }
            else if (txtSearchAgy.Text.Trim().Length == 0)
            {
                lblAgyCount.Text = originalDataSource.Rows.Count.ToString();
                listAgys.DataSource = originalDataSource;
                lblNotFound.Visible = false;
            }
            else
            {
                lblAgyCount.Text = originalDataSource.Rows.Count.ToString();
                lblNotFound.Visible = true;
                listAgys.DataSource = originalDataSource;
            }
        }
    }
}
