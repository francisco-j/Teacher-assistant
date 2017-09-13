using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormGrupo : Form
    {
        public FormGrupo(short groupId)
        {
            InitializeComponent();
            Text += groupId;
        }
    }
}
