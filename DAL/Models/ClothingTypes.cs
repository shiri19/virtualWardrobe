using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ClothingTypes
    {
        public ClothingTypes()
        {
            Clothing = new HashSet<Clothing>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Clothing> Clothing { get; set; }
    }
}
