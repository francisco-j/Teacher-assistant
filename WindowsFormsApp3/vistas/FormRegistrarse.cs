using System;
using System.Drawing;
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
            txbUsuario.BackColor = Color.White;
            txbContrasena.BackColor = Color.White;
            txbConfirmacion.BackColor = Color.White;

            string usuario = txbUsuario.Text.Trim();
            string contraseña = txbContrasena.Text;
            string confirmacion = txbConfirmacion.Text;

            //Validaciones de que los campos no estén vacíos, usar regex
            //Definir cuántos caracteres se aceptan por cada txb
            if (usuario == string.Empty)
            {
                System.Media.SystemSounds.Beep.Play();
                txbUsuario.BackColor = Color.LightSalmon;
                txbUsuario.Focus();
            }
            else if (contraseña == string.Empty)
            {
                System.Media.SystemSounds.Beep.Play();
                txbContrasena.BackColor = Color.LightSalmon;
                txbContrasena.Focus();
            }
            else if (confirmacion == string.Empty)
            {
                System.Media.SystemSounds.Beep.Play();
                txbConfirmacion.BackColor = Color.LightSalmon;
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
                    MessageBox.Show("El maestro " + usuario + " se ha guardado exitosamente");
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