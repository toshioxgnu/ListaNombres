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
        private ArrayList notas = new ArrayList();

        public Alumno(string rut, string nombre, int edad, int seccion, string asignatura)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.edad = edad;
            this.seccion = seccion;
            this.asignatura = asignatura;
        }

        public void llenaNotas(double[] notasarr)
        {
            foreach (double nota in notasarr)
            {
                notas.Add(nota);
            }
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

        public ArrayList Notas
        {
            get => notas;
            set => notas = value;
        }
    }
}