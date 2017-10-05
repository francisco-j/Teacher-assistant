﻿using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using WindowsFormsApp3.vistas;
using System.Collections.Generic;

namespace WindowsFormsApp3
{
    static class Program
    {
        public static FormInicio inicio;
        public static FormListaGrupos listaGrupos;
        public static FormListaMaterias listaMaterias;
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


//****************************** logg  **********************************************

        /// <summary> Incia sesión y abre "FormListaGrupos" </summary>
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

        /// <summary> devuelbe todos los alumnos que concidan con el string indicado
        ///  toma en cuenta nombre, apellidoM y apellidoM 
        ///  pero si el string abarca mas de uno no encontrara al alumno deseado </summary>
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

        /// <summary> array con los dias de clase del grupo </summary>
        internal static DateTime[] getDiasClase(int idGrupo)
        {
            return dbConection.getDiasClase(idGrupo);
        }

        /// <summary> array con los dias que falto el alumno </summary>
        internal static DateTime[] getFaltas(int idAlumno)
        {
            return dbConection.getFaltas(idAlumno);
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


//****************************  db escritura  **************************************************

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

        /// <summary> borra el grupo indicado de la DB </summary>
        internal static void borrarGrupo(int idrupo)
        {
            dbConection.borrarGrupo(idrupo);
        }

        /// <summary> borra la materia indicada de la DB </summary>
        internal static void borrarMateria(int idMateria)
        {
            dbConection.borrarMateria(idMateria);
        }

        /// <summary> pone o quita faltas al alumo indicado de acuerdo al parametro asistencia </summary>
        internal static void tomarAsistencia(int idAlumno, DateTime dia, bool asisencia)
        {
            if (asisencia)
                dbConection.quitarFalta(idAlumno, dia);
            else
                dbConection.ponerFalta(idAlumno, dia);
        }


// ****************************** db lectura ********************************************

        /// <summary> cuenta cuantos alumos ahy en el gruo indicado </summary>
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