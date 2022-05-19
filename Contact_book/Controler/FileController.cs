using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Contact_book
{
   public class FileController
    {
        public List<Contact> list_contacts { get; set; }
        public string Path;
        public FileController()
        {
            Path = "MyContacts.txt";
        }
        public void Write(List<Contact> contactsList)
        {
            File.Delete(Path);
            foreach (var item in contactsList)
            {
                File.AppendAllText(Path, item.ToString());
            }
        }
        public void Read(ListContactsContoller contactController)
        {
            string str = File.ReadAllText(Path);
            string[] splStr = str.Split('\n');
            for (int i = 0; i < splStr.Length - 1; i++)
            {
                string rez = splStr[i];
                string[] value = rez.Split('\t');
                Contact contact = new Contact(Int32.Parse (value[0]) , value[1], value[2], new List<string> { value[3] },value[4]);
                contactController.AddContact(contact);
            }
        }
    }
}
