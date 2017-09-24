using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormAgregarGrupo : Form
    {
        FormListaGrupos ventanaPadre;
        public FormAgregarGrupo( FormListaGrupos ventana )
        {
            InitializeComponent();

            ventanaPadre = ventana;
        }

        //Aquí debe de guardar el grupo en la base de datos y luego agregarlo al formulario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if( txbGrado.Text == "" )
            {
                MessageBox.Show( "El campo grado es obligatorio" );
                txbGrado.Focus();
            }
            else if( txbGrupo.Text == "" )
            {
                MessageBox.Show( "El campo grupo es obligatorio" );
                txbGrupo.Focus();
            }
            else
            {
                ventanaPadre.setDatosGrupoNuevo( txbGrado.Text, txbGrupo.Text, txbEscuela.Text, txbDescripcion.Text );
                this.Dispose();
            }
        }

        private void FormAgregarGrupo_Load(object sender, EventArgs e)
        {

        }

        //Método que verifica que no se ingresen letras en el txbGrado
        private void txbGrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!( char.IsNumber( e.KeyChar ) ) && ( e.KeyChar != ( char )Keys.Back ))
            {
                MessageBox.Show( "Sólo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                e.Handled = true;
                return;
            }
            txbGrado.Text = "";
        }
    }
}
