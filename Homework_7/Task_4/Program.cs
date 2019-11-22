using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Homework_Adv_7_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var queryString = @"select * from Movies";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["Homework_7_DB"].ToString();
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                using (SqlDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        Console.WriteLine($"Name: {sqlReader[0].ToString()}, Genre: {sqlReader[1].ToString()}," +
                            $"  Year: {sqlReader[2].ToString()}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

