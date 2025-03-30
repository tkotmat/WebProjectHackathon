using Microsoft.EntityFrameworkCore;
using WebProjectHackathon.Models;

namespace WebProjectHackathon.Context
{
    public class ContextMainDatabase : DbContext
    {
        public ContextMainDatabase(DbContextOptions<ContextMainDatabase> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
    }
}
