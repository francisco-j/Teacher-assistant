using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.vistas
{
    public partial class FormAgregarMateria : Form
    {
        FormListaMaterias ventanaPadre;

        /// <summary> ventana para agregar nuevas materias </summary>
        /// <param name="ventanaPadre"> FormListaMaterias padre </param>
        public FormAgregarMateria( FormListaMaterias ventanaPadre )
        {
            InitializeComponent();

            this.ventanaPadre = ventanaPadre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validacion, que el nombre no este vacío
            string nombre = txbNombreMateria.Text;
            int salon = ventanaPadre.getIdGrupo();

            //try catch
            Program.agregarMateria(nombre, salon);
            ventanaPadre.cargarBotones();
            this.Dispose();
        }
    }
}
