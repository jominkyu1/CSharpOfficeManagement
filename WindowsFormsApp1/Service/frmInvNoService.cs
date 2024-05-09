using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.Service
{
    /**
     * DB연결 APP CONFIG
     * SQL Parameter Append
     */
    internal class frmInvNoService
    {
        private static readonly string _sunghwa91 =
            ConfigurationManager.ConnectionStrings["sunghwa91"].ConnectionString;

        private static readonly SqlConnection con = SingletonDB.GetInstance(_sunghwa91);
        private static SqlCommand cmd = new SqlCommand();

        private static frmInvNoService instance = null;
        private static readonly object lockObj = new object();

        private readonly Dictionary<string, string> braList = new Dictionary<string, string>();

        public static frmInvNoService getInstance()
        {
            lock (lockObj)
            {
                return instance ?? (instance = new frmInvNoService());
            }
        }

        private frmInvNoService()
        {
            //인스턴스 생성시 영업소 리스트 받아오기
            cmd = openCon();
            MessageBox.Show(cmd.Connection.ConnectionString);
            string sql = "SELECT DISTINCT bra_id, bra_name FROM ls801t0";
            cmd.CommandText = sql;

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    braList.Add(reader["bra_id"].ToString(), 
                                reader["bra_name"].ToString());
                }
            }
            closeCon();
        }


        public DataRow findInfoByInvNo(string invNo)
        {
            cmd = openCon();
            MessageBox.Show(cmd.Connection.ConnectionString);
            string sql = @"SELECT * 
                            FROM LS001T0
                            WHERE INV_NO = @invNo";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("invNo", invNo);

            DataTable dataTable = new DataTable();
            DataRow dataRow;
            using (var reader = cmd.ExecuteReader())
            {
                dataTable.Load(reader);
                dataTable.Columns["PIC_BRA_ID"].MaxLength = 15; // 3 -> 15
                dataTable.Columns["DLY_BRA_ID"].MaxLength = 15;
                dataRow = dataTable.Rows[0];

                string strPicBraId = dataRow["PIC_BRA_ID"].ToString();
                string strDlyBraId = dataRow["DLY_BRA_ID"].ToString();

                dataRow["PIC_BRA_ID"] = strPicBraId + "\t" + braList[strPicBraId];
                dataRow["DLY_BRA_ID"] = strDlyBraId + "\t" + braList[strDlyBraId];
            }
            closeCon();

            return dataRow;
        }

        public DataTable findScansByInvNo(string invNo)
        {
            cmd = openCon();
            string sql = "SELECT * FROM ls101t0_TEST WHERE inv_no = @invNo";
            cmd.CommandText = sql;

            //SIMPLE BUT 명확한 자료형, 길이 지정이 더 좋지 않을까?
            //cmd.Parameters.AddWithValue("invNo", invNo); 
            cmd.Parameters.Add("invNo", SqlDbType.NVarChar, 20).Value = invNo;
            DataTable dataTable = new DataTable();
            using (var reader = cmd.ExecuteReader())
            {
                dataTable.Load(reader);
            }


            closeCon();
            return dataTable;
        }

        public int deleteScan(List<Ls101T0DTO> models)
        {
            using (var transaction = new TransactionScope())
            {
                cmd = openCon();
                
                try
                {
                    int result=0;

                    foreach (var model in models)
                    {
                        string sql = $@"DELETE FROM LS101T0_TEST 
                                    WHERE inv_no = '{model.InvNo}'
                                      and scann_slt = '{model.ScannSlt}'
                                      and scann_date = '{model.ScannDate}' 
                                      and scann_time = '{model.ScannTime}' 
                                      and scann_usr_id = '{model.ScannUsrId}'";
                        cmd.CommandText = sql;
                        result += cmd.ExecuteNonQuery();
                    }

                    transaction.Complete();
                    return result;
                }
                catch (Exception e)
                {
                    MessageBox.Show(
                        "DELETE FAILED. TRANSACTION ROLLBACK",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return 0;
                }
                finally
                {
                    closeCon();
                }
            }
        }

        private SqlCommand openCon()
        {
            try
            {
                con.ConnectionString = _sunghwa91;
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Connect Exception", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return con.CreateCommand();
        }

        private void closeCon()
        {
            try
            {
                cmd?.Dispose(); 
                con?.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Close Exception", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
