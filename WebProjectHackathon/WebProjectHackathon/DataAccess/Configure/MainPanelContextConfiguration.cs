using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebProjectHackathon.DataAccess.Entity;

namespace WebProjectHackathon.DataAccess.Configure
{
    public class MainPanelContextConfiguration : IEntityTypeConfiguration<MainPanelContextEntity>
    {
        public void Configure(EntityTypeBuilder<MainPanelContextEntity> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(m => m.Context)
                .HasMaxLength(1000);

            builder.Property(m => m.Url)
                .HasMaxLength(500);

            builder.HasOne(m => m.CircleContextPageInfo)
                .WithMany(c => c.mainPanelContext)
                .HasForeignKey(m => m.CircleContextPagesInfoEntityId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
