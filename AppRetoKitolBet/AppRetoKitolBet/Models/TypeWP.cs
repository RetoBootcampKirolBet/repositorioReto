using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class TypeWP
    {
        public int Id { get; set; }
        public List<TypeWP> type { get; set; }
        [JsonProperty(propertyName: "Title")]
        public string Tipo { get; set; }
    }
}
