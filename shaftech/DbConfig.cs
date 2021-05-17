using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
namespace TinaliAutoLight
{
    class DbConfig
    {

        public static String CONNECTION_STRING = @"Data Source = shaftech.db";

        public void getConnection()
        {
            
            string stm = "SELECT SQLITE_VERSION()";
            SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING);

            connection.Open();

            SQLiteCommand command = new SQLiteCommand(stm, connection);
            string version = command.ExecuteScalar().ToString();

            MessageBox.Show("SQLite version: " + version);

        }
        public static int getNextItemId(){

            int nextId = -1;

            String query = "SELECT seq FROM SQLITE_SEQUENCE where name='items'";
            
            SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read()){
                nextId = reader.GetInt32(0) + 1;
            }
            reader.Close();
            connection.Close();
            return nextId;
        }
    }
}
