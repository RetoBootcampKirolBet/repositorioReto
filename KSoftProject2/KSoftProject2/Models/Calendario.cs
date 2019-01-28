using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSoftProject2.Models
{
    public class Calendario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public double Lunes { get; set; }
        public double Martes { get; set; }
        public double Miercoles { get; set; }
        public double Jueves { get; set; }
        public double Viernes { get; set; }
        
    }
}
