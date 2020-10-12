using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using TeoremaBayes.entidades;
using TeoremaBayes.negocio;

namespace TeoremaBayes
{
    public partial class VistaPrincipal : Form
    {
        string[] arr2 = ConfigurationManager.AppSettings["Enunciado"].Split(',');
        string[] arr = ConfigurationManager.AppSettings["Pregunta"].Split(',');
        public VistaPrincipal()
        {
            InitializeComponent();
            cbPregunta.DataSource = arr;
            //Cargar los elementos en el GRID
            cargarDGV();
        }

        private void cargarDGV()
        {
            //Columnas
            DGVDatos.ColumnCount = 10;
            DGVDatos.Columns[0].Name = "Nombre";
            DGVDatos.Columns[1].Name = "IA 1er";
            DGVDatos.Columns[2].Name = "IA 2do";
            DGVDatos.Columns[3].Name = "IA 3ro";
            DGVDatos.Columns[4].Name = "In 1er";
            DGVDatos.Columns[5].Name = "In 2do";
            DGVDatos.Columns[6].Name = "In 3er";
            DGVDatos.Columns[7].Name = "Re 1er";
            DGVDatos.Columns[8].Name = "Re 2do";
            DGVDatos.Columns[9].Name = "Re 3er";
            //Filas
            string [] a= new string[10];
            for (int i = 0; i < Alumno.ListaAlumnos().Count; i++)
            {
                a[0] = Alumno.ListaAlumnos()[i].nombre;
                a[1] = Alumno.ListaAlumnos()[i].listaMaterias[0].parcial1.ToString();
                a[2] = Alumno.ListaAlumnos()[i].listaMaterias[0].parcial2.ToString();
                a[3] = Alumno.ListaAlumnos()[i].listaMaterias[0].parcial3.ToString();
                a[4] = Alumno.ListaAlumnos()[i].listaMaterias[1].parcial1.ToString();
                a[5] = Alumno.ListaAlumnos()[i].listaMaterias[1].parcial2.ToString();
                a[6] = Alumno.ListaAlumnos()[i].listaMaterias[1].parcial3.ToString();
                a[7] = Alumno.ListaAlumnos()[i].listaMaterias[2].parcial1.ToString();
                a[8] = Alumno.ListaAlumnos()[i].listaMaterias[2].parcial2.ToString();
                a[9] = Alumno.ListaAlumnos()[i].listaMaterias[2].parcial3.ToString();
                DGVDatos.Rows.Add(a);
            }
        }

        private void btnTeorema_Click(object sender, EventArgs e)
        {
            Probabilidad _p = new Probabilidad();
            if (cbPregunta.SelectedIndex == 0)
            {
                txtProbabilidadEnunciado.Text = arr2[cbPregunta.SelectedIndex]+
                    "\n\nR=La probabilidad es de: " +
                    Math.Round(_p.teorema1() * 100,2,MidpointRounding.AwayFromZero) + "%";
            }
            if (cbPregunta.SelectedIndex == 1)
            {
                txtProbabilidadEnunciado.Text = arr2[cbPregunta.SelectedIndex] + 
                    "\n\nR=La probabilidad es de: " +
                    Math.Round(_p.teorema2() * 100, 2, MidpointRounding.AwayFromZero) + "%";
            }
            if (cbPregunta.SelectedIndex == 2)
            {
                txtProbabilidadEnunciado.Text = arr2[cbPregunta.SelectedIndex] +
                    "\n\nR=La probabilidad es de: " +
                    Math.Round(_p.teorema3() * 100, 2, MidpointRounding.AwayFromZero)+"%";
            }

            //Combrobación de probabilidades
            //for (int i = 0; i < _p.materias_a.Length; i++)
            //{
            //    MessageBox.Show("PA: " + _p.materias_a[i]);
            //    MessageBox.Show("PR: " + _p.materias_r[i]);
            //}
        }

        //EVENTOS

        private void cbPregunta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProbabilidadEnunciado.Text = arr2[cbPregunta.SelectedIndex];
        }
    }
}
