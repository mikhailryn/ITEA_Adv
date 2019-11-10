using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        public delegate T GenericDelegate<T,R>(R someName);
        static string NameMethod(string name)
        {
            return name;
        }
        static void Main(string[] args)
        {
            GenericDelegate<string,string> genericDelegate = NameMethod;

            genericDelegate = name => NameMethod("Petr");
   
            Console.WriteLine(genericDelegate(""));
            Console.ReadKey();
        }
    }
}
