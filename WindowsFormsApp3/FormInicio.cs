using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using System.Collections.Generic;

namespace WindowsFormsApp3
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string contraseña = txbContraseña.Text;
            string usuario = txbUsuario.Text;
            //Validación para asegurarnos que ingresó algo como contraseña
            //**La validación de que la contraseña sea la correcta se hará en Program.cs
            if (usuario != "")
            {
                if (contraseña != "")
                {
                    Program.Login( usuario, contraseña );
                }
                else
                {
                    MessageBox.Show( "Ingresa la contraseña para poder iniciar sesión" );
                    txbContraseña.Focus();
                }
            }
            else
            {
                MessageBox.Show( "Ingresa tu usuario para iniciar sesión" );
                txbUsuario.Focus();
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
    }
}
