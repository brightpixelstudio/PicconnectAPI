using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.Email
{
    public class SelectSentEmails
    {
        [Key]
        public int orderfield { get; set; }
        public int startemailid { get; set; }
        public int useremailid { get; set; }
        public string? useremailguid { get; set; }
        public int fromuserid { get; set; }
        public string? userguid { get; set; }
        public DateTime dateexpiration { get; set; }
        public DateTime isreaddate { get; set; }
        public DateTime isdeletedate { get; set; }
        public DateTime isfalggeddate { get; set; }
        public string? username { get; set; }
        public sbyte sex { get; set; }
        public string? defaultpicture { get; set; }
        public string? title { get; set; }
        public string? message { get; set; }
        public DateTime dateadded { get; set; }
        public int messagecount { get; set; }
    }
}
