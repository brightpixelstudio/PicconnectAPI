using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.Email
{
    [Keyless]
    public class SelectEmailCounts
    {        
        public int inbox { get; set; }
        public int notread { get; set; }
        public int sent { get; set; }
        public int deleted { get; set; }
    }
}
