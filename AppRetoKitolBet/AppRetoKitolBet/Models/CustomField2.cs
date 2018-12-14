using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKirolBet.Models
{
    public class CustomField2
    {
        public int Id { get; set; }
        public List<CustomField2> CustomField2s { get; set; }
        [JsonProperty(PropertyName = "Title")]
        public string KsoftProject { get; set; }
    }
}
