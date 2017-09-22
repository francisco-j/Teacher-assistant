using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using WindowsFormsApp3.clases;

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
            inicio = new FormInicio();  //Instancia el form inicio
            Application.Run(inicio);    //lo corre
            //falta mostrar al frente
        }

        //Para inciar sesión, abre el Form de lista de grupos
        internal static void Login(String contraseña ) 
        {
            //La contraseña la obtendremos de la base de datos y verificaremos que coincida
            if ( isValidContraseña( contraseña ) )
            {
                //Instanciamos el siguiente Form "Lista de grupos"
                listaGrupos = new FormListaG();  
                //Lo mostramos en la pantalla y ocultamos el anterior, el Form de inicio
                listaGrupos.Show();             
                inicio.Hide();
            }
            else
            {
                MessageBox.Show( "La contraseña ingresada es incorrecta, por favor intenta de nuevo" );
            }
        }

        private static bool isValidContraseña( string contraseña )
        {
            //Cuando conectemos la base de datos hay que incluir la validación de la contraseña
            return true;
        }

        //Para cerrar sesión y regresarte al Form de Login
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

        internal static void ShowStudent(ushort studentId)  //muestra el estuduante indicado
        {
            // some code //
        }

        internal static void ShowGroup(ushort groupId)  //abre el formGroupX con el grupo indicado
        {
/**
 * aqui crea una cosa pero muestra otra
 * crea un form y no lo amacena, luego muestra grupo
 **/
            new FormGrupo(groupId); //crea el form
            grupo.Show();   //lo muestra
        }

    }
}
