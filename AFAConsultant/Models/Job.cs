using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AFAConsultant.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Birth date is required")]
        [DataType(DataType.Date,ErrorMessage = "Please Valid Data")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Street address is required")]
        [Display(Name = "Street Address")]
        public string StreetAddress1 { get; set; }
        [Display(Name = "Second Address")]
        public string? StreetAddress2 { get; set; }
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }
        [Display(Name = "City")]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        [Display(Name = "Province")]
        [Required(ErrorMessage = "Province is required")]
        public string Province { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        [Display(Name = "Current Position")]
        [AllowNull]
        public string? CurrentPosition { get; set; }
        [Display(Name = "Year of Experience")]
        [AllowNull]
        public int? YearsOfExperience { get; set; }
        [Display(Name = "Specialization Area")]
        [AllowNull]
        public string? SpecializationArea { get; set; }
        [Display(Name = "Image")]
        public string PicUrl { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Picture is Required")]
        public IFormFile Picture { get; set; }
    }
}
