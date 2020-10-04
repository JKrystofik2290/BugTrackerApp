using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Data
{
    public class UsersClass
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public int type { get; set; }
    }
}
