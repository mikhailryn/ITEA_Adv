using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Linq;

namespace Homework_Adv_9_03
{
   public class DeleteDirectors
    {
        public static void deleteDirectors()
        {
            DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["CinemaConnect"].ToString());

            var delDirector = dataContext.GetTable<Directors>().Where(x => x.BirthDate > 1960 && x.BirthDate < 1980);
            dataContext.GetTable<Directors>().DeleteAllOnSubmit(delDirector);

            dataContext.SubmitChanges();
            Console.WriteLine("Directors deleted");
        }


    }
}
