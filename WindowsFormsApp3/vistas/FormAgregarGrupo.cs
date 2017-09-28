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

// ******************* constructor ****************************

            /// <summary> ventana para agregar nuevos grupos
            /// </summary>
            /// <param name="ventanaPadre"></param>
        public FormAgregarGrupo( FormListaGrupos ventanaPadre )
        {
            InitializeComponent();

            this.ventanaPadre = ventanaPadre;

        }

            /// <summary> guardar el grupo en la base de datos y luego lo agrega al formulario
            /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            /*if( txbGrado.Text == "" )
            {
                MessageBox.Show( "El campo grado es obligatorio" );
                txbGrado.Focus();
            }
            else if( txbGrupo.Text == "" )
            {
                MessageBox.Show( "El campo grupo es obligatorio" );
                txbGrupo.Focus();
            }
            else*/
            {
                int grado = (int)numGrado.Value;
                char grupo = cbGrupo.Text.First();
                string escuela = txbEscuela.Text;
                int maestro = ventanaPadre.GetIdMaestro();
                //try catch
                Program.agregarGrupo( grado, grupo, escuela, maestro );
                ventanaPadre.CargarBotones();
                this.Dispose();
            }
        }
        
            /// <summary> verifica que no se ingresen letras en el txbGrado
            /// </summary>
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
