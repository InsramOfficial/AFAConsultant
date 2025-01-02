using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AFAConsultant.Pages
{
    public class JobApplicationModel : PageModel
    {
        private readonly AppdbContext db;

        private IWebHostEnvironment env;
        public JobApplicationModel(AppdbContext _db, IWebHostEnvironment env)
        {
            db = _db;
            this.env = env;
        }
        
        public JobApplication JobApplications { get; set; }

        [HttpPost]
        public IActionResult OnPost(JobApplication JobApplications)
        {
            if (!ModelState.IsValid)
            {
                TempData["info"] = "Insert your data correctly";

                
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }

                return Page();
            }

            try
            {
                if (JobApplications.Picture != null)
                {
                    JobApplications.PicUrl = JobApplications.Picture.FileName;
                    var folderPath = Path.Combine(env.WebRootPath, "images");
                    var imagePath = Path.Combine(folderPath, JobApplications.Picture.FileName);
                    Directory.CreateDirectory(folderPath);
                    using (var fileStream = new FileStream(imagePath, FileMode.Create))
                    {
                        JobApplications.Picture.CopyTo(fileStream);
                    }
                }

                db.jobApplications.Add(JobApplications);
                db.SaveChanges();
                TempData["success"] = "Thank you";
                return RedirectToPage();
            }
            catch (Exception ex)
            {
                TempData["error"] = $"Error while submitting review: {ex.Message}";
                return Page();
            }
        }
    }
}
