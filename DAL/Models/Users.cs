using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Users
    {
        public Users()
        {
            Clothing = new HashSet<Clothing>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public int? BearthYear { get; set; }
        public int? Size { get; set; }
        public string Picture { get; set; }

        public virtual ICollection<Clothing> Clothing { get; set; }
    }
}
