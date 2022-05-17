using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_book
{
     public class ContactController
    {
        public List<Contact> list_contacts { get; set; }

        public ContactController()
        {
            list_contacts = new List<Contact>();
            this.list_contacts.Add(new Contact(1,"Ponomarenko", "Artem", new List<string> { "+38067674556633" },"Ivanovskaya,22"));
            this.list_contacts.Add(new Contact(2,"Azarova", "Karolina", new List<string> { "+38067004556633" }, "Shmidta,35"));
            this.list_contacts.Add(new Contact(3,"Shut", "Mila", new List<string> { "+38063688556633" }, "Korolenka,22"));
        }


        public void AddContact(Contact item)
        {
           if(item.ID==-1)
            {
                if (this.list_contacts.Count > 0) { item.ID = this.list_contacts.Last().ID + 1; }
                else
                { item.ID = 0; }
            }
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
