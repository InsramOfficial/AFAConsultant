using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.ViewComponents
{
    public class IconViewComponent : ViewComponent
    {
        private readonly AppdbContext db;
        
        public Settings Settings { get; set; }

        public IconViewComponent(AppdbContext _db)
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
