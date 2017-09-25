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
            Console.WriteLine("coneccion: " + dbConection.canConnect());
            inicio = new FormInicio();
            inicio.Show();
            Application.Run();
            //falta mostrar al frente
        }

//****************************** logg  **********************************************

        //Para inciar sesión, abre el Form de lista de grupos
        internal static void Login(String usuario, String contraseña ) 
        {
            //Se le asgna cero porque no se puede mandar como parámetro si no le has asignado nada
            int idUsuario = 0;

            //La contraseña la obtendremos de la base de datos y verificaremos que coincida
            if (dbConection.isCorrecto(ref idUsuario, usuario, contraseña) )
            {
                //lee que grupos pertenecen al usuario
                Grupo[] gruposAsociados = dbConection.GruposAsociadosCon(idUsuario);

                //Instanciamos el siguiente Form "Lista de grupos"
                listaGrupos = new FormListaGrupos( gruposAsociados );
                //Lo mostramos en la pantalla y ocultamos el anterior, el Form de inicio
                listaGrupos.Show();
                inicio.Close();
            }
            else
            {
                MessageBox.Show( "La contraseña ingresada es incorrecta, por favor intenta de nuevo" );
            }
        }

        //Para cerrar sesión y regresar al Form de Login
        internal static void LogOut( Form ventana )  
        {
            inicio = new FormInicio();
            inicio.Show();
            ventana.Dispose();
        }

//***************************** ventanas *******************************************

        //muestra las materias del grupo especificado
        internal static void showListaMaterias( string nombreGrupo )
        {
            Form listaMaterias = new FormListaMaterias( nombreGrupo );
            listaMaterias.Show();
        }

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

        //abre el formGroupX con el grupo indicado
        internal static void ShowGroup(ushort groupId)
        {
            new FormGrupo(groupId); //crea el form
            grupo.Show();   //lo muestra
        }

//****************************  db  **************************************************

        internal static bool registrar(string usuario, string contra)
        {
            return dbConection.registrarUsuario( usuario, contra );
        }

// ************************** metodos privados ****************************************

        //some code

    }
}
