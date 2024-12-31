using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AFAConsultant.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Website Name is required.")]
        [Display(Name = "Website Name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Logo is required.")]
        [Display(Name = "Logo")]
        public string? LogoFavicon { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Logo/Favicon is required.")]
        public IFormFile LogoFav { get; set; }

    }
}
