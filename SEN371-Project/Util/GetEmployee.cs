using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project.Util
{
    internal class GetEmployee
    {
        public static string PhoneNum(string EmployeeID)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source=..\..\Database\Premier_SQLite_Final.db");
            string PhoneNum = "";

            using (var cmd = new SQLiteCommand(conn))
            {
                using (var command = new SQLiteCommand(conn))
                {
                    conn.Open();
                    command.CommandText = "SELECT * FROM EmployeeDetails";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ID = reader["EmployeeNumber"].ToString();

                            if (EmployeeID == ID)
                            {
                                PhoneNum = reader["EmployeePhoneNumber"].ToString();
                                return PhoneNum;
                            }
                        }
                    }
                    conn.Close();
                }
            }
            return PhoneNum;
        }

    }
}
