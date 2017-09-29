using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormGrupoMateria : Form
    {
        GroupBox groupVisible;
        int idMateria, idGrupo;


//*************************** constructor ******************************************

        /// <summary> ventana principal del progrma </summary>
        /// <param name="idMateria"> id de la materia a mostrar </param>
        public FormGrupoMateria(int idMateria, int idGrupo)
        {
            InitializeComponent();

            this.idMateria = idMateria;
            this.idGrupo = idGrupo;

            string grupo, materia, numeroAlumnos, escuela;

            Program.getIfo(idMateria, idGrupo, out grupo, out materia, out numeroAlumnos, out escuela);

            lblGrupo.Text = grupo;
            lblMateria.Text = materia;
            lblDatosGrupo.Text = numeroAlumnos + lblDatosGrupo.Text + escuela;

            this.Text = grupo + " " + materia;
            
            groupBoxAsistencia.Visible = true;
            /*
             * aqui ponermos los demas groupBoxes
             * */
            groupVisible = groupBoxAsistencia;

        }


// ******************************** btn Eventos ***************************************************

        /// <summary> muestra la ventana asistencia y las demas invisibles </summary>
        private void btnAsistencia_Click(object sender, System.EventArgs e)
        {
            show(groupBoxAsistencia);
        }


// ************************************** metodos *****************************************************

        /// <summary> muestra el groupBox indicado y oculta el visible anteriormente </summary>
        private void show(GroupBox newVisible)
        {
            groupVisible.Visible = false;
            newVisible.Visible = true;
            groupVisible = newVisible;
        }
        
    }
}
