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
    public partial class ChangeContactForm : Form
    {
       public Contact contact;
        public ChangeContactForm()
        {
            InitializeComponent();
        }
        public ChangeContactForm(Contact _contact)
        {
           
            InitializeComponent();
            this.contact = _contact;
            this.NameTB.Text = contact.Name;
            this.SurnameTB.Text = contact.Surname;
            this.phoneNumberTB.Text = contact.phone_number.First();
            this.adressTB.Text = contact.adress;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
