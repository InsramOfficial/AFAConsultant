using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AFAConsultant.Models
{
    public class Countries
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Flag Image")]
        [AllowNull]
        public string? Flag_PicUrl { get; set; }
        [Display(Name = "Country Image")]
        [AllowNull]
        public string? Country_PicUrl { get; set; }
        [NotMapped]
        public IFormFile? FlagPicture { get; set; }
        [NotMapped]
        public IFormFile? CountryPicture { get; set; }

    }
}
