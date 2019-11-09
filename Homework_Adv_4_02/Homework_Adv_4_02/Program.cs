using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_Adv_4_02
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Call call = new Call();

            call.PhoneCall += () => Console.WriteLine($"Звонок от");

            call.DoEvent();

            Console.ReadKey();
        }   
    }
}
