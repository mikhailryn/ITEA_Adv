using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10_02
{
    [AttributeUsage(AttributeTargets.Method)]
   public class Author:Attribute
    {
        private string name;
        public int version { get; set; }

        public Author(string name)
        {
            this.name = name;
        }
    }
}
