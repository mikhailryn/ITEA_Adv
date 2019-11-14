using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Adv_5_03
{
    public enum BodyParts
    {
        Head,
        Legs,
        Arms
    }
    public class Human
    {
        public BodyParts MostImportantBodyPart { get; set; } = BodyParts.Head;
    }
}
