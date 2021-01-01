using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp_sessionSecond
{
    class DB
    {
        public SqlConnection conn;

        public DB()
        {
            conn = Connect();
        }

        public SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BB2;Integrated Security=True");
            return conn;
        }

        public void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
        }

        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();
        }
    }
}
