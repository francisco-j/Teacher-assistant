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
    public partial class AgregarGrupo : Form
    {
        public AgregarGrupo()
        {
            InitializeComponent();
        }

        //Aquí debe de guardar el grupo en la base de datos y luego agregarlo al formulario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if( txbNombre.Text == "" )
            {
                MessageBox.Show( "Por favor ingresa el nombre del grupo" );
                txbNombre.Focus();
            }
            else
            {
            
            }
        }
    }
}
