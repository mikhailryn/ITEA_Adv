using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Adv_5_01
{
    class Car
    {
        public static void OnEngine(Action actionOnEngine)
        {
            actionOnEngine();
        }
    }
}
