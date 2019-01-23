using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace KSProject.Models
{
    public class CustomField1
    {
        public int Id { get; set; }
        public List<CustomField1> customField1 { get; set; }
        [JsonProperty(PropertyName = "title")]
        [DisplayName("Ksoft Project")]
        public string KsoftProject { get; set; }
    }
}
