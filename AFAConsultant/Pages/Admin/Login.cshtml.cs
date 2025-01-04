using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.Pages.Admin
{
    public class LoginModel : PageModel
    {
        private readonly AppdbContext db;
        private readonly IWebHostEnvironment env;
        [BindProperty]
        public Login? login {  get; set; }
        public LoginModel(AppdbContext _db, IWebHostEnvironment _env)
        {
            db = _db;
            env = _env;
        }
        public IActionResult OnGet()
        {
            if ((HttpContext.Session.GetString("flag") == "true"))
            {
                TempData["warning"] = "You are already logged in";
                return RedirectToPage("/Admin/Index");
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(Login login)
        {
            if (!ModelState.IsValid)
            {
                TempData["info"] = "Insert your data correctly";
                return Page();
            }
            else
            {
                try
                {
                    User user = new();
                    user = await db.tbl_user.Where(x => x.Username == login.Username && x.Password == login.Password).FirstOrDefaultAsync();
                    if (user == null)
                    {
                        TempData["error"] = "Invalid username or password.";
                        return RedirectToPage("/Admin/Login");
                    }
                    else
                    {
                        HttpContext.Session.SetString("FullName", user.FullName);
                        HttpContext.Session.SetString("flag", "true");
                        HttpContext.Session.SetString("userid", user.Id.ToString());
                        TempData["success"] = "Login successful!";
                        return RedirectToPage("/Admin/index");
                    }
                }
                catch (Exception ex)
                {
                    TempData["error"] = "User Not Found";
                    return RedirectToPage();
                }
                
                
            }
        }
        public IActionResult OnPostLogout()
        {
            if (HttpContext.Session.GetString("flag") == "true")
            {
                HttpContext.Session.Clear();
                TempData["success"] = "Logout Successfully!";
                return RedirectToPage("/Admin/Login");
            }
            else
            {
                return RedirectToPage("/Admin/Login");
            }
        }
    }
}
