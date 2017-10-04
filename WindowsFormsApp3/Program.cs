using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using WindowsFormsApp3.vistas;
using System.Collections.Generic;

namespace WindowsFormsApp3
{
    static class Program
    {
        public static Form inicio;
        public static FormListaGrupos listaGrupos;
        public static FormListaMaterias listaMaterias;
        public static Form grupo;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dbConection.canConnect();
            inicio = new FormInicio();
            Application.Run();
        }

        internal static void borrarMateria(int idMateria)
        {
            dbConection.borrarMateria(idMateria);
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
                inicio.Hide();
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
            foreach (Form vent in Application.OpenForms)
            {
                if(vent != inicio)
                    vent.Dispose();
            }
            inicio.Show();
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
            listaMaterias = new FormListaMaterias(idGrupo);
        }

        /// <summary> abre el formGrupoMateria con la materia indicada </summary>
        internal static void showGrupoMateria(int idMateria, int idGrupo)
        {
            grupo = new FormGrupoMateria(idMateria, idGrupo);
            grupo.Show();
        }

//****************************  db arrays  **************************************************

        internal static Alumno[] busqueda(string text)
        {
            return dbConection.buscar(text);
        }

        /// <summary> retorna los grupos que pertenecen al usuario indicado </summary>
        public static Grupo[] gruposDeMaestro(int idMaestro)
        {
            return dbConection.GruposAsociadosCon(idMaestro);
        }

        /// <summary> retorna las materias que pertenecen al grupo indicado </summary>
        internal static Materia[] materiasDeGrupo(int idGrupo)
        {
            return dbConection.materiasAsociadasCon(idGrupo);
        }

        /// <summary> retorna los alumnos que pertenecen al grupo indicado </summary>
        internal static Alumno[] alumnosGrupo( int idGrupo )
        {
            return dbConection.alumnosGrupo( idGrupo );
        }

//****************************  db objetos  **************************************************

        /// <summary> retorna el grupo con el id indicado </summary>
        internal static Grupo getGrupo(int idGrupo)
        {
            return dbConection.getGrupo(idGrupo);
        }

        /// <summary> retorna el grupo con el id indicado </summary>
        internal static Materia getMateria(int idMateria)
        {
            return dbConection.getMateria(idMateria);
        }


//****************************  db scritura  **************************************************

        /// <summary> registra al usuario indicado en la DB </summary>
        internal static void registrarUsuario(string usuario, string contra)
        {
            dbConection.registrarUsuario(usuario, contra);
        }

        /// <summary> agrega la materia indicada a la DB </summary>
        internal static void agregarMateria(string nombre, int salon)
        {
            dbConection.agregarMateria(nombre, salon);
        }

        /// <summary> agrega el grupo indicado a la DB </summary>
        internal static void agregarGrupo(int grado, char grupo, String escuela, int idMaesto)
        {
            dbConection.agregarGrupo(grado, grupo, escuela, idMaesto);
        }

        /// <summary> agrega el alumno indicado a la DB </summary>
        internal static void agregarAlumno( Alumno alumno )
        {
            dbConection.agregarAlumno( alumno );
        }

        /// <summary> modifica info de la materia en la DB </summary>
        internal static void modificarMateria(int idMateria, string nombre)
        {
            dbConection.modificarMateria(idMateria, nombre);
        }

        /// <summary> modifica info del usuario en la DB </summary>
        internal static void modificarGrupo(int id, int grado, char grupo, String escuela)
        {
            dbConection.modificarGrupo(id, grado, grupo, escuela);
        }

        internal static void borrarGrupo(int idrupo)
        {
            dbConection.borrarGrupo(idrupo);
        }

// ****************************** db lectura ********************************************

        internal static int numeroAlumnosEn(int idGrupo)
        {
            return dbConection.numeroAlumnosEn(idGrupo);
        }

        /// <summary> llena la informacion sobre el grupo y materia indicados </summary>
        internal static void getIfo(int idMateria, int idGrupo, out string grupo, out string materia, out string numeroAlumnos, out string escuela)
        {
            dbConection.getInfo(idMateria, idGrupo, out grupo, out materia, out numeroAlumnos, out escuela);
        }

    }
}