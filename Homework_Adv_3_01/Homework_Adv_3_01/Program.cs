using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        public delegate BigBadWolf MyDelegate(string name);
        static void Main(string[] args)
        {   
            MyDelegate myDelegate;
            myDelegate = name => new BigBadWolf(name);
            myDelegate("GreyWolf");
        }
    }
}
