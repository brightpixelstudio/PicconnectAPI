using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.User
{
    public class SelectViewedMeListCounts
    {
        [Key]
        public int today { get; set; }
        public int week { get; set; }
        public int month { get; set; }
    }
}

