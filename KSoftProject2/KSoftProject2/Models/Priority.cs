using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSoftProject2.Models
{
    public class Priority
    {
        public int Id { get; set; }
        public List<Priority> priority { get; set; }
        public string Title { get; set; }
    }
}
