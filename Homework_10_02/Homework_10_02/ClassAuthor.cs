using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10_02
{
   public class ClassAuthor
    {
        [Author("Mikhail", version = 1) ]
        public void PubMethod()
        {
            Console.WriteLine("Public Method");
        }

        [Author("Mikhail", version = 2)]
        private void PrivMethod()
        {
            Console.WriteLine("Private Method");
        }

    }
}
