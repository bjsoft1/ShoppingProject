using Microsoft.EntityFrameworkCore;
using ShoppingProject.Models;

namespace ShoppingProject.Datbase
{
    public class DatabaseDesign:DbContext
    {
        public DatabaseDesign(DbContextOptions<DatabaseDesign> options) :base(options)
        { 
            
        }

        public DbSet<UserAccountModels> UserAccounts { get; set; }
        public DbSet<CategoriesModels> CategoriesModels { get; set; }
        public DbSet<CategoriesImages> CategoriesImages { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<UserAccountModels>(b =>
            {
                b.ToTable(nameof(UserAccounts));
                b.HasKey(x=> x.Id).HasAnnotation("SqlServer:Identity", "1, 1");
                b.Property(x=> x.FullName).HasMaxLength(100).IsRequired(true);
                b.Property(x=> x.EmailAddress).HasMaxLength(100).IsRequired(true);
                b.Property(x=> x.ContactNumber).HasMaxLength(15).IsRequired(true);
                b.Property(x=> x.Password).HasMaxLength(200).IsRequired(true);
                b.Property(x=> x.DateOfBirth).IsRequired(false);
                b.Property(x=> x.RoleId).IsRequired(true).HasDefaultValue(2); // 1 Admin // 2 User
                b.Property(x=> x.IsActive).IsRequired(true).HasDefaultValue(true);
                b.Property(x=> x.CreationTime).IsRequired(true);
                b.Property(x=> x.FullName).HasMaxLength(100).IsRequired(true);
                b.HasOne(f => f.ModifireUserAccout).WithMany().HasForeignKey(f => f.ModifierUserId).OnDelete(DeleteBehavior.Restrict);
            });

            mb.Entity<CategoriesModels>(b =>
            {
                b.ToTable(nameof(CategoriesModels));
                b.HasKey(x => x.Id).HasAnnotation("SqlServer:Identity", "1, 1");
                b.Property(x => x.CategoryName).HasMaxLength(100).IsRequired(true);
                b.Property(x => x.IsActive).IsRequired(true).HasDefaultValue(true);
                b.Property(x => x.CreationTime).IsRequired(true);
                b.HasOne(f => f.ModifireUserAccout).WithMany().HasForeignKey(f => f.ModifierUserId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
                b.HasOne(f => f.CreatorUserAccout).WithMany().HasForeignKey(f => f.CreatorUserId).OnDelete(DeleteBehavior.Restrict).IsRequired(true);
            });

            mb.Entity<CategoriesImages>(b =>
            {
                b.ToTable(nameof(CategoriesImages));
                b.HasKey(x => x.Id).HasAnnotation("SqlServer:Identity", "1, 1");
                b.Property(x => x.ImageName).HasMaxLength(100).IsRequired(true);
                b.Property(x => x.ImagePath).HasMaxLength(200).IsRequired(true);
                b.Property(x => x.DisplayName).HasMaxLength(100).IsRequired(true);
                b.HasOne(f => f.CateogryAccount).WithMany(x=>x.CategoriesImages).HasForeignKey(f => f.CategoryId).OnDelete(DeleteBehavior.Restrict).IsRequired(true);
            });

        }
    }
}
