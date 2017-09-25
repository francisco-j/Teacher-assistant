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
        /*La siguiente varibale es la que se comunicará con las ventanas agregar grupo y ésta para recibir la información
         del grupo que se quiere crear datosGrupo[ 0 ] almacenará grado, [ 1 ] grupo, [ 2 ] nombre y [ 3 ] descripción*/
        private string[] datosNuevoGrupo = new string[ 4 ];
        //La siguiente variable obtendrá de la base de datos la cantidad de grupos registrados para este maestro 
        private int numeroBotones;
        //La siguiente variable se utiliazará para cargar todos los botones en el contenedor containerGrupos
        private Button boton;
        //Vector que almacena colores que asignará a los botones que vayan siendo agregados, máximo habrá 10 botones de grupo por lo que se cubren todos los casos
        private Color[ ] coloresBotones = new Color[ 10 ] { Color.Aqua, Color.Beige, Color.Red, Color.Pink, Color.Yellow, Color.White, Color.Snow, Color.Silver, Color.Salmon, Color.RoyalBlue };
        private Label escuelaGrupo;
        private Label descripcionGrupo;

//*********************************  constructor ********************************
        public FormListaGrupos( Grupo[] grupos )
        {
            InitializeComponent();

            numeroBotones = 0;

            foreach (Grupo g in grupos)
            {
                boton = new Button();
                containerGrupos.Controls.Add( boton );

                PersonalizacionComponentes.configurarBoton( ref boton, "Grupo "+g.ToString(), "Grupo "+g.ToString(), new Size(150, 115), new Font("Microsoft Sans Serif", 20), coloresBotones[ 2 ] );

                boton.Click += new System.EventHandler( boton_Click );

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
            nuevoGrupo.ShowDialog( );

            if (numeroBotones < 10)
            {
                numeroBotones++;
                Button botonNuevo = new Button();
                PersonalizacionComponentes.configurarBoton( ref botonNuevo, datosNuevoGrupo[ 0 ] + " " + datosNuevoGrupo[ 1 ].ToUpper(), datosNuevoGrupo[ 0 ] + "° - " + datosNuevoGrupo[ 1 ].ToUpper(), new Size(150, 115), new Font("Microsoft Sans Serif", 20), coloresBotones[ numeroBotones - 1 ] );
                containerGrupos.Controls.Add( botonNuevo );

                botonNuevo.Click += new System.EventHandler( boton_Click );
                botonNuevo.Focus();
                /*NO BORRAR
                PersonalizacionComponentes.configurarLabelGrupos( ref escuelaGrupo, datosNuevoGrupo[ 2 ], new Font( "Microsoft Sans Serif", 12 ) );
                PersonalizacionComponentes.configurarLabelGrupos( ref descripcionGrupo, datosNuevoGrupo[ 3 ], new Font( "Microsoft Sans Serif", 12 ) );

                containerGrupos.Controls.Add( escuelaGrupo );
                containerGrupos.Controls.Add( descripcionGrupo );*/
            }
            else
            {
                MessageBox.Show( "Sólo se pueden tener un máximo de 10 grupos por sesión" );
            }
        }


        public void setDatosGrupoNuevo( string grado, string grupo, string escuela, string descripcion )
        {
            datosNuevoGrupo[ 0 ] = grado;
            datosNuevoGrupo[ 1 ] = grupo;
            datosNuevoGrupo[ 2 ] = escuela;
            datosNuevoGrupo[ 3 ] = descripcion;
        }
    }
}
