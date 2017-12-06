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

        public const int tipoTarea = 1, tipoExam = 2, tipoProy = 3;

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

        /// <summary>Cuando se va a registrar un nuevo alumno se verifica que no exista en ese grupo un alumno con exactamente los mismos nombres</summary>
        internal static bool alumnoNameExists(int idGrupo, string nombre, string paterno, string materno)
        {
            try
            {
                conection.Open();
                comand = new OleDbCommand("SELECT * FROM Alumnos WHERE grupo="+ idGrupo + " AND nombres='" + nombre + "' AND apellidoPaterno='" + paterno + "' AND apellidoMaterno='" + materno + "'", conection);
                reader = comand.ExecuteReader();

                return reader.HasRows;
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
        }

        #endregion

        #region lectura de arrays

        //Ya lo hacen bien otros métodos
        // <summary> array de una calificacion por cada rubro </summary>
        /* internal static int[] getCalifRubro(int idAlumno, int[] tiposTareas)
         {
             List<int> calif = new List<int>();

             try
             {
                 foreach( int rubro in tiposTareas)
                 {
                     if (rubro == 1)
                     {
                         //lee cantidad de tareas en la amteria
                         //lee cantidad de tareas de l alumno
                         //calif.Add entregas/entregadas
                     }
                     else
                     {
                         conection.Open();
                         comand.Connection = conection;
                         comand.CommandText =
                             "SELECT Avg(calif) " +
                             "FROM Entregas " +
                             "WHERE alumno =" + idAlumno ;
                             //" AND tarea pertenece a la materia" ;
                         reader = comand.ExecuteReader();

                         reader.Read();

                         Alumno alumno = new Alumno((int)reader["id"], reader["nombres"].ToString(), reader["apellidoPaterno"].ToString(), reader["apellidoMaterno"].ToString(), (int)reader["grupo"]);
                         Console.WriteLine("Alumno obtenido desde DB: " + alumno.getId());
                     }
                     conection.Close();
                 }
             }
             finally
             {
                 reader.Close();
                 conection.Close();
             }
             return calif.ToArray();
         }*/

        /// <summary> retorna los grupos asociados al maestro indicado </summary>
        internal static List<Grupo> GruposAsociadosCon(int idUsuario)
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
                return lGrupos;
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
        }

        /// <summary> Retorna las materias asociadas al grupo indicado </summary>
        internal static List<Materia> materiasAsociadasCon(int idGrupo)
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
            return lMaterias;
        }

        /// <summary> Se obtienen todos los alumnos del grupo enviado como parámetro </summary>
        internal static List<Alumno> alumnosGrupo(int idGrupo)
        {
            List<Alumno> lAlumnos = new List<Alumno>();
            try
            {
                conection.Open();
                comand.Connection = conection;
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
            return lAlumnos;
        }

        /// <summary> devuelve todos los alumnos que concidan con el string indicado.</summary>
        internal static Alumno[] buscar(string name, int idMaestro)
        {
            List<int> gruposDeMaestro = new List<int>();
            List<Alumno> lAlumnos = new List<Alumno>();

            try
            {
                conection.Open();

                comand.CommandText =
                        "SELECT * FROM Alumnos " +
                        "WHERE nombres & ' ' & apellidoPaterno & ' ' & apellidoMaterno like '%" + name + "%'" +
                        "AND grupo IN (" +
                            "SELECT id FROM Grupos " +
                            "WHERE maestro=" + idMaestro +
                        ")";
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
            finally
            {
                reader.Close();
                conection.Close();
            }

            return lAlumnos.ToArray();
        }

        /// <summary> devuelve array con nombres de alumnos que coincidan </summary>
        internal static string[] prediccionBusqueda(string name, int idMaestro)
        {
            List<int> gruposDeMaestro = new List<int>();
            List<string> lAlumnos = new List<string>();

            try
            {
                conection.Open();

                //para cada grupo busca los alumnos que coincidan
                foreach (int grupoM in gruposDeMaestro)
                {
                    comand.CommandText =
                        "SELECT * FROM Alumnos " +
                        "WHERE nombres & ' ' & apellidoPaterno & ' ' & apellidoMaterno like '%" + name + "%'" +
                        "AND grupo IN (" +
                            "SELECT id FROM Grupos " +
                            "WHERE maestro=" + idMaestro +
                        ")";
                    reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        string coincidencia = reader["nombres"].ToString() + " " + reader["apellidoPaterno"].ToString() + " " + reader["apellidoMaterno"].ToString();

                        lAlumnos.Add(coincidencia);
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

                while (reader.Read())
                {
                    diasClase.Add(new DiaClase((DateTime)reader["fecha"], (int)reader["idGrupo"]));
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
                    "AND tipo = " + tipoProy;
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
        internal static Examen[] getExamenes(int idMateria)
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
                comand.CommandText = "SELECT * FROM inAsistencias WHERE alumno =" + idAlumno;
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

        internal static int getNumeroFaltas( int idAlumno )
        {
            try
            {
                conection.Open();
                comand.CommandText = "SELECT COUNT(*) FROM inAsistencias WHERE alumno=" + idAlumno;
                comand.Connection = conection;

                return (int)comand.ExecuteScalar();
            }
            finally
            {
                conection.Close();
            }
        }

        /// <summary> array de id's de las tareas entregadas por el alumno indicado </summary>
        internal static int[] getEntregasTareas(int idAlumno) //+ y que sean de x materia
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
                //+ y que sean de x materia
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
        internal static int[] getCalifExam(int idAlumno, Examen[] listExamenes) //+ y que sean de x materia
        {
            List<int> calificaciones = new List<int>();
            try
            {
                conection.Open();
                comand.Connection = conection;

                foreach (Examen examen in listExamenes)
                {
                    comand.CommandText =
                        "SELECT * FROM Entregas " +
                        "WHERE alumno =" + idAlumno +
                        "AND entregable = " + examen.id;
                    reader = comand.ExecuteReader();

                    if (reader.Read())
                        calificaciones.Add((int)reader["calif"]);
                    else
                        calificaciones.Add(50);      //La calificación mínima es 5

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
        internal static int[] getCalifProy(int idAlumno, Proyecto[] listProyectoss) //+ y que sean de x materia
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
                        calificaciones.Add(50);

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

        /// <summary> Validación si la fecha que se trata de agregar no existe ya para este grupo </summary>
        internal static bool dayExists(DateTime dia, int idGrupo)
        {
            try
            {
                conection.Open();
                comand.CommandText =
                    "SELECT * FROM DiasClase " +
                    "WHERE fecha=#" + dia.ToString("MM'/'dd'/'yy") + "# " +
                    "AND idGrupo=" + idGrupo;
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

        /// <summary> devuelve la cantidad de entregables en la materia especificada </summary>
        internal static int getNumeroEntregablesTotales(int idMateria, int tipo)
        {
            try
            {
                conection.Open();
                comand.CommandText = "SELECT COUNT(*) FROM Entregables " +
                    "WHERE materia=" + idMateria +
                    "AND tipo=" + tipo;
                comand.Connection = conection;
                return (int)comand.ExecuteScalar();
            }
            finally
            {
                conection.Close();
            }
        }

        /// <summary> devuelve cantidad de tareas entregadas por el alumno en el grupo indicado </summary>
        internal static int getNumeroTareas(int idAlumno, int idMateria)
        {
            try
            {
                conection.Open();
                comand.CommandText = "SELECT COUNT(*) FROM Entregas WHERE alumno=" + idAlumno +
                    " AND entregable IN (SELECT id FROM Entregables WHERE tipo=" + tipoTarea + " AND materia=" + idMateria + ")";
                comand.Connection = conection;
                return (int)comand.ExecuteScalar();
            }
            finally
            {
                conection.Close();
            }
        }

        /// <summary> devuelve la calificacion promedio del alumno en la materia indicada del tipo de entregable indicado </summary>
        internal static decimal getPromCalifProyectosOExam(int idAlumno, int idMateria, int tipo)
        {
            try
            {
                conection.Open();
                comand.CommandText = "SELECT AVG(calif) FROM Entregas WHERE alumno=" + idAlumno +
                    " AND entregable IN (SELECT id FROM Entregables WHERE tipo=" + tipo + " AND materia=" + idMateria + ")";
                comand.Connection = conection;

                object promedio = (object)comand.ExecuteScalar();
                if (promedio == DBNull.Value)
                    return 0;
                Console.WriteLine("Promedio database(dividir entre 100): " + promedio.ToString());
                //El promedio lo saca en base 100 por lo que se divide entre 100 para que quede como lo necesitamos
                return (decimal)(Convert.ToDecimal(promedio) / 100);
            }
            finally
            {
                conection.Close();
            }
        }

        /// <summary> debuelbe los nombres del los tipos de entregables </summary>
        internal static string[] getNombresTipoDe(int materia)
        {
            List<string> nombresTipos = new List<string>();

            try
            {
                conection.Open();
                comand.CommandText =
                    "SELECT * FROM TiposTareas WHERE tipo in ( " +
                        "SELECT tipo FROM Rubros WHERE materia = " + materia +
                    ")";
                reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    nombresTipos.Add(reader["nombre"].ToString());
                }
            }
            finally
            {
                reader.Close();
                conection.Close();
            }
            return nombresTipos.ToArray();
        }

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
        internal static int getIdMaestro(int idGrupo)
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
                conection.Close();
            }
        }

        /// <summary> Pide el id y devuelve un alumno con toda su información </summary>
        internal static Alumno getAlumno(int id)
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
        internal static void getPorcentages(int idMateria, out decimal tareas, out decimal examenes, out decimal proyectos)
        {
            try
            {
                conection.Open();

                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM Rubros WHERE materia=" + idMateria + "AND tipo =" + tipoTarea;
                reader = comand.ExecuteReader();
                tareas = reader.Read() ? (decimal)((int)reader["porcentage"]) / 10 : 3;
                reader.Close();

                comand.Connection = conection;
                comand.CommandText = "SELECT * FROM Rubros WHERE materia=" + idMateria + "AND tipo =" + tipoExam;
                reader = comand.ExecuteReader();
                examenes = reader.Read() ? (decimal)((int)reader["porcentage"]) / 10 : 4;
                reader.Close();

                comand.CommandText = "SELECT * FROM Rubros WHERE materia=" + idMateria + "AND tipo =" + tipoProy;
                reader = comand.ExecuteReader();
                proyectos = reader.Read() ? (decimal)((int)reader["porcentage"]) / 10 : 3;
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

        /// <summary> registra el entregable en la db y regresa su id</summary>
        internal static int agregarEntregable(int tipo, string nombre, int materia)
        {
            int id = 0;
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText =
                    "INSERT INTO Entregables " +
                    "(tipo, nombre, materia) " +
                    "VALUES(" + tipo + ", '" + nombre + "', " + materia + ")";
                Console.WriteLine(comand.ExecuteNonQuery() + " entregable agregado del tipo " + tipo);

                comand.CommandText = "SELECT @@IDENTITY";
                id = (int)comand.ExecuteScalar();
                Console.WriteLine("id de entrega: " + id);
            }
            finally
            {
                conection.Close();
                reader.Close();
            }
            return id;
        }

        /// <summary> registra entregas relaizadas por los alumnos </summary>
        internal static void agregarEntregas(int idAlumno, int tipo, int idEntrega)
        {
            conection.Open();

            comand.CommandText = (
                    tipo == tipoTarea ? 
                    "INSERT INTO Entregas (alumno, tipo, entregable, calif ) VALUES(" + idAlumno + "," + tipo + ", " + idEntrega + ", " + 0 + ")"
                    : "INSERT INTO Entregas (alumno, tipo, entregable, calif ) VALUES(" + idAlumno + "," + tipo + ", " + idEntrega + ", " + 100 + ")"
                );
            comand.Connection = conection;

            comand.ExecuteNonQuery();

            conection.Close();
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
                    comand.CommandText =
                        "INSERT INTO Usuarios " +
                        "(usuario, contrasena) " +
                        "VALUES('" + usuario + "', '" + contra + "')";
                    comand.Connection = conection;
                    Console.WriteLine(comand.ExecuteNonQuery() + " línas con cambios");
                }
            }
            finally
            {
                conection.Close();
                reader.Close();
            }
        }

        /// <summary> agrega un dia al grupo indicado </summary>
        internal static void agregarDiaClase(DiaClase dia)
        {
            comand.CommandText =
                "INSERT INTO DiasClase " +
                "(fecha, idGrupo) " +
                "VALUES(#" + dia.dia.ToString("MM'/'dd'/'yy") + "#, " + dia.idGrupo + " )";
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
        internal static int agregarGrupo(int grado, char grupo, String escuela, int maestro)
        {
            int id;
            try
            {
                comand.Connection = conection;
                comand.CommandText =
                    "INSERT INTO Grupos " +
                    "(grado, grupo, escuela, maestro) " +
                    "VALUES(" + grado + ", '" + grupo + "' , '" + escuela + "', " + maestro + ")";

                conection.Open();
                comand.ExecuteNonQuery();
                comand.CommandText = "SELECT @@IDENTITY";
                id = (int)comand.ExecuteScalar();
            }
            finally
            {
                conection.Close();
            }
            return id;
        }

        /// <summary> registra la materia indicada en la base de datos </summary>
        internal static int agregarMateria(String nombre, int salon)
        {
            int id;

            try
            {
                conection.Open();
                comand.Connection = conection;

                //agregar materia
                comand.CommandText =
                    "INSERT INTO Materias " +
                    "(nombre, grupo) " +
                    "VALUES('" + nombre + "'," + salon + ")";
                comand.ExecuteNonQuery();

                //leer id
                comand.CommandText = "SELECT @@IDENTITY";
                id = (int)comand.ExecuteScalar();
                Console.WriteLine("Materia (id = " + id + ") agregada");

                //agregar rubros
                comand.CommandText =
                    "INSERT INTO Rubros " +
                    " (tipo, porcentage, materia) " +
                    "VALUES(" + tipoTarea + ",30," + id + ")";
                comand.ExecuteNonQuery();

                comand.CommandText =
                    "INSERT INTO Rubros " +
                    "(tipo, porcentage, materia) " +
                    "VALUES(" + tipoProy + ",30," + id + ")";
                comand.ExecuteNonQuery();

                comand.CommandText =
                    "INSERT INTO Rubros " +
                    "(tipo, porcentage, materia) " +
                    "VALUES(" + tipoExam + ",40," + id + ")";
                comand.ExecuteNonQuery();

            }
            finally
            {
                conection.Close();
            }
            return id;
        }

        /// <summary> Registra un nuevo alumno en la BD y nuevos registros de exámenes y proyectos por cada materia del grupo al que pertenece </summary>
        internal static Alumno agregarAlumno(int idGrupo, string nombre, string paterno, string materno)
        {
            int id;
            try
            {
                comand.Connection = conection;
                conection.Open();

                comand.CommandText = "INSERT INTO Alumnos (nombres, apellidoPaterno, apellidoMaterno, grupo) " +
                    "VALUES('" + nombre + "','" + paterno + "','" + materno + "'," + idGrupo + ")";
                Console.WriteLine(comand.ExecuteNonQuery() + " alumno agregado");

                //leer id
                comand.CommandText = "SELECT @@IDENTITY";
                id = (int)comand.ExecuteScalar();

                conection.Close();

                //Grabar exámenes
                conection.Open();
                comand = new OleDbCommand("SELECT id FROM Entregables WHERE tipo = " + 2 + " AND materia IN (SELECT id FROM Materias WHERE grupo = " + idGrupo + ")", conection);
                reader = comand.ExecuteReader();

                List<int> examenes = new List<int>();
                while (reader.Read())
                {
                    examenes.Add((int)reader["id"]);
                }
                reader.Close();

                foreach (int idExa in examenes)
                {
                    comand.CommandText = "INSERT INTO Entregas (alumno, tipo, entregable, calif) VALUES (" + id + ", " + 2 +
                        ", " + idExa + ", " + 100 + ")";
                    comand.ExecuteNonQuery();
                }
                conection.Close();

                //Grabar proyectos
                conection.Open();
                comand = new OleDbCommand("SELECT id FROM Entregables WHERE tipo = " + 3 + " AND materia IN (SELECT id FROM Materias WHERE grupo = " + idGrupo + ")", conection);
                reader = comand.ExecuteReader();

                List<int> proyectos = new List<int>();
                while (reader.Read())
                {
                    proyectos.Add((int)reader["id"]);
                }
                reader.Close();

                foreach (int idPro in proyectos)
                {
                    comand.CommandText = "INSERT INTO Entregas (alumno, tipo, entregable, calif) VALUES (" + id + ", " + 3 +
                        ", " + idPro + ", " + 100 + ")";
                    Console.WriteLine(comand.CommandText);
                    comand.ExecuteNonQuery();
                }
                /*Prueba que no sirvió
                 * comand.CommandText = "INSERT INTO Entregas (alumno, tipo, entregable, calif) VALUES(" + id + "," + 2 +
                    ", (IN (SELECT id FROM Entregables WHERE tipo= 2 AND materia IN (SELECT id FROM Materias WHERE grupo = " + idGrupo + "))), 100)";
                Console.WriteLine(comand.CommandText);
                comand.ExecuteNonQuery();*/
            }
            finally
            {
                conection.Close();
            }

            Console.WriteLine("alumno (id = " + id + ") agregado");

            //devolber una copia del alumno recien agregado
            return new Alumno(id, nombre, paterno, materno, idGrupo);
        }

        /// <summary> registra la falta del alumno indicado el dia indicado en la DB  </summary>
        internal static void ponerFalta(int idAlumno, DateTime dia)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText =
                    "INSERT INTO inAsistencias " +
                    "(alumno, dia) " +
                    "VALUES(" + idAlumno + ",#" + dia.ToString("MM'/'dd'/'yy") + "#)";

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
                comand.CommandText =
                    "DELETE * FROM inAsistencias " +
                    "WHERE alumno = " + idAlumno +
                    "AND dia = #" + dia.ToString("MM'/'dd'/'yy") + "#";

                Console.WriteLine(comand.ExecuteNonQuery() + " ; falta borrada del alumno: " + idAlumno + " del dia: " + dia.ToShortDateString());
            }
            finally
            {
                conection.Close();
            }
        }

        /// <summary> Establece que el alumno con ese Id sí entregó la tarea </summary>
        internal static void setTareaEntregada(int idAlumno, int idTarea)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = 
                    "INSERT INTO Entregas " +
                    "(alumno, tipo, entregable, calif) " +
                    "VALUES(" + idAlumno + "," + 1 + "," + idTarea + "," + 0 + ")";

                Console.WriteLine(comand.ExecuteNonQuery() + " Tarea agregada para el alumno: " + idAlumno);
            }
            finally
            {
                conection.Close();
            }
        }

        /// <summary> Establece que el alumno con ese Id no entregó la tarea con ese ID </summary>
        internal static void quitarTareaEntregada(int idAlumno, int idTarea)
        {
            try
            {
                conection.Open();
                comand.Connection = conection;
                comand.CommandText = "DELETE * FROM Entregas WHERE alumno=" + idAlumno + " AND entregable=" + idTarea;

                Console.WriteLine(comand.ExecuteNonQuery() + " Tarea borrada para el alumno: " + idAlumno);
            }
            finally
            {
                conection.Close();
            }
        }

        /// <summary>Actualiza la calificación del alumno con ese id, puede ser de examen o proyecto que tenga ese ID</summary>
        internal static void actualizarCalificacionEntrega(int idAlumno, int idEntrega, decimal calificacion)
        {
            try
            {
                conection.Open();
                comand.CommandText = 
                    "UPDATE Entregas " +
                    "SET calif=" + calificacion * 10 + 
                    " WHERE alumno=" + idAlumno + " AND entregable=" + idEntrega;
                Console.WriteLine(comand.ExecuteNonQuery() + " calificación actualizada al alumno: " + idAlumno);
            }
            finally
            {
                conection.Close();
            }
        }

        #endregion

        #region actualizar

        internal static void modificarGrupo(int idGrupo, int grado, char grupo, String escuela)
        {
            comand.CommandText =
                "UPDATE Grupos SET "
                    + "grado = " + grado + ", "
                    + "grupo = '" + grupo + "', "
                    + "escuela = '" + escuela + "'"
                + "WHERE id = " + idGrupo;
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
                comand.CommandText =
                    "UPDATE Alumnos " +
                    "SET nombres ='" + nombres + "', apellidoPaterno ='" + paterno + "', apellidoMaterno ='" + materno +
                    "' WHERE id=" + id;

                Console.WriteLine(comand.ExecuteNonQuery() + " Alumno actualizado");
            }
            finally
            {
                conection.Close();
            }
        }

        internal static void modificarMateria(int idMateria, string nombre)
        {
            comand.CommandText =
                "UPDATE Materias " +
                "SET nombre = '" + nombre +
                "' WHERE id = " + idMateria;
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
                comand.CommandText =
                    "UPDATE Rubros " +
                    "SET porcentage = " + newValor +
                    " WHERE materia=" + idMateria + "AND tipo =" + tipo;
                comand.Connection = conection;

                comand.ExecuteNonQuery();
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

        internal static void borrarDiaClase(string dia, int idGrupo, List<Alumno> alumnosGrupo)
        {
            try
            {
                conection.Open();
                comand.CommandText =
                    "DELETE * FROM DiasClase " +
                    "WHERE fecha=#" + dia + "# " +
                    "AND idGrupo=" + idGrupo;
                Console.WriteLine(comand.ExecuteNonQuery() + ": Día borrado " + dia);
                conection.Close();

                //Elimina todas las inasistencias de ese día en la base de datos
                conection.Open();
                foreach (Alumno alumActual in alumnosGrupo.ToArray())
                {
                    comand.CommandText =
                        "DELETE * FROM inAsistencias " +
                        "WHERE alumno=" + alumActual.getId() +
                        " AND dia=#" + dia + "#";
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
                comand.CommandText =
                    "DELETE * FROM Alumnos " +
                    "WHERE id=" + idAlumno;
                comand.ExecuteNonQuery();
                Console.Write("Alumno " + idAlumno + " Borrado");
            }
            finally
            {
                conection.Close();
            }
        }

        internal static void borrarMateria(int idMateria)
        {
            comand.CommandText =
                "DELETE FROM Materias " +
                "WHERE id = " + idMateria;
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

        internal static void eliminarEntrega(int idEntrega)
        {
            try
            {
                conection.Open();
                comand = new OleDbCommand("DELETE * FROM Entregables WHERE id=" + idEntrega, conection);
                Console.WriteLine("Entrega eliminada: " + idEntrega);
                comand.ExecuteNonQuery();
            }
            finally
            {
                conection.Close();
            }

        }

        #endregion

        public static void llenarMatrizCalificaciones(int idAlumno, int idGrupo, List<Materia> materias, decimal[,] matriz, ref decimal promedioTotal, decimal[,] porcentajeCalificaciones )
        {
            try
            {
                int fila = 0;
                foreach(Materia materia in materias )
                {
                    decimal tareas, examenes, proyectos;
                    dbConection.getPorcentages(materia.getId(), out tareas, out examenes, out proyectos);
                    porcentajeCalificaciones[fila, 0] = tareas;
                    porcentajeCalificaciones[fila, 1] = proyectos;
                    porcentajeCalificaciones[fila, 2] = examenes;

                    int tareasTotales = dbConection.getNumeroEntregablesTotales( materia.getId(), 1 );
                    int tareasAlumno = dbConection.getNumeroTareas(idAlumno, materia.getId());

                    //Si no se tiene ninguna tarea no podemos dividir entre 0
                    if (tareasTotales == 0)
                        tareasTotales++;

                    matriz[fila, 0] = (dbConection.getNumeroTareas(idAlumno, materia.getId() ) * tareas) / tareasTotales;
                    matriz[fila, 1] = (dbConection.getPromCalifProyectosOExam(idAlumno, materia.getId(), 3) * proyectos);
                    matriz[fila, 2] = (dbConection.getPromCalifProyectosOExam(idAlumno, materia.getId(), 2) * examenes);
                    matriz[fila, 3] = matriz[fila, 0] + matriz[fila, 1] + matriz[fila, 2];

                    promedioTotal += matriz[fila, 3];
                    fila++;
                }

                promedioTotal /= materias.Count != 0 ? materias.Count : 1;
            }
            finally
            {
                Console.WriteLine("Calificaiones llenadas exitosamente");
            }
        }
    }
}
