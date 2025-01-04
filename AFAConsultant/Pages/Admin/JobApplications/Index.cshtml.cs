using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.Pages.Admin.JobApplications
{
    public class IndexModel : PageModel
    {
        private readonly AppdbContext db;

        public IEnumerable<Job> Jobs { get; set; }
        public Job Job { get; set; }
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
                Jobs = await db.tbl_job.ToListAsync();
                return Page();
            }
            catch (Exception ex)
            {
                Jobs = new List<Job>();
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
                Job = db.tbl_job.Where(x => x.Id == id).FirstOrDefault();
                db.tbl_job.Remove(Job);
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
