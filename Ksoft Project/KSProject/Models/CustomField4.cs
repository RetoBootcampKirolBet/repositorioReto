using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace KSProject.Models
{
    public class CustomField4
    {
        public int Id { get; set; }
        public List<CustomField4> customField4 { get; set; }
        [JsonProperty(PropertyName = "title")]
        [DisplayName("Ksoft Project")]
        public string KsoftProject { get; set; }
    }
}
