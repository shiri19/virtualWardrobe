using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Sets
    {
        public Sets()
        {
            Clothing = new HashSet<Clothing>();
        }

        public int Id { get; set; }
        public string SetName { get; set; }
        public string Picture { get; set; }

        public virtual ICollection<Clothing> Clothing { get; set; }
    }
}
