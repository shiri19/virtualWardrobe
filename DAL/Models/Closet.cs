using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Closet
    {
        public Closet()
        {
            Shelf = new HashSet<Shelf>();
        }

        public int Id { get; set; }
        public string ClosetNane { get; set; }
        public string ClosetDesc { get; set; }

        public virtual ICollection<Shelf> Shelf { get; set; }
    }
}
