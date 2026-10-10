using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.User
{
    [Keyless]
    public class SelectUser
    {
        public int userid { get; set; }
        public string? userguid { get; set; }
        public string? username { get; set; }
        public string? firstname { get; set; }
        public string? defaultpicture { get; set; }
        public sbyte profilecomplete { get; set; }
        public sbyte matchsetcount { get; set; }
        public string? incompletepage { get; set; }
        public int searchcount { get; set; }
        public string? lastname { get; set; }
        public string? password { get; set; }
        public sbyte statusid { get; set; }
        public sbyte typeid { get; set; }
        public string? zipcode { get; set; }
        public string? emailaddress { get; set; }
        public string? phone { get; set; }
        public int dateborn { get; set; }
        public DateTime lastlogin { get; set; }
        public float lat{ get; set; }
        public float lng { get; set; }
        public int totalsubscriptions { get; set; }
        public int totalhot { get; set; }
    }
}

