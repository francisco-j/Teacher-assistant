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

        // verid=fica que la conexion se pueda relizar
        public static bool canConnect()
        {
            try
            {
                conection.Open();

                if (conection.State == ConnectionState.Open)
                {
                    conection.Close();
                    // retorna true si se puede realizar una conecion, false a culquier otra cosa
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        internal static Grupo[] GruposAsociadosCon(object ususario)
        {
            Grupo g =  new Grupo(1, 1, 'A', "chapalirta");
            Grupo[] gs = { g };

            return gs;

        }

        // ******************** validacion ***************************************

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
                //id = ;

                conection.Close();
                return true;
            }
            conection.Close();
            return true;
        }

//************************  lectura ******************************************

        //some code

//************************  escritura ******************************************

        internal static bool registrarUsuario(string usuario, string contra)
        {
            conection.Open();
            comand.Connection = conection;
            comand.CommandText = "SELECT * FROM Usuarios WHERE usuario='" + usuario + "'" ;
            OleDbDataReader reader = comand.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show( "EL usuario ya existe :v " );
                //throw new Exception("ya existe este usuario");
                conection.Close();
                return false;
            }

            reader.Close();
            comand = new OleDbCommand();
            comand.CommandText = "INSERT INTO Usuarios (usuario, contrasena) VALUES('"+usuario+"', '"+contra+"')";
            comand.Connection = conection;
            Console.WriteLine(comand.ExecuteNonQuery()+" lienas con cambios");
            conection.Close();
            return true;
        }

        internal static void agregarAlumno()
        {
            throw new NotImplementedException();
            //some code
        }

        internal static void agregarGrupo()
        {
            throw new NotImplementedException();
            //some code
        }

        internal static void agregarTarea()
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
