using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnCall_Staffing.Models;

namespace OnCall_Staffing.Data
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
                    Name = "Employer",
                    NormalizedName = "EMPLOYER"
                },
                new IdentityRole
                {
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                });

            builder.Entity<PostingEmployeeJoin>()
                .HasKey(pe => new { pe.PostingID, pe.EmployeeID });
            builder.Entity<PostingEmployeeJoin>()
                .HasOne(pe => pe.Posting)
                .WithMany(p => p.PostingEmployeeJoins)
                .HasForeignKey(pe => pe.PostingID);
            builder.Entity<PostingEmployeeJoin>()
                .HasOne(pe => pe.Employee)
                .WithMany(e => e.PostingEmployeesJoins)
                .HasForeignKey(pe => pe.EmployeeID);
            
        }
        public DbSet<OnCall_Staffing.Models.Employer> Employer { get; set; }
        public DbSet<OnCall_Staffing.Models.Employee> Employee { get; set; }
        public DbSet<OnCall_Staffing.Models.Posting> Posting { get; set; }
        public DbSet<OnCall_Staffing.Models.Address> Address { get; set; }
        public DbSet<OnCall_Staffing.Models.PostingEmployeeJoin> PostingEmployeeJoin { get; set; }
    }
}
