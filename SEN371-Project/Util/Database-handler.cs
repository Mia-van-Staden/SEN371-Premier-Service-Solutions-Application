using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
