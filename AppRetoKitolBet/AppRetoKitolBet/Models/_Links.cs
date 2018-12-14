using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKirolBet.Models
{
    public class _Links
    {
        public int Id { get; set; }
        public AssigneeWP Assignee { get; set; }
        public TypeWP Type { get; set; }
        public StatusWP Status { get; set; }
        public Priority Priority { get; set; }
        public CustomField1WP CustomField1 { get; set; }
        public CustomField2WP CustomField2 { get; set; }
    }
}
