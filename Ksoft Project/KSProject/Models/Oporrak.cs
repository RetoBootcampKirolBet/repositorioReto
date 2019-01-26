using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSProject.Models
{
    public class Oporrak
    {
        public int Id { get; set; }
        public DateTime DiasDeVacaciones { get; set; }//lista de fechas
        public double HorasDeVacaciones { get; set; }//segun el papel piden horas
                                                     //varia segun el contrato
    }
}
