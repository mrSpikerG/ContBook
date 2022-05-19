using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_book.View
{
    public partial class Form1 : Form
    {
       public  ListContactsContoller ListContacts = new ListContactsContoller();
       AddContactForm addContact;
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addContact = new AddContactForm();
            addContact.Show();
            addContact.button1.Click += new System.EventHandler(this.button_add);
          
        }
        public void button_add(object sender, EventArgs e)
        {
            this.ListContacts.list_contacts.Add(new Contact(this.ListContacts.list_contacts.Count > 0 ? ListContacts.list_contacts.Last().ID + 1 : 0, addContact.textBox1.Text, addContact.textBox2.Text, new List<string> { $"{addContact.textBox4.Text}" }, addContact.textBox5.Text));
            this.generalContactControlls.GenerateView(this.ListContacts.list_contacts) ;
            file.Write(this.ListContacts.list_contacts);
            addContact.Close();

        }

       
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
