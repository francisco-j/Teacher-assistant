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

#region constructores

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

#endregion

#region eventos para asignar

        /// <summary> para crear un nuevo grupo </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int grado = (int)numGrado.Value;
            char grupo = cbGrupo.Text.First();
            string escuela = txbEscuela.Text.Trim();

            //try catch
            int idGrupo = dbConection.agregarGrupo(grado, grupo, escuela, idMaestro);

            (this.Owner as FormListaGrupos).recibirGrupoNuevo(new Grupo(idGrupo, grado, grupo, escuela));
            this.Dispose();
        }
        
        /// <summary> para modoficar un grupo existente </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int grado = (int)numGrado.Value;
            char grupo = Char.ToUpper( cbGrupo.Text.First() );
            string escuela = txbEscuela.Text.Trim();

            //try catch
            dbConection.modificarGrupo(idGrupo, grado, grupo, escuela);

            (this.Owner as FormListaGrupos).modificacionGrupo(new Grupo(idGrupo, grado, grupo, escuela));
            this.Dispose();
        }


        private void txbEscuela_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                btnGuardar.PerformClick();
            }
        }

        private void cbGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                txbEscuela.Focus();
            }
        }

        private void numGrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbGrupo.Focus();
        }
        #endregion

    }
}