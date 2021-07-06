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
    public partial class AccountDetail : Form
    {
        DataClasses2DataContext db;
        private int accountID;
        private string username;

        public AccountDetail(string username, int accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
            this.username = username;

            using (db = new DataClasses2DataContext())
            {
                //select customer id where username = username 
                var custID = db.Customers.Where(i => i.UserName.Equals(username))
                                    .Select(i => i.CustomerID).First();

                lblCustName.Text = "Customer Name: " +
                    db.Customers.Where(i => i.CustomerID == custID).Select(i => i.FName + i.LName).First();

                lblAccountNum.Text = "Account Number:  " + accountID;
                
                lblAccountBalance.Text = "Account Balance: " +
                    db.Accounts.Where(i => i.AccountID == accountID).Select(i => i.Balance).First();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go to next window
            this.Hide();
            var menuForm = new MenuForm(username);
            menuForm.Show();
        }
    }
}
