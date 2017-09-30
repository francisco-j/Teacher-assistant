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
        }


        //****************************** logg  **********************************************

        /// <summary> Incia sesión, abre el Form de lista de grupos </summary>
        /// <param name="usuario">  nombre de usuario a iniciar </param>
        /// <param name="contrasena"> constrase;a del usuario a ingresar </param>
        internal static void Login(String usuario, String contrasena)
        {
            //Se le asgna cero porque no se puede mandar como parámetro si no le has asignado nada
            int idUsuario = 0;

            //La contraseña la obtendremos de la base de datos y verificaremos que coincida
            if (dbConection.isCorrecto(ref idUsuario, usuario, contrasena))
            {
                //Instanciamos el siguiente Form "Lista de grupos"
                listaGrupos = new FormListaGrupos(idUsuario);
                //Lo mostramos en la pantalla y ocultamos el anterior, el Form de inicio
                listaGrupos.Show();
                inicio.Close();
            }
            else
            {
                throw new ApplicationException("Usuario y contraseña no coinsiden \npor favor intenta de nuevo");
            }
        }

        /// <summary> Para cerrar sesión y regresar al Form de Login </summary>
        /// <param name="ventana"> ventana que ejecuto el  logout </param>
        internal static void LogOut(Form ventana)
        {
            inicio = new FormInicio();
            inicio.Show();
            ventana.Dispose();
        }

        //***************************** ventanas *******************************************

        internal static void returnToListaGrupos()
        {
            listaGrupos.Show();
        }

        /// <summary> muestra el estuduante indicado </summary>
        internal static void ShowStudent(ushort idStudent)
        {
            throw new NotImplementedException();
        }

        /// <summary> muestra las materias del grupo especificado </summary>
        internal static void showListaMaterias(int idGrupo)
        {
            Form listaMaterias = new FormListaMaterias(idGrupo);
            listaMaterias.Show();
        }

        /// <summary> abre el formGrupoMateria con la materia indicada </summary>
        internal static void showGrupoMateria(int idMateria, int idGrupo)
        {
            grupo = new FormGrupoMateria(idMateria, idGrupo);
            grupo.Show();
        }

        //****************************  db  **************************************************

        internal static void busqueda(string text)
        {
            throw new NotImplementedException();
        }

        /// <summary> retorna los grupos que pertenecen al usuario indicado </summary>
        public static Grupo[] gruposDeMaestro(int idMaestro)
        {
            return dbConection.GruposAsociadosCon(idMaestro);
        }

        /// <summary> retorna las materias que pertenecen al grupo indicado </summary>
        internal static Materia[] materiasDeGrupo(int idGrupo)
        {
            Console.WriteLine("mostrando materias del salon: " + idGrupo);
            return dbConection.materiasAsociadasCon(idGrupo);
        }

        /// <summary> retorna el grupo con el id indicado </summary>
        internal static Grupo getGrupo(int idGrupo)
        {
            return dbConection.getGrupo(idGrupo);
        }

        internal static void agregarMateria(string nombre, int salon)
        {
            dbConection.AgregarMateria(nombre, salon);
        }

        /// <summary> llena la informacion sobre el grupo y materia indicados </summary>
        internal static void getIfo(int idMateria, int idGrupo, out string grupo, out string materia, out string numeroAlumnos, out string escuela)
        {
            dbConection.getInfo(idMateria, idGrupo, out grupo, out materia, out numeroAlumnos, out escuela);
        }

        /// <summary> registra al usuario indicado en la base de datos </summary>
        /// <throws> aplicationExeption cuando no se puede registrar </throws>
        internal static void registrarUsuario(string usuario, string contra)
        {
            dbConection.RegistrarUsuario(usuario, contra);
        }

        /// <summary>  </summary>
        internal static void agregarGrupo(int grado, char grupo, String escuela, int idMaesto)
        {
            dbConection.AgregarGrupo(grado, grupo, escuela, idMaesto);
        }

        // ************************** metodos privados ****************************************

        //some code

    }
}