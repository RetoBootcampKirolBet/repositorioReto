using System;
using System.Collections.Generic;
using System.Text;
using KSoftProject2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KSoftProject2.Data
{
    public class ApplicationDbContext : IdentityDbContext<KSUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<KSoftProject2.Models.User> User { get; set; }
        public DbSet<KSoftProject2.Models.WorkPackage> WorkPackage { get; set; }
        public DbSet<KSoftProject2.Models.UserWorkPackage> UserWorkPackage { get; set; }
        public DbSet<KSoftProject2.Models.ResponseWP> ResponseWP { get; set; }
        public DbSet<KSoftProject2.Models.ResponseUser> ResponseUser { get; set; }
        public DbSet<KSoftProject2.Models.Calendario> Calendario { get; set; }
        public DbSet<KSoftProject2.Models.Oporrak> Oporrak { get; set; }
        public DbSet<KSoftProject2.Models.Persona> Persona { get; set; }
        public DbSet<KSoftProject2.Models.CalendarioPersona> CalendarioPersona { get; set; }
        public DbSet<KSoftProject2.Models.Dedication> Dedication { get; set; }

    }
}
