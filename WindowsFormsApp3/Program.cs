using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

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
            inicio = new FormInicio();  //crea un inicio
            Application.Run(inicio);    //lo corre
        }

        internal static void Login(String contra) //para iniciar secion
        {
            if (true) // si contra correcta:
            {
                listaG = new FormListaG();  //crea FormListaG
                listaG.Show();   //y muestrala
                //inicio.Close();
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
            // some code //
        }

        internal static void ShowGroup(ushort groupId)  //abre el formGroupX con el grupo indicado
        {
            new FormGrupo(groupId); //crea el form
            grupo.Show();   //lo muestra
        }

    }
}
