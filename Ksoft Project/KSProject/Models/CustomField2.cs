﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace KSProject.Models
{
    public class CustomField2
    {
        public int Id { get; set; }
        public List<CustomField2> customField2 { get; set; }
        [JsonProperty(PropertyName = "Title")]
        [DisplayName("Ksoft Project")]
        public string KsoftProject { get; set; }
    }
}
