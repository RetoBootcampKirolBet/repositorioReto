using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSProject.Models
{
    public class Persona
    {
        public int Id {get;set;}
        public int IdOP { get; set; }
        public string Nombre { get; set; }
        public double TotalHorasEstimadas { get; set; }//horas anuales que tiene que hacer segun contrato
        public double TotalHorasTrabajadas { get; set; }//horas realizadas
        public List<Oporrak> Oporrak { get; set; }
        public List<Dedication> Dedications { get; set; }
    }
}
