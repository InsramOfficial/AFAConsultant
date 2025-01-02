using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AFAConsultant.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Designation is required")]
        [Display(Name = "Designation")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Review Message is required")]
        [Display(Name = "Review Message")]
        [MaxLength(180,ErrorMessage = "Review Message must be less than 180 characters")]
        public string Message { get; set; }
        [Required(ErrorMessage = "Select Rating Stars")]
        [Display(Name = "Rating")]
        [Range(1,5,ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }
        [Display(Name = "Image")]
        public string? PicUrl { get; set; }
        [NotMapped]
        public IFormFile Picture { get; set; }
    }
}
