using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AFAConsultant.Pages
{
    public class JobApplicationModel : PageModel
    {
        private readonly AppdbContext db;

        private readonly IWebHostEnvironment env;
        public Job Job { get; set; }
        public JobApplicationModel(AppdbContext _db, IWebHostEnvironment env)
        {
            db = _db;
            this.env = env;
        }
        public void OnGet()
        {
            Job = new();
            Job.PicUrl = "null";
        }

        

        public IActionResult OnPost(Job Job)
        {
            if (!ModelState.IsValid)
            {
                TempData["info"] = "Insert your data correctly";
                return Page();
            }
            try
            {
                Job.PicUrl = Job.Picture.FileName;
                var folderPath = Path.Combine(env.WebRootPath, "images");
                var imagePath = Path.Combine(folderPath, Job.Picture.FileName);
                Directory.CreateDirectory(folderPath);
                using (var fileStream = new FileStream(imagePath, FileMode.Create))
                {
                    Job.Picture.CopyTo(fileStream);
                }
                db.tbl_job.Add(Job);
                db.SaveChanges();
                TempData["success"] = "Thank You for joining us we shall come to you shortly";
                return RedirectToPage("/Success");
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error while submitting application try again later";
                return Page();
            }
        }

        public IActionResult OnPostBack()
        {
            return RedirectToPage("/Index");
        }
    }
}
