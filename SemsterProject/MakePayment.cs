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
    public partial class MakePayment : Form
    {
        DataClasses2DataContext db;
        private int accountID;
        private string username; 

        public MakePayment(string username, int accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
            this.username = username; 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go to next window
            this.Hide();
            var menuForm = new MenuForm(username);
            menuForm.Show();
        }

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            decimal payment = Convert.ToDecimal(txtPaymentAmount.Text);

            Payment pay = new Payment();
            pay.AccountID = accountID;
            pay.PaymentDate = DateTime.Now;
            pay.PaymentAmount = payment;

            using (db = new DataClasses2DataContext())
            {
                //add payment to database 
                db.Payments.InsertOnSubmit(pay);
                db.SubmitChanges();
            }

            if (payment <= 0)
            {
                lblResults.Text = "Insufficent payment amount";
            }
            else
            {
                lblResults.Text = "Payment Accepted";
            }
        }
    }
}
