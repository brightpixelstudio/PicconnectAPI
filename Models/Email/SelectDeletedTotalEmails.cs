using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.Email
{
    [Keyless]
    public class SelectDeletedTotalEmails
    {        
        public int total { get; set; }
    }
}
