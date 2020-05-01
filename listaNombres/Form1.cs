using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaNombres
{
    public partial class Form1 : Form
    {
        ArrayList<Alumno> curso = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void ingresa_Click(object sender, EventArgs e)
        {
            string text = nombre.Text + "\n";
            cursos.Add(text);
            MessageBox.Show("Ingresado, Total en la lista: " + cursos.Count);
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            foreach (var nombre in nombres)
            {
                listView1.Items.Add(nombre.ToString());
            }
        }
    }
}
