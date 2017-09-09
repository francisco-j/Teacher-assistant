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
            inicio = new FormInicio();
            Application.Run(inicio);
        }

        internal static void Login(String contra)
        {
            if (true)
            {
                foreach (Form vent in Application.OpenForms)
                {
                    vent.Hide();
                }
                listaG = new FormListaG();
                listaG.Show();
            }
        }

        internal static void LogOut()
        {
            foreach (Form vent in Application.OpenForms)
                vent.Hide();
            inicio.Show();
        }

        internal static void ShowGroup(Int16 groupId)
        {
            grupo = new FormGrupo(groupId);
            grupo.Show();
        }

    }
}
