using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormGrupoMateria : Form
    {
        GroupBox groupVisible;

        /// <summary> ventana principal del progrma </summary>
        /// <param name="groupId"> id del grupo a mostrar </param>
        public FormGrupoMateria(int idMateria)
        {
            InitializeComponent();
            this.Text += idMateria;  //en el titulo del form agrega el nombre del grupo
            //lblDatosGrupo.Text = Alumnos + " Alumnos\r\n" + "Primaria" + escuela; //llena la informacion del grupo

            groupBoxAsistencia.Visible = true;
            /*
             * aqui ponermos los demas groupBoxes
             * */
            groupVisible = groupBoxAsistencia;

        }

        private void btnAsistencia_Click(object sender, System.EventArgs e) // muestra la ventana asistencia y las demas invisibles
        {
            show(groupBoxAsistencia);
        }


        private void show(GroupBox newVisible) //muestra el groupBox indicado y oculta el visible anteriormente
        {
            groupVisible.Visible = false;
            newVisible.Visible = true;
            groupVisible = newVisible;
        }

        private void btnAlumnos_Click(object sender, System.EventArgs e)
        {

        }
    }
}
