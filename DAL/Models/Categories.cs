using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Clothing = new HashSet<Clothing>();
        }

        public int Id { get; set; }
        public string CatName { get; set; }

        public virtual ICollection<Clothing> Clothing { get; set; }
    }
}
