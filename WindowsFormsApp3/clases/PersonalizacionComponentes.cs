using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using System.Collections.Generic;
using WindowsFormsApp3.vistas;

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
            FlowLayoutPanel contenedor = new FlowLayoutPanel();

            //boton (informacion y estilo)
            boton.Text = grupo.ToString();
            boton.Name = "btnGrupo" + grupo.getId();

            boton.Font = miFuenteGrupo;
            boton.Size = new Size(150, 115);
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = botonGrupoColores[color];

            //label (estilo, tamano e info)
            info.Font = miFuenteInfo;
            info.AutoSize = true;
            info.Text += grupo.getEscuela() + "\n";
            info.Text += Program.numeroAlumnosEn(grupo.getId()) + " alumnos";

            //contenedor (tamano)
            contenedor.AutoSize = true;

            //contenedor(llenar)
            contenedor.Controls.Add(boton);
            contenedor.Controls.Add(info);

            //menu contextual del boton(click derecho)
            MenuItem[] mi = {
                    new MenuItem("Editar",editarG_Click),
                    new MenuItem("Borar",borrarG_Click),
                    new MenuItem("Exportar",exportarG_Click)
                };
            mi[0].Name = "Editar" + grupo.getId().ToString();
            mi[1].Name = "Borar" + grupo.getId().ToString();
            mi[2].Name = "Exportar" + grupo.getId().ToString();

            boton.ContextMenu = new ContextMenu(mi);

            //eventos
            boton.Click += new EventHandler(grupo_Click);
            //click derecho;
            
            return contenedor;
        }

        /// <summary> decora el boton con la informacion de la materia indicada </summary>
        public static Button configurarBotonMateria(Materia materia, int color)
        {
            //boton
            Button boton = new Button();

            boton.Font = miFuenteMateria;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = botonMateriaColores[color];

            boton.Text = materia.toString();
            boton.Size = new Size(180, 70);
            boton.Name = "btnMateria" + materia.getId();

            //evento
            boton.Click += new EventHandler(materia_Click);

            //menu contextual del boton(click derecho)
            MenuItem[] mi = {
                    new MenuItem("Editar",editarM_Click),
                    new MenuItem("Borar",borrarM_Click),
                };
            mi[0].Name = "Editar" + materia.getId().ToString();
            mi[1].Name = "Borar" + materia.getId().ToString();
            
            boton.ContextMenu = new ContextMenu(mi);

            return boton;
        }

// **************************  eventos para asignar *********************************
        
                        // ** grupos ** //

        /// <summary> evento para los botonesGrupo  </summary>
        private static void grupo_Click(object sender, System.EventArgs e)
        {
            string grupo = (sender as Button).Name.Replace("btnGrupo", "");
            int idGrupo = int.Parse(grupo);

            Program.showListaMaterias(idGrupo);
            Program.listaGrupos.Hide();
        }

        /// <summary> para menu contextual de grupo </summary>
        private static void editarG_Click(object sender, System.EventArgs e)
        {
            int idGrupo = int.Parse((sender as MenuItem).Name.Replace("Editar", ""));
            new FormAgregarGrupo(idGrupo);
        }

        /// <summary> para menu contextual de grupo </summary>
        private static void borrarG_Click(object sender, System.EventArgs e)
        {
            int idGrupo = int.Parse((sender as MenuItem).Name.Replace("Borar", ""));
            new FormBorrarGrupo(idGrupo);
        }

        /// <summary> para menu contextual de grupo </summary>
        private static void exportarG_Click(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
            //int idGrupo = int.Parse((sender as MenuItem).Name.Replace("Exportar", ""));
            //Program.listaGrupos.ShowDialog(new FormExportarGrupo(idGrupo));
        }

                        // ** materias ** //
        
        /// <summary> evento para los botonesMateria </summary>
        private static void materia_Click(object sender, System.EventArgs e)
        {
            string materia = (sender as Button).Name.Replace("btnMateria", "");
            int idMateria = int.Parse(materia);

            Program.showGrupoMateria(idMateria, ((FormListaMaterias)Program.listaMaterias).getIdGrupo());
            Program.listaMaterias.Hide();
        }
        
        /// <summary> para menu contextual de grupo </summary>
        private static void editarM_Click(object sender, System.EventArgs e)
        {
            int idMateria = int.Parse((sender as MenuItem).Name.Replace("Editar", ""));
            new FormAgregarMateria(idMateria);
        }

        /// <summary> para menu contextual de grupo </summary>
        private static void borrarM_Click(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
            //int idMateria = int.Parse((sender as MenuItem).Name.Replace("Borar", ""));
            //new FormBorrarMateria(idMateria);
        }

    }
}
