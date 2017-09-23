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
        //La siguiente variable obtendrá de la base de datos la cantidad de grupos registrados para este maestro 
        private int numeroBotones;
        //La siguiente variable se utiliazará para cargar todos los botones en el contenedor containerGrupos
        private Button boton;
        //Vector que almacena colores que asignará a los botones que vayan siendo agregados, máximo habrá 10 botones de grupo por lo que se cubren todos los casos
        private Color[ ] coloresBotones = new Color[ 10 ] { Color.Aqua, Color.Beige, Color.Red, Color.Pink, Color.Yellow, Color.White, Color.Snow, Color.Silver, Color.Salmon, Color.RoyalBlue };

        public FormListaGrupos()
        {
            InitializeComponent();

            numeroBotones = 0;

            for( int i = 0; i < 1; i++, numeroBotones++ )
            {
                boton = new Button();
                containerGrupos.Controls.Add( boton );

                configurarBoton( ref boton, "Grupo" + ( i + 1 ), "Grupo " + ( i + 1 ), 150, 115, "Microsoft Sans Serif", 20, coloresBotones[ i ] );

                boton.Click += new System.EventHandler( boton_Click );
            }
        }

        private void boton_Click(object sender, System.EventArgs e)
        {
            Program.showListaMaterias((sender as Button).Text);
            //Se oculta esta ventana para que cuando se regrese no se vuelva a cargar todo
            this.Hide();
        }

        private void configurarBoton(ref Button boton, string nombre, string text, int ancho, int alto, string fuente, int tamañoLetra, Color color)
        {
            boton.Name = nombre;
            boton.Text = text;

            Size tamaño = new Size();
            tamaño.Width = ancho;
            tamaño.Height = alto;
            boton.Size = tamaño;

            Font letra = new Font( fuente, tamañoLetra );
            boton.Font = letra;

            boton.BackColor = color;
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, System.EventArgs e)
        {
            Program.LogOut( this );
        }

        private void btnAgregarGrupo_Click(object sender, System.EventArgs e)
        {
            if (numeroBotones < 10)
            {
                numeroBotones++;
                Button botonNuevo = new Button();
                configurarBoton( ref botonNuevo, "Grupo" + numeroBotones, "Grupo " + numeroBotones, 150, 115, "Microsoft Sans Serif", 20, coloresBotones[ numeroBotones - 1 ] );
                containerGrupos.Controls.Add( botonNuevo );

                botonNuevo.Click += new System.EventHandler( boton_Click );
            }
            else
            {
                MessageBox.Show( "Sólo se pueden tener un máximo de 10 grupos por sesión" );
            }
        }
    }
}
