using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSoftProject2.Models
{
    public class Responsible
    {
        public int Id { get; set; }
        public List<Responsible> responsible { get; set; }
        [JsonProperty(PropertyName = "Title")]
        public string Name { get; set; }
    }
}
