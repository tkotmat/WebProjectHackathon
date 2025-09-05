using Microsoft.EntityFrameworkCore;
using WebProjectHackathon.DataAccess.Configure;
using WebProjectHackathon.DataAccess.Entity;

public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public DbSet<ContextHomePagesEntity> ContextHomePages { get; set; }
    public DbSet<MainPanelContextEntity> MainPanelContexts { get; set; }
    public DbSet<CircleContextPagesInfoEntity> CircleContextPagesInfos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ContextHomePagesConfiguration());
        modelBuilder.ApplyConfiguration(new CircleContextPagesInfoConfiguration());
        modelBuilder.ApplyConfiguration(new MainPanelContextConfiguration());

        DataSet.Seed(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }
}
