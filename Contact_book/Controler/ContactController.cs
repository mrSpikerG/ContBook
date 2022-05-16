using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_book.Controler
{
    class ContactController
    {
        public List<Contact> list_contacts { get; set; }

        public ContactController()
        {
            list_contacts = new List<Contact>();
            this.list_contacts.Add(new Contact("Ponomarenko", "Artem", "Mikhailovich", new List<string> { "+38067674556633" },"Ivanovskaya,22"));
            this.list_contacts.Add(new Contact("Azarova", "Karolina", "Andreevna", new List<string> { "+38067004556633" }, "Shmidta,35"));
            this.list_contacts.Add(new Contact("Shut", "Mila", "Oleksandrovna", new List<string> { "+38063688556633" }, "Korolenka,22"));
        }


        public void AddContact(Contact item)
        {
            this.list_contacts.Add(item);

        }

        public void DeleteContact(Contact item)
        {
            if(this.list_contacts.Contains(item))
            this.list_contacts.Remove(item);

        }
        public List<Contact> GetContact()
        {
            return list_contacts;

        }

    }
}
