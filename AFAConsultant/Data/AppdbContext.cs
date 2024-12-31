using Microsoft.EntityFrameworkCore;

namespace AFAConsultant.Data
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions<AppdbContext> options) : base(options)
        {
            
        }

    }
}
