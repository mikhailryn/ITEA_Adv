using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Adv_5_01
{
    class Program
    {
        static void Main(string[] args)
        {
           Action action = SomePhrase;

           Car.OnEngine(action);

           void SomePhrase()
            {
                Console.WriteLine("Start the engine");
            }
            
        }
    }
}
