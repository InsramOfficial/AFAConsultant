using System.ComponentModel.DataAnnotations;

namespace AFAConsultant.Models
{
    public class Aboutus
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        [MaxLength(280,ErrorMessage = "Description must be less than 280 characters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Field is required")]
        [Display(Name = "Total Visa Categories")]
        public int Total_Visa_Categories { get; set; }
        [Required(ErrorMessage = "Field is required")]
        [Display(Name = "Total Team Members")]
        public int Total_Team_Members { get; set; }
        [Required(ErrorMessage = "Field is required")]
        [Display(Name = "Total Visa Processes")]
        public int Total_Visa_Processes { get; set; }
        [Required(ErrorMessage = "Field is required")]
        [Display(Name = "Success Rate")]
        [Range(0, 100, ErrorMessage = "Success Rate must be between 0 and 100")]
        public int Success_Rate { get; set; }
    }
}
