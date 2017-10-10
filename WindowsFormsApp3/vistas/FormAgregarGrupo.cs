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
            dtPickerInicio.Value = grupo.getInicioCurso();
            dtPickerFin.Value = grupo.getFinCurso();

            btnGuardar.Click += btnModificar_Click;

        }

// ************************** eventos para asignar *************************************
        
        /// <summary> para crear un nuevo grupo </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int grado = (int)numGrado.Value;
            char grupo = cbGrupo.Text.First();
            string escuela = txbEscuela.Text.Trim();
            int maestro = idMaestro;
            DateTime inicioCurso = dtPickerInicio.Value;
            DateTime finCurso = dtPickerFin.Value;

            //try catch
            Program.agregarGrupo(grado, grupo, escuela, maestro, inicioCurso, finCurso);
            this.Dispose();

        }
        
        /// <summary> para modoficar un grupo existente </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int grado = (int)numGrado.Value;
            char grupo = cbGrupo.Text.First();
            string escuela = txbEscuela.Text.Trim();
            DateTime inicioCurso = dtPickerInicio.Value;
            DateTime finCurso = dtPickerFin.Value;

            //try catch
            Program.modificarGrupo(idGrupo, grado, grupo, escuela, inicioCurso, finCurso);
            this.Dispose();
        }

        private void FormAgregarGrupo_Load(object sender, EventArgs e)
        {

        }
    }
}