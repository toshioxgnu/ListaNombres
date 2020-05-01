using System.Collections;

namespace listaNombres
{
    public class Alumno
    {
        private string rut;
        private string nombre;
        private int edad;
        private int seccion;
        private string asignatura;
        private double nota; 

        public Alumno(string rut, string nombre, int edad, int seccion, string asignatura, double nota)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.edad = edad;
            this.seccion = seccion;
            this.asignatura = asignatura;
            this.nota = nota;
        }

        public Alumno()
        {

        }

        public string Rut
        {
            get => rut;
            set => rut = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        public int Seccion
        {
            get => seccion;
            set => seccion = value;
        }

        public string Asignatura
        {
            get => asignatura;
            set => asignatura = value;
        }

        public double Nota
        {
            get => nota;
            set => nota = value;
        }
    }
}