using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.Email
{
    public class SelectSentTotalEmails
    {
        [Key]
        public int total { get; set; }
    }
}
