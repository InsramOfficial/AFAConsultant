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
		public async Task OnGetAsync()
		{
			try
			{
				Messages = await db.tbl_querymessages.ToListAsync();
			}
			catch (Exception ex)
			{
				Messages = new List<QueryMessage>();
			}
		}
		public IActionResult OnGetDelete(int id)
		{
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
