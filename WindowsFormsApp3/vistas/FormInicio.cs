using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp3
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            this.Show();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            txbUsuario.BackColor = Color.White;
            txbContrasena.BackColor = Color.White;

            string contrasena = txbContrasena.Text;
            string usuario = txbUsuario.Text;

            //*La validación de que la contraseña sea la correcta se hará en Program.cs
            if (usuario == string.Empty)
            {
                System.Media.SystemSounds.Beep.Play();
                txbUsuario.Focus();
                txbUsuario.BackColor = Color.LightSalmon;
            }
            else if (contrasena == string.Empty)
            {
                System.Media.SystemSounds.Beep.Play();
                txbContrasena.Focus();
                txbContrasena.BackColor = Color.LightSalmon;
            }
            else
            {
                try
                {
                    Program.Login( usuario, contrasena );
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(this, ex.Message); 
                }

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form registrarse = new FormRegistrarse();
            registrarse.ShowDialog();
            txbUsuario.Focus();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            txbUsuario.Focus();
        }

        //*********************** errores ****************************
        private string erTitulo = "Error inesperado";
        private string erTituloContra = "datos incorrectos";

    }
}
