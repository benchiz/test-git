using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_sessionSecond
{
    class Service
    {
        DB Database = new DB();
        /// <summary>
        /// <c>SelectServices</c> это метод для выбора данных из таблицы Сервисы.
        /// <returns>Возращает <c>service</c></returns>
        /// </summary>
        public SqlDataReader SelectServices()
        {
            Database.CloseConnection();
            Database.OpenConnection();
            string sqlLine = @"SELECT * FROM Service";
            SqlCommand cmd = new SqlCommand(sqlLine, Database.conn);
            SqlDataReader service = cmd.ExecuteReader();
            return service;
        }

        // Будет ли он нужен далее ? =)
        public SqlDataReader SelectService(int id)
        {
            Database.CloseConnection();
            Database.OpenConnection();
            string sqlLine = @"SELECT * FROM Service WHERE ID = " + id;
            SqlCommand cmd = new SqlCommand(sqlLine, Database.conn);
            SqlDataReader service = cmd.ExecuteReader();
            return service;
        }

        public void DeleteService(int id)
        {
            Database.CloseConnection();
            Database.OpenConnection();
            string sqlLine = @"DELETE FROM Service WHERE ID = " + id;
            SqlCommand cmd = new SqlCommand(sqlLine, Database.conn);
            SqlDataReader service = cmd.ExecuteReader();
        }

        public void UpdateService(int id, string Title, double Cost, int DurationInSeconds, string MainImagePath, double Discount)
        {
            Database.CloseConnection();
            Database.OpenConnection();
            string sqlLine = "UPDATE Service SET Title = @Title, Cost = @Cost, DurationInSeconds = @DurationInSeconds," +
            "Discount = @Discount, MainImagePath = @MainImagePath WHERE ID = @id";
            SqlCommand cmd = new SqlCommand(sqlLine, Database.conn);

            SqlParameter idParam = new SqlParameter("@id", id);
            cmd.Parameters.Add(idParam);
            SqlParameter TitleParam = new SqlParameter("@Title", Title);
            cmd.Parameters.Add(TitleParam);
            SqlParameter CostParam = new SqlParameter("@Cost", Cost);
            cmd.Parameters.Add(CostParam);
            SqlParameter DurationInSecondsParam = new SqlParameter("@DurationInSeconds", DurationInSeconds);
            cmd.Parameters.Add(DurationInSecondsParam);
            SqlParameter DiscountParam = new SqlParameter("@Discount", Discount);
            cmd.Parameters.Add(DiscountParam);
            SqlParameter MainImagePathParam = new SqlParameter("@MainImagePath", MainImagePath);
            cmd.Parameters.Add(MainImagePathParam);

            SqlDataReader service = cmd.ExecuteReader();
        }

        public void AddService(string Title, double Cost, int DurationInSeconds, string MainImagePath, double Discount)
        {
            Database.CloseConnection();
            Database.OpenConnection();

            string sqlLine = @"INSERT INTO Service (Title, Cost, DurationInSeconds, Discount, MainImagePath) VALUES (@Title, @Cost, @DurationInSeconds,
            @Discount, @MainImagePath)";

            SqlCommand cmd = new SqlCommand(sqlLine, Database.conn);

            SqlParameter TitleParam = new SqlParameter("@Title", Title);
            cmd.Parameters.Add(TitleParam);
            SqlParameter CostParam = new SqlParameter("@Cost", Cost);
            cmd.Parameters.Add(CostParam);
            SqlParameter DurationInSecondsParam = new SqlParameter("@DurationInSeconds", DurationInSeconds);
            cmd.Parameters.Add(DurationInSecondsParam);
            SqlParameter DiscountParam = new SqlParameter("@Discount", Discount);
            cmd.Parameters.Add(DiscountParam);
            SqlParameter MainImagePathParam = new SqlParameter("@MainImagePath", MainImagePath);
            cmd.Parameters.Add(MainImagePathParam);

            cmd.ExecuteReader();
        }
    }
}
