using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Adv_5_03
{
    static class HumanExtension
    {
        public static void Evolve(this Human human)
        {
            human.MostImportantBodyPart = BodyParts.Arms;
            var x = human.MostImportantBodyPart;
            Console.WriteLine(x);
        }
    }
}
