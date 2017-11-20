using System;
using System.Windows.Forms;
using WindowsFormsApp3.clases_objeto;
using WindowsFormsApp3.vistas;

namespace WindowsFormsApp3
{
    public partial class FormListaGrupos : Form
    {
        // id del maestro que inició sesión
        private int idMaestro;
        private Grupo[] grupos;

//*********************************  constructor ********************************

        ///<sumary> ventana que muestra los grupos asociados con el maestro indicado </sumary>
        public FormListaGrupos(int idMaestro)
        {
            InitializeComponent();

            this.idMaestro = idMaestro;

            if( cargarBotones() )
            {
                lblInfo.Hide();
                lblArrow.Hide();
            }
            
            this.Show();
        }

//**************************** btn_click ********************************************

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            if( txbBusqueda.Text == "Nombre del alumno" )
            {
                new FormResultadoBusqueda("", idMaestro);
            }
            else
            {
                new FormResultadoBusqueda(txbBusqueda.Text, idMaestro);
            }
        }

        private void btnLogOut_Click(object sender, System.EventArgs e)
        {
            Program.LogOut();
            this.Dispose();
        }

        private void btnAgregarGrupo_Click(object sender, System.EventArgs e)
        {
            if (new FormAgregarGrupo(idMaestro).ShowDialog(this) == DialogResult.OK)
            {
                cargarBotones();

                removeLblInfo();
            }
        }

// ***************************** metodos  *******************************************************

        ///<sumary> limpia el contenedor y carga todos los grupos como botones nuevos </sumary>
        public bool cargarBotones()
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

            return grupos.Length > 0;
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

        public void removeLblInfo()
        {
            if (this.Controls.ContainsKey("lblInfo"))
            {
                lblInfo.Hide();
                lblArrow.Hide();
            }
        }

        public void mostrarLblInfo()
        {
            if( grupos.Length == 0 )
            {
                lblInfo.Show();
                lblArrow.Show();
            }
        }

        private void txbBusqueda_Click(object sender, EventArgs e)
        {
            txbBusqueda.Text = "";
            txbBusqueda.ForeColor = System.Drawing.Color.Black;
            txbBusqueda.ReadOnly = false;
            txbBusqueda.Focus();
        }
    }
}