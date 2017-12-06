using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp3.clases_objeto;
using WindowsFormsApp3.vistas;

namespace WindowsFormsApp3
{
    public partial class FormListaGrupos : Form
    {
        // id del maestro que inició sesión
        private int idMaestro;
        private List<Grupo> grupos;
        private int color;

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
                new FormResultadoBusqueda(txbBusqueda.Text.Trim(), idMaestro);
            }
        }

        private void btnLogOut_Click(object sender, System.EventArgs e)
        {
            Program.LogOut();
            this.Dispose();
        }

        private void btnAgregarGrupo_Click(object sender, System.EventArgs e)
        {
            if( grupos.Count != 10 )
            {
                new FormAgregarGrupo(idMaestro).ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Sólo puedes agregar un máximo de 10 grupos por maestro", "´Grupos llenos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

// ***************************** metodos  *******************************************************

        ///<sumary> limpia el contenedor y carga todos los grupos como botones nuevos </sumary>
        public bool cargarBotones()
        {
            grupos = dbConection.GruposAsociadosCon(idMaestro);

            contenedorGrupos.Controls.Clear();
            color = 0;
            
            Panel contenedor;

            foreach (Grupo grp in grupos)
            {
                contenedor = PersonalizacionComponentes.hacerConternedorGrupo(grp, color);
                contenedorGrupos.Controls.Add(contenedor);
                
                color++;
            }

            return grupos.Count > 0;
        }

        public void recibirGrupoNuevo( Grupo newGrupo )
        {
            removeLblInfo();
            grupos.Add(newGrupo);
            contenedorGrupos.Controls.Add( PersonalizacionComponentes.hacerConternedorGrupo(newGrupo, color) );
            color++;
        }

        public void modificacionGrupo( Grupo grupoModificado )
        {
            string id = grupoModificado.getId().ToString();
            FlowLayoutPanel panelGrupoCambios = ((FlowLayoutPanel)contenedorGrupos.Controls.Find(id, false)[0]);
            Button botonGrupo = (Button)panelGrupoCambios.Controls.Find(id, false)[0];
            botonGrupo.Text = grupoModificado.ToString();

            Label info = (Label)panelGrupoCambios.Controls.Find("Label" + id, false)[0];
            string nameGroup = grupoModificado.getEscuela();
            if (nameGroup.Length > 18)
            {
                ToolTip message = new ToolTip();
                message.SetToolTip(info, nameGroup);

                nameGroup = nameGroup.Substring(0, 16) + "...";
            }
            info.Text = nameGroup + "\n" + dbConection.numeroAlumnosEn(grupoModificado.getId()) + " alumnos";

            //Se cambia también en la lista
            for( int i = 0; i < grupos.Count; i++ )
            {
                if( grupos[i].getId() == grupoModificado.getId() )
                {
                    grupos[i] = grupoModificado;
                    break;
                }
            }
        }

        public void eliminarGrupo( int idGrupoEliminar )
        {
            contenedorGrupos.Controls.RemoveByKey(idGrupoEliminar.ToString());

            for( int i = 0; i < grupos.Count; i++ )
            {
                if( grupos[i].getId() == idGrupoEliminar )
                {
                    grupos.RemoveAt(i);
                    break;
                }
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
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                btnBuscar.PerformClick();
            }
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
            if( grupos.Count == 0 )
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