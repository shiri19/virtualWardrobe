using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Clothing
    {
        public Clothing()
        {
            MatchingDeatailsAlternateClothingNavigation = new HashSet<MatchingDeatails>();
            MatchingDeatailsClothing = new HashSet<MatchingDeatails>();
            Using = new HashSet<Using>();
        }

        public int Id { get; set; }
        public string ClothingName { get; set; }
        public string Picture { get; set; }
        public int? Kind { get; set; }
        public int? Category { get; set; }
        public int? Season { get; set; }
        public string Gender { get; set; }
        public int? UserId { get; set; }
        public int? SetId { get; set; }
        public int? Size { get; set; }
        public int? ShelfId { get; set; }
        public int? Priority { get; set; }

        public virtual Categories CategoryNavigation { get; set; }
        public virtual ClothingTypes KindNavigation { get; set; }
        public virtual Seasons SeasonNavigation { get; set; }
        public virtual Sets Set { get; set; }
        public virtual Shelf Shelf { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<MatchingDeatails> MatchingDeatailsAlternateClothingNavigation { get; set; }
        public virtual ICollection<MatchingDeatails> MatchingDeatailsClothing { get; set; }
        public virtual ICollection<Using> Using { get; set; }
    }
}
