using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKirolBet.Models
{
    public class Description
    {
        public int Id { get; set; }
        public List<Description> Descriptions { get; set; }
        [DisplayName("Subject")]
        public string Raw { get; set; }
    }
}
