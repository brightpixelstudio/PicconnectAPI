using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.Email
{
    public class SelectFlaggedTotalEmails
    {
        [Key]
        public int total { get; set; }
    }
}
