using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class NewsDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        public NewsDbContext(DbContextOptions<NewsDbContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    new ExchangeRateEntityTypeConfiguration()
        //        .Configure(modelBuilder.Entity<ExchangeRate>());
        //    new CurrencyEntityTypeConfiguration()
        //        .Configure(modelBuilder.Entity<Currency>());
        //    new CountryEntityTypeConfiguration()
        //        .Configure(modelBuilder.Entity<Country>());
        //}

        //protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        //{
        //    configurationBuilder
        //        .Properties<Currency>()
        //        .HaveConversion<CurrencyEntityTypeConverter>();
        //}
    }
}
