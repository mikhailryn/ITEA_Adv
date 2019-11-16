using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Adv_5_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var characters = PersonsService.GetPersons();


            var sortedPerson = characters.Where(x => x.Age > 30).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);  

            foreach(var person in sortedPerson)
                Console.WriteLine(person.ToString());
            Console.ReadKey();
        }
    }
}
