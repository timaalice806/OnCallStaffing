﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
                }
            );
        }
        public DbSet<OnCall_Staffing.Models.Employer> Employer { get; set; }
        public DbSet<OnCall_Staffing.Models.Employee> Employee { get; set; }
        public DbSet<OnCall_Staffing.Models.Posting> Posting { get; set; }
        public DbSet<OnCall_Staffing.Models.Address> Address { get; set; }
        public DbSet<OnCall_Staffing.Models.PostingEmployeeJoin> PostingEmployeeJoin { get; set; }
    }
}
