using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;

            string entry = $"Name: {name}, Email: {email}, Phone: {phoneNumber}";
            listBox1.Items.Add(entry);

            txtName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
        }
    }
}
