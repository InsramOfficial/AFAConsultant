using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AFAConsultant.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppdbContext db;
        public QueryMessage message { get; set; }
        public IndexModel(ILogger<IndexModel> logger,AppdbContext _db)
        {
            db = _db;
            _logger = logger;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost(QueryMessage message)
        {
            if (!ModelState.IsValid)
            {
                TempData["info"] = "Please insert required fields";
                return Page();
            }
            try
            {
                db.tbl_querymessages.Add(message);
                db.SaveChanges();
                TempData["success"] = "Thank You for your Message we'll come to you shortly";
                return RedirectToPage("/Success");
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error occur while send your message please try again later Thank you for you cooperation";
                return Page();
            }
        }
    }
}
