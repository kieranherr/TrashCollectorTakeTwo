﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TrashCollector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            },
            new IdentityRole
            {
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            }
            );
        }
        public DbSet<TrashCollector.Models.Customer> Customer { get; set; }
        public DbSet<TrashCollector.Models.Employee> Employee { get; set; }
    }
}
