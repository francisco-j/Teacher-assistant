using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using System.Collections.Generic;

namespace WindowsFormsApp3
{
    public partial class FormListaGrupos : Form
    {
        //grupos a mostrar como botones
        private Grupo[] grupos;
        // id del maestro que esta viendo la ventana
        private int idMaestro;

        private Label escuelaGrupo;
        private Label descripcionGrupo;

//*********************************  constructor ********************************

            ///<sumary> ventana que muestra los grupos asociados con un maestro </sumary>
            /// <param name="idMaestro">
            /// id del maestro </param>>
        public FormListaGrupos( int idMaestro )
        {
            InitializeComponent();

            this.idMaestro = idMaestro;

            CargarBotones();
            
        }

//**************************** btn_click ********************************************

        private void boton_Click(object sender, System.EventArgs e)
        {
            Program.showListaMaterias( ( sender as Button ).Text );
            //Se oculta esta ventana para que cuando se regrese no se vuelva a cargar todo
            this.Hide();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            Program.busqueda(txbBusqueda.Text);
        }

        private void btnLogOut_Click(object sender, System.EventArgs e)
        {
            Program.LogOut( this );
        }

        private void btnAgregarGrupo_Click(object sender, System.EventArgs e)
        {
            FormAgregarGrupo nuevoGrupo = new FormAgregarGrupo( this );
            nuevoGrupo.ShowDialog( this );
        }

// ***************************** metodos  *******************************************************

            ///<sumary> limpia el contenedor y carga todos los grupos como botones nuevos </sumary>
        public void CargarBotones()
        {
            grupos = Program.gruposDeMaestro(idMaestro);

            containerGrupos.Controls.Clear();
            int color = 0;

            Button boton;

            foreach (Grupo grp in grupos)
            {
                boton = new Button();
                containerGrupos.Controls.Add(boton);

                PersonalizacionComponentes.configurarBotonGrupo(ref boton, grp, color);

                boton.Click += new EventHandler(boton_Click);

                color++;
                /*
                 * NO BORRAR
                escuelaGrupo = new Label();
                descripcionGrupo = new Label();
                PersonalizacionComponentes.configurarLabelGrupos( ref escuelaGrupo, "Escuela " + ( i + 1 ), new Font( "Microsoft Sans Serif", 12 ) );
                PersonalizacionComponentes.configurarLabelGrupos( ref descripcionGrupo, "Descripción " + ( i + 1 ), new Font( "Microsoft Sans Serif", 12 ) );

                containerGrupos.Controls.Add( escuelaGrupo );
                containerGrupos.Controls.Add( descripcionGrupo );
                */
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
