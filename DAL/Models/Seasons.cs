using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Seasons
    {
        public Seasons()
        {
            Clothing = new HashSet<Clothing>();
        }

        public int Id { get; set; }
        public string SeasonName { get; set; }

        public virtual ICollection<Clothing> Clothing { get; set; }
    }
}
