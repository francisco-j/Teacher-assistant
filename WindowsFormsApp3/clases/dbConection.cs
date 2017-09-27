using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WindowsFormsApp3.clases
{
    class dbConection
    {
//************************  control ********************************************

        //crea la conecion
        private static OleDbConnection conection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\teacher assistant.mdb");
        private static OleDbCommand comand = new OleDbCommand();
        private static OleDbDataAdapter adapter = new OleDbDataAdapter();

        // verifica que la conexion se pueda relizar, muestra respuesta en output
        public static bool canConnect()
        {
            try
            {
                conection.Open();

                if (conection.State == ConnectionState.Open)
                {
                    Console.WriteLine("conexion exitosa");
                    conection.Close();
                    return true;
                }
                else
                {
                    Console.WriteLine("conexion fallida");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine( "conexion fallida, error: "+ex.Message );
                return false;
            }

        }

        // retorna los grupos que controla el maestro indicado
        internal static Grupo[] GruposAsociadosCon(int idUsuario)
        {
            //provicional
            /*
            Grupo g =  new Grupo(1, 1, 'A', "chapalirta");
            Grupo[] gs = { g };
            */

            //codigo real
            conection.Open();
            comand.Connection = conection;
            comand.CommandText = "SELECT * FROM Salones WHERE maestro=" + idUsuario.ToString();
            OleDbDataReader reader = null;
            reader = comand.ExecuteReader();

            List<Grupo> lGrupos = new List<Grupo>();

            while (reader.Read())
            {
                int id = Convert.ToInt16(reader["idSalon"].ToString());
                int grado = Convert.ToInt16(reader["grado"].ToString());
                char grupo = reader["grupo"].ToString().First();
                string escuela = reader["escuela"].ToString();
                Grupo g = new Grupo(id, grado, grupo, escuela);

                lGrupos.Add(g);
            }

            reader.Close();
            conection.Close();

            return lGrupos.ToArray();

        }
        
        //verifica que la contrasena y usuario coinsidan
        internal static bool isCorrecto(ref int idUsuario, string usuario, string contrasena)
        {
            conection.Open();
            comand.Connection = conection;
            comand.CommandText = "SELECT * FROM Usuarios WHERE usuario='" + usuario + "' AND contrasena='"+contrasena+"'";
            OleDbDataReader reader = comand.ExecuteReader();

            if (reader.HasRows)
            {
                // asignar valor a id
                //porvicional
                idUsuario = 1 ;

                conection.Close();
                return true;
            }
            else
            {
                conection.Close();
                return false;
            }
        }

//************************  lectura ******************************************

        //some code

//************************  escritura ******************************************

        internal static bool RegistrarUsuario(string usuario, string contra)
        {
            conection.Open();
            comand.Connection = conection;
            comand.CommandText = "SELECT * FROM Usuarios WHERE usuario='" + usuario + "'" ;
            OleDbDataReader reader = comand.ExecuteReader();

            if (reader.HasRows)
            {
                //MessageBox.Show( "EL usuario ya existe" );
                conection.Close();
                throw new ApplicationException ("Ya existe este usuario");
            }
            else
            {
                reader.Close();
                comand = new OleDbCommand();
                comand.CommandText = "INSERT INTO Usuarios (usuario, contrasena) VALUES('"+usuario+"', '"+contra+"')";
                comand.Connection = conection;
                Console.WriteLine(comand.ExecuteNonQuery()+" lienas con cambios");
                conection.Close();
                return true;
                }
            }

        internal static void AgregarAlumno()
        {
            throw new NotImplementedException();
            //some code
        }

        internal static void AgregarGrupo(int grado, char grupo, String escuela, int maesto)
        {
            throw new NotImplementedException();
        }

        internal static void AgregarTarea()
        {
            throw new NotImplementedException();
            //some code
        }



        //************************** otros *********************************************

        //experimentacion
        //public int temp()
        //{
        //    adapter.SelectCommand.CommandText = "SELECT * FROM Contactos";
        //    conection.Open();
        //    adapter.SelectCommand.Connection = conection;

        //    OleDbDataReader reader = adapter.SelectCommand.ExecuteReader();
        //    reader.Read();
        //    int id = Convert.ToInt16(reader["Id"].ToString());

        //    conection.Close();

        //    return id;
        //}
        
    }
}
