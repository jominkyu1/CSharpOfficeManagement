using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public static class SingletonDB
    {
        private static SqlConnection instance;
        private static readonly object lockObject = new Object();

        public static SqlConnection GetInstance(string connectionStr)
        {
            lock(lockObject){
                if (instance == null) instance =  new SqlConnection(connectionStr);
                else instance.ConnectionString = connectionStr;
                
                Trace.TraceInformation("SqlConnection Hash: " + instance.GetHashCode().ToString());
                return instance;
            }
        }
    }
}
