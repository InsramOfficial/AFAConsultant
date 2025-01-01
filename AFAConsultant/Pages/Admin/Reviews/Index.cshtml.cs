using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.Pages.Admin.Reviews
{
    public class IndexModel : PageModel
    {
		private readonly AppdbContext db;
		public IEnumerable<Review> reviews { get; set; }
		public Review Review { get; set; }
		public IndexModel(AppdbContext _db)
		{
			db = _db;
		}
		public async Task OnGetAsync()
		{
			try
			{
				reviews = await db.tbl_review.ToListAsync();
			}
			catch (Exception ex)
			{
				reviews = new List<Review>();
			}
		}
		public IActionResult OnGetDelete(int id)
		{
			try
			{
				Review = db.tbl_review.Where(x => x.Id == id).FirstOrDefault();
				db.tbl_review.Remove(Review);
				db.SaveChanges();
				TempData["success"] = "Review Deleted Successfully";
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
