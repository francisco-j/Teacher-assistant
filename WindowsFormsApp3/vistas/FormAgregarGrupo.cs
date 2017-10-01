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

        //para cuando se modifica un grupo
        int idGrupo;

        // ******************* constructores ****************************

        /// <summary> ventana para agregar nuevos grupos </summary>
        /// <param name="ventanaPadre"> FormListaGrupos padre </param>
        public FormAgregarGrupo(FormListaGrupos ventanaPadre)
        {
            InitializeComponent();

            this.ventanaPadre = ventanaPadre;

        }

        /// <summary> ventana para modificarar un grupo existente </summary>
        public FormAgregarGrupo(int idGrupo)
        {
            InitializeComponent();
            this.Text = "Editar Grupo";

            Grupo grupo = Program.getGrupo(idGrupo);

            this.idGrupo = idGrupo;
            numGrado.Value = grupo.getGrado();
            cbGrupo.Text = grupo.getGrupo();
            txbEscuela.Text = grupo.getEscuela();

        }

        /// <summary> guardar el grupo en la base de datos y luego lo agrega al formulario </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
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

        /// <summary> guardar el grupo en la base de datos y luego lo agrega al formulario </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int grado = (int)numGrado.Value;
            char grupo = cbGrupo.Text.First();
            string escuela = txbEscuela.Text;
            int maestro = ventanaPadre.GetIdMaestro();

            //try catch
            Program.modificarGrupo(idGrupo, grado, grupo, escuela);
            ventanaPadre.cargarBotones();
            this.Dispose();

        }



    }
}