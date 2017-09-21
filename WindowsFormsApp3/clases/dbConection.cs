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

        OleDbConnection conn = new OleDbConnection();
        OleDbDataAdapter ada = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();

        private void Connect()
        {
            try
            {
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\...\teacher assistant.accdb;";
                conn.Open();
                if (conn.State == ConnectionState.Open)
                    MessageBox.Show("Connected");
                else
                    MessageBox.Show("DisConnected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
}
