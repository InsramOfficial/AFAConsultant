using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.Pages.Admin.Contact
{
    public class UpdateContactUsModel : PageModel
    {
        private readonly AppdbContext db;
        public Contactus contact {  get; set; }
        public UpdateContactUsModel(AppdbContext _db)
        {
            db = _db;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            if (!(HttpContext.Session.GetString("flag") == "true"))
            {
                return RedirectToPage("/Admin/Login");
            }
            contact = await db.tbl_contactus.FirstOrDefaultAsync();
            return Page();
        }

        public IActionResult OnPost(Contactus contact)
        {
            if (!(HttpContext.Session.GetString("flag") == "true"))
            {
                return RedirectToPage("/Admin/Login");
            }
            if (!ModelState.IsValid)
            {
                TempData["info"] = "Please Insert Correct data";
                return Page();
            }
            try
            {
                db.tbl_contactus.Update(contact);
                db.SaveChanges();
                TempData["success"] = "Data Updated Successfully";
                return RedirectToPage();
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error While Updating Record";
                return Page();
            }
        }
    }
}
