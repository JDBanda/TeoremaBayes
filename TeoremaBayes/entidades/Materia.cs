using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoremaBayes.entidades
{
    class Materia
    {
        public string nombre { get; set; }
        public double parcial1 { get; set; }
        public double parcial2 { get; set; }
        public double parcial3 { get; set; }
        public double promedio { get; set; }

        public Materia(string nombre, double parcial1, double parcial2, double parcial3)
        {
            this.nombre = nombre;
            this.parcial1 = parcial1;
            this.parcial2 = parcial2;
            this.parcial3 = parcial3;
        }
    }
}
