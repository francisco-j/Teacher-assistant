using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using System.Collections.Generic;

/// <summary> clase encargada de guardar los métodos que usaremos para personalizar componentes como:
/// los botones, labels y demás componenetes que estaremos generando en tiempo de ejecución
/// todos los metodos son static por que la clase no se instancia </summary>
namespace WindowsFormsApp3
{
    class PersonalizacionComponentes
    {
        private static Color[] botonGrupoColores = new Color[10] { Color.Aqua, Color.Beige, Color.Red, Color.Pink, Color.Yellow, Color.White, Color.Snow, Color.Silver, Color.Salmon, Color.RoyalBlue };
        private static Color[] botonMateriaColores = new Color[10] { Color.Aqua, Color.Beige, Color.Red, Color.Pink, Color.Yellow, Color.White, Color.Snow, Color.Silver, Color.Salmon, Color.RoyalBlue };
        private static Font miFuenteGrupo = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
        private static Font miFuenteMateria = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        private static Font miFuenteInfo = new Font("Microsoft Sans Serif", 16);


//********************************** constructor **************************************

        //privado para que no lo instancien
        private PersonalizacionComponentes() { }


// **************************************  metodos ********************************************

        /// <summary> debuelbe el contenedor con la informacion del grupo indicado </summary>
        /// <param name="boton"> contenedor a decorar </param>
        /// <param name="grupo"> grupo del que se tomara la informacion </param>
        public static FlowLayoutPanel hacerConternedorGrupo(Grupo grupo, int color)
        {
            //componentes (declarar todo)
            Label info = new Label();
            Button boton = new Button();
            ContextMenu cm = new ContextMenu();
            FlowLayoutPanel contenedor = new FlowLayoutPanel();

            //boton (informacion y estilo)
            boton.Text = grupo.ToString();
            boton.Name = "btnGrupo" + grupo.getId();

            boton.Font = miFuenteGrupo;
            boton.Size = new Size(150, 115);
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = botonGrupoColores[color];

            //label
            info.Font = miFuenteInfo;
            info.AutoSize = true;
            info.Text += grupo.getEscuela() + "\n";
            info.Text += Program.numeroAlumnosEn(grupo.getId()) + " alumnos";

            //contenedor (tamano)
            contenedor.AutoSize = true;

            //contenedor(llenar)
            contenedor.Controls.Add(boton);
            contenedor.Controls.Add(info);
            
            //menu contextual del boton
            MenuItem[] mi = { new MenuItem("Editar"), new MenuItem("Borar"), new MenuItem("Exportar") };
            cm.MenuItems.AddRange(mi);
            boton.ContextMenu = cm;

            //eventos
            boton.Click += new EventHandler(boton_Click);
            //click derecho;
            
            return contenedor;
        }


        /// <summary> decora el boton con la informacion de la materia indicada </summary>
        public static void configurarBotonMateria(ref Button boton, Materia materia, int color)
        {
            boton.Font = miFuenteMateria;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = botonMateriaColores[color];

            boton.Text = materia.toString();
            boton.Size = new Size(180, 70);
            boton.Name = "btnMateria" + materia.getId();
        }

// **************************  eventos para asignar *********************************
        
        /// <summary> evento para los botonesGrupo  </summary>
        private static void boton_Click(object sender, System.EventArgs e)
        {
            string grupo = (sender as Button).Name.Replace("btnGrupo", "");
            int idGrupo = int.Parse(grupo);

            Program.showListaMaterias(idGrupo);
            Program.listaGrupos.Hide();
        }



    }
}
