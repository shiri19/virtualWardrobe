using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MatchingDeatails
    {
        public int Id { get; set; }
        public int? NatchKod { get; set; }
        public int? ClothingId { get; set; }
        public int? AlternateClothing { get; set; }

        public virtual Clothing AlternateClothingNavigation { get; set; }
        public virtual Clothing Clothing { get; set; }
        public virtual Matching NatchKodNavigation { get; set; }
        public string tostring()
        {
            string str = "בגד: " + Clothing.ClothingName + " בגד חלופי: " + AlternateClothingNavigation.ClothingName;
            return str;
        }
    }
}
