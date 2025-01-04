using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AFAConsultant.Pages.Admin.Professional
{
    public class AddProfessionalModel : PageModel
    {
        private readonly AppdbContext db;
        private readonly IWebHostEnvironment env;
        public Professionals Professional { get; set; }
        public AddProfessionalModel(AppdbContext _db, IWebHostEnvironment _env)
        {
            db = _db;
            env = _env;
        }
        public IActionResult OnGet()
        {
            if (!(HttpContext.Session.GetString("flag") == "true"))
            {
                return RedirectToPage("/Admin/Login");
            }
            return Page();
        }
        public IActionResult OnPost(Professionals Professional)
        {
            if (!(HttpContext.Session.GetString("flag") == "true"))
            {
                return RedirectToPage("/Admin/Login");
            }
            if (!ModelState.IsValid)
            {
                TempData["info"] = "Please Insert Correct Data";
                return Page();
            }
            try
            {
                if (Professional.Picture == null)
                {
                    Professional.PicUrl = null;
                }
                else
                {
                    Professional.PicUrl = Professional.Picture.FileName;
                    var folderpath = Path.Combine(env.WebRootPath, "images");
                    var imagepath = Path.Combine(folderpath, Professional.Picture.FileName);
                    Professional.Picture.CopyTo(new FileStream(imagepath, FileMode.Create));
                }
                db.tbl_professionals.Add(Professional);
                db.SaveChanges();
                TempData["success"] = "Professional Added Successfully";
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
