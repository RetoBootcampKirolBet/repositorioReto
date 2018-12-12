using Newtonsoft.Json;
using System.Collections.Generic;

namespace AppRetoKitolBet.Models
{
    public class EmbededWP
    {
        public int Id { get; set; }
        [JsonProperty(PropertyName = "elements")]
        public List<WorkPackage> WorkPackages { get; set; }

        public _Links _links { get; set; }
        public Description Descriptions { get; set; }

    }
}