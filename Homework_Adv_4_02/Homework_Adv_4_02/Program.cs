using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_Adv_4_02
{
    class Program
    {
        public delegate void MyDelegate();
        public event MyDelegate PhoneCall;
        static void Main(string[] args)
        {
            Call call = new Call();

            call.PhoneCall += () => Console.WriteLine($"Звонок от");

            call.DoEvent();

            Console.ReadKey();
        }   
    }
}
