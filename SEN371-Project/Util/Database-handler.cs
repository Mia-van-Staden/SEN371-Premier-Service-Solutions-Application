using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project.Util
{
    internal class Database_handler
    {
        public static void Insert(string query)
        {
            //Create an open connection
            SQLiteConnection conn = new SQLiteConnection(@"data source=..\..\Database\Premier_SQLite_Final.db");
            conn.Open();

            //Initialize the SqliteCommand
            var SqliteCmd = new SQLiteCommand();

            //Create the SqliteCommand
            SqliteCmd = conn.CreateCommand();

            //Assigning the query to CommandText
            SqliteCmd.CommandText = query;

            //Execute the SqliteCommand
            SqliteCmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable AdaptSelect(string query)
        {
           
            //Create and open connection
            SQLiteConnection conn = new SQLiteConnection(@"data source=..\..\Database\Premier_SQLite_Final.db");
            conn.Open();

            //Create the command to send to database
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            //Used to store result in correct format for a datagridview
            DataTable dt = new DataTable();

            //This will get the data from the database using the cmd, adapt and store.
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            conn.Close();
            return dt;

        }

    }
}
