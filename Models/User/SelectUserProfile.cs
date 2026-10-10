using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.User
{
    public class SelectUserProfile
    {
        [Key]
        public int userid { get; set; }
        public sbyte statusid { get; set; }
        public string? userguid { get; set; }
        public sbyte matchsetcount { get; set; }
        public int totalviews { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
        public sbyte profilecomplete { get; set; }
        public string? username { get; set; }
        public sbyte sex { get; set; }
        public DateTime lastlogin { get; set; }
        public int picturecount{ get; set; }
        public string? defaultpicture { get; set; }
        public string? zipcode { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public sbyte children { get; set; }
        public int yearborn { get; set; }
        public sbyte feet { get; set; }
        public sbyte inches { get; set; }
        public string? phrase { get; set; }
        public string? title { get; set; }
        public string? profile { get; set; }
        public int hot { get; set; }
        public sbyte showratings { get; set; }
        public sbyte blocked { get; set; }
        public string? bodytype { get; set; }
        public string? enthnicity { get; set; }
        public string? religion { get; set; }
        public string? salary { get; set; }
        public string? occupation { get; set; }
    }
}

