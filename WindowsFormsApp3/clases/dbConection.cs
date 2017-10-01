using System;
using System.Data;
using System.Linq;
using System.Text;
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
        private static OleDbDataReader reader;


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
                Console.WriteLine("conexion fallida, error: " + ex.Message);
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
                reader = comand.ExecuteReader();

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
                return lGrupos.ToArray();
            }
            finally
            {
                reader.Close();
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
                comand.CommandText = "SELECT * FROM Materias WHERE grupo=" + idGrupo;
                reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string nombre = reader["nombre"].ToString();
                    int grupo = (int)reader["grupo"];
                    Materia m = new Materia(id, nombre, grupo);

                    lMaterias.Add(m);
                }
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
            return lMaterias.ToArray();
        }

        internal static Alumno[] buscar(string text)
        {
            List<Alumno> lAlumnos = new List<Alumno>();
            try
            {
                conection.Open();
                comand.Connection = conection;
                //compara con nombre y apellidos
                comand.CommandText = "SELECT * FROM Alumnos WHERE nombres like '%" + text + "%' or apellidoPaterno like '%" + text + "%' or apellidoMaterno like '%" + text + "%'";
                reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string nombre = reader["nombres"].ToString();
                    string apellidoP = reader["apellidoPaterno"].ToString();
                    string apellidoM = reader["apellidoMaterno"].ToString();
                    int grupo = (int)reader["grupo"];
                    Alumno a = new Alumno(id, nombre, apellidoP, apellidoM, grupo);

                    lAlumnos.Add(a);
                }
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
            return lAlumnos.ToArray();
        }

        internal static string getNombreMateria(int idMateria)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM Materias WHERE id=" + idMateria;
                reader = comand.ExecuteReader();

                reader.Read();
                
                string nombre = reader["nombre"].ToString();

                return nombre;
            }
            finally
            {
                reader.Close();
                conection.Close();
            }

        }

        /// <summary> verifica que la contrasena y usuario coinsidan </summary>
        internal static bool isCorrecto(ref int idUsuario, string usuario, string contrasena)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM Usuarios WHERE usuario='" + usuario + "' AND contrasena='" + contrasena + "'";
                reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    idUsuario = (int)reader["id"];

                    conection.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                conection.Close();
                reader.Close();
            }

        }

        /// <summary> lle el grupo asociado con el id indicado </summary>
        internal static Grupo getGrupo(int idGrupo)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM Grupos WHERE id=" + idGrupo;
                reader = comand.ExecuteReader();

                reader.Read();

                int id = (int)reader["id"];
                int grado = (int)reader["grado"];
                char grupo = reader["grupo"].ToString().First();
                string escuela = reader["escuela"].ToString();

                return new Grupo(id, grado, grupo, escuela);
            }
            finally
            {
                reader.Close();
                conection.Close();
            }

        }

        /// <summary> llena la informacion sobre el grupo y materia indicados </summary>
        internal static void getInfo(int idMateria, int idGrupo, out string nombreGrupo, out string nombreMateria, out string numeroAlumnos, out string nombreEscuela)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;


                // ** grupo ** //

                comand.CommandText = "SELECT * FROM Grupos WHERE id=" + idGrupo;
                reader = comand.ExecuteReader();

                reader.Read();
                //asigna el nombre del grupo
                nombreGrupo = reader["grado"].ToString() + "º" + reader["grupo"].ToString();
                //asigna el nombre de la escuela
                nombreEscuela = reader["escuela"].ToString();
                reader.Close();


                // ** materia ** //

                comand.CommandText = "SELECT * FROM Materias WHERE id=" + idMateria;
                reader = comand.ExecuteReader();

                reader.Read();
                //asigna el nombre de la materia
                nombreMateria = reader["nombre"].ToString();
                reader.Close();


                // ** alumnos ** //

                conection.Close();
                
                numeroAlumnos = numeroAlumnosEn(idGrupo).ToString();
                reader.Close();
            }
            finally
            {
                conection.Close();
                reader.Close();
            }
        }

        /// <summary> cuenta cuantos alumnos pertenecen al grupo indicado </summary>
        internal static int numeroAlumnosEn(int idGrupo)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;

                comand.CommandText = "SELECT * FROM Alumnos WHERE grupo=" + idGrupo;
                reader = comand.ExecuteReader();

                int numAlum = 0;
                while (reader.Read())
                    numAlum++;

                return numAlum;
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
        }


//************************  escritura ******************************************

        /// <summary> registra el usuario indicado en la base de datos </summary>
        internal static void RegistrarUsuario(string usuario, string contra)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM Usuarios WHERE usuario='" + usuario + "'";
                reader = comand.ExecuteReader();

                if (reader.HasRows)
                {
                    //MessageBox.Show( "EL usuario ya existe" );
                    conection.Close();
                    throw new ApplicationException("Ya existe este usuario");
                }
                else
                {
                    reader.Close();
                    comand = new OleDbCommand();
                    comand.CommandText = "INSERT INTO Usuarios (usuario, contrasena) VALUES('" + usuario + "', '" + contra + "')";
                    comand.Connection = conection;
                    Console.WriteLine(comand.ExecuteNonQuery() + " lienas con cambios");
                }
            }
            finally
            {
                conection.Close();
            }
        }

        /// <summary> registra el grupo indicado en la base de datos </summary>
        internal static void AgregarGrupo(int grado, char grupo, String escuela, int maesto)
        {
            comand.CommandText = "INSERT INTO Grupos (grado, grupo, escuela, maestro) VALUES(" + grado + ", '" + grupo + "', '" + escuela + "'," + maesto + ")";
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

        /// <summary> registra la materia indicada en la base de datos </summary>
        internal static void AgregarMateria(String nombre, int salon)
        {
            comand.CommandText = "INSERT INTO Materias (nombre, grupo) VALUES('" + nombre + "'," + salon + ")";
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


//******************************** actualizar ***********************************************

        internal static void actualizarGrupo(int idGrupo, int grado, char grupo, String escuela)
        {
            comand.CommandText = "UPDATE Grupos SET grado = "+grado+", grupo = '"+grupo+"', escuela = '" + escuela + "' WHERE id = "+idGrupo;
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

        internal static void actualizarMateria(int idMateria, string nombre)
        {
            comand.CommandText = "UPDATE Materias SET nombre = '" + nombre + "' WHERE id = " + idMateria;
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
