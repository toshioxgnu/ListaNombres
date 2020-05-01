using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaNombres
{
    public partial class Form1 : Form
    {
        ArrayList curso = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void ingresa_Click(object sender, EventArgs e)
        {
            
            string nombrealumno  = nombreAlumn.Text;
            string rutalumno = rutalum.Text;
            int edadalumno = Int32.Parse(edadAlum.Text);
            int seccionalumno = Int32.Parse(seccionAlum.Text);
            string asignaturaalumno = asignaturaAlumn.Text;

            Alumno alumno = new Alumno(rutalumno,nombrealumno, edadalumno, seccionalumno, asignaturaalumno);
            curso.Add(alumno);
            MessageBox.Show("Ingresado, Total en la lista: " + curso.Count);
            nombreAlumn.Text = "";
            rutalum.Text = "";
            edadAlum.Text = "";
            seccionAlum.Text = "";
            asignaturaAlumn.Text = "";
            mostrar();
        }


        public void mostrar()
        {
            listView1.Items.Clear();
            foreach (Alumno alumno in curso)
            {
                             
                ListViewItem al = new ListViewItem(alumno.Rut);
                al.SubItems.Add(alumno.Nombre);
                al.SubItems.Add(alumno.Edad.ToString());
                al.SubItems.Add(alumno.Seccion.ToString());
                al.SubItems.Add(alumno.Asignatura);

                listView1.Items.Add(al);
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Alumno alumno in curso)
            {
                foreach (var c in Controls)
                {
                    if(c is TextBox)
                    {
                        TextBox t = (TextBox)c ;
                        if(t.Text != "")
                        {
                            string data = t.Name;
                            string termino = t.Text;
                            search(data, termino);
                            mostrar();
                        }
                    }
                }

            }
        }

        public Alumno search( string data, string termino )
        {
            Alumno encontrado = new Alumno();
            foreach (Alumno alumno in curso)
            {
                if(data == alumno.Rut)
                {
                    encontrado = new Alumno(alumno.Rut, alumno.Nombre, alumno.Edad, alumno.Seccion ,alumno.Asignatura);
                }
                else if(data == alumno.Nombre)
                {
                    encontrado = new Alumno(alumno.Rut, alumno.Nombre, alumno.Edad, alumno.Seccion, alumno.Asignatura);
                }
                else if( data == alumno.Seccion.ToString())
                {
                    encontrado = new Alumno(alumno.Rut, alumno.Nombre, alumno.Edad, alumno.Seccion, alumno.Asignatura);
                }

            }

            return encontrado;
        }
    }
}
