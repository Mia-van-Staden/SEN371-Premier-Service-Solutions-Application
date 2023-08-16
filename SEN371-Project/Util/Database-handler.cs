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

        public static string[] GetPerformance(string EmpID)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source=..\..\Database\Premier_SQLite_Final.db");
            String[] Arr = {"","","","",""};

            using (var cmd = new SQLiteCommand(conn))
            {
                using (var command = new SQLiteCommand(conn))
                {
                    conn.Open();
                    command.CommandText = "SELECT * FROM EmployeePerformance";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ID = reader["EmployeeNumber"].ToString();

                            if ((ID.Equals(EmpID)))
                            {
                                Arr[0] = reader["EmployeeNumber"].ToString();
                                Arr[1] = reader["EmployeeName"].ToString();
                                Arr[2] = reader["EmployeeSurname"].ToString();
                                Arr[3] = reader["PerformanceRating"].ToString();
                                Arr[4] = reader["JobDescription"].ToString();
                                conn.Close();
                                return Arr;
                            }
                        }
                    }
                    conn.Close();
                }
            }
            return Arr;
        }

    }
}
