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

        /// <summary> ventana para agregar nuevos grupos </summary>
        /// <param name="ventanaPadre"> FormListaGrupos padre </param>
        public FormAgregarGrupo(FormListaGrupos ventanaPadre)
        {
            InitializeComponent();

            this.ventanaPadre = ventanaPadre;

        }

        /// <summary> guardar el grupo en la base de datos y luego lo agrega al formulario </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int grado = (int)numGrado.Value;
            char grupo = cbGrupo.Text.First();
            string escuela = txbEscuela.Text;
            int maestro = ventanaPadre.GetIdMaestro();

            //try catch
            Program.agregarGrupo(grado, grupo, escuela, maestro);
            ventanaPadre.cargarBotones();
            this.Dispose();

        }

    }
}