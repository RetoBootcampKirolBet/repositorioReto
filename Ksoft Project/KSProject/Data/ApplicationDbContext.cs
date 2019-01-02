using System;
using System.Collections.Generic;
using System.Text;
using KSProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KSProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<KSUser,IdentityRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<KSProject.Models.User> User { get; set; }
        public DbSet<KSProject.Models.WorkPackage> WorkPackage { get; set; }
        public DbSet<KSProject.Models.UserWorkPackage> UserWorkPackage { get; set; }
        public DbSet<KSProject.Models.ResponseWP> ResponseWP { get; set; }
        public DbSet<KSProject.Models.ResponseUser> ResponseUser { get; set; }
    }
}
