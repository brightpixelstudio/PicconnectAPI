using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.Utilities
{
    public class SelectCategories
    {
        [Key]
        public int categoryid { get; set; }
        public string? title { get; set; }
        public int totalphotos { get; set; }
    }
}

