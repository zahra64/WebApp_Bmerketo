using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using WebApp.Models.Entities;
using static WebApp.Models.Entities.TagEntity;

namespace WebApp.Contexts;

public class DataContext : IdentityDbContext<UserEntity>
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<UserAddressEntity> UserAddresses { get; set; }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<TagEntity> Tags { get; set; }

    public DbSet<ProductTagEntity> ProductTags { get; set; }
    public DbSet<ContactFormEntity> ContactForms { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole {
                Id = "c8489980-6fd1-40d9-b059-b8593debae14",
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            },
            new IdentityRole
            {
                Id = "187664d6-1cbe-484d-a9e6-184a44c63323",
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            });


        var passwordHasher = new PasswordHasher<UserEntity>();
        var userEntity = new UserEntity
            {
                Id = "f900fcab-87e3-4d4f-a751-3e7bcc0f3755",
                UserName = "admin@domain.com",
                NormalizedUserName = "ADMIN@DOMAIN.COM",
                Email = "admin@domain.com",
                NormalizedEmail = "ADMIN@DOMAIN.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };
        userEntity.PasswordHash = passwordHasher.HashPassword(userEntity,"HEj1111!");
        builder.Entity<UserEntity>().HasData(userEntity);


        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            UserId = userEntity.Id,
            RoleId = "c8489980-6fd1-40d9-b059-b8593debae14"
        });


        builder.Entity<TagEntity>().HasData(
            new { Id = 1, TagName = "new" },
            new { Id = 2, TagName = "featured" },
            new { Id = 3, TagName = "popular" }
        );
        builder.Entity<ProductEntity>().HasData(
            new ProductEntity { Id = 1, Title = "Gaming RGB GR900 ", Price = 200, ImageUrl = "https://www.dustinhome.se/product/5011133361/gaming-rgb-gr900", Description = "Voxicon GR900 har snabb responstid. Skärmen svarar direkt när du klickar på eller flyttar musen vilket ökar precisionen i ditt spelande" }
        );
        builder.Entity<ProductTagEntity>().HasData(
            new ProductTagEntity { ProductId = 1, TagId = 1 }
        );

    }
}
