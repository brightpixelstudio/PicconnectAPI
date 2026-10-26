using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.User
{
    public class SelectSearchUsers
    {
        [Key]
        public int userid { get; set; }
        public string? userguid { get; set; }
        public int matchcount { get; set; }
        public string? username { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public int totalviews { get; set; }
        public string? defaultpicture { get; set; }
        public string? zipcode { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public sbyte sex { get; set; }
        public int distance { get; set; }
        public int userhotid { get; set; }
        public DateTime lastlogin { get; set; }
        public DateTime dateaddded { get; set; }
        public sbyte feet { get; set; }
        public sbyte inches { get; set; }
        public sbyte children { get; set; }
        public int yearborn { get; set; }
        public sbyte picturecount { get; set; }
        public string? phrase { get; set; }
        public string? title { get; set; }
        public string? profile { get; set; }
        public string? bodytype { get; set; }
        public string? enthinicity { get; set; }
        public string? religion { get; set; }
        public string? salary { get; set; }
        public string? occupation { get; set; }
    }
}

