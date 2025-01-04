using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AFAConsultant.Pages.Admin.JobApplications
{
    public class JobApplicationDetailModel : PageModel
    {
        private readonly AppdbContext db;

        private readonly IWebHostEnvironment env;
        public JobApplicationDetailModel(AppdbContext db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }
        public Job Job { get; set; }
        public void OnGet(int id)
        {
            Job = db.tbl_job.Where(s => s.Id == id).FirstOrDefault();
        }
    }
}
