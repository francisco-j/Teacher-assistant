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
            Application.Run(inicio);
            //falta mostrar al frente
        }

//****************************** logg  **********************************************

        //Para inciar sesión, abre el Form de lista de grupos
        internal static void Login(String usuario, String contraseña ) 
        {
            //La contraseña la obtendremos de la base de datos y verificaremos que coincida
            if ( dbConection.isCorrecto(usuario, contraseña) )
            {
                //Instanciamos el siguiente Form "Lista de grupos"
                listaGrupos = new FormListaGrupos();
                //Lo mostramos en la pantalla y ocultamos el anterior, el Form de inicio
                listaGrupos.Show();
                inicio.Hide();
            }
            else
            {
                MessageBox.Show( "La contraseña ingresada es incorrecta, por favor intenta de nuevo" );
            }
        }

        //Para cerrar sesión y regresar al Form de Login
        internal static void LogOut()  
        {
            //Se recorren todas las ventanas que están abiertas y se ocultan para mostrar la de login
            foreach (Form vent in Application.OpenForms)
            {
                //Es más probable que la ventana que encuentre no sea la de inicio y la tenga que ocultar, de lo contrario mostrará la ventan de inicio
                if( vent.Name != "FormInicio")
                    vent.Hide();
                else
                    vent.Show();
            }
        }

//***************************** ventanas *******************************************

        //muestra las materias del grupo especificado
        internal static void showListaMaterias( string nombreGrupo )
        {
            Form listaMaterias = new FormListaMaterias( nombreGrupo );
            listaMaterias.Show();
        }
        
        //muestra el estuduante indicado
        internal static void ShowStudent(ushort studentId)  
        {
            // some code //
        }

        //abre el formGroupX con el grupo indicado
        internal static void ShowGroup(ushort groupId)
        {
/**
 * aqui crea una cosa pero muestra otra
 * crea un form y no lo amacena, luego muestra grupo
 **/
            new FormGrupo(groupId); //crea el form
            grupo.Show();   //lo muestra
        }

//****************************  db  **************************************************

        internal static void registrar(string usuario, string contra)
        {
            dbConection.registrarUsuario(usuario, contra);
        }

// ************************** metodos privados ****************************************

        //some code

    }
}
