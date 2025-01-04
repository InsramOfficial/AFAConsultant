using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.Pages.Admin.Country
{
    public class IndexModel : PageModel
    {
        private readonly AppdbContext db;
        public IEnumerable<Countries> countries { get; set; }
        public Countries country { get; set; }
        public IndexModel(AppdbContext _db)
        {
            db = _db;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            if (!(HttpContext.Session.GetString("flag") == "true"))
            {
                return RedirectToPage("/Admin/Login");
            }
            try
            {
                countries = await db.tbl_countries.ToListAsync();
                return Page();
            }
            catch (Exception ex)
            {
                countries = new List<Countries>();
                return Page();
            }
        }
        public IActionResult OnGetDelete(int id)
        {
            if (!(HttpContext.Session.GetString("flag") == "true"))
            {
                return RedirectToPage("/Admin/Login");
            }
            try
            {
                country = db.tbl_countries.Where(x => x.Id == id).FirstOrDefault();
                db.tbl_countries.Remove(country);
                db.SaveChanges();
                TempData["success"] = "Record Deleted Successfully";
                return RedirectToPage();
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error While Deleting Record";
                return RedirectToPage();
            }
        }
    }
}
