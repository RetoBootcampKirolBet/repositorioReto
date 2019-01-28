using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KSoftProject2.Models
{
    public class CalendarioPersona
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Calendario")]
        public int PersonaId { get; set; }
        [ForeignKey("Persona")]
        public int WorkPackageId { get; set; }
        public Calendario Calendario { get; set; }
        public Persona Persona { get; set; }
    }
}
