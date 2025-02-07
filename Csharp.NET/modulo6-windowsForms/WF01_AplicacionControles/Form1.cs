using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF01_AplicacionControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;

            lblResultado.Text = $"mi nombre completo es {nombre} {apellido} y tengo {edad} años";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            lblResultado.Text = "";

            txtNombre.Focus();
        }
    }
}
