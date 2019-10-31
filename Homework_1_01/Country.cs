using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Country:IKey
    {
        public string nameCountry { get; set; }

        public Country(string name)
        {
            nameCountry = name;
        }
    }
}
