using AFAConsultant.Data;
using AFAConsultant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.ViewComponents
{
    public class UsersViewComponent : ViewComponent
    {
        private readonly AppdbContext db;
        public User user { get; set; }
        public UsersViewComponent(AppdbContext _db)
        {
            db = _db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            user = await db.tbl_user.FirstOrDefaultAsync();
            return View(user);
        }

    }
}
