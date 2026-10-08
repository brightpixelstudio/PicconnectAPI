using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.Utilities
{
    public class SelectLatestNewestUsers
    {
        [Key]
        public int userid { get; set; }
        public DateTime dateexpiration { get; set; }
        public string? defaultpicture { get; set; }
        public string? emailaddress { get; set; }
        public int sex { get; set; }
        public string? userguid { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? usermatchprofileguid { get; set; }
        public int totalphotos { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
        public sbyte latest { get; set; }
        public sbyte newest { get; set; }
    }
}

