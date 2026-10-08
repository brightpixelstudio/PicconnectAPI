using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.Utilities
{
    public class SelectExpiringMemberships
    {
        [Key]
        public int usersubscriptionid { get; set; }
        public DateTime dateexpiration { get; set; }
        public string? firstname{ get; set; }
        public string? lastname { get; set; }
        public string? userguid { get; set; }
        public string? emailaddress { get; set; }
    }
}

