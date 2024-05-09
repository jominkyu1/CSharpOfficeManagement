using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Service
{
    public class Form2Service
    {
        private readonly SqlCommand Cmd;
        private static Form2Service Instance = null;
        private DataTable TotalDataTable;

        private Form2Service(SqlCommand command)
        {
            Cmd = command;
        }
        public static Form2Service GetInstance(SqlCommand command)
        {
            Instance = Instance ?? new Form2Service(command);
            return Instance;
        }


        public DataTable Get404Combo(bool hasId = true)
        {
            string filter = hasId ? "type = '404' and usr_id is not null" : 
                                    "type = '404' and usr_id is null";

            DataTable tempTable = new DataTable();
            //새로운 데이터테이블의 토탈데이터테이블 Column 복사 ( rows X )
            tempTable = TotalDataTable.Clone();

            foreach (var dataRow in TotalDataTable.Select(filter, "agy_id asc"))
            {
                tempTable.ImportRow(dataRow);
            }

            return tempTable;
        }

        public DataTable Get405Combo(bool hasId = true)
        {
            string filter = hasId ? "type = '405' and usr_id is not null" : 
                                    "type = '405' and usr_id is null";

            DataTable tempTable = new DataTable();
            tempTable = TotalDataTable.Clone();

            foreach (var dataRow in TotalDataTable.Select(filter, "agy_id asc"))
            {
                tempTable.ImportRow(dataRow);
            }

            return tempTable;
        }

        public DataTable UnionQuery(string cust_id)
        {
            string sql = $@"
                SELECT distinct  
                    ls404t0.agy_id                                          as agy_id, 
                    concat(ls404t0.agy_id, ' :: ', ls404t0.agy_name)        as agy_name, 
                    v_ls902t0_usr.usr_id                                    as usr_id, 
                    v_ls902t0_usr.psd                                       as psd, 
                    '404'                                                   as type 
                FROM LS404T0 
                LEFT JOIN V_LS902T0_USR on ls404t0.cust_id = v_ls902t0_usr.cust_id  
                               and v_ls902t0_usr.TARGET_DB = 'SA02' 
                               and ls404t0.agy_id = v_ls902t0_usr.agy_id  
                WHERE ls404T0.cust_id = '{cust_id}' and ls404t0.end_date = '' 

                UNION

                SELECT distinct 
                    ls405t0.agy_id                                       as agy_id,
                    concat(ls405t0.agy_id, ' :: ', ls405t0.agy_name)     as agy_name,
                    v_ls902t0_usr.usr_id                                 as usr_id,
                    v_ls902t0_usr.psd                                    as psd, 
                    '405'                                                as type
                FROM ls405t0
                LEFT JOIN v_ls902t0_usr on ls405t0.cust_id = v_ls902t0_usr.cust_id
                            and v_ls902t0_usr.target_db = 'SA02'
                            and ls405t0.agy_id = v_ls902t0_usr.agy_id
                WHERE ls405t0.cust_id = '{cust_id}' and ls405t0.end_date = '' 

                ORDER BY dbo.ls404t0.agy_id";

            TotalDataTable = CreateQuery(sql);

            return TotalDataTable;
        }


        private DataTable CreateQuery(string sql)
        {
            DataTable dt = new DataTable();
            Cmd.CommandText = sql;
            try
            {
                using (var reader = Cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cmd.Dispose();
            }
            return dt;
        }
    }
}
