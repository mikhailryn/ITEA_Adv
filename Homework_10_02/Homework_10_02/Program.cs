using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Homework_10_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Service<ClassAuthor>.ShowMethodsAttributes(new ClassAuthor());
            Console.ReadKey();
        }
    }
}
