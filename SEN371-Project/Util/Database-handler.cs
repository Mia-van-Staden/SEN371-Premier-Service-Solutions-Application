using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SEN371_Project.Util
{
    internal class Database_handler
    {
        public static void Insert(string query)
        {
            Backup();
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

        public static void Update(string query)
        {
            Backup();
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
            Backup();
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
            Backup();

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

        private static void Backup()
        {

            string fileToCopy = @"..\..\Database\Premier_SQLite_Final.db";
            string destinationDirectory = @"..\..\Backup\Premier_SQLite_Final.db";

            if (!(File.Exists(Path.Combine(fileToCopy, destinationDirectory))))
            {
                File.Copy(fileToCopy, destinationDirectory);
            }
            else
            { 
                File.Delete(destinationDirectory);
                File.Copy(fileToCopy, destinationDirectory);
            }
            
        }

        public static string[] GetJob(string JobID)
        {
            Backup();

            SQLiteConnection conn = new SQLiteConnection(@"data source=..\..\Database\Premier_SQLite_Final.db");
            String[] Arr = { "", "", "", "", "", "", "", "", ""};

            using (var cmd = new SQLiteCommand(conn))
            {
                using (var command = new SQLiteCommand(conn))
                {
                    conn.Open();
                    command.CommandText = "SELECT * FROM JobDetails";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ID = reader["JobID"].ToString();

                            if ((ID.Equals(JobID)))
                            {
                                Arr[0] = reader["ClientID"].ToString();
                                Arr[1] = reader["EmployeeID"].ToString();
                                Arr[2] = reader["Location"].ToString();
                                Arr[3] = reader["EquipmentDetails"].ToString();
                                Arr[4] = reader["StartDate"].ToString();
                                Arr[5] = reader["EndDate"].ToString();
                                Arr[6] = reader["ExpectedTime"].ToString();
                                Arr[7] = reader["PossibleSlackTime"].ToString();
                                Arr[8] = reader["JobDescription"].ToString();
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

        /*
                private void Authorize()
                {
                    string[] scopes = new string[] { DriveService.Scope.Drive,
                                       DriveService.Scope.DriveFile,};
                    var clientId = "12345678-kiwwjelkrklsjdkljklaflkjsdjasdkhw.apps.googleusercontent.com";      // From https://console.developers.google.com  
                    var clientSecret = "ksdklfklas2lskj_asdklfjaskla-";          // From https://console.developers.google.com  
                                                                                 // here is where we Request the user to give us access, or use the Refresh Token that was previously stored in %AppData%  
                    var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
                    {
                        ClientId = clientId,
                        ClientSecret = clientSecret
                    }, scopes,
                    Environment.UserName, CancellationToken.None, new FileDataStore("MyAppsToken")).Result;
                    //Once consent is recieved, your token will be stored locally on the AppData directory, so that next time you wont be prompted for consent.   

                    DriveService service = new DriveService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = "MyAppName",

                    });
                    service.HttpClient.Timeout = TimeSpan.FromMinutes(100);
                    //Long Operations like file uploads might timeout. 100 is just precautionary value, can be set to any reasonable value depending on what you use your service for  

                    // team drive root https://drive.google.com/drive/folders/0AAE83zjNwK-GUk9PVA   

                    var respocne = uploadFile(service, textBox1.Text, "");
                    // Third parameter is empty it means it would upload to root directory, if you want to upload under a folder, pass folder's id here.
                    MessageBox.Show("Process completed--- Response--" + respocne);
                }

                public Google.Apis.Drive.v3.Data.File uploadFile(DriveService _service, string _uploadFile, string _parent, string _descrp = "Uploaded with .NET!")
                {
                    if (System.IO.File.Exists(_uploadFile))
                    {
                        Google.Apis.Drive.v3.Data.File body = new Google.Apis.Drive.v3.Data.File();
                        body.Name = System.IO.Path.GetFileName(_uploadFile);
                        body.Description = _descrp;
                        body.MimeType = GetMimeType(_uploadFile);
                        // body.Parents = new List<string> { _parent };// UN comment if you want to upload to a folder(ID of parent folder need to be send as paramter in above method)
                        byte[] byteArray = System.IO.File.ReadAllBytes(_uploadFile);
                        System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                        try
                        {
                            FilesResource.CreateMediaUpload request = _service.Files.Create(body, stream, GetMimeType(_uploadFile));
                            request.SupportsTeamDrives = true;
                            // You can bind event handler with progress changed event and response recieved(completed event)
                            request.ProgressChanged += Request_ProgressChanged;
                            request.ResponseReceived += Request_ResponseReceived;
                            request.Upload();
                            return request.ResponseBody;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message, "Error Occured");
                            return null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The file does not exist.", "404");
                        return null;
                    }
                }
        */
    }
}
