using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.User
{
    public class SelectUsermatchSets
    {
        [Key]
        public int usermatchprofileid { get; set; }
        public string? usermatchprofileguid { get; set; }
        public string? title { get; set; }
        public sbyte? seeking { get; set; }
        public sbyte? topage { get; set; }
        public sbyte? bottomage { get; set; }
        public int distance { get; set; }
        public sbyte? children { get; set; }
        public int religionid { get; set; }
        public int salaryid { get; set; }
        public sbyte? feet { get; set; }
        public sbyte? inches { get; set; }
        public string? religion { get; set; }
        public string? salary { get; set; }
        public sbyte? primary { get; set; }
        public DateTime dateaddded { get; set; }
        public int likes { get; set; }
        public int dislikes { get; set; }
        public int totalphotos { get; set; }
    }
}

