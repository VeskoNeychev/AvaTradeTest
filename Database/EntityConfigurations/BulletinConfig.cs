using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.EntityConfigurations
{
    public class BulletinConfig : IEntityTypeConfiguration<Bulletin>
    {
        public void Configure(EntityTypeBuilder<Bulletin> builder)
        {
            builder
                .HasMany(b => b.News)
                .WithOne(n => n.Bulletin)
                .HasForeignKey(n => n.BulletinId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
