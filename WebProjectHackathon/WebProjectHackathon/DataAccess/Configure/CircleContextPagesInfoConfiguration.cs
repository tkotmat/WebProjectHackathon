using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebProjectHackathon.DataAccess.Entity;

namespace WebProjectHackathon.DataAccess.Configure
{
    public class CircleContextPagesInfoConfiguration : IEntityTypeConfiguration<CircleContextPagesInfoEntity>
    {
        public void Configure(EntityTypeBuilder<CircleContextPagesInfoEntity> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Description)
                .HasMaxLength(1000);

            builder.HasMany(c => c.mainPanelContext)
                .WithOne(m => m.CircleContextPageInfo)
                .HasForeignKey(m => m.CircleContextPagesInfoEntityId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
