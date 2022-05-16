using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_book
{
    class Contact
    {
        

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Father_Name { get; set; }
        public List<string> phone_number { get; set; }
        public string adress { get; set; }


        public Contact( string surname, string name, string father_Name, List<string> phone_number, string adress)
        {
            Name = name;
            Surname = surname;
            Father_Name = father_Name;
            this.phone_number = phone_number;
            this.adress = adress;
        }



    }
}
