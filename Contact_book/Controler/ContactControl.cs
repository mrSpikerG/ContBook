using Contact_book.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_book
{
    public partial class ContactControl : UserControl
    {
        public Contact contact { get; set; }
        public ContactControl()
        {
            InitializeComponent();
        }
        public ContactControl(Contact _contact)
        {
            InitializeComponent();
            contact = _contact;
            this.NameLB.Text = _contact.Name;
            this.PhoneNumberLB.Text = _contact.phone_number.First();
        }

        private void ContactControl_Click(object sender, EventArgs e)
        {
           
            //contactform.NameLB.Text = contact.Name;
            //contactform.SurnameLB.Text = contact.Surname;
            //contactform.PhoneNumberLB.Text = contact.phone_number.First();
            //contactform.AdressLB.Text = contact.adress;
            //contactform.button2.Click += Button2_Click;
            //contactform.ShowDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            changeContactForm.NameTB.Text = contact.Name;
            changeContactForm.SurnameTB.Text = contact.Surname;
            changeContactForm.phoneNumberTB.Text = contact.phone_number.First();
            changeContactForm.adressTB.Text = contact.adress;
            changeContactForm.saveBtn.Click += SaveBtn_Click1;
            changeContactForm.ShowDialog();
          
        }

        private void SaveBtn_Click1(object sender, EventArgs e)
        {

            contactform.NameLB.Text = changeContactForm.NameTB.Text;
            contactform.SurnameLB.Text = changeContactForm.SurnameTB.Text;
            contactform.PhoneNumberLB.Text = changeContactForm.phoneNumberTB.Text;
            contactform.AdressLB.Text = changeContactForm.adressTB.Text;

            contactform.NameLB.Text = contact.Name;
            contactform.SurnameLB.Text = contact.Surname;
            contactform.PhoneNumberLB.Text = contact.phone_number.First();
            contactform.AdressLB.Text = contact.adress;

            changeContactForm.Close();
        }

        
    }
}
