using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppRetoKitolBet.Models;

namespace AppRetoKitolBet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AppRetoKitolBet.Models.WorkPackage> WorkPackage { get; set; }
        public DbSet<AppRetoKitolBet.Models.User> User { get; set; }
        public DbSet<AppRetoKitolBet.Models.ResponseWP> ResponseWP { get; set; }
        public DbSet<AppRetoKitolBet.Models.ResponseUser> ResponseUser { get; set; }
        public DbSet<AppRetoKitolBet.Models.UserWorkPackage> UserWorkPackage { get; set; }
    }
}
