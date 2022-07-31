using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SystemSettings
    {
        public int Id { get; set; }
        public bool? UseChip { get; set; }
        public bool? FrequencyOfUse { get; set; }
    }
}
