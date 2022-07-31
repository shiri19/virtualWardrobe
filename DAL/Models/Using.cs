using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Using
    {
        public int Id { get; set; }
        public int? ClothingId { get; set; }
        public DateTime? UsingDate { get; set; }
        public string Note { get; set; }
        public DateTime? ReturnDate { get; set; }

        public virtual Clothing Clothing { get; set; }
    }
}
