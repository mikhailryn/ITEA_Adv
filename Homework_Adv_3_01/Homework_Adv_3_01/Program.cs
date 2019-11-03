using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Homework_Adv_3_01
{
    class Program
    {

        public delegate BigBadWolf WolfDelegate(string name);

        static void Main(string[] args)
        { 
            BigBadWolf bigBadWolf = new BigBadWolf("GreyWolf");

                WolfDelegate wolfDelegate;

                wolfDelegate = BigBadWolf => bigBadWolf.name;

             Console.WriteLine(wolfDelegate.Invoke(name: "Wolf"));

            Console.ReadKey();
            
        

        }
       
    }
}
