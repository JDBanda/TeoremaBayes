using TeoremaBayes.entidades;

namespace TeoremaBayes.negocio
{
    class Probabilidad
    {
        //CONSTANTES
        public const double P_PARCIAL = 0.3333;
        public const double P_MATERIA = 0.3333;
        //Propiedades 0 1 2
        public double[] materias_a = new double[9];
        public double[] materias_r = new double[9];

        public Probabilidad()
        {
            //A nivel de un alumno
            foreach (var item in Alumno.ListaAlumnos())
            {
                int j = 0;
                foreach (var m in item.listaMaterias)
                {
                    //Parcial 1
                    if (m.parcial1 > 60)
                    {
                        materias_a[j] += 1;
                    }
                    else
                    {
                        materias_r[j] += 1;
                    }

                    //Parcial 2
                    if (m.parcial2 > 60)
                    {
                        materias_a[j+1] += 1;
                    }
                    else
                    {
                        materias_r[j+1] += 1;
                    }

                    //Parcial 3
                    if (m.parcial1 > 60)
                    {
                        materias_a[j+2] += 1;
                    }
                    else
                    {
                        materias_r[j+2] += 1;
                    }
                    j+=3;
                }
                
            }
            //Hay que sacar probabilidad para cada parcial xD
            //Porcentaje de aprobados en IA
            //1er
            materias_a[0] = materias_a[0] / 21;
            //2do
            materias_a[1] = materias_a[1] / 21;
            //3er
            materias_a[2] = materias_a[2] / 21;

            //Porcentaje de aprobados en Ingles
            //1er
            materias_a[3] = materias_a[3] / 21;
            //2do
            materias_a[4] = materias_a[4] / 21;
            //3er
            materias_a[5] = materias_a[5] / 21;

            //Porcentaje de aprobados en Redes
            //1er
            materias_a[6] = materias_a[6] / 21;
            //2do
            materias_a[7] = materias_a[7] / 21;
            //3er
            materias_a[8] = materias_a[8] / 21;

            //Porcentaje de reprobados en IA
            //1er
            materias_r[0] = materias_r[0] / 21;
            //2do
            materias_r[1] = materias_r[1] / 21;
            //3er
            materias_r[2] = materias_r[2] / 21;

            //Porcentaje de reprobados en Ingles
            //1er
            materias_r[3] = materias_r[3] / 21;
            //2do
            materias_r[4] = materias_r[4] / 21;
            //3er
            materias_r[5] = materias_r[5] / 21;

            //Porcentaje de reprobados en redes
            //1er
            materias_r[6] = materias_r[6] / 21;
            //2do
            materias_r[7] = materias_r[7] / 21;
            //3er
            materias_r[8] = materias_r[8] / 21;
        }
        /*
         * La probabilidad de que se escoja al azar un alumno de la materia
         * de Ingles y que este alumno tenga una calificación reprobatoria
         * y que sea del 2do parcial.
         */
        public double teorema1()
        {
            double p = (materias_r[4] * P_PARCIAL) /
                ((materias_r[0] * P_PARCIAL)+
                (materias_r[1] * P_PARCIAL)+
                (materias_r[2] * P_PARCIAL)+
                (materias_r[3] * P_PARCIAL)+
                (materias_r[4] * P_PARCIAL)+
                (materias_r[5] * P_PARCIAL)+
                (materias_r[6] * P_PARCIAL)+
                (materias_r[7] * P_PARCIAL)+
                (materias_r[8] * P_PARCIAL));
            return p;
        }
        /*
         * La probabilidad de que se escoja al azar otro alumno de la materia
         * de Redes y que este tenga todas las calificaciones aprobadas en todos los parciales.
         */
        public double teorema2()
        {
            //Parcial 1 de redes
            double p1 = (materias_a[6] * P_PARCIAL) /
                ((materias_a[0] * P_PARCIAL) +
                (materias_a[1] * P_PARCIAL) +
                (materias_a[2] * P_PARCIAL) +
                (materias_a[3] * P_PARCIAL) +
                (materias_a[4] * P_PARCIAL) +
                (materias_a[5] * P_PARCIAL) +
                (materias_a[6] * P_PARCIAL) +
                (materias_a[7] * P_PARCIAL) +
                (materias_a[8] * P_PARCIAL));
            //Parcial 2 de redes
            double p2 = (materias_a[7] * P_PARCIAL) /
                ((materias_a[0] * P_PARCIAL) +
                (materias_a[1] * P_PARCIAL) +
                (materias_a[2] * P_PARCIAL) +
                (materias_a[3] * P_PARCIAL) +
                (materias_a[4] * P_PARCIAL) +
                (materias_a[5] * P_PARCIAL) +
                (materias_a[6] * P_PARCIAL) +
                (materias_a[7] * P_PARCIAL) +
                (materias_a[8] * P_PARCIAL));
            //Parcial 1 de redes
            double p3 = (materias_a[8] * P_PARCIAL) /
                ((materias_a[0] * P_PARCIAL) +
                (materias_a[1] * P_PARCIAL) +
                (materias_a[2] * P_PARCIAL) +
                (materias_a[3] * P_PARCIAL) +
                (materias_a[4] * P_PARCIAL) +
                (materias_a[5] * P_PARCIAL) +
                (materias_a[6] * P_PARCIAL) +
                (materias_a[7] * P_PARCIAL) +
                (materias_a[8] * P_PARCIAL));
            double p = p1+p2+p3;
            return p;
        }

        /*
         * La probabilidad de que se elija un alumno al azar y este tenga los 
         * tres parciales reprobados en la materia de Inteligencia Artificial.
         */
         public double teorema3()
        {
            //Parcial 1 de IA
            double p1 = (materias_a[0] * P_PARCIAL) /
                ((materias_a[0] * P_PARCIAL) +
                (materias_a[1] * P_PARCIAL) +
                (materias_a[2] * P_PARCIAL) +
                (materias_a[3] * P_PARCIAL) +
                (materias_a[4] * P_PARCIAL) +
                (materias_a[5] * P_PARCIAL) +
                (materias_a[6] * P_PARCIAL) +
                (materias_a[7] * P_PARCIAL) +
                (materias_a[8] * P_PARCIAL));
            //Parcial 2 de IA
            double p2 = (materias_a[1] * P_PARCIAL) /
                ((materias_a[0] * P_PARCIAL) +
                (materias_a[1] * P_PARCIAL) +
                (materias_a[2] * P_PARCIAL) +
                (materias_a[3] * P_PARCIAL) +
                (materias_a[4] * P_PARCIAL) +
                (materias_a[5] * P_PARCIAL) +
                (materias_a[6] * P_PARCIAL) +
                (materias_a[7] * P_PARCIAL) +
                (materias_a[8] * P_PARCIAL));
            //Parcial 3 de IA
            double p3 = (materias_a[2] * P_PARCIAL) /
                ((materias_a[0] * P_PARCIAL) +
                (materias_a[1] * P_PARCIAL) +
                (materias_a[2] * P_PARCIAL) +
                (materias_a[3] * P_PARCIAL) +
                (materias_a[4] * P_PARCIAL) +
                (materias_a[5] * P_PARCIAL) +
                (materias_a[6] * P_PARCIAL) +
                (materias_a[7] * P_PARCIAL) +
                (materias_a[8] * P_PARCIAL));
            double p = p1 + p2 + p3;
            return p;
        }
    }
}
