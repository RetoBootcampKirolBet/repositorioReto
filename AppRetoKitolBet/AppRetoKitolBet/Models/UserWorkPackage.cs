using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppRetoKitolBet.Models
{
    public class UserWorkPackage
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("WorkPackage")]
        public int WorkPackageId { get; set; }
        public User User { get; set; }
        public WorkPackage WorkPackage { get; set; }
    }
}
