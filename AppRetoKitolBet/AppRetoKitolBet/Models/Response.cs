﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class Response
    {
        public int Count { get; set; }
        public int Offset { get; set; }
        public int Total { get; set; }
        [JsonProperty(PropertyName ="_embedded")] // toma el nombre real y lo podemos cambiar por lo que queramos
        public Embeded WorkPackagesContainer { get; set; }
        
    }
}
