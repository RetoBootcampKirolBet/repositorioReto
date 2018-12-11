using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class AssigneeWP
    {
        public int Id { get; set; }
        public List<AssigneeWP> assignee { get; set; }
        [JsonProperty(PropertyName = "Title")]
        public string Name { get; set; }
    }
}
