using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Homework_Adv_7_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var queryString =
               @"insert into Movies ([Name], [Genre], [Year])
                values ('A beautiful mind', 'Biography, Drama', '2001');
                insert into Movies ([Name], [Genre], [Year])
                values('Брат 2', 'Боевик, триллер', '2000');
                insert into Movies ([Name], [Genre], [Year])
                values('The Terminal', 'Comedy, Drama', '2004');";
                
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

