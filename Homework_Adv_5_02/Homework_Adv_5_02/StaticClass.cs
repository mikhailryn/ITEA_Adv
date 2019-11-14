using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Adv_5_02
{
    public delegate void MyDelegate();
    static class StaticClass
    {
        public static void CallDelegate(MyDelegate myDelegate)
        {
            myDelegate();
        }
    }
}
