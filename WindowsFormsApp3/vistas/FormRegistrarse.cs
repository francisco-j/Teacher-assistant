using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormRegistrarse : Form
    {
        public FormRegistrarse()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txbUsuario.Text;
            string contraseña = txbContrasena.Text;
            string confirmacion = txbConfirmacion.Text;

            //Validaciones de que los campos no estén vacíos, usar regex
            //Definir cuántos caracteres se aceptan por cada txb
            if (usuario == "")
            {
                MessageBox.Show("Ingresa el nombre de usuario por favor");
                txbUsuario.Focus();
            }
            else if (contraseña == "")
            {
                MessageBox.Show("Define una contraseña por favor");
                txbContrasena.Focus();
            }
            else if (confirmacion == "")
            {
                MessageBox.Show("Debes confirmar la contraseña");
                txbConfirmacion.Focus();
            }
            else if (confirmacion != contraseña)
            {
                MessageBox.Show("La contraseña y la confirmación no coinciden");
                txbContrasena.Focus();
            }
            else
            {
                try
                {
                    Program.registrarUsuario(usuario, contraseña);
                    MessageBox.Show( "El maestro " + usuario + " se ha guardado exitosamente" );
                    this.Dispose();

                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

    }
}
