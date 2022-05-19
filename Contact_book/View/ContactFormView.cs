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
    public partial class ContactFormView : Form
    {
        public Contact contact;

        public ContactFormView()
        {
            InitializeComponent();
        }
        public ContactFormView(Contact _contact)
        {

            
            InitializeComponent();
            contact = _contact;
            this.NameLB.Text = contact.Name;
            this.SurnameLB.Text = contact.Surname;
            this.PhoneNumberLB.Text = contact.phone_number.First();
            this.AdressLB.Text = contact.adress;
        }

        private void PhoneNumberLB_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //this.NameLB.Text = changeContactForm.NameTB.Text;
            //this.SurnameLB.Text = changeContactForm.SurnameTB.Text;
            //this.PhoneNumberLB.Text = changeContactForm.phoneNumberTB.Text;
            //this.AdressLB.Text = changeContactForm.adressTB.Text;
            //changeContactForm.Close();
        }
    }
}
