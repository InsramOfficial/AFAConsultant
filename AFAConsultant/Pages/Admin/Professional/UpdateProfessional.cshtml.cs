using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AFAConsultant.Pages.Admin.Professional
{
    public class UpdateProfessionalModel : PageModel
    {
        private readonly AppdbContext db;
        private readonly IWebHostEnvironment env;
        public Professionals Professional { get; set; }
        public UpdateProfessionalModel(AppdbContext _db, IWebHostEnvironment _env)
        {
            db = _db;
            env = _env;
        }
        public async Task OnGetAsync(int id)
        {
            try
            {
                Professional = await db.tbl_professionals.FindAsync(id);
                TempData["picurl"] = Professional.PicUrl;
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error Occur While Getting Data";
            }
        }
        public IActionResult OnPost(Professionals Professional)
        {
            if (!ModelState.IsValid)
            {
                TempData["info"] = "Please Insert Correct Data";
                return Page();
            }
            try
            {
                if (Professional.Picture == null)
                {
                    Professional.PicUrl = Professional.PicUrl;
                }
                else
                {
                    Professional.PicUrl = Professional.Picture.FileName;
                    var folderpath = Path.Combine(env.WebRootPath, "images");
                    var imagepath = Path.Combine(folderpath, Professional.Picture.FileName);
                    Professional.Picture.CopyTo(new FileStream(imagepath, FileMode.Create));
                }
                db.tbl_professionals.Update(Professional);
                db.SaveChanges();
                TempData["success"] = "Professional Updated Successfully";
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