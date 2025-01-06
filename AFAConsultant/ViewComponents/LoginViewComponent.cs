using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.ViewComponents
{
    public class LoginViewComponent : ViewComponent
    {
        private readonly AppdbContext db;

        public Settings Settings { get; set; }

        public LoginViewComponent(AppdbContext _db)
        {
            db = _db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Settings = await db.tbl_settings.FirstOrDefaultAsync();
            return View(Settings);
        }
    }
}
