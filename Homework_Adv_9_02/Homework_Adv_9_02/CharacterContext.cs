using Homework_Adv_9_02.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Adv_9_02
{
    public class CharacterContext: DbContext
    {
        public DbSet<Character> Characters { get; set; }
    }
}
