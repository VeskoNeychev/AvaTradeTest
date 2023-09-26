using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Database
{
    public class AvaTradeContextDbFactory : IDesignTimeDbContextFactory<AvaTradeContext>
    {
        public AvaTradeContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AvaTradeContext>();

            builder.UseSqlServer(new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build()
                .GetConnectionString("DefaultConnection"));

            return new AvaTradeContext(builder.Options);
        }
    }
}
