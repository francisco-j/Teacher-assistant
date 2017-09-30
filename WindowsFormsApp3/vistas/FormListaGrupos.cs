using System;
using System.Windows.Forms;
using WindowsFormsApp3.vistas;

namespace WindowsFormsApp3
{
    public partial class FormListaGrupos : Form
    {
        // id del maestro que esta viendo la ventana
        private int idMaestro;
        private Grupo[] grupos;

        //*********************************  constructor ********************************

        ///<sumary> ventana que muestra los grupos asociados con un maestro </sumary>
        /// <param name="idMaestro"> id del maestro cuyos grupos se mostraran </param>>
        public FormListaGrupos(int idMaestro)
        {
            InitializeComponent();

            this.idMaestro = idMaestro;

            cargarBotones();

        }

        //**************************** btn_click ********************************************

        /// <summary> evento para los botonesGrupo  </summary>
        public void boton_Click(object sender, System.EventArgs e)
        {
            string grupo = (sender as Button).Name.Replace("btnGrupo", "");
            int idGrupo = int.Parse(grupo);

            Program.showListaMaterias(idGrupo);
            this.Hide();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            Program.busqueda(txbBusqueda.Text);
        }

        private void btnLogOut_Click(object sender, System.EventArgs e)
        {
            Program.LogOut(this);
        }

        private void btnAgregarGrupo_Click(object sender, System.EventArgs e)
        {
            FormAgregarGrupo nuevoGrupo = new FormAgregarGrupo(this);
            nuevoGrupo.ShowDialog(this);
        }

        // ***************************** metodos  *******************************************************

        ///<sumary> limpia el contenedor y carga todos los grupos como botones nuevos </sumary>
        public void cargarBotones()
        {
            grupos = Program.gruposDeMaestro(idMaestro);

            contenedorGrupos.Controls.Clear();
            int color = 0;
            
            Panel contenedor;

            foreach (Grupo grp in grupos)
            {
                Button boton = PersonalizacionComponentes.hacerBotonGrupo(grp, color);
                boton.Click += new EventHandler(boton_Click);
                contenedor = PersonalizacionComponentes.hacerConternedorGrupo(ref boton, grp);

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
    }
}