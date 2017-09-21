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
            //Validación para asegurarnos que ingresó algo como contraseña
            //**La validación de que la contraseña sea la correcta se hará en Program.cs
            if( contraseña == null )
            {
                MessageBox.Show( "Ingresa la contraseña para iniciar sesión" );
            }
            else
            {
                Program.Login( contraseña );
            }
        }
    }
}
