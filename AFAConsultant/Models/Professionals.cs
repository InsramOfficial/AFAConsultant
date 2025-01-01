using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AFAConsultant.Models
{
    public class Professionals
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        [MaxLength(80,ErrorMessage = "Description must be less than 80 characters")]
        public string Description { get; set; }
        [Display(Name = "Image")]
        [AllowNull]
        public string? PicUrl { get; set; }
        [NotMapped]
        public IFormFile? Picture { get; set; }
    }
}
