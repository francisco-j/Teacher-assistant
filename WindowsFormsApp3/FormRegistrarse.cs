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
            string contraseña = txbContraseña.Text;
            string confirmacion = txbConfirmacion.Text;

            //Validaciones de que los campos no estén vacíos
            //Definir cuántos caracteres se aceptan por cada txb y que no se vean en txbContraseña
            if( usuario != "" )
            {
                if( contraseña != "" )
                {
                    if( confirmacion != "" )
                    {
                       if( confirmacion == contraseña )
                        {
                            MessageBox.Show( "El maestro " + usuario + " se ha guardado exitosamente" );
                            this.Dispose();
                            //Agregar código para guardar registro del nuevo usuario en la base de datos
                        }
                        else
                        {
                            MessageBox.Show( "La contraseña y la confirmación no coinciden, verifica que estés ingresando la misma en los dos campos" );
                        }
                    }
                    else
                    {
                        MessageBox.Show( "Debes ingresar otra vez la contraseña" );
                        txbConfirmacion.Focus();
                    }
                }
                else
                {
                    MessageBox.Show( "Define una contraseña por favor" );
                    txbContraseña.Focus();
                }
            }
            else
            {
                MessageBox.Show( "Ingresa el nombre de usuario por favor" );
                txbUsuario.Focus();
            }
        }
    }
}
