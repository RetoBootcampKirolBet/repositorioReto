using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSProject.Models
{
    public class User
    {
        public int Id { get; set; }
        [JsonProperty(PropertyName = "id")]
        public int IdUserOpenProject { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string UserRole { get; set; }
        public string Team { get; set; }
        public List<UserWorkPackage> UserWorkPackages { get; set; }

        public static implicit operator User(KSUser v)
        {
            throw new NotImplementedException();
        }
    }
}
