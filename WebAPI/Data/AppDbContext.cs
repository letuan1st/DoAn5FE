using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Creatin Roles for or application

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                    new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                    new { Id = "2", Name = "User", NormalizedName = "USER" }
                    
                );
        }
      
        public DbSet<PhimModel> Phims { get; set; }
        public DbSet<TapPhimModel> TapPhims { get; set; }
        public DbSet<TheLoaiModel> TheLoais { get; set; }
        public DbSet<TLofPhimModel> TLofPhims { get; set; }
        
    }
}