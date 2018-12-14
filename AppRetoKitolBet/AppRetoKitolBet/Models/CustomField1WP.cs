using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKirolBet.Models
{
    public class CustomField1WP
    {
        public int Id { get; set; }
        public List<CustomField1WP> customField1WPs { get; set; }
        [JsonProperty(PropertyName = "Title")]
        public string Sprint { get; set; }
    }
}
