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

            personalizarVentana(idMateria, idGrupo);

            //dodos los groupBox son visibles=false por defecto
            show(grpBxAsistencia);

        }


// ******************************** btn Eventos ***************************************************

        /// <summary> muestra la ventana asistencia y las demas invisibles </summary>
        private void btnAsistencia_Click(object sender, System.EventArgs e)
        {
            show(grpBxAsistencia);
        }


// ************************************** metodos *****************************************************

        /// <summary> muestra el groupBox indicado y oculta el visible anteriormente </summary>
        private void show(GroupBox newVisible)
        {
            groupVisible.Visible = false;
            newVisible.Visible = true;
            groupVisible = newVisible;
        }
        
// **************************************** privados **************************************************

        private void personalizarVentana(int idMateria,int idGrupo)
        {
            string grupo, materia, numeroAlumnos, escuela;

            Program.getIfo(idMateria, idGrupo, out grupo, out materia, out numeroAlumnos, out escuela);

            lblGrupo.Text = grupo;
            lblMateria.Text = materia;
            lblDatosGrupo.Text = numeroAlumnos + lblDatosGrupo.Text + escuela;

            this.Text = grupo + " " + materia;
        }
    }
}
