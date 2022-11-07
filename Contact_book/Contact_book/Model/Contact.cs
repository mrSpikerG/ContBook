using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_book
{
   public class Contact
    { 
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<string> phone_number { get; set; }
        public string adress { get; set; }


        public Contact( int Id, string surname, string name, List<string> phone_number, string adress)
        {
            this.ID = Id;
            Name = name;
            Surname = surname;   
            this.phone_number = phone_number;
            this.adress = adress;
        }
        public Contact( string surname, string name, List<string> phone_number, string adress)
        {
            this.ID = -1;
            Name = name;
            Surname = surname;
            this.phone_number = phone_number;
            this.adress = adress;
        }


        public override string ToString()
        {
            StringBuilder contact = new StringBuilder();
            contact.Append(ID + "\t");
            contact.Append(Surname + "\t");
            contact.Append(Name + "\t");
            foreach(string number in phone_number)
            {
                contact.Append(number + "\t");
            }
            contact.Append(adress + "\n");

            return contact.ToString();
        }

    }
}
