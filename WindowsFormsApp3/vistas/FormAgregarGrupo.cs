using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp3.clases_objeto;

namespace WindowsFormsApp3
{
    public partial class FormAgregarGrupo : Form
    {
        //para cuando se modifica un grupo
        int idGrupo;

        //para cuando se crea un grupo
        int idMaestro;

// ******************* constructores ****************************

        /// <summary> ventana para agregar nuevos grupos </summary>
        public FormAgregarGrupo(int idMaestro)
        {
            InitializeComponent();

            this.idMaestro = idMaestro;

            btnGuardar.Click += btnAgregar_Click;
        }

        /// <summary> ventana para modificarar un grupo existente </summary>
        public FormAgregarGrupo(Grupo grupo)
        {
            InitializeComponent();
            this.Text = "Editar Grupo " +grupo.ToString();
            
            this.idGrupo = grupo.getId();
            numGrado.Value = grupo.getGrado();
            cbGrupo.Text = grupo.ToString();
            txbEscuela.Text = grupo.getEscuela();

            btnGuardar.Click += btnModificar_Click;

        }

// ************************** eventos para asignar *************************************
        
        /// <summary> para crear un nuevo grupo </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int grado = (int)numGrado.Value;
            char grupo = cbGrupo.Text.First();
            string escuela = txbEscuela.Text.Trim();

            //try catch
            dbConection.agregarGrupo(grado, grupo, escuela, idMaestro);
            this.Dispose();
        }
        
        /// <summary> para modoficar un grupo existente </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int grado = (int)numGrado.Value;
            char grupo = cbGrupo.Text.First();
            string escuela = txbEscuela.Text.Trim();

            //try catch
            dbConection.modificarGrupo(idGrupo, grado, grupo, escuela);
            this.Dispose();
        }
    }
}