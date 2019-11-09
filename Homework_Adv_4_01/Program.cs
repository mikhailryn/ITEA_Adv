using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        public delegate T GenericDelegate<T>(T obj1, T obj2);
        static int AddMethod(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            GenericDelegate<int> genericDelegate = AddMethod;

            genericDelegate = (num1, num2) => AddMethod(173, 282);
   
            Console.WriteLine(genericDelegate(1,1));
            Console.ReadKey();
        }
    }
}
