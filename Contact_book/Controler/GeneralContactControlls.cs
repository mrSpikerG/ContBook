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
    public partial class GeneralContactControlls : UserControl
    {
        public ListContactsContoller List_Contacts;
        public Contact contactDelete;
        public GeneralContactControlls(ListContactsContoller list_contacts)
        {
            InitializeComponent();
            this.List_Contacts = list_contacts;

        }
        public GeneralContactControlls()
        {
            InitializeComponent();
        }

        public void GenerateView(List<Contact> contacList)
        {
            panel1.Controls.Clear();
            int x = 0;
            foreach (Contact item in contacList)
            {
                ContactControl tmp = new ContactControl(item);
                tmp.Location = new Point(0, x);
                tmp.Click += Tmp_Click;
                panel1.Controls.Add(tmp);
                x += tmp.Size.Height + 5;
            }
        }

        private void Tmp_Click(object sender, EventArgs e)
        {
            contactFormView = new ContactFormView((sender as ContactControl).contact);
            contactFormView.button2.Click += Button2_Click;
            contactFormView.deleteBtn.Click += DeleteBtn_Click;
            contactFormView.ShowDialog();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            this.List_Contacts.DeleteContact(contactFormView.contact);
            fileController.Write(List_Contacts.list_contacts);
            contactFormView.Close();
            this.GenerateView(this.List_Contacts.list_contacts);
        }

        private void Button2_Click(object sender, EventArgs e)
        {

             changeContactForm = new ChangeContactForm(contactFormView.contact);
            contactDelete = contactFormView.contact;
            changeContactForm.saveBtn.Click += SaveBtn_Click;
            changeContactForm.ShowDialog();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Contact foadd = new Contact(contactDelete.ID,changeContactForm.SurnameTB.Text,changeContactForm.NameTB.Text,new List<string> { changeContactForm.phoneNumberTB.Text },changeContactForm.adressTB.Text);
            this.List_Contacts.DeleteContact(contactDelete);
            this.List_Contacts.AddContact(foadd);
            contactFormView.NameLB.Text = foadd.Name;
            contactFormView.SurnameLB.Text = foadd.Surname;
            contactFormView.PhoneNumberLB.Text = foadd.phone_number.First();
            contactFormView.AdressLB.Text = foadd.adress;
            fileController.Write(List_Contacts.list_contacts);
            changeContactForm.Close();
            this.GenerateView(this.List_Contacts.list_contacts);


        }

        private void AllContactControlls_Load(object sender, EventArgs e)
        {
            this.GenerateView(this.List_Contacts.GetContacts());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchLineTB_TextChanged(object sender, EventArgs e)
        {
            if (searchLineTB.Text == string.Empty)
            {
                GenerateView(List_Contacts.GetContacts());
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    GenerateView(this.List_Contacts.GetContacts().Where(i => i.Name.Equals(searchLineTB.Text)).ToList());
                   
                }
                else
                {
                    GenerateView(this.List_Contacts.GetContacts().Where(i => i.Name.Contains(searchLineTB.Text)).ToList());
                }
            }
        }
    }
}
