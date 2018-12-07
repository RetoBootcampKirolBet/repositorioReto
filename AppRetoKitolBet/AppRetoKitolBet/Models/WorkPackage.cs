using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class WorkPackage
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Assignee { get; set; }
    }
}
