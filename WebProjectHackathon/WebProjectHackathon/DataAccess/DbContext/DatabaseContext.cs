using Microsoft.EntityFrameworkCore;
using System.Data;
using WebProjectHackathon.DataAccess.Entity;

public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public DbSet<ContextHomePagesEntity> ContextHomePages { get; set; }
    public DbSet<MainPanelContextEntity> MainPanelContexts { get; set; }
    public DbSet<CircleContextPagesInfoEntity> CircleContextPagesInfos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        DataSet.Seed(modelBuilder);
    }
}
