using System.ComponentModel.DataAnnotations;

namespace AFAConsultant.Models
{
    public class QueryMessage
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Subject is required")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Message is required")]
        [Display(Name = "Message")]
        public string Message { get; set; }

    }
}
