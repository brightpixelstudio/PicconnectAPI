using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.User
{
    public class SelectUsersViewed
    {
        [Key]
        public int userid { get; set; }
        public string? emailaddress { get; set; }
        public string? firstname { get; set; }
        public string? phone { get; set; }
        public int count { get; set; }
    }
}

