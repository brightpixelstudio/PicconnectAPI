using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.Utilities
{
    public class SelectMostPopularPhotos
    {
        [Key]
        public int photoid { get; set; }
        public string? title { get; set; }
        public string? photoguid { get; set; }
        public int photo_count { get; set; }
        public sbyte rating { get; set; }
    }
}

