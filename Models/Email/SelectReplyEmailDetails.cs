using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.Email
{
    public class SelectReplyEmailDetails
    {
        [Key]
        public int fromuserid { get; set; }
        public int touserid { get; set; }
        public string? username { get; set; }
        public int statusid { get; set; }
        public sbyte sex { get; set; }
        public string? defaultpicture { get; set; }
        public string? userguid { get; set; }
        public sbyte blocked { get; set; }
    }
}
