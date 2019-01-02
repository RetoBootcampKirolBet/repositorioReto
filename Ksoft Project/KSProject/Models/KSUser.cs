using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSProject.Models
{
    public class KSUser:IdentityUser
    {
        public KSUser() : base()
        {
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
