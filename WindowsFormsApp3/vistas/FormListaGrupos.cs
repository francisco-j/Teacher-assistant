using System;
using System.Windows.Forms;
using WindowsFormsApp3.clases_objeto;
using WindowsFormsApp3.vistas;

namespace WindowsFormsApp3
{
    public partial class FormListaGrupos : Form
    {
        // id del maestro que esta viendo la ventana
        private int idMaestro;
        private Grupo[] grupos;

//*********************************  constructor ********************************

        ///<sumary> ventana que muestra los grupos asociados con el maestro indicado </sumary>
        public FormListaGrupos(int idMaestro)
        {
            InitializeComponent();

            this.idMaestro = idMaestro;

            cargarBotones();

            this.Show();

        }

//**************************** btn_click ********************************************

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            new FormResultadoBusqueda(txbBusqueda.Text);
        }

        private void btnLogOut_Click(object sender, System.EventArgs e)
        {
            Program.LogOut();
            this.Dispose();
        }

        private void btnAgregarGrupo_Click(object sender, System.EventArgs e)
        {
            new FormAgregarGrupo(idMaestro).ShowDialog(this);

            cargarBotones();
        }

// ***************************** metodos  *******************************************************

        ///<sumary> limpia el contenedor y carga todos los grupos como botones nuevos </sumary>
        public void cargarBotones()
        {
            grupos = dbConection.GruposAsociadosCon(idMaestro);

            contenedorGrupos.Controls.Clear();
            int color = 0;
            
            Panel contenedor;

            foreach (Grupo grp in grupos)
            {
                contenedor = PersonalizacionComponentes.hacerConternedorGrupo(grp, color);
                contenedorGrupos.Controls.Add(contenedor);

                color++;
            }
        }

// ********************************** geter *********************************************

        /// <summary> id del maestro que controla los grupos de este form </summary>
        public int GetIdMaestro()
        {
            return idMaestro;
        }

        private void txbBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnBuscar.PerformClick();
        }

        private void FormListaGrupos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}