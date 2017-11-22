using System;
using System.Data;
using System.Linq;
using System.Data.OleDb;
using System.Collections.Generic;
using WindowsFormsApp3.clases_objeto;

namespace WindowsFormsApp3
{
    abstract class dbConection
    {
        private static OleDbConnection conection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=teacher assistant.mdb");

        private static OleDbCommand comand = new OleDbCommand();

        private static OleDbDataReader reader;

        public static int tipoTarea = 1, tipoExam = 2, tipoProy = 3;
        
#region control

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

        /// <summary> Validación si la fecha que se trata de agregar no existe ya para este grupo </summary>
        internal static bool dayExists(DateTime dia, int idGrupo)
        {
            try
            {
                conection.Open();
                comand = new OleDbCommand("SELECT * FROM DiasClase WHERE fecha=#" + dia.ToString("MM'/'dd'/'yy") + "# AND idGrupo=" + idGrupo, conection);
                reader = comand.ExecuteReader();
                reader.Read();

                return (reader.HasRows);
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

        #endregion

        #region lectura de arrays

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

        /// <summary> Se obtienen todos los alumnos del grupo enviado como parámetro </summary>
        internal static Alumno[] alumnosGrupo(int idGrupo)
        {
            List<Alumno> lAlumnos = new List<Alumno>();
            try
            {
                conection.Open();
                comand.Connection = conection;
                //compara con nombre y apellidos
                comand.CommandText = "SELECT * FROM Alumnos WHERE grupo=" + idGrupo;
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

        /// <summary> devuelbe todos los alumnos que concidan con el string indicado. Toma en cuenta nombre, apellidoM y apellidoM. Pero si el string abarca mas de uno no encontrara al alumno deseado </summary>
        internal static Alumno[] buscar(string name, int idMaestro )
        {
            List<int> gruposDeMaestro = new List<int>();
            List<Alumno> lAlumnos = new List<Alumno>();

            try
            {
                conection.Open();

                comand.CommandText = 
                    "SELECT * FROM Grupos " +
                    "WHERE maestro=" + idMaestro;
                reader = comand.ExecuteReader();

                //busca todos los grupos del maestro
                while (reader.Read())
                {
                    gruposDeMaestro.Add((int)reader["id"]);
                }

                reader.Close();

                //para cada grupo busca los alumnos que coincidan
                foreach (int grupoM in gruposDeMaestro)
                {
                    comand.CommandText =
                        "SELECT * FROM Alumnos " +
                        "WHERE nombres & ' ' & apellidoPaterno & ' ' & apellidoMaterno like '%" + name + "%'" +
                        "AND grupo=" + grupoM;
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
                    reader.Close();
                }

            }
            finally
            {
                reader.Close();
                conection.Close();
            }

            return lAlumnos.ToArray();
        }

        /// <summary> array con los dias de clase del grupo </summary>
        internal static DiaClase[] getDiasClase(int idGrupo)
        {
            List<DiaClase> diasClase = new List<DiaClase>();
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM DiasClase WHERE idGrupo =" + idGrupo + " ORDER BY fecha ASC";
                reader = comand.ExecuteReader();

                while( reader.Read() )
                {
                    diasClase.Add(new DiaClase( (DateTime)reader["fecha"], (int)reader["idGrupo"] ) );
                }
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
            return diasClase.ToArray();
        }

        /// <summary> devuelbe las tereas de la materia indicada </summary>
        internal static Tarea[] getTareas(int idMateria)
        {
            List<Tarea> Tareas = new List<Tarea>();
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = 
                    "SELECT * FROM Entregables " +
                    "WHERE materia =" + idMateria + 
                    "AND tipo = " + tipoTarea;
                reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Tareas.Add(new Tarea(reader["nombre"].ToString(), (int)reader["id"]));
                }
            }
            finally
            {
                reader.Close();
                conection.Close();
            }

            return Tareas.ToArray();
        }

        /// <summary> devuelbe los proyectos de la materia indicada </summary>
        internal static Proyecto[] getProyectos(int idMateria)
        {
            List<Proyecto> proyectos = new List<Proyecto>();
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText =
                    "SELECT * FROM Entregables " +
                    "WHERE materia =" + idMateria +
                    "AND tipo >= " + tipoProy;
                reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Proyecto proy = new Proyecto(reader["nombre"].ToString(), (int)reader["id"]);
                    proyectos.Add(proy);
                }
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
            return proyectos.ToArray();
        }

        /// <summary> devuelbe los proyectos de la materia indicada </summary>
        internal static  Examen[] getExamenes(int idMateria)
        {
            List<Examen> examenes = new List<Examen>();
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText =
                    "SELECT * FROM Entregables " +
                    "WHERE materia =" + idMateria +
                    "AND tipo = " + tipoExam;
                reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    examenes.Add(new Examen(reader["nombre"].ToString(), (int)reader["id"]));
                }
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
            return examenes.ToArray();
        }

        /// <summary> array con los dias que falto el alumno </summary>
        internal static DateTime[] getFaltas(int idAlumno)
        {
            List<DateTime> lFaltas = new List<DateTime>();
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText =    "SELECT * FROM inAsistencias WHERE alumno =" + idAlumno;
                reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    DateTime dia = (DateTime)reader["dia"];
                    lFaltas.Add(dia);
                }
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
            return lFaltas.ToArray();
        }

        /// <summary> array de id's de las tareas entregadas por el alumno indicado </summary>
        internal static int[] getEntregasTareas(int idAlumno)
        {
            List<int> entregas = new List<int>();
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = 
                    "SELECT * FROM Entregas " +
                    "WHERE alumno =" + idAlumno + 
                    "AND tipo = " + tipoTarea;
                reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    int entregable = (int)reader["entregable"];
                    entregas.Add(entregable);
                }
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
            return entregas.ToArray();
        }

        /// <summary> array de calificaciones de los examenes presentados por el alumno indicado </summary>
        internal static int[] getCalifExam(int idAlumno, Examen[] listExamenes)
        {
            List<int> calificaciones = new List<int>();
            try
            {
                conection.Open();
                comand.Connection = conection;

                foreach(Examen examen in listExamenes)
                {
                    comand.CommandText =
                        "SELECT * FROM Entregas " +
                        "WHERE alumno =" + idAlumno +
                        "AND entregable = " + examen.id;
                    reader = comand.ExecuteReader();

                    if (reader.Read())
                        calificaciones.Add((int)reader["calif"]);
                    else
                        calificaciones.Add(0);

                    reader.Close();
                }
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
            return calificaciones.ToArray();
        }

        /// <summary> array de calificaciones de los proyectos presentados por el alumno indicado </summary>
        internal static int[] getCalifProy(int idAlumno, Proyecto[] listProyectoss)
        {
            List<int> calificaciones = new List<int>();
            try
            {
                conection.Open();
                comand.Connection = conection;

                foreach (Proyecto proy in listProyectoss)
                {
                    comand.CommandText =
                        "SELECT * FROM Entregas " +
                        "WHERE alumno =" + idAlumno +
                        "AND entregable = " + proy.id;

                    reader = comand.ExecuteReader();

                    if (reader.Read())
                        calificaciones.Add((int)reader["calif"]);
                    else
                        calificaciones.Add(0);

                    reader.Close();
                }
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
            return calificaciones.ToArray();
        }

        #endregion

#region lectura

        /// <summary> debuelbe el nombre del tipo de entregable </summary>
        internal static string getNombreTipo(int tipo)
        {
            string nombreTipo;
            try
            {
                conection.Open();
                comand.CommandText = "SELECT * FROM TiposTareas WHERE tipo = " + tipo;
                comand.Connection = conection;
                reader = comand.ExecuteReader();

                reader.Read();

                nombreTipo = reader["nombre"].ToString();

            }
            finally
            {
                reader.Close();
                conection.Close();
            }
            return nombreTipo;
        }

        /// <summary> id del maestro a cargo del grupo indicado </summary>
        internal static int getIdMaestro( int idGrupo )
        {
            int idMaestro;
            try
            {
                conection.Open();
                comand.CommandText = "SELECT * FROM Grupos WHERE id=" + idGrupo;
                comand.Connection = conection;
                reader = comand.ExecuteReader();

                reader.Read();

                idMaestro = (int)reader["maestro"];

            }
            finally
            {
                reader.Close();
                conection.Close();
            }
            return idMaestro;
        }

        /// <summary> nombre de la materia indicada </summary>
        internal static Materia getMateria(int idMateria)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM Materias WHERE id=" + idMateria;
                reader = comand.ExecuteReader();

                reader.Read();

                int id = (int)reader["id"];
                string nombre = reader["nombre"].ToString();
                int salon = (int)reader["grupo"];

                return new Materia(id, nombre, salon);
            }
            finally
            {
                reader.Close();
                conection.Close();
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

        /// <summary> cuenta cuantos alumnos pertenecen al grupo indicado </summary>
        internal static int numeroAlumnosEn(int idGrupo)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;

                comand.CommandText = "SELECT COUNT(*) FROM Alumnos WHERE grupo=" + idGrupo;

                return (int)comand.ExecuteScalar();
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
        }

        /// <summary> Pide toda la información del alumno para devolver otro alumno pero con su Id </summary>
        internal static Alumno getAlumno( string nombre, string paterno, string materno, int idGrupo )
        {
            conection.Open();
            comand.CommandText = "SELECT * FROM Alumnos WHERE nombres='" + nombre + "' AND apellidoPaterno='" + paterno + "' AND apellidoMaterno='" + materno + "' AND grupo=" + idGrupo;
            Console.WriteLine(comand.CommandText);
            reader = comand.ExecuteReader();

            reader.Read();

            Alumno alumno = new Alumno( (int)reader["id"], nombre, paterno, materno, idGrupo );
            reader.Close();
            conection.Close();

            return alumno;
        }

        /// <summary> Pide el id y devuelve un alumno con toda su información </summary>
        internal static Alumno getAlumno( int id )
        {
            try
            {
                conection.Open();
                comand = new OleDbCommand("SELECT * FROM Alumnos WHERE id=" + id, conection);
                reader = comand.ExecuteReader();

                reader.Read();

                Alumno alumno = new Alumno((int)reader["id"], reader["nombres"].ToString(), reader["apellidoPaterno"].ToString(), reader["apellidoMaterno"].ToString(), (int)reader["grupo"]);
                Console.WriteLine("Alumno obtenido desde DB: " + alumno.getId());
                return alumno;
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

        /// <summary> porcentage de la calificaicon que cada tubro tiene en la materia indicada </summary>
        internal static void getPorcentages(int idMateria, out int tareas, out int examenes, out int proyectos)
        {
            try
            {
                conection.Open();

                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM Rubros WHERE materia=" + idMateria + "AND tipo =" + tipoTarea;
                reader = comand.ExecuteReader();
                tareas = reader.Read() ? (int)reader["porcentage"]/10 : 3;
                reader.Close();

                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM Rubros WHERE materia=" + idMateria + "AND tipo =" + tipoExam;
                reader = comand.ExecuteReader();
                examenes = reader.Read() ? (int)reader["porcentage"]/10 : 4;
                reader.Close();

                comand.CommandText = "SELECT * FROM Rubros WHERE materia=" + idMateria + "AND tipo =" + tipoProy;
                reader = comand.ExecuteReader();
                proyectos = reader.Read() ? (int)reader["porcentage"]/10 : 3;
                reader.Close();
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
        }


#endregion

#region escritura

        /// <summary> registra el entregable en la db </summary>
        internal static void agregarEntregable(int tipo, string nombre, int materia)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText =
                    "INSERT INTO Entregables " +
                    "(tipo, nombre, materia) " +
                    "VALUES(" + tipo + ", '" + nombre + "', " + materia + ")";
                Console.WriteLine(comand.ExecuteNonQuery() + " lienas con cambios");
            }
            finally
            {
                conection.Close();
                reader.Close();
            }
        }

        /// <summary> registra el usuario indicado en la base de datos </summary>
        internal static void registrarUsuario(string usuario, string contra)
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
                reader.Close();
            }
        }

        /// <summary> agrega un dia al grupo indicado </summary>
        internal static void agregarDiaClase( DiaClase dia )
        {
            comand.CommandText = "INSERT INTO DiasClase (fecha, idGrupo) VALUES(#" + dia.dia.ToString("MM'/'dd'/'yy") + "#, " + dia.idGrupo + " )";
            comand.Connection = conection;
            try
            {
                conection.Open();
                comand.ExecuteNonQuery();
                Console.WriteLine("Dia agregado");
            }
            finally
            {
                conection.Close();
            }
        }

        /// <summary> registra el grupo indicado en la base de datos </summary>
        internal static void agregarGrupo(int grado, char grupo, String escuela, int maestro)
        {
            try
            {
                comand.Connection = conection;
                comand.CommandText = 
                    "INSERT INTO Grupos " +
                    "(grado, grupo, escuela, maestro) " +
                    "VALUES(" + grado + ", '" + grupo + "' , '" + escuela + "', " + maestro + ")";
             
                conection.Open();
                Console.WriteLine("Grupo agregado: " + comand.ExecuteNonQuery() );
            }
            finally
            {
                conection.Close();
            }
        }

        /// <summary> registra la materia indicada en la base de datos </summary>
        internal static void agregarMateria(String nombre, int salon)
        {
            comand.CommandText = "INSERT INTO Materias (nombre, grupo) VALUES('" + nombre + "'," + salon + ")";
            comand.Connection = conection;
            try
            {
                conection.Open();
                Console.WriteLine(comand.ExecuteNonQuery() + " nueva materia " + nombre + salon);
            }
            finally
            {
                conection.Close();
            }

        }

        /// <summary> Registra un nuevo alumno en la BD </summary>
        internal static void agregarAlumno(Alumno alumno)
        {
            comand.CommandText = "INSERT INTO Alumnos (nombres, apellidoPaterno, apellidoMaterno, grupo) VALUES('" + alumno.getNombres() + "','" + alumno.getPaterno() + "','" + alumno.getMaterno() + "'," + alumno.getGupo() + ")";
            comand.Connection = conection;
            try
            {
                conection.Open();
                Console.WriteLine( comand.ExecuteNonQuery() + " lienaagregada" );
            } finally
            {
                conection.Close();
            }
        }

        /// <summary> registra la falta del alumno indicado el dia indicado en la DB  </summary>
        internal static void ponerFalta(int idAlumno, DateTime dia)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = "INSERT INTO inAsistencias (alumno, dia) VALUES(" + idAlumno + ",#" + dia.ToString("MM'/'dd'/'yy") + "#)";

                Console.WriteLine(comand.ExecuteNonQuery() + " ; falta del alumno: " + idAlumno + " del día: " + dia.ToShortDateString());
            }
            finally
            {
                conection.Close();
            }
        }

        /// <summary> borra la falta del alumno indicado el dia indicado en la DB </summary>
        internal static void quitarFalta(int idAlumno, DateTime dia)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = "DELETE * FROM inAsistencias WHERE alumno = " + idAlumno + "AND dia = #" + dia.ToString("MM'/'dd'/'yy") + "#";

                Console.WriteLine(comand.ExecuteNonQuery() + " ; falta borrada del alumno: " + idAlumno + " del dia: " + dia.ToShortDateString() );
            }
            finally
            {
                conection.Close();
            }
        }

        /// <summary>Establece que el alumno con ese Id sí entregó la tarea</summary>
        internal static void setTareaEntregada(int idAlumno, int idTarea)
        {
            throw new NotImplementedException();
        }

        /// <summary>Establece que el alumno con ese Id no entregó la tarea con ese ID</summary>
        internal static void quitarTareaEntregada(int idAlumno, int idTarea)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region actualizar

        internal static void modificarGrupo(int idGrupo, int grado, char grupo, String escuela)
        {
            comand.CommandText =
                "UPDATE Grupos SET "
                    + "grado = "+    grado+", "
                    + "grupo = '"+   grupo + "', "
                    + "escuela = '"+ escuela + "'"
                + "WHERE id = " +    idGrupo ;
            comand.Connection = conection;
            try
            {
                conection.Open();
                Console.WriteLine(comand.ExecuteNonQuery() + " cambios en grupo " + idGrupo + escuela + grado + grupo);
            }
            finally
            {
                conection.Close();
            }
        }

        internal static void actualizarAlumno(int id, string nombres, string paterno, string materno)
        {
            try
            {
                conection.Open();
                comand = new OleDbCommand("UPDATE Alumnos SET nombres='" + nombres + "', apellidoPaterno='" + paterno + "', apellidoMaterno='" + materno + "' WHERE id=" + id, conection);

                Console.WriteLine(comand.ExecuteNonQuery() + " Alumno actualizado");
            }
            finally
            {
                conection.Close();
            }
        }

        internal static void modificarMateria(int idMateria, string nombre)
        {
            comand.CommandText = "UPDATE Materias SET nombre = '" + nombre + "' WHERE id = " + idMateria;
            comand.Connection = conection;
            try
            {
                conection.Open();
                Console.WriteLine(comand.ExecuteNonQuery() + " cambios en materia " + idMateria + nombre);
            }
            finally
            {
                conection.Close();
            }
        }

        internal static void actualizarRubro(int idMateria, int tipo, float newValor)
        {
            newValor *= 10;
            try
            {
                conection.Open();

                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM Rubros WHERE materia=" + idMateria + "AND tipo =" + tipo;
                reader = comand.ExecuteReader();

                bool yaExiste = reader.Read();

                reader.Close();

                if (yaExiste)
                {
                    comand.CommandText = 
                        "UPDATE Rubros " +
                        "SET porcentage = " + newValor + 
                        " WHERE materia=" + idMateria + "AND tipo =" + tipo;
                    comand.Connection = conection;

                    comand.ExecuteNonQuery();
                }
                else
                {
                    comand.CommandText = 
                        "INSERT INTO Rubros " +
                        "(porcentage, materia, tipo) " +
                        "VALUES(" + newValor + ", "+ idMateria + "," + tipo + ")";

                    comand.Connection = conection;

                    comand.ExecuteNonQuery();
                }
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
        }

#endregion

#region borrar

        /// <summary> borra el grupo indicado de la tabla grupos </summary>
        internal static void borrarGrupo(int idGrupo)
        {
            try
            {
                conection.Open();
                comand.CommandText = "DELETE FROM Grupos WHERE id = " + idGrupo;
                comand.Connection = conection;

                comand.ExecuteNonQuery();
                   
                Console.WriteLine(comand.ExecuteNonQuery() + " borrada " + idGrupo);
            }
            finally
            {
                conection.Close();
            }
            
        }

        internal static void borrarDiaClase( string dia, int idGrupo, Alumno[] alumnosGrupo )
        {
            try
            {
                conection.Open();
                comand = new OleDbCommand("DELETE * FROM DiasClase WHERE fecha=#" + dia + "# AND idGrupo=" + idGrupo, conection);
                Console.WriteLine(comand.ExecuteNonQuery() + ": Día borrado " + dia );
                conection.Close();

                conection.Open();
                //Elimina todas las inasistencias de ese día en la base de datos
                foreach( Alumno alumActual in alumnosGrupo )
                {
                    comand = new OleDbCommand("DELETE * FROM inAsistencias WHERE alumno=" + alumActual.getId() + " AND dia=#" + dia + "#", conection);
                    comand.ExecuteNonQuery();
                }
            }
            finally
            {
                conection.Close();
            }


        }

        internal static void borrarAlumno(int idAlumno)
        {
            try
            {
                conection.Open();
                comand = new OleDbCommand("DELETE * FROM Alumnos WHERE id=" + idAlumno, conection);
                comand.ExecuteNonQuery();
                Console.Write("Alumno Borrado");
            }
            finally
            {
                conection.Close();
            }
        }

        internal static void borrarMateria(int idMateria)
        {
            comand.CommandText = "DELETE FROM Materias WHERE id = " + idMateria;
            comand.Connection = conection;
            try
            {
                conection.Open();
                Console.WriteLine(comand.ExecuteNonQuery() + " borrada " + idMateria);
            }
            finally
            {
                conection.Close();
            }
        }

#endregion

    }
}
