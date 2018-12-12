using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class Description
    {
        public int Id { get; set; }
        public List<Description> Descriptions { get; set; }
        public string Raw { get; set; }
    }
}
