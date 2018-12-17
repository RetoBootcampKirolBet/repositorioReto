using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKirolBet.Models
{
    public class Priority
    {
        public int Id { get; set; }
        public List<Priority> priority { get; set; }
        [DisplayName("Priority")]
        public string Title { get; set; }
    }
}
