using System.ComponentModel.DataAnnotations;

namespace PicconnectAPI.Models.User
{
    public class FormSignup
    {
        [Required(ErrorMessage = "Email is required.")]
        [MaxLength(5000, ErrorMessage = "The Email  must be less than 150 characters long.")]
        public string? email { get; set; }
    }
}
