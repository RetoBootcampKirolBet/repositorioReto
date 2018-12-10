using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class MySprint
    {
        public string KsoftProject { get; set; }
        public string Sprint { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Status { get; set; }
        public int EstimatedTime { get; set; }
        public int SpentTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }

    }
}
