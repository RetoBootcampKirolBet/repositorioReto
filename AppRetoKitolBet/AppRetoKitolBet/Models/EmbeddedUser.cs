using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class EmbeddedUser
    {
        [JsonProperty(PropertyName = "elements")]
        //public List<WorkPackage> WorkPackages { get; set; }
        public List<User> Users { get; set; }

        public _Links _links { get; set; }
    }
}
