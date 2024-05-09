using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DbConnection
    {
        private static readonly string _sunghwa91 =
            ConfigurationManager.ConnectionStrings["sunghwa91"].ConnectionString;
        private static readonly string _sunghwa92 = 
            ConfigurationManager.ConnectionStrings["sunghwa92"].ConnectionString;

        //Local DB
        private string Uid;
        private string Pw;
        private string Schema;
        private string Server;
        private string ConnectionStr;

        public SqlConnection GetLocalConnection()
        {
            Uid = "mk";
            Pw = "1234";
            Schema = "WinformSchema";
            Server = "(LocalDB)\\MSSQLLocalDB";

            ConnectionStr = $"SERVER={Server};" +
                            $"DATABASE={Schema};" +
                            $"UID={Uid};" +
                            $"Password={Pw};";

            return SingletonDB.GetInstance(ConnectionStr);
        }

        public SqlConnection GetSunghwaConnection()
        {
            return SingletonDB.GetInstance(_sunghwa91);
        }

        public SqlConnection GetSunghwaConnection92()
        {
            return SingletonDB.GetInstance(_sunghwa92);
        }
    }
}
