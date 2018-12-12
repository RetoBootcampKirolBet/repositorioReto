using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class AppRole:IdentityRole
    {
        public string Permission { get; set; }
        

        public AppRole() : base()
        {

        }

        public AppRole(string roleName) : base(roleName)
        {

        }

      
    }
}
