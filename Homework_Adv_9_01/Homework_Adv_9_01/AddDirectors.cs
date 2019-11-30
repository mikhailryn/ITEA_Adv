using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Linq;

namespace Homework_Adv_9_01
{
   public class AddDirectors
    {
        public static void InsertDirectors()
        {
            DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["CinemaConnect"].ToString());

            var directorOne = new Directors() { FirstName = "Quentin", LastName = "Tarantino", BirthDate = 1963 };
            var directorTwo = new Directors() { FirstName = "Guy", LastName = "Ritchie", BirthDate = 1968 };
            var directorThree = new Directors() { FirstName = "Алексей", LastName = "Балабанов", BirthDate = 1959 };

            dataContext.GetTable<Directors>().InsertAllOnSubmit(new Directors[] { directorOne,directorTwo, directorThree});
            
            dataContext.SubmitChanges();
            Console.WriteLine("Directors inserted");
        }
    }
}
