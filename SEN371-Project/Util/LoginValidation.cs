using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project.Util
{
    internal class LoginValidation
    {

        public static Boolean Validate(String Username, String Password)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source=..\..\Database\Premier_SQLite_Final.db");


            using (var cmd = new SQLiteCommand(conn))
            {
                using (var command = new SQLiteCommand(conn))
                {
                    conn.Open();
                    command.CommandText = "SELECT * FROM Login";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String user = reader["Username"].ToString();
                            String pass = reader["Password"].ToString();

                            if ((user.Equals(Username)) && (pass.Equals(Password)))
                            {
                                return true;
                            }
                        }
                    }
                    conn.Close();
                }
            }
            return false;
        }

    }
}
