using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.Pages.Admin.Professional
{
    public class IndexModel : PageModel
    {
		private readonly AppdbContext db;
		public IEnumerable<Professionals> Professionals { get; set; }
		public Professionals Professional { get; set; }
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
				Professionals = await db.tbl_professionals.ToListAsync();
				return Page();
			}
			catch (Exception ex)
			{
				Professionals = new List<Professionals>();
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
				Professional = db.tbl_professionals.Where(x => x.Id == id).FirstOrDefault();
				db.tbl_professionals.Remove(Professional);
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
