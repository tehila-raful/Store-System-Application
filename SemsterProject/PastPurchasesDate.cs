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
    public partial class PastPurchasesDate : Form
    {
        DataClasses2DataContext db;
        private int accountID;
        private string username;

        public PastPurchasesDate(string username, int accountID)
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
                        listPurchasesByDate.Items.Add(row);
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

        private void btnSubmitDates_Click(object sender, EventArgs e)
        {
            listPurchasesByDate.Items.Clear();
            
            //get dates
            var fromDate = dateTimePickerFrom.Value;
            var toDate = dateTimePickerTo.Value;

            //populate listView with Iemun of purchases 
            using (db = new DataClasses2DataContext())
            {
                var list = db.Orders.Where(i => i.AccountID == accountID)
                    .Where(i => i.OrderDate >= fromDate && i.OrderDate <= toDate)
                    .Select(i => i).ToList();

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
                        listPurchasesByDate.Items.Add(row);
                    }
                }
            }
        }
    }
}
