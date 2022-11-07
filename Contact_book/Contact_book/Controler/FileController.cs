using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Data.SqlClient;
using System.Data;

namespace Contact_book
{
    public class FileController
    {
        public List<Contact> list_contacts { get; set; }
        public string Path;



        public FileController()
        {
            Path = "MyContacts.txt";

            if (!File.Exists("connection.json"))
            {
                SaveJSON(@"Server = localhost\SQLEXPRESS; Database = Resorces; Trusted_Connection = True;");
            }

            ReadJSON();
        }

        async public void SaveJSON(string con)
        {
            using (FileStream fs = new FileStream("connection.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<string>(fs, con);
            }
        }

        public void ReadJSON()
        {
            string json = File.ReadAllText("connection.json");
            using (JsonDocument document = JsonDocument.Parse(json))
            {
                JsonElement root = document.RootElement;
                SingletoneDB.InitConnection(root.GetString());
            }
        }






        public void Write(List<Contact> contactsList)
        {

            string cmd = @"USE Resorces; IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Contacts' and xtype='U')CREATE TABLE Contacts ([Id] INT IDENTITY,[Name] VARCHAR(100),[Surname] VARCHAR(100),[Phone] VARCHAR(50),[Address] NTEXT)";
            using (SqlCommand command = new SqlCommand(cmd, SingletoneDB.GetInstance().GetDBConnection()))
            {
                command.ExecuteNonQuery();
            }
           
            foreach (var item in contactsList)
            {
                cmd = $"USE Resorces; IF NOT EXISTS(SELECT* FROM Contacts WHERE [Id] = {item.ID}) INSERT INTO Contacts([Name], [Surname], [Phone], [Address]) VALUES('{item.Name}','{item.Surname}','{item.phone_number.First()}','{item.adress}');";
                using (SqlCommand command = new SqlCommand(cmd, SingletoneDB.GetInstance().GetDBConnection()))
                {
                    command.ExecuteNonQuery();
                }
            }


           
        }
        public void Read(ListContactsContoller contactController)
        {

            string commStr = $"SELECT * FROM Contacts";
            using (SqlCommand command = new SqlCommand(commStr, SingletoneDB.GetInstance().GetDBConnection()))
            {
                SqlDataReader sqlData = command.ExecuteReader();
               
                while (sqlData.Read())
                {
                    contactController.AddContact(new Contact((int)sqlData.GetValue(0), sqlData.GetValue(2).ToString(), sqlData.GetValue(1).ToString(), new List<string> { sqlData.GetValue(3).ToString() }, sqlData.GetValue(4).ToString()));
                }
                sqlData.Close();
              
            }
        }
    }
}
