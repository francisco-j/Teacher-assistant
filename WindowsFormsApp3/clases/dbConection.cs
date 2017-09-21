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

        private static OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\teacher assistant.mdb");
        private static OleDbCommand cmd = new OleDbCommand();
        private static OleDbDataAdapter ada = new OleDbDataAdapter();

        public static void Connect()
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                    Console.WriteLine("Connected");
                else
                    Console.WriteLine("DisConnected");
            }
            catch (Exception ex)
            {
                Console.WriteLine("bien triste :(   " + ex.Message);
            }

        }

        public int temp()
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

        int getFirst()
        {
            return 0;
        }
    }
}
