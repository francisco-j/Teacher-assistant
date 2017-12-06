using System;
using System.Windows.Forms;

namespace WindowsFormsApp3.vistas
{
    public partial class FormAgregarEntregable : Form
    {
        private int tipo, materia;

        public FormAgregarEntregable(int tipo, int materia)
        {
            this.tipo = tipo;
            this.materia = materia;

            InitializeComponent();
            string txtTipo = dbConection.getNombreTipo(tipo);

            this.Text += txtTipo;
            lblNombre.Text += txtTipo;
        }

        private void txbNombreEntregable_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                btnGuardar.PerformClick();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if( txbNombreEntregable.Text.Trim() != string.Empty )
            {
                string nameEntregable = txbNombreEntregable.Text;
                // for ( char i = nameEntregable; i <= 10; i++ )
                Console.WriteLine("Tipo grabado: " + tipo );
                ( this.Owner as FormGrupoMateria ).recibirIdEntregaNueva( nameEntregable, dbConection.agregarEntregable(tipo, nameEntregable, materia), tipo );
                this.Dispose();
            }
            else
            {
                txbNombreEntregable.Focus();
                txbNombreEntregable.BackColor = System.Drawing.Color.LightSalmon;
                System.Media.SystemSounds.Beep.Play();
            }
        }
    }
}
