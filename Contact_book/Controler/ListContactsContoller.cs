using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_book
{
     public class ListContactsContoller
    {
        public List<Contact> list_contacts { get; set; }

        public ListContactsContoller()
        {
            list_contacts = new List<Contact>();
           
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
        public List<Contact> GetContacts()
        {
            return list_contacts;

        }
       
        public Contact GetById(int id) => list_contacts.Where(item => item.ID.Equals(id)).First<Contact>();

    }
}
