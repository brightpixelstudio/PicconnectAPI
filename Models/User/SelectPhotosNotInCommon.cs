using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.User
{
    public class SelectPhotosNotInCommon
    {
        [Key]
        public string? photoguid { get; set; }
        public int rating { get; set; }
        public string? title { get; set; }
    }
}

