using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.Pages.Admin.QueryMessages
{
    public class IndexModel : PageModel
    {
		private readonly AppdbContext db;
		public IEnumerable<QueryMessage> Messages { get; set; }
		public QueryMessage Message { get; set; }
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
				Messages = await db.tbl_querymessages.ToListAsync();
				return Page();
			}
			catch (Exception ex)
			{
				Messages = new List<QueryMessage>();
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
				Message = db.tbl_querymessages.Where(x => x.Id == id).FirstOrDefault();
				db.tbl_querymessages.Remove(Message);
				db.SaveChanges();
				TempData["success"] = "Message Deleted Successfully";
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
