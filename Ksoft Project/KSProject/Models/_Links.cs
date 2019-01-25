using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSProject.Models
{
    public class _Links
    {
        public int Id { get; set; }
        public AssigneeWP Assignee { get; set; }
        public TypeWP Type { get; set; }
        public StatusWP Status { get; set; }
        public Priority Priority { get; set; }
        public CustomField1 CustomField1 { get; set; }
        public CustomField2 CustomField2 { get; set; }
        public Responsible Responsible { get; set; }
        public Author Author { get; set; }
    }
}
