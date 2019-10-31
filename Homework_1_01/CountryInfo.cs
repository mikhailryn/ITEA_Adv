using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
   public class CountryInfo:IValue
    {
        public string Capital { get; set; }
        public int Population { get; set; }
        public int Size { get; set; }

        public CountryInfo(string capital, int pop, int size)
        {
            Capital = capital;
            Population = pop;
            Size = size;
        }


    }
}
