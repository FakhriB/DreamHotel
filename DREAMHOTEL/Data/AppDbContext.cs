using Microsoft.EntityFrameworkCore;

namespace DREAMHOTEL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }


    }
}
