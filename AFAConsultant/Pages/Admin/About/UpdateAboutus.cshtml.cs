using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.Pages.Admin.About
{
    public class UpdateAboutusModel : PageModel
    {
        private readonly AppdbContext db;

        public Aboutus aboutus {  get; set; }
        public UpdateAboutusModel(AppdbContext _db)
        {
            db = _db;
        }
        public async Task OnGet()
        {
            aboutus = await db.tbl_aboutus.FirstOrDefaultAsync();
        }

        public IActionResult Onpost(Aboutus aboutus)
        {
            try
            {
                db.tbl_aboutus.Update(aboutus);
                db.SaveChanges();
                TempData["success"] = "Record Updated Successfully";
                return RedirectToPage();
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error While Updating Record";
                return Page();
            }
        }
    }
}
