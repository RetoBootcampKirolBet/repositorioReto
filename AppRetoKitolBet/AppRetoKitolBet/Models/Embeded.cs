using Newtonsoft.Json;
using System.Collections.Generic;

namespace AppRetoKitolBet.Models
{
    public class Embeded
    {
        [JsonProperty(PropertyName = "elements")]
        public List<WorkPackage> WorkPackages { get; set; }

        public _Links _links { get; set; }
        public Description Descriptions { get; set; }

    }
}