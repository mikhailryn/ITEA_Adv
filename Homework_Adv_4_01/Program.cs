using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        public delegate T GenericDelegate<T>(T obj1);
        static string NameMethod(string name)
        {
            return $"First name: {name}";
        }
        static void Main(string[] args)
        {
            GenericDelegate<string> genericDelegate = NameMethod;

            genericDelegate = name => NameMethod("Petro");

            Console.WriteLine(genericDelegate(""));
            Console.ReadKey();
        }
    }
}
