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

// ******************** validacion ***************************************

        //verifica que la contrase;a y usuario coinsidan
        internal static bool isCorrecto(string usuario, string contraseña)
        {
            throw new NotImplementedException();
            //some code
        }

//************************  lectura ******************************************

        //some code

//************************  escritura ******************************************

        internal static void registrarUsuario(string usuario, string contra)
        {
            conection.Open();
            comand.Connection = conection;
            comand.CommandText = "select * from Usuarios where usuario='" + usuario + "'" ;
            OleDbDataReader reader = comand.ExecuteReader();

            if (reader.HasRows)
            {
                throw new Exception("ya existe este usuario");
            }
            else
            {
                reader.Close();
                comand.CommandText = "INSERT INTO Usuarios (usuario, contraseña) VALUES('" + usuario+"', '"+contra+"')";
                comand.CommandType = CommandType.Text;
                comand.ExecuteNonQuery();
            }
            conection.Close();
        }

//************************** otros *********************************************
        
        //experimentacion
        public int temp()
        {
            adapter.SelectCommand.CommandText = "SELECT * FROM Contactos";
            conection.Open();
            adapter.SelectCommand.Connection = conection;

            OleDbDataReader reader = adapter.SelectCommand.ExecuteReader();
            reader.Read();
            int id = Convert.ToInt16(reader["Id"].ToString());

            conection.Close();

            return id;
        }

        
    }
}
