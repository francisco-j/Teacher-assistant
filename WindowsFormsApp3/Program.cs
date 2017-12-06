using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static class Program
    {
        public static FormInicio inicio;
        public static FormListaGrupos listaGrupos;
        public static frmMaterias listaMaterias;
        public static FormGrupoMateria grupo;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dbConection.canConnect();
            inicio = new FormInicio();
            Application.Run();
        }


#region logg

        /// <summary> Incia sesión y abre "FormListaGrupos" </summary>
        internal static void Login(String usuario, String contrasena)
        {
            //parámetro de referencia para el evento dbConection.isCorrecto()
            int idUsuario = new int();

            //La contraseña la obtendremos de la base de datos y verificaremos que coincida
            if (dbConection.isCorrecto(ref idUsuario, usuario, contrasena))
            {
                //Instanciamos el siguiente Form "Lista de grupos"
                listaGrupos = new FormListaGrupos(idUsuario);
            }
            else
            {
                throw new ApplicationException("Usuario y contraseña no coinciden \npor favor intenta de nuevo");
            }
        }

        /// <summary> Para cerrar sesión y regresar al Form de Login </summary>
        /// <param name="ventana"> ventana que ejecuto el  logout </param>
        internal static void LogOut()
        {
            FormInicio login = new FormInicio();
            login.Visible = true;
        }

        #endregion

#region ventanas

        internal static void returnToListaGrupos()
        {
            listaGrupos.Show();
        }

        /// <summary> muestra las materias del grupo especificado </summary>
        internal static void showListaMaterias(int idGrupo, int idMaestro)
        {
            listaMaterias = new frmMaterias(idGrupo, idMaestro);
        }

        internal static void returnToListaMaterias()
        {
            listaMaterias.Show();
        }

        /// <summary> abre el formGrupoMateria con la materia indicada </summary>
        internal static void showGrupoMateria(int idMateria, int idGrupo)
        {
            grupo = new FormGrupoMateria(idMateria, idGrupo);
            grupo.Show();
        }

#endregion
    }
}