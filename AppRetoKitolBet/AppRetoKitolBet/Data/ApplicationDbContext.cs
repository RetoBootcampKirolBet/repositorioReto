using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppRetoKirolBet.Models;
using Microsoft.AspNetCore.Identity;

namespace AppRetoKirolBet.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser,IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AppRetoKirolBet.Models.WorkPackage> WorkPackage { get; set; }
        public DbSet<AppRetoKirolBet.Models.User> User { get; set; }
        public DbSet<AppRetoKirolBet.Models.ResponseWP> ResponseWP { get; set; }
        public DbSet<AppRetoKirolBet.Models.ResponseUser> ResponseUser { get; set; }
        public DbSet<AppRetoKirolBet.Models.UserWorkPackage> UserWorkPackage { get; set; }
    }
}
