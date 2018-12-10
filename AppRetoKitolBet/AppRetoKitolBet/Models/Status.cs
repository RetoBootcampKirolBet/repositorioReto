using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class Status
    {
        public List<Assignee> assignee { get; set; }
        [JsonProperty(PropertyName = "Title")]
        public string Estado { get; set; }
    }
}
