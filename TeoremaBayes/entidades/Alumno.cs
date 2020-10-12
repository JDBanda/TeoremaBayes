using System.Collections.Generic;

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

        public static List<Alumno> ListaAlumnos()
        {
            //Lista de alumnos del grupo 7A
            List<Alumno> alumnos = new List<Alumno>();
            //Crear los 21 alumnos con sus calificaciones
            alumnos.Add(new Alumno("Aguilar Solorio Said Alejandro", new List<Materia> {
                new Materia("Inteligencia Artificial",60,60,100),
                new Materia("Inglés",60,100,100),
                new Materia("Redes",60,100,60)}));
            alumnos.Add(new Alumno("Almaraz Barrera Brent Ulises", new List<Materia> {
                new Materia("Inteligencia Artificial",100,60,100),
                new Materia("Inglés",100,100,100),
                new Materia("Redes",60,60,60)}));
            alumnos.Add(new Alumno("Arias Hernández Pamela", new List<Materia> {
                new Materia("Inteligencia Artificial",60,60,100),
                new Materia("Inglés",60,100,100),
                new Materia("Redes",60,60,60)}));
            alumnos.Add(new Alumno("Banda Villeda Javier David", new List<Materia> {
                new Materia("Inteligencia Artificial",100,100,100),
                new Materia("Inglés",100,100,100),
                new Materia("Redes",60,60,60)}));
            alumnos.Add(new Alumno("Chavez Serrano Elsy Anel", new List<Materia> {
                new Materia("Inteligencia Artificial",60,60,60),
                new Materia("Inglés",60,60,60),
                new Materia("Redes",100,100,100)}));
            alumnos.Add(new Alumno("Contreras Dimas Nedilson Yariber", new List<Materia> {
                new Materia("Inteligencia Artificial",60,60,60),
                new Materia("Inglés",60,60,100),
                new Materia("Redes",60,100,100)}));
            alumnos.Add(new Alumno("Cortes Angeles Nely Guadalupe", new List<Materia> {
                new Materia("Inteligencia Artificial",60,100,100),
                new Materia("Inglés",100,100,60),
                new Materia("Redes",60,60,60)}));
            alumnos.Add(new Alumno("Cruz Zuñiga Samuel Eduardo", new List<Materia> {
                new Materia("Inteligencia Artificial",60,100,100),
                new Materia("Inglés",100,100,60),
                new Materia("Redes",60,60,60)}));
            alumnos.Add(new Alumno("Encarnacion Martinez Jorge Daniel", new List<Materia> {
                new Materia("Inteligencia Artificial",60,60,100),
                new Materia("Inglés",60,100,100),
                new Materia("Redes",60,100,60)}));
            alumnos.Add(new Alumno("Espino Lopez Angela Gabriela", new List<Materia> {
                new Materia("Inteligencia Artificial",60,60,100),
                new Materia("Inglés",60,100,100),
                new Materia("Redes",60,60,60)}));
            alumnos.Add(new Alumno("Estrada Cruz Maria Jose", new List<Materia> {
                new Materia("Inteligencia Artificial",100,100,100),
                new Materia("Inglés",60,60,60),
                new Materia("Redes",100,100,100)}));
            alumnos.Add(new Alumno("Hernandez Caballero Lendy", new List<Materia> {
                new Materia("Inteligencia Artificial",60,60,60),
                new Materia("Inglés",60,100,60),
                new Materia("Redes",100,100,100)}));
            alumnos.Add(new Alumno("López Romero Obed Albino", new List<Materia> {
                new Materia("Inteligencia Artificial",60,60,60),
                new Materia("Inglés",100,100,60),
                new Materia("Redes",60,100,100)}));
            alumnos.Add(new Alumno("Martinez Arteaga Mariana de Israel", new List<Materia> {
                new Materia("Inteligencia Artificial",100,100,100),
                new Materia("Inglés",100,100,100),
                new Materia("Redes",60,60,60)}));
            alumnos.Add(new Alumno("Miranda Monroy Brayan Israel", new List<Materia> {
                new Materia("Inteligencia Artificial",100,60,100),
                new Materia("Inglés",100,100,100),
                new Materia("Redes",100,60,100)}));
            alumnos.Add(new Alumno("Monroy Morales Monserrat", new List<Materia> {
                new Materia("Inteligencia Artificial",100,60,60),
                new Materia("Inglés",100,100,100),
                new Materia("Redes",60,100,60)}));
            alumnos.Add(new Alumno("Perez Sanchez Fernando Adyr", new List<Materia> {
                new Materia("Inteligencia Artificial",100,60,60),
                new Materia("Inglés",60,100,100),
                new Materia("Redes",100,100,100)}));
            alumnos.Add(new Alumno("Ponce Pérez Lidia Citali", new List<Materia> {
                new Materia("Inteligencia Artificial",60,100,100),
                new Materia("Inglés",100,100,100),
                new Materia("Redes",100,100,100)}));
            alumnos.Add(new Alumno("Ramirez Camacho Lizeth", new List<Materia> {
                new Materia("Inteligencia Artificial",100,100,60),
                new Materia("Inglés",100,60,100),
                new Materia("Redes",100,100,100)}));
            alumnos.Add(new Alumno("Reyes Rafael David", new List<Materia> {
                new Materia("Inteligencia Artificial",100,100,100),
                new Materia("Inglés",60,60,60),
                new Materia("Redes",100,100,60)}));
            alumnos.Add(new Alumno("Salvador Lugo Monica", new List<Materia> {
                new Materia("Inteligencia Artificial",100,60,60),
                new Materia("Inglés",100,100,100),
                new Materia("Redes",100,100,60)}));
            return alumnos;
        }
    }
}
