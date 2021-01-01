using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_sessionSecond
{
    class ClientService
    {
        DB Database = new DB();

        public SqlDataReader SelectClientServices()
        {
            Database.CloseConnection();
            Database.OpenConnection();
            string sqlLine = @"SELECT * FROM ClientService";
            SqlCommand cmd = new SqlCommand(sqlLine, Database.conn);
            SqlDataReader clientService = cmd.ExecuteReader();
            return clientService;
        }

        public SqlDataReader SelectClientService(int id)
        {
            Database.CloseConnection();
            Database.OpenConnection();
            string sqlLine = @"SELECT * FROM ClientService WHERE ID = " + id;
            SqlCommand cmd = new SqlCommand(sqlLine, Database.conn);
            SqlDataReader clientService = cmd.ExecuteReader();
            return clientService;
        }

        //public void DeleteClientService(int id)
        //{
        //    Database.CloseConnection();
        //    Database.OpenConnection();
        //    string sqlLine = @"SELECT * FROM ClientService WHERE ID = ";
        //    SqlCommand cmd = new SqlCommand(sqlLine, Database.conn);
        //    SqlDataReader clientService = cmd.ExecuteReader();
        //}
    }
}
