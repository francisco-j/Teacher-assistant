using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using System.Collections.Generic;

namespace WindowsFormsApp3.vistas
{
    public partial class FormResultadoBusqueda : Form
    {
        //almacenamos los alumnos para cuando queramos ver al info de cada uno
        Alumno[] alumnos;


//********************** constructor ******************************************

        /// <summary> ventana que muestra la busqueda indicada </summary>
        public FormResultadoBusqueda(string busqueda)
        {
            InitializeComponent();

            txbBusqueda.Text = busqueda;
            mostrar(busqueda);

            this.Show();
        }


//*************************************** btn_click  ****************************

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mostrar(txbBusqueda.Text);
        }


//********************************  metodos  ******************************************

        /// <summary> busca en la DB y agrega a la lista </summary>
        private void mostrar(string busqueda)
        {
            lstBxNombres.Items.Clear();
            lstBxGrados.Items.Clear();
            lblSinResultados.Visible = false;

            alumnos =  Program.busqueda(busqueda);

            if (alumnos.Length == 0)
            {
                lblSinResultados.Visible = true;
            }
            else
            {
                foreach (Alumno a in alumnos)
                {
                    lstBxNombres.Items.Add(a.nombreCompletoPN());
                    Grupo g = Program.getGrupo(a.getGupo());
                    lstBxGrados.Items.Add(g.ToString());
                }
                lstBxGrados.Height = lstBxGrados.PreferredHeight;
                lstBxNombres.Height = lstBxNombres.PreferredHeight;
            }
        }

    }
}
