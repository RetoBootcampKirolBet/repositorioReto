using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSoftProject2.Models
{
    public class AssigneeWP
    {
        public int Id { get; set; }
        public List<AssigneeWP> Assignee { get; set; }
        [JsonProperty(PropertyName = "Title")]
        public string Name { get; set; }
    }
}
