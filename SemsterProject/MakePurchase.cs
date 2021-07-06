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
    public partial class MakePurchase : Form
    {
        DataClasses2DataContext db;
        private int accountID;
        private string username; 
        private decimal creditMax = 150.00M;       

        public MakePurchase(string username, int accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
            this.username = username; 
            groupBoxPurchase.Hide();
        }

        private void btnSubmitPurchase_Click(object sender, EventArgs e)
        {
            bool valid = true;
            lblResults.Text = "";

            if (txtQuantity.Text.Equals(""))
            {
                MessageBox.Show("must enter a quantity greater than 0");
            }
            else
            {
                int qnt = Int32.Parse(txtQuantity.Text);
                string itemName = comboBoxlistItems.SelectedValue.ToString();
                
               
                using (db = new DataClasses2DataContext())
                {
                    //get itemId of item selected 
                    int itemID = db.Items.Where(i => i.ItemName.Equals(itemName)).Select(i => i.ItemID).First();

                    //create new purchase 
                    ItemPurchase pur = new ItemPurchase();
                    pur.OrderID = Int32.Parse(lblOrderNumValue.Text);
                    pur.ItemID = itemID;

                    //get price 
                    pur.QuotedPrice = db.Items.Where(i => i.ItemID == itemID)
                                              .Select(i => i.Price).First();

                    while (valid)
                    {
                        valid = false;
                      
                        //check inventory 
                        int inventory = db.Items.Where(i => i.ItemID == itemID)
                                            .Select(i => i.Units).First();

                        if (qnt < 1)
                        {
                            lblResults.Text = "Insufficient Quantity ";
                            break;
                        }

                        if (qnt > inventory)
                        {
                            lblResults.Text = "Item out of stock";
                            break;
                        }


                        pur.Quantity = qnt;


                        //check that balance won't go over credit with this purchase
                        var balance = db.Accounts.Where(i => i.AccountID == accountID).Select(i => i.Balance).First();
                        if (balance + (pur.QuotedPrice * qnt) > creditMax)
                        {
                            lblResults.Text = "Cannot place purchase. Exceeding Credit of $150";
                            break;
                        }

                        //if buying the same item in the same purchase
                        //then just up the quantity 

                        //get all items in order so far 
                        var itemsOrdered = db.ItemPurchases.Where(i => i.OrderID == Int32.Parse(lblOrderNumValue.Text)).Select(i => i.ItemID);
                        if (itemsOrdered.Contains(itemID))
                        {
                            //update the current record 
                            var m = db.ItemPurchases.Where(i => i.OrderID == Int32.Parse(lblOrderNumValue.Text) && i.ItemID == itemID).First();
                            m.Quantity += qnt;
                            db.SubmitChanges();
                            MessageBox.Show("Updated Quantity");
                            break;
                        }

                        //if still valid then add purchase to order and database 
                        db.ItemPurchases.InsertOnSubmit(pur);
                        db.SubmitChanges();
                        MessageBox.Show("Item Purchased");
                    }

                    txtQuantity.Clear();
                }
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            groupBoxPurchase.Show();
            Order order = new Order();
            order.AccountID = accountID;
            order.OrderDate = DateTime.Now;

            using (db = new DataClasses2DataContext())
            {
                //check that balance isn't higher than 150 
                var balance = db.Accounts.Where(i => i.AccountID == accountID).Select(i => i.Balance).First();

                if (balance <= creditMax)
                {
                    //create an order and add to database 
                    db.Orders.InsertOnSubmit(order);
                    db.SubmitChanges();

                    //get the order number and display it  
                    int orderID = order.OrderID;
                    lblOrderNumValue.Text = orderID.ToString();
                }
                else
                {
                    lblResults.Text = "Cannot create an order\nYour balance is above your $150 credit limit";
                    groupBoxPurchase.Hide();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go to next window
            this.Hide();
            var menuForm = new MenuForm(username);
            menuForm.Show();
        }

        private void MakePurchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeSystemDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.storeSystemDataSet.Item);
        }
    }
}
