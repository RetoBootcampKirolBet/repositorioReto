using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class User
    {
        public int IdUserLocal { get; set; }
        [JsonProperty(PropertyName = "Id")]//falta hacer esto
        public int IdUserOpenProject { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public List<UserWorkPackage> UserWorkPackages { get; set; }
    }
}
