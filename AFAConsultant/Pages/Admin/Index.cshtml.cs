using AFAConsultant.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AFAConsultant.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly AppdbContext db;
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

            int Professionals =db.tbl_professionals.Count();
            int Reviews = db.tbl_review.Count();
            int Messages = db.tbl_querymessages.Count();
            int Country=db.tbl_countries.Count();

            ViewData["Professionals"] = Professionals;
            ViewData["Reviews"] = Reviews;
            ViewData["Messages"] = Messages;
            ViewData["Country"] = Country;
            return Page();
        }
    }
}
