using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AFAConsultant.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        [MaxLength(150,ErrorMessage = "Description must be less than 150 Characters")]
        public string Description { get; set; }
        [Display(Name = "Slider Image")]
        [AllowNull]
        public string? PicURL { get; set; }
        [NotMapped]
        public IFormFile? Picture { get; set; }
    }
}
