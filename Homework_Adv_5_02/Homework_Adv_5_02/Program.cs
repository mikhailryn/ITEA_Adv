using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Adv_5_02
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass.CallDelegate(() => Console.WriteLine("А так можно было?"));
            Console.ReadKey();
        }
    }
}
