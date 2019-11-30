using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Adv_9_03
{
    [Table(Name = "Directors")]
    public class Directors
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string FirstName { get; set; }
        [Column]
        public string LastName { get; set; }
        [Column]
        public int BirthDate { get; set; }
    }
}
