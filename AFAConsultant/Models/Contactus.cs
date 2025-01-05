using System.ComponentModel.DataAnnotations;

namespace AFAConsultant.Models
{
    public class Contactus
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [Display(Name = "Address")]
        public string Address1 { get; set; }
        [Display(Name = "Second Address")]
        public string? Address2 { get; set; }
        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber1 { get; set; }
        [Display(Name = "Second Phone Number")]
        public string? PhoneNumber2 { get; set; }
        [Required(ErrorMessage = "Email Address is required")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email1 { get; set; }
        [Display(Name = "Second Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email2 { get; set; }
        [Display(Name = "Facebook Link")]
        public string FacebookLink { get; set; }
        [Display(Name = "Twitter Link")]
        public string TwitterLink { get; set; }
        [Display(Name = "Instagram Link")]
        public string InstagramLink { get; set; }
        [Display(Name = "Tiktok Link")]
        public string TiktokLink { get; set; }

    }
}
