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
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //check that entered all information 
            if(txtUsername.Text.Equals("") || txtPassword.Text.Equals("") || txtLName.Text.Equals("")
                || txtFName.Text.Equals("") || txtEmail.Text.Equals(""))
            {
                MessageBox.Show("all information is required");
            }
            else
            {
                //create new Customer 
                Customer cust = new Customer();
                cust.FName = txtFName.Text;
                cust.LName = txtLName.Text;
                cust.Email = txtEmail.Text;
                cust.CustomerPassword = txtPassword.Text;

                using (DataClasses2DataContext db = new DataClasses2DataContext())
                {
                    //check to see if username exists yet 
                    var usernames = db.Customers.Select(s => s.UserName);
                    if (!usernames.Contains(txtUsername.Text))
                    {
                        cust.UserName = txtUsername.Text;
                        db.Customers.InsertOnSubmit(cust);
                        db.SubmitChanges();
                        MessageBox.Show("Account created successfully ");

                        var menuForm = new MenuForm(txtUsername.Text);
                        this.Hide();
                        menuForm.Show();
                    }

                    else
                    {
                        MessageBox.Show("Username already taken");
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
            }
        }
    }
}
