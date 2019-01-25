using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSProject.Models
{
    public class Author
    {
        public int Id { get; set; }
        public List<Author> author { get; set; }
        [JsonProperty(PropertyName = "Title")]
        public string Name { get; set; }
    }
}
