using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class WorkPackage
    {
        public int IdWPLocal { get; set; }
        [JsonProperty(PropertyName = "Id")]
        public int IdWPOpenProject { get; set; }
        public string Subject { get; set; }
        public string EstimatedTime { get; set; }
        public string RemainingTime { get; set; }
        public string StartDate { get; set; }
        public string DueDate { get; set; }

        public _Links _Links { get; set; }
        public Description Description{ get; set; }
        public List<UserWorkPackage> UserWorkPackages { get; set; }

    }
}
