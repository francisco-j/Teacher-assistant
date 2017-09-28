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
            //pruebas
            /*
            List<Grupo> lGrupos = new List<Grupo>();
            for (int i=1; i<=10; i++)
            {
                int id = i;
                int grado = i;
                char grupo = 'A';
                string escuela = "escuela";
                Grupo g = new Grupo(id, grado, grupo, escuela);

                lGrupos.Add(g);
            }

            return lGrupos.ToArray();
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

        //

        /// <summary> verifica que la contrasena y usuario coinsidan
        /// </summary>
        /// <param name="idUsuario"> aqui se ponel el vallor del id del maestro </param>
        /// <param name="usuario"> nombre de usuario </param>
        /// <param name="contrasena"> constrase;a del usuario </param>
        /// <returns> true si la base de datos contiene un registro con ese usuario y esa contrase;a </returns>
        internal static bool isCorrecto(ref int idUsuario, string usuario, string contrasena)
        {
            conection.Open();
            comand.Connection = conection;
            comand.CommandText = "SELECT * FROM Usuarios WHERE usuario='" + usuario + "' AND contrasena='"+contrasena+"'";
            OleDbDataReader reader = comand.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                idUsuario = (int)reader["id"];

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

            /// <summary> registra el usuario indicado en la base de datos </summary>
            /// <param name="usuario"> nombre de usuario </param>
            /// <param name="contra"> contrase;a del usuario </param>
            /// <returns></returns>
        internal static void RegistrarUsuario(string usuario, string contra)
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
                }
            }

        internal static void AgregarAlumno()
        {
            throw new NotImplementedException();
            //some code
        }

        internal static void AgregarGrupo(int grado, char grupo, String escuela, int maesto)
        {
            comand.CommandText = "INSERT INTO Salones (grado, grupo, escuela, maestro) VALUES("+grado+", '" + grupo + "', '" + escuela + "'" + maesto + ")";
            comand.Connection = conection;
            conection.Open();
            Console.WriteLine(comand.ExecuteNonQuery() + " lienas con cambios");
            conection.Close();
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
