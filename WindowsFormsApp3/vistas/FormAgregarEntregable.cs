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
            dbConection.agregarEntregable(tipo, txbNombreEntregable.Text, materia);
            this.Dispose();
        }
    }
}
