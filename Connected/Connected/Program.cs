using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connected
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStrings"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            
            connection.Open();

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "CREATE TABLE gruppa (id int primary key identity(1,1), name nvarchar(max)); ";
            command.ExecuteNonQuery();
        }
    }
}
