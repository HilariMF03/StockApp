using Microsoft.EntityFrameworkCore;
using StockApp.Core.Domain.Entities;

namespace StockApp.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Table
            modelBuilder.Entity<Product>()
                .ToTable("Products");

            modelBuilder.Entity<Category>()
                .ToTable("Category");

            #endregion

            #region PrimaryKey
            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Category>()
                .HasKey(c => c.Id);

            #endregion

            #region Relationships
            modelBuilder.Entity<Category>()
                .HasMany<Product>(category => category.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Property configuration

            #region Product
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired();

            modelBuilder.Entity<Product>()
              .Property(p => p.Price)
              .IsRequired();
            #endregion

            #region Category
            modelBuilder.Entity<Category>()
              .Property(p => p.Name)
              .IsRequired()
              .HasMaxLength(100);
            #endregion

            #endregion
        }
    }
}
