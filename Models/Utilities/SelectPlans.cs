using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.Utilities
{
    public class SelectPlans {
        [Key]
        public int planid { get; set; }
        public sbyte length { get; set; }
        public sbyte lengthtype { get; set; }
        public float cost { get; set; }
        public sbyte discount { get; set; }
        public int free { get; set; }
        public int joined { get; set; }
        public int maxjoined { get; set; }
    }
}

