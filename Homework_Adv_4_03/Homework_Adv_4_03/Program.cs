using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Adv_4_03
{
    public delegate void MyDelegate();
    
    class Program
    {  
        static void Main(string[] args)
        {
          Call call = new Call();

          MyDelegate myDelegate = new MyDelegate(Call_PhoneCall);

          call.PhoneCall += myDelegate;

          call.DoEvent();
        }
        private static void Call_PhoneCall()
        {
            Console.WriteLine("Звонок от:");
            Console.ReadKey();
        }
    }
}
