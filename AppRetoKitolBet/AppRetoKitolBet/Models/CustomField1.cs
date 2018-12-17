using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKirolBet.Models
{
    public class CustomField1
    {
        public int Id { get; set; }
        public List<CustomField1> customField1 { get; set; }
        [JsonProperty(PropertyName = "Title")]
        public string Sprint { get; set; }
    }
}
