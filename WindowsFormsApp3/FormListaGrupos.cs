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

        public FormListaGrupos(int[] grupos)
        {
            InitializeComponent();

            numeroBotones = 0;

            for( int i = 0; i < 1; i++, numeroBotones++ )
            {
                boton = new Button();
                containerGrupos.Controls.Add( boton );

                configurarBoton( ref boton, "Grupo" + ( i + 1 ), "Grupo " + ( i + 1 ), new Size(150, 115), new Font("Microsoft Sans Serif", 20), coloresBotones[ i ] );

                boton.Click += new System.EventHandler( boton_Click );
            }
        }

        private void boton_Click(object sender, System.EventArgs e)
        {
            Program.showListaMaterias((sender as Button).Text);
            //Se oculta esta ventana para que cuando se regrese no se vuelva a cargar todo
            this.Hide();
        }

        private void configurarBoton(ref Button boton, string nombre, string text, Size tamanio, Font fuente, Color color)
        {
            boton.Name = nombre;
            boton.Text = text;
            boton.Size = tamanio;
            boton.Font = fuente;
            boton.BackColor = color;
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
            //que muestre formAgregarGrupo


            if (numeroBotones < 10)
            {
                numeroBotones++;
                Button botonNuevo = new Button();
                configurarBoton( ref botonNuevo, "Grupo" + numeroBotones, "Grupo " + numeroBotones, new Size(150, 115), new Font("Microsoft Sans Serif", 20), coloresBotones[ numeroBotones - 1 ] );
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
