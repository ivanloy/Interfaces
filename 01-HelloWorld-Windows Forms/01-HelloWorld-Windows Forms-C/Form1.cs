using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_HelloWorld_Windows_Forms_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {

            clsPersona oPersona = new clsPersona();

            oPersona.nombre = "Jorge";
            oPersona.apellidos = "Obando Lopez";

            //string nombre;
            //nombre = this.txtNombre.Text;

            //System.Windows.Forms.MessageBox.Show(nombre);

            //System.Windows.Forms.MessageBox.Show($"Hola{nombre}");

            System.Windows.Forms.MessageBox.Show($"Soy el objeto persona {oPersona.nombre} {oPersona.apellidos}");

            //System.Windows.Forms.MessageBox.Show(string.Format("Hola {0}", nombre));
        }
    }
}
