using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.Utilities
{
    public class SelectCoordinates
    {
        [Key]
        public float latitude { get; set; }
        public float longitude { get; set; }
    }
}

