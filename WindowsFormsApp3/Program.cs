using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using WindowsFormsApp3.clases;

namespace WindowsFormsApp3
{
    static class Program
    {

        private static Form inicio, listaG, grupo;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine( dbConection.canConnect());
            inicio = new FormInicio();
            Application.Run(inicio);
        }

        internal static void Login(String contra) //para iniciar secion
        {
            if (true) // si contra correcta:
            {
                foreach (Form vent in Application.OpenForms) // para todas las ventanas abiertas
                    vent.Hide(); // oculatalas

                listaG = new FormListaG();  //crea FormListaG
                listaG.Show();   //y muestrala
            }
        }

        internal static void LogOut()   //cerrar secion
        {
            foreach (Form vent in Application.OpenForms) // para todas las ventanas abiertas
                vent.Hide(); // oculatalas

            inicio.Show();  //muestra FormInicio
        }

        internal static void ShowStudent(ushort studentId)  //muestra el estuduante indicado
        {
            // falta agregar
        }

        internal static void ShowGroup(ushort groupId)  //abre el formGroupX con el grupo indicado
        {
            new FormGrupo(groupId); //crea el form
            grupo.Show();   //lo muestra
        }

    }
}
