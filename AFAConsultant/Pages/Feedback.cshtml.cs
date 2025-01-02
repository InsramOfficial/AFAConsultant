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
        public Review Review { get; set; }
        public IActionResult OnPost(Review Review)
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
                Review.PicUrl = Review.Picture.FileName;
                db.tbl_review.Add(Review);
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