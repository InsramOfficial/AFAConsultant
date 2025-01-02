using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class JobApplication
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Full name is required")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [Phone(ErrorMessage = "Invalid phone number")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Birth date is required")]
    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }

    [Required(ErrorMessage = "Gender is required")]
    public string Gender { get; set; }

    [Required(ErrorMessage = "Street address is required")]
    public string StreetAddress1 { get; set; }

    public string StreetAddress2 { get; set; }

    [Required(ErrorMessage = "Country is required")]
    public string Country { get; set; }

    [Required(ErrorMessage = "City is required")]
    public string City { get; set; }

    [Required(ErrorMessage = "Region is required")]
    public string Region { get; set; }

    [Required(ErrorMessage = "Postal code is required")]
    [RegularExpression("\\d{5}", ErrorMessage = "Postal code must be 5 digits")]
    public string PostalCode { get; set; }

    [Required(ErrorMessage = "Current position is required")]
    public string CurrentPosition { get; set; }

    [Required(ErrorMessage = "Years of experience is required")]
    [Range(0, 50, ErrorMessage = "Years of experience must be between 0 and 50")]
    public int YearsOfExperience { get; set; }

    [Required(ErrorMessage = "Specialization area is required")]
    public string SpecializationArea { get; set; }

    

    [Url(ErrorMessage = "Invalid picture URL")]
    public string? PicUrl { get; set; }

    [NotMapped]
    public IFormFile Picture { get; set; }
}
