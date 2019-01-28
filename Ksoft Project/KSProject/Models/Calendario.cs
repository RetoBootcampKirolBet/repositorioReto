using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSProject.Models
{
    public class Calendario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        //public DateTime Festivo { get; set; }//esto es una lista de festivos,no uno solo
        public double Lunes { get; set; }
        public double Martes { get; set; }
        public double Miercoles { get; set; }
        public double Jueves { get; set; }
        public double Viernes { get; set; }
        //public List<Persona> Personas { get; set; }
    }
}
