using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AFAConsultant.Pages.Admin.HomeSlider
{
    public class UpdateSliderModel : PageModel
    {
        private readonly AppdbContext db;
        private readonly IWebHostEnvironment env;
        public Slider Slider { get; set; }
        public UpdateSliderModel(AppdbContext _db, IWebHostEnvironment _env)
        {
            db = _db;
            env = _env;
        }
        public async Task OnGetAsync(int id)
        {
            try
            {
                Slider = await db.tbl_slider.FindAsync(id);
                TempData["picurl"] = Slider.PicURL;
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error Occur While Getting Data";
            }
        }
        public IActionResult OnPost(Slider Slider)
        {
            if (!ModelState.IsValid)
            {
                TempData["info"] = "Please Insert Correct Data";
                return Page();
            }
            try
            {
                if (Slider.Picture == null)
                {
                    Slider.PicURL = Slider.PicURL;
                }
                else
                {
                    Slider.PicURL = Slider.Picture.FileName;
                    var folderpath = Path.Combine(env.WebRootPath, "images");
                    var imagepath = Path.Combine(folderpath, Slider.Picture.FileName);
                    Slider.Picture.CopyTo(new FileStream(imagepath, FileMode.Create));
                }
                db.tbl_slider.Update(Slider);
                db.SaveChanges();
                TempData["success"] = "Slider Updated Successfully";
                return RedirectToPage("index");
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error While Adding Record";
                return Page();
            }
        }
    }
}
