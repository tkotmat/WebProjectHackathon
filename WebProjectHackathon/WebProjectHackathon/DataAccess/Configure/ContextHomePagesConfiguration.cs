using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebProjectHackathon.DataAccess.Entity;

namespace WebProjectHackathon.DataAccess.Configure
{
    public class ContextHomePagesConfiguration : IEntityTypeConfiguration<ContextHomePagesEntity>
    {
        public void Configure(EntityTypeBuilder<ContextHomePagesEntity> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Description)
                .HasMaxLength(1000);

            builder.HasMany(c => c.CircleContextPagesInfo)
                .WithOne(c => c.ContextHomePage)
                .HasForeignKey(c => c.IdContextHomePages)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
