using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_sessionSecond
{
    class Client
    {
        DB Database = new DB();
        public SqlDataReader SelectClients()
        {
            Database.CloseConnection();
            Database.OpenConnection();
            string sqlLine = @"SELECT * FROM Client";
            SqlCommand cmd = new SqlCommand(sqlLine, Database.conn);
            SqlDataReader client = cmd.ExecuteReader();
            return client;
        }

        public SqlDataReader SelectClient(int id)
        {
            Database.CloseConnection();
            Database.OpenConnection();
            string sqlLine = @"SELECT * FROM Client WHERE ID = " + id;
            SqlCommand cmd = new SqlCommand(sqlLine, Database.conn);
            SqlDataReader client = cmd.ExecuteReader();
            return client;
        }

        //public void DeleteClient(int id)
        //{
        //    Database.CloseConnection();
        //    Database.OpenConnection();
        //    string sqlLine = @"SELECT * FROM Client WHERE ID = ";
        //    SqlCommand cmd = new SqlCommand(sqlLine, Database.conn);
        //    SqlDataReader client = cmd.ExecuteReader();
        //}
    }
}
