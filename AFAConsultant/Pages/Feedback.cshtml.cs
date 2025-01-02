using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AFAConsultant.Pages
{
    public class FeedbackModel : PageModel
    {
        private readonly AppdbContext db;

        private IWebHostEnvironment env;
        public FeedbackModel(AppdbContext _db, IWebHostEnvironment env)
        {
            db = _db;
            this.env = env;
        }
        public Review ClientReview { get; set; }

        [HttpPost]
        public IActionResult OnPost(Review ClientReview)
        {
            if (!ModelState.IsValid)
            {
                TempData["info"] = "Insert your data correctly";

                // Debugging Validation Errors
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }

                return Page();
            }

            try
            {
                if (ClientReview.Picture != null)
                {
                    ClientReview.PicUrl = ClientReview.Picture.FileName;
                    var folderPath = Path.Combine(env.WebRootPath, "images");
                    var imagePath = Path.Combine(folderPath, ClientReview.Picture.FileName);
                    Directory.CreateDirectory(folderPath);  
                    using (var fileStream = new FileStream(imagePath, FileMode.Create))
                    {
                        ClientReview.Picture.CopyTo(fileStream);
                    }
                }

                db.tbl_review.Add(ClientReview);
                db.SaveChanges();
                TempData["success"] = "Thank you for your review";
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