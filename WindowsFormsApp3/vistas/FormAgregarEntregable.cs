using System;
using System.Windows.Forms;

namespace WindowsFormsApp3.vistas
{
    public partial class FormAgregarEntregable : Form
    {
        private int tipo;

        public FormAgregarEntregable(int tipo)
        {
            this.tipo = tipo;

            InitializeComponent();
            string txtTipo = dbConection.getNombreTipo(tipo);

            this.Text += txtTipo;
            lblNombre.Text += txtTipo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dbConection.agregarEntregable(tipo, txbNombreEntregable.Text);
            this.Dispose();
        }
    }
}
