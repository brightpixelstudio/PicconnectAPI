using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.Email
{
    public class SelectEmailHistory
    {
        [Key]
        public int touserid { get; set; }
        public int fromuserid { get; set; }
        public string? title { get; set; }
        public string? username { get; set; }
        public string? message { get; set; }
        public DateTime dateadded { get; set; }

    }
}
