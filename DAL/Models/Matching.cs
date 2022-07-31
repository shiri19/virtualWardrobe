using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Matching
    {
        public Matching()
        {
            MatchingDeatails = new HashSet<MatchingDeatails>();
        }

        public int Id { get; set; }
        public string MatchName { get; set; }
        public int? Priority { get; set; }
        public string Picture { get; set; }

        public virtual ICollection<MatchingDeatails> MatchingDeatails { get; set; }
        public string toString()
        {
            return MatchName;
        }
    }
}
