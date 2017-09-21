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

        static OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\teacher assistant.mdb");
        static OleDbDataAdapter ada = new OleDbDataAdapter();
        static OleDbCommand cmd = new OleDbCommand();

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
    }
}
