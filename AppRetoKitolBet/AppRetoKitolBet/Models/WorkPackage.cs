using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKirolBet.Models
{
    public class WorkPackage
    {
        public int Id { get; set; }
        [JsonProperty(PropertyName = "id")]
        [DisplayName("Id")]
        public int IdOP { get; set; }
        [DisplayName("Subject")]
        public string Subject { get; set; }
        [DisplayName("Estimated Time")]
        public string EstimatedTime { get; set; }
        [DisplayName("Spent Time")]
        public string SpentTime { get; set; }
        [DisplayName("Start Date")]
        public string StartDate { get; set; }
        [DisplayName("Due Date")]
        public string DueDate { get; set; }
        public string Activation { get; set; }

        public _Links _Links { get; set; }
        public Description Description { get; set; }
        public List<UserWorkPackage> UserWorkPackages { get; set; }

    }
}
