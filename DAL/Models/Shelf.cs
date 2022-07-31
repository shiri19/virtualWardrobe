using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Shelf
    {
        public Shelf()
        {
            Clothing = new HashSet<Clothing>();
        }

        public int Id { get; set; }
        public int? ClosetId { get; set; }
        public string ShelfDesc { get; set; }

        public virtual Closet Closet { get; set; }
        public virtual ICollection<Clothing> Clothing { get; set; }
    }
}
