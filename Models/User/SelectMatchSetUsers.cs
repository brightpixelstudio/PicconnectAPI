using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.User
{
    public class SelectMatchSetUsers
    {
        [Key]
        public int userid { get; set; }
        public string? userguid { get; set; }
        public string? username { get; set; }
        public int totalviews { get; set; }
        public string? defaultpicture { get; set; }
        public string? city { get; set; }
        public string? zipcode { get; set; }
        public string? state { get; set; }
        public sbyte? sex { get; set; }
        public int distance { get; set; }
        public int userhotid { get; set; }
        public DateTime lastlogin { get; set; }
        public DateTime dateaddded { get; set; }
        public int usermatchprofileid { get; set; }
        public int matchcount { get; set; }
        public int photocount { get; set; }
    }
}

