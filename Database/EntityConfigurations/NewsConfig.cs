using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.EntityConfigurations
{
    public class NewsConfig : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder
                .HasOne(n => n.Publisher)
                .WithMany(p => p.News)
                .HasForeignKey(p => p.NewsId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
