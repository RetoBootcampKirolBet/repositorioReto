using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSoftProject2.Models
{
    public class Dedication
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Desarrollo { get; set; }
        public double Gestion { get; set; }
        public double Formacion { get; set; }
        public double Soporte { get; set; }
        public double Investigacion { get; set; }
        public double NoDedicadas { get; set; }
    }
}
