using System.ComponentModel.DataAnnotations;

namespace AFAConsultant.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Username is required.")]
        [Display(Name = "User Name")]
        [MaxLength(100, ErrorMessage = "Username cannot exceed 100 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage = "Password cannot exceed 100 characters.")]
        public string Password { get; set; }
    }
}
