using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.User
{
    [Keyless]
    public class SelectUser
    {
        public DateTime dateaddded { get; set; }
        public sbyte length { get; set; }
        public sbyte lengthtype { get; set; }
        public float cost{ get; set; }
        public sbyte discount { get; set; }
        public float amount { get; set; }
        public DateTime lastbilling { get; set; }
        public DateTime dateexpiration { get; set; }
        public int daysexpiration { get; set; }
    }
}

