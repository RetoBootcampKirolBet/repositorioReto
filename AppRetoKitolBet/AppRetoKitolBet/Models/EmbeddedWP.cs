using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKirolBet.Models
{
    public class EmbeddedWP
    {
        public int Id { get; set; }
        [JsonProperty(PropertyName = "elements")]
        public List<WorkPackage> WorkPackages { get; set; }

        public _Links _links { get; set; }
        public Description Descriptions { get; set; }
    }
}
