using AlisonSilvaIdentityUser.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AlisonSilvaIdentityUser.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
        IdentityDbContext<ApplicationUser, Roles, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>(options)
    {
        public DbSet<ApplicationUser>? ApplicationUsers { get; set; }
        public DbSet<Roles>? Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Roles>()
                .HasKey(u => u.Id);

            builder.Entity<ApplicationUser>()
                .HasKey(u => u.Id);

            builder.Entity<ApplicationUser>()
                .Property(u => u.NomeCompleto)
                    .HasMaxLength(150)
                        .IsRequired();

            builder.Entity<ApplicationUser>()
                .Property(u => u.RG)
                    .HasMaxLength(12)
                        .IsRequired();

            builder.Entity<ApplicationUser>()
                .Property(u => u.CPF)
                    .HasMaxLength(14)
            .IsRequired();

            builder.Entity<IdentityUserLogin<int>>().HasNoKey();

            builder.Entity<IdentityUserRole<int>>().HasNoKey();

            builder.Entity<IdentityUserToken<int>>().HasNoKey();

            builder.Entity<Roles>()
                .HasMany(r => r.Users)
                    .WithOne(u => u.Role)
                        .IsRequired()
                            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
