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

            // Сортировка в порядке убывания по возрасту
            var sortedAge = characters.Where(x => x.Age > 30).OrderByDescending(x => x.Age);  

            foreach(var adult in sortedAge)
                Console.WriteLine(adult.ToString());
            Console.WriteLine();

            // Сортировка по возрастанию FirstName
            var sortedName = characters.Where(x => x.Age > 30).OrderBy(x => x.FirstName);

            foreach (var name in sortedName)
                Console.WriteLine(name.ToString());
            Console.ReadKey();
        }
    }
}
