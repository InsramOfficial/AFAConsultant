using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AFAConsultant.Pages.Admin.UserProfile
{
    public class IndexModel : PageModel
    {
        private readonly AppdbContext db;
        private readonly IWebHostEnvironment env;

        public User user { get; set; }

        public string ImageName = "";

        public IndexModel(AppdbContext _db, IWebHostEnvironment _env)
        {
            db = _db;
            env = _env;
        }


        public IActionResult OnGet()
        {
            if (!(HttpContext.Session.GetString("flag") == "true"))
            {
                return RedirectToPage("/Admin/Login");
            }
            user = db.tbl_user.FirstOrDefault();
            ImageName = user.ImageName;
            return Page();
        }

        public IActionResult OnPost(User user)
        {
            if (!(HttpContext.Session.GetString("flag") == "true"))
            {
                return RedirectToPage("/Admin/Login");
            }
            if (!ModelState.IsValid)
            {
                TempData["info"] = "Insert your data correctly";
                return Page();
            }
            else
            {
                try
                {
                    User update = new();
                    update.Id = user.Id;
                    update.Username = user.Username;
                    update.Password = user.Password;
                    update.FullName = user.FullName;

                    if (user.Image is null)
                    {
                        update.ImageName = user.ImageName;
                    }
                    else
                    {
                        update.ImageName = user.Image.FileName;
                        var folderpath = Path.Combine(env.WebRootPath, "images");
                        var imagepath = Path.Combine(folderpath, user.Image.FileName);
                        user.Image.CopyTo(new FileStream(imagepath, FileMode.Create));
                    }
                    db.tbl_user.Update(update);
                    db.SaveChanges();
                    TempData["success"] = "Your Profile Save and Updated Successfully";
                    return RedirectToPage("/Admin/UserProfile/Index");
                }
                catch (Exception ex)
                {
                    TempData["error"] = "Error While Updating Your Profile";
                    return Page();
                }
            }
        }
    }
}
