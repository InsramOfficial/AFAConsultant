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
        public async Task OnGetAsync()
        {
            try
            {
                Jobs = await db.tbl_job.ToListAsync();
            }
            catch (Exception ex)
            {
                Jobs = new List<Job>();
            }
        }
        public IActionResult OnGetDelete(int id)
        {
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
