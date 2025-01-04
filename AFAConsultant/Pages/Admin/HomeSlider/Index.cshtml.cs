using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.Pages.Admin.HomeSlider
{
    public class IndexModel : PageModel
    {
		private readonly AppdbContext db;
		public IEnumerable<Slider> Sliders { get; set; }
		public Slider Slider { get; set; }
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
				Sliders = await db.tbl_slider.ToListAsync();
				return Page();
			}
			catch (Exception ex)
			{
				Sliders = new List<Slider>();
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
				Slider = db.tbl_slider.Where(x => x.Id == id).FirstOrDefault();
				db.tbl_slider.Remove(Slider);
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
