using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKirolBet.Models
{
    public class TypeWP
    {
        public int Id { get; set; }
        public List<TypeWP> Type { get; set; }
        [JsonProperty(propertyName: "Title")]
        [DisplayName("Type")]
        public string Tipo { get; set; }
    }
}
