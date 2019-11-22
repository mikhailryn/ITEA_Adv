using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Homework_Adv_7_02
{
    class Program
    {
        static void Main(string[] args)
        {


            var queryString = @"create table Movies ( Name nvarchar(20), Genre nvarchar(50), Year int);";


            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["Homework_7_DB"].ToString();
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}

