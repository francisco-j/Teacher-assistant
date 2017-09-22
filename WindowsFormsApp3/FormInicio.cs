using System;
using System.Windows.Forms;

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
            if( usuario != "" )
            {
                if (contraseña != "")
                {
                    Program.Login( usuario, contraseña );
                }
                else
                {
                    MessageBox.Show( "Ingresa la contraseña para poder iniciar sesión" );
                }
            }
            else
            {
                MessageBox.Show( "Ingresa tu usuario para iniciar sesión" );
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form registrarse = new FormRegistrarse();
            registrarse.ShowDialog();
        }
    }
}
