using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

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

            btnGuardar.Click += btnAgregar_Click;
        }

        /// <summary> ventana para modificarar un grupo existente </summary>
        public FormAgregarGrupo(int idGrupo)
        {
            InitializeComponent();
            this.Text = "Editar Grupo";

            Grupo grupo = Program.getGrupo(idGrupo);

            this.idGrupo = idGrupo;
            numGrado.Value = grupo.getGrado();
            cbGrupo.Text = grupo.ToString();
            txbEscuela.Text = grupo.getEscuela();

            btnGuardar.Click += btnModificar_Click;

            this.Visible = true;

        }

// ************************** eventos para asignar *************************************

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

            //try catch
            Program.modificarGrupo(idGrupo, grado, grupo, escuela);
            Program.listaGrupos.cargarBotones();
            this.Dispose();

        }
    }
}