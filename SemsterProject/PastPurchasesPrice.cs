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
    public partial class PastPurchasesPrice : Form
    {
        DataClasses2DataContext db;
        private int accountID;
        private string username;

        public PastPurchasesPrice(string username, int accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
            this.username = username; 

            using (db = new DataClasses2DataContext())
            {
                var list = db.Orders.Where(i => i.AccountID == accountID).Select(i => i);

                foreach (var i in list)
                {
                    //get all purchases under that order and add it to list view 
                    var pur = i.ItemPurchases.Where(p => p.OrderID == i.OrderID).Select(p => p);

                    foreach (var p in pur)
                    {
                        ListViewItem row = new ListViewItem(i.OrderID.ToString());
                        row.SubItems.Add(p.Item.ItemName.ToString());
                        row.SubItems.Add(p.Quantity.ToString());
                        row.SubItems.Add(p.QuotedPrice.ToString());
                        row.SubItems.Add(p.Subtotal.ToString());
                        row.SubItems.Add(i.OrderDate.ToString());
                        listPurchasesByPrice.Items.Add(row);
                    }
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

        private void btnSubmitPriceRange_Click(object sender, EventArgs e)
        {
            //clear all items 
            listPurchasesByPrice.Items.Clear();

            decimal fromPrice = Convert.ToDecimal(txtFromPrice.Text);
            decimal toPrice = Convert.ToDecimal(txtToPrice.Text);

            //populate listView with Iemun of purchases 
            using (db = new DataClasses2DataContext())
            {
                var list = db.Orders.Where(i => i.AccountID == accountID).Select(i => i);
        
                foreach (var i in list)
                {
                    //get all purchases under that order and add it to list view 
                    //if within price range 
                    var pur = i.ItemPurchases.Where(p => p.OrderID == i.OrderID)
                                             .Where(p => p.Subtotal >= fromPrice && p.Subtotal <= toPrice)
                                             .Select(p => p).ToList();

                    foreach (var p in pur)
                    {
                        ListViewItem row = new ListViewItem(i.OrderID.ToString());
                        row.SubItems.Add(p.Item.ItemName.ToString());
                        row.SubItems.Add(p.Quantity.ToString());
                        row.SubItems.Add(p.QuotedPrice.ToString());
                        row.SubItems.Add(p.Subtotal.ToString());
                        row.SubItems.Add(i.OrderDate.ToString());
                        listPurchasesByPrice.Items.Add(row);
                    }
                }
            }
        }
    }
}
