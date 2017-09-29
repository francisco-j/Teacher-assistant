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

        private static OleDbConnection conection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=teacher assistant.mdb");
        private static OleDbCommand comand = new OleDbCommand();
        private static OleDbDataAdapter adapter = new OleDbDataAdapter();


//************************  control ********************************************

        /// <summary> verifica que la conexion se pueda relizar, muestra respuesta en consola </summary>
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


//************************  lectura ******************************************
        
        /// <summary> retorna los grupos asociados al maestro indicado </summary>
        internal static Grupo[] GruposAsociadosCon(int idUsuario)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM Grupos WHERE maestro=" + idUsuario;
                OleDbDataReader reader = comand.ExecuteReader();

                List<Grupo> lGrupos = new List<Grupo>();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    int grado = (int)reader["grado"];
                    char grupo = reader["grupo"].ToString().First();
                    string escuela = reader["escuela"].ToString();
                    Grupo g = new Grupo(id, grado, grupo, escuela);

                    lGrupos.Add(g);
                }
                reader.Close();

                return lGrupos.ToArray();
            }
            finally
            {
                conection.Close();
            }
        }

        /// <summary> Retorna las materias asociadas al grupo indicado <summary>
        internal static Materia[] materiasAsociadasCon(int idGrupo)
        {
            List<Materia> lMaterias = new List<Materia>();
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM Materias WHERE salon=" + idGrupo;
                OleDbDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string nombre = reader["nombre"].ToString();
                    int grupo = (int)reader["salon"];
                    Materia m = new Materia(id, nombre, grupo);

                    lMaterias.Add(m);
                }
                reader.Close();
            }
            finally
            {
                conection.Close();
            }
            return lMaterias.ToArray();
        }


        /// <summary> verifica que la contrasena y usuario coinsidan </summary>
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

        /// <summary> lle el grupo asociado con el id indicado </summary>
        internal static Grupo getGrupo(int idGrupo)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM Grupos WHERE id="+idGrupo;
                OleDbDataReader reader = comand.ExecuteReader();

                reader.Read();

                int id = (int)reader["id"];
                int grado = (int)reader["grado"];
                char grupo = reader["grupo"].ToString().First();
                string escuela = reader["escuela"].ToString();

                return new Grupo(id, grado, grupo, escuela);
            }
            finally
            {
                conection.Close();
            }

        }

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

        internal static void AgregarGrupo(int grado, char grupo, String escuela, int maesto)
        {
            comand.CommandText = "INSERT INTO Grupos (grado, grupo, escuela, maestro) VALUES("+grado+", '" + grupo + "', '" + escuela + "'," + maesto + ")";
            comand.Connection = conection;
            try
            {
                conection.Open();
                Console.WriteLine(comand.ExecuteNonQuery() + " lienas con cambios");
            }
            finally
            {
                conection.Close();
            }
        }

        internal static void AgregarMateria(String nombre, int salon)
        {
            comand.CommandText = "INSERT INTO Materias (nombre, salon) VALUES('"+nombre+"'," +salon+ ")";
            comand.Connection = conection;
            try
            {
                conection.Open();
                Console.WriteLine(comand.ExecuteNonQuery() + " lienas con cambios");
            }
            finally
            {
                conection.Close();
            }
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
