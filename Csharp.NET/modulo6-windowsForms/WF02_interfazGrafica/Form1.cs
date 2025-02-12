using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF02_interfazGrafica
{
    public partial class FormHolaMundo : Form
    {
        public FormHolaMundo()
        {
            InitializeComponent();
        }

        private void btnMostrar_MouseClick(object sender, MouseEventArgs e)
        {
            string txt;

            txt = txtIngreso.Text;

            lblMostrar.Text = txt;
        }

        private void btnSalir_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void btnLimpiar_MouseClick(object sender, MouseEventArgs e)
        {
            txtIngreso.Text = "";
            lblMostrar.Text = "";

            txtIngreso.Focus();
        }
    }
}
