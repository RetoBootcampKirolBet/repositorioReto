using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class _Links
    {
        public int Id { get; set; }
        public AssigneeWP Assignee { get; set; }
        public TypeWP Type { get; set; }
        public StatusWP Status { get; set; }
        public Priority Priority { get; set; }
    }
}
