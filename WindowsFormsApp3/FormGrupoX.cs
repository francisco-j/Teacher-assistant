using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormGrupo : Form
    {
        public FormGrupo(ushort groupId)
        {
            InitializeComponent();
            this.Text += groupId;  //form text, add group name;
            //lblDatosGrupo.Text = Alumnos + " Alumnos\r\n" + "Primaria" + escuela;

        }

        private void btnAsistencia_Click(object sender, System.EventArgs e)
        {

        }
    }
}
