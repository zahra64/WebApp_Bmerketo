using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;

namespace WebApp.Contexts;

public class DataContext : IdentityDbContext<UserEntity>
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<UserAddressEntity> UserAddresses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole {
                Id = "c8489980-6fd1-40d9-b059-b8593debae14",
                Name = "admin",
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
    }
}
