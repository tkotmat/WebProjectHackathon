using Microsoft.EntityFrameworkCore;
using WebProjectHackathon.DataAccess.DbContext.Seed;

public class DataSet
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        HomePagesSeed.Seed(modelBuilder);
        FrondEndSeed.Seed(modelBuilder);
        BackEndSeed.Seed(modelBuilder);
        HrSeed.Seed(modelBuilder);
        UiUxSeed.Seed(modelBuilder);
    }
}
