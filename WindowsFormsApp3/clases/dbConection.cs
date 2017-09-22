using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApp3.clases
{
    class dbConection
    {
        private static String db = "|DataDirectory|\teacher assistant.mdb"; //direccion de la base de datos Access
        private static String dbStringConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+db;
        
        private static OleDbConnection conn = new OleDbConnection(@dbStringConexion);
        private static OleDbCommand cmd = new OleDbCommand();
        private static OleDbDataAdapter ada = new OleDbDataAdapter();

        // verid=fica que la conexion se pueda relizar
        public static bool canConnect()
        {
            try
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    // retorna true si si se puede realizar, false sculquier otra cosa
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

        public int temp() //experimentacion
        {
            ada.SelectCommand.CommandText = "SELECT * FROM Contactos";
            conn.Open();
            ada.SelectCommand.Connection = conn;

            OleDbDataReader reader = ada.SelectCommand.ExecuteReader();
            reader.Read();
            int id = Convert.ToInt16(reader["Id"].ToString());

            conn.Close();

            return id;
        }

        int getFirst() // no hace nada
        {
            return 0;
        }
    }
}
