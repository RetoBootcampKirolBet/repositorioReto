using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSProject.Models
{
    public class TypeWP
    {
        public int Id { get; set; }
        public List<TypeWP> Type { get; set; }
        [JsonProperty(propertyName: "Title")]
        public string Tipo { get; set; }
    }
}
