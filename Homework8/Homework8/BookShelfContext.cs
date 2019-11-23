using PractAdv8;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class BookShelfContext:DbContext
    {
        public BookShelfContext(): base("BookShelfContext")
        {

        }     
        public DbSet<Character> Characters { get; set; }
    }
}
