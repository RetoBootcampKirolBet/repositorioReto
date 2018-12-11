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
        public DbSet<KirolBetServices.Models.WorkPackage> WorkPackage { get; set; }
        public DbSet<KirolBetServices.Models.User> User { get; set; }
        public DbSet<KirolBetServices.Models.ResponseWP> ResponseWP { get; set; }
        public DbSet<KirolBetServices.Models.ResponseUser> ResponseUser { get; set; }
    }
}
