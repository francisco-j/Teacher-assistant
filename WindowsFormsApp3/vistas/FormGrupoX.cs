using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormGrupo : Form
    {
        GroupBox groupVisible;

        public FormGrupo(int groupId) //recibe el id del grupo a mostrar
        {
            InitializeComponent();
            this.Text += groupId;  //en el titulo del form agrega el nombre del grupo
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
