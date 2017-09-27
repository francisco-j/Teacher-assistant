using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using System.Collections.Generic;

namespace WindowsFormsApp3
{
    static class Program
    {
        private static Form inicio, listaGrupos, listaMaterias, grupo, alumno;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dbConection.canConnect();
            inicio = new FormInicio();
            inicio.Show();
            Application.Run();
            //falta mostrar al frente
        }

//****************************** logg  **********************************************

        /// <summary>
        /// Incia sesión, abre el Form de lista de grupos </summary>
        /// <param name="usuario"> 
        /// nombre de usuario a iniciar </param>
        /// <param name="contrasena">
        /// constrase;a del usuario a ingresar </param>
        internal static void Login(String usuario, String contrasena ) 
        {
            //Se le asgna cero porque no se puede mandar como parámetro si no le has asignado nada
            int idUsuario = 0;

            //La contraseña la obtendremos de la base de datos y verificaremos que coincida
            if (dbConection.isCorrecto(ref idUsuario, usuario, contrasena) )
            {
                //Instanciamos el siguiente Form "Lista de grupos"
                listaGrupos = new FormListaGrupos( idUsuario );
                //Lo mostramos en la pantalla y ocultamos el anterior, el Form de inicio
                listaGrupos.Show();
                inicio.Close();
            }
            else
            {
                throw new ApplicationException("Usuario y contraseña no coinsiden \npor favor intenta de nuevo");
            }
        }

        /// <summary>
        /// lee que grupos pertenecen al usuario indicado </summary>
        /// <param name="idMaestro">
        /// id del maestro con</param>
        /// <returns>
        /// array de objetos tipo Grupo sobre los que el maestro tiene control</returns>
        public static Grupo[] gruposDeMaestro(int idMaestro)
        {
            return dbConection.GruposAsociadosCon(idMaestro);
        }

        /// <summary>
        /// Para cerrar sesión y regresar al Form de Login </summary>
        /// <param name="ventana">
        /// ventana que ejecuto el  logout </param>
        internal static void LogOut( Form ventana )  
        {
            inicio = new FormInicio();
            inicio.Show();
            ventana.Dispose();
        }

//***************************** ventanas *******************************************

        internal static void returnToListaGrupos( )
        {
            listaGrupos.Show();
        }

        internal static void busqueda(string text)
        {
            //throw new NotImplementedException();
        }

        //muestra el estuduante indicado
        internal static void ShowStudent(ushort studentId)  
        {
            // some code //
        }

            /// <summary>
            /// muestra las materias del grupo especificado
            /// </summary>
            /// <param name="nombreGrupo"></param>
        internal static void showListaMaterias( string nombreGrupo )
        {
            Form listaMaterias = new FormListaMaterias( nombreGrupo );
            listaMaterias.Show();
        }

        //abre el formGroupX con el grupo indicado
        internal static void ShowGroup(ushort groupId)
        {
            new FormGrupo(groupId); //crea el form
            grupo.Show();   //lo muestra
        }

//****************************  db  **************************************************

            /// <summary>
            /// registra un usuario en la base de datos </summary>
            /// <param name="usuario">
            /// nombre de usuario a registrar </param>
            /// <param name="contra">
            /// contrase;a del usuario a registrar </param>
            /// <returns>
            /// true si se guardo con exito </returns>
        internal static bool registrar(string usuario, string contra)
        {
            return dbConection.RegistrarUsuario( usuario, contra );
        }

        internal static void agregarGrupo(int grado, char grupo, String escuela, int maesto)
        {
            dbConection.AgregarGrupo(grado, grupo, escuela, maesto);
        }

// ************************** metodos privados ****************************************

        //some code

    }
}
