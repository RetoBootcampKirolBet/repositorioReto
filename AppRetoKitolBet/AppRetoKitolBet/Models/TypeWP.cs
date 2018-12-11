using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class TypeWP
    {
        public List<Type> type { get; set; }
        [JsonProperty(propertyName: "Title")]
        public string Tipo { get; set; }
    }
}
