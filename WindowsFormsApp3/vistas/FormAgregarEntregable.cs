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
