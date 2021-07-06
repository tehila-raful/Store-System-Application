using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; 


namespace SemsterProject
{
    public partial class MenuForm : Form
    {
        DataClasses2DataContext db;
        private int accountID;
        private int custID;
        private string username; 

        public MenuForm(String username)
        {
            InitializeComponent();
            this.username = username;
            using ( db = new DataClasses2DataContext())
            { 
                //select customer id where username = username 
                custID = db.Customers.Where(i => i.UserName.Equals(username))
                                    .Select(i => i.CustomerID).First();

                //select account id where customer Id = custId
                accountID = db.Accounts.Where(i => i.CustomerID == custID)
                                    .Select(i => i.AccountID).First();
            }

            listItems.View = View.Details;
            listItems.Hide();
        }

        private void menuViewItems_Click(object sender, EventArgs e)
        {
            listItems.Items.Clear(); //clear if anything is in there 

            using (db = new DataClasses2DataContext())
            {
                var list = db.Items.Select(i => i).ToList();
                foreach (var i in list)
                {
                    ListViewItem item = new ListViewItem(i.ItemID.ToString());
                    item.SubItems.Add(i.ItemName);
                    item.SubItems.Add(i.Price.ToString());
                    listItems.Items.Add(item);
                }
            }

            listItems.Show();
        }

        private void menuMakeAPurchase_Click(object sender, EventArgs e)
        {
            //go to next window
            this.Hide();
            var purchase = new MakePurchase(username, accountID);
            purchase.Show();
        }

        private void menuItemViewAccountDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            var acct = new AccountDetail(username, accountID);
            acct.Show();
        }

        private void menuItemByDateTool_Click(object sender, EventArgs e)
        {
            this.Hide();
            var date = new PastPurchasesDate(username, accountID);
            date.Show();
        }

        private void menuItemByPrice_Click(object sender, EventArgs e)
        {
            this.Hide();
            var price = new PastPurchasesPrice(username, accountID);
            price.Show();
        }

        private void menuMakeAPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            var payment = new MakePayment(username, accountID);
            payment.Show(); 
        }
    
        private void MenuForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeSystemDataSet.Item' table.
            // You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.storeSystemDataSet.Item);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var user = new SignInForm();
            user.Show(); 
        }
    }
}
