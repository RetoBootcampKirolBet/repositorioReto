using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSoftProject2.Models
{
    public class StatusWP
    {
        public int Id { get; set; }
        public List<StatusWP> status { get; set; }
        [JsonProperty(PropertyName = "Title")]
        public string Estado { get; set; }
    }
}
