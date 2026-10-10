using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.User
{
    public class SelectUserSettings
    {
        [Key]
        public int settingid { get; set; }
        public sbyte type { get; set; }
        public string? title { get; set; }
        public sbyte value { get; set; }
    }
}

