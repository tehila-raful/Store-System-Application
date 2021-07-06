using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemsterProject
{
    public partial class SignInForm : Form
    {
        DataClasses2DataContext db; 
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            using (db = new DataClasses2DataContext())
            {
                string user = txtUsername.Text;
                string password = txtPassword.Text;
                var usernames = db.Customers.Select(s => s.UserName);
                var passwords = db.Customers.Select(s => s.CustomerPassword);

                //check if username and password are in database
                if (usernames.Contains(user) && passwords.Contains(password))
                {
                    //check to see if username matches password 
                    foreach (var customer in db.Customers.Select(s => s))
                    {
                        if (customer.UserName.Equals(user) && customer.CustomerPassword.Equals(password))
                        {
                            //go to next window
                            this.Hide();
                            var menuForm = new MenuForm(user);
                            menuForm.Show();
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Username or Password not found");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }

        private void linkLblNewCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //go to next window
            this.Hide();
            var newCustForm = new NewCustomerForm();
            newCustForm.Show();
        }
    }
}
