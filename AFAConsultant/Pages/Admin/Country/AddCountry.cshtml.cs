using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AFAConsultant.Pages.Admin.Country
{
    public class AddCountryModel : PageModel
    {
        private readonly AppdbContext db;
        private readonly IWebHostEnvironment env;
        public Countries Country { get; set; }
        public AddCountryModel(AppdbContext _db,IWebHostEnvironment _env)
        {
            db = _db;
            env = _env;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost(Countries Country)
        {
            if (!ModelState.IsValid)
            {
                TempData["info"] = "Please Insert Correct Data";
                return Page();
            }
            try
            {
                if (Country.FlagPicture == null)
                {
                    Country.Flag_PicUrl = null;
                }
                else
                {
                    Country.Flag_PicUrl = Country.FlagPicture.FileName;
                    var folderpath = Path.Combine(env.WebRootPath, "images");
                    var imagepath = Path.Combine(folderpath, Country.FlagPicture.FileName);
                    Country.FlagPicture.CopyTo(new FileStream(imagepath, FileMode.Create));
                }
                if(Country.CountryPicture == null)
                {
                    Country.Country_PicUrl = null;
                }
                else
                {
                    Country.Country_PicUrl = Country.CountryPicture.FileName;
                    var folderpath = Path.Combine(env.WebRootPath, "images");
                    var imagepath = Path.Combine(folderpath, Country.CountryPicture.FileName);
                    Country.CountryPicture.CopyTo(new FileStream(imagepath, FileMode.Create));
                }
                db.tbl_countries.Add(Country);
                db.SaveChanges();
                TempData["success"] = "Country Added Successfully";
                return RedirectToPage("index");
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error While Adding Record";
                return Page();
            }
        }
    }
}
