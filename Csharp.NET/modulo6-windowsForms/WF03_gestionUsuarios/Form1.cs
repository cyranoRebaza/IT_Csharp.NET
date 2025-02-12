using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF03_gestionUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            lblInformacion.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* declaro variables */
            string usuario;
            string clave;

            /* Lectura de datos */
            usuario = txtUsuario.Text;
            clave = txtContrasena.Text;

            /* Validacion de datos */
            if (usuario == "pepito")
            {
                if (clave == "educacionIT")
                {
                    lblInformacion.Text = "Bienvenido Pepito";
                }
                else
                {
                    lblInformacion.Text = "Usuario no coincide con la clave";
                }
            }
            else
            {
                lblInformacion.Text = "Usuario Incorrecto";
            }



        }
    }
}
