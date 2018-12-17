using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKirolBet.Models
{
    public class StatusWP
    {
        public int Id { get; set; }
        public List<AssigneeWP> assignee { get; set; }
        [JsonProperty(PropertyName = "Title")]
        [DisplayName("Status")]
        public string Estado { get; set; }
    }
}
