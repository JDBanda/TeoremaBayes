using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoremaBayes.entidades
{
    class Alumno
    {
        public string nombre { get; set; }
        public List<Materia> listaMaterias { get; set; }

        public Alumno(string nombre, List<Materia> listaMaterias)
        {
            this.nombre = nombre;
            this.listaMaterias = listaMaterias;
        }
    }
}
