using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppdbContext db;
        public QueryMessage message { get; set; }
        public Aboutus Aboutus { get; set; }
        public Contactus Contactus { get; set; }
        public IEnumerable<Countries> Countries { get; set; }
        public IEnumerable<Professionals> Professionals { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public List<Slider> slider { get; set; }
        public IndexModel(ILogger<IndexModel> logger,AppdbContext _db)
        {
            db = _db;
            _logger = logger;
        }
        public async Task OnGetAsync()
        {
            Aboutus = await db.tbl_aboutus.FirstOrDefaultAsync();
            Contactus = await db.tbl_contactus.FirstOrDefaultAsync();
            Countries = await db.tbl_countries.ToListAsync();
            Professionals = await db.tbl_professionals.ToListAsync();
            Reviews = await db.tbl_review.ToListAsync();
            slider = await db.tbl_slider.ToListAsync();
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
