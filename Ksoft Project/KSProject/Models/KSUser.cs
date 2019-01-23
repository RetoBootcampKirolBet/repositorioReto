using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Peio Murguia (pei@c.com , Pei0.murgu) jefe OT
//Endika Sanchez (end@c.com , End1.sanch) OT
//Igone Ortiz (igo@c.com , Ig0n.ortiz) jefe RT
//Lorena Martinez (lor@c.com , Lor3n.mart) RT
//Miguel Dans (mig@c.com , Migu3.dans) jefe GT
//David Esteve (dav@c.com , Dav1.deste) GT
//John Carrasco (jcarrascobar@gmail.com , Jon.c4rras) admin

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
