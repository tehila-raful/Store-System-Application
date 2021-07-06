
namespace SemsterProject
{
    partial class PastPurchasesPrice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxPurchasesPrice = new System.Windows.Forms.GroupBox();
            this.listPurchasesByPrice = new System.Windows.Forms.ListView();
            this.OrderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtToPrice = new System.Windows.Forms.TextBox();
            this.txtFromPrice = new System.Windows.Forms.TextBox();
            this.btnSubmitPriceRange = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBoxPurchasesPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPurchasesPrice
            // 
            this.groupBoxPurchasesPrice.Controls.Add(this.listPurchasesByPrice);
            this.groupBoxPurchasesPrice.Controls.Add(this.txtToPrice);
            this.groupBoxPurchasesPrice.Controls.Add(this.txtFromPrice);
            this.groupBoxPurchasesPrice.Controls.Add(this.btnSubmitPriceRange);
            this.groupBoxPurchasesPrice.Controls.Add(this.label9);
            this.groupBoxPurchasesPrice.Controls.Add(this.label10);
            this.groupBoxPurchasesPrice.Controls.Add(this.label11);
            this.groupBoxPurchasesPrice.Controls.Add(this.label12);
            this.groupBoxPurchasesPrice.Controls.Add(this.label13);
            this.groupBoxPurchasesPrice.Controls.Add(this.label14);
            this.groupBoxPurchasesPrice.Location = new System.Drawing.Point(123, 13);
            this.groupBoxPurchasesPrice.Name = "groupBoxPurchasesPrice";
            this.groupBoxPurchasesPrice.Size = new System.Drawing.Size(555, 424);
            this.groupBoxPurchasesPrice.TabIndex = 15;
            this.groupBoxPurchasesPrice.TabStop = false;
            this.groupBoxPurchasesPrice.Text = "Past Purchases ";
            // 
            // listPurchasesByPrice
            // 
            this.listPurchasesByPrice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderNum,
            this.ItemID,
            this.Quantity,
            this.Price,
            this.subtotal,
            this.date});
            this.listPurchasesByPrice.HideSelection = false;
            this.listPurchasesByPrice.Location = new System.Drawing.Point(22, 155);
            this.listPurchasesByPrice.Name = "listPurchasesByPrice";
            this.listPurchasesByPrice.Size = new System.Drawing.Size(446, 251);
            this.listPurchasesByPrice.TabIndex = 14;
            this.listPurchasesByPrice.UseCompatibleStateImageBehavior = false;
            this.listPurchasesByPrice.View = System.Windows.Forms.View.Details;
            // 
            // OrderNum
            // 
            this.OrderNum.Text = "Order Num";
            this.OrderNum.Width = 84;
            // 
            // ItemID
            // 
            this.ItemID.Text = "Item Name";
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // subtotal
            // 
            this.subtotal.Text = "Subtotal";
            this.subtotal.Width = 65;
            // 
            // date
            // 
            this.date.Text = "Order Date";
            this.date.Width = 96;
            // 
            // txtToPrice
            // 
            this.txtToPrice.Location = new System.Drawing.Point(90, 110);
            this.txtToPrice.Name = "txtToPrice";
            this.txtToPrice.Size = new System.Drawing.Size(100, 22);
            this.txtToPrice.TabIndex = 13;
            // 
            // txtFromPrice
            // 
            this.txtFromPrice.Location = new System.Drawing.Point(90, 64);
            this.txtFromPrice.Name = "txtFromPrice";
            this.txtFromPrice.Size = new System.Drawing.Size(100, 22);
            this.txtFromPrice.TabIndex = 12;
            // 
            // btnSubmitPriceRange
            // 
            this.btnSubmitPriceRange.Location = new System.Drawing.Point(254, 74);
            this.btnSubmitPriceRange.Name = "btnSubmitPriceRange";
            this.btnSubmitPriceRange.Size = new System.Drawing.Size(75, 46);
            this.btnSubmitPriceRange.TabIndex = 11;
            this.btnSubmitPriceRange.Text = "Submit Price ";
            this.btnSubmitPriceRange.UseVisualStyleBackColor = true;
            this.btnSubmitPriceRange.Click += new System.EventHandler(this.btnSubmitPriceRange_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "From: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "To: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Price Range";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 17);
            this.label13.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 17);
            this.label14.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 36);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PastPurchasesPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxPurchasesPrice);
            this.Name = "PastPurchasesPrice";
            this.Text = "Past Purchases By Price";
            this.groupBoxPurchasesPrice.ResumeLayout(false);
            this.groupBoxPurchasesPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPurchasesPrice;
        private System.Windows.Forms.ListView listPurchasesByPrice;
        private System.Windows.Forms.ColumnHeader OrderNum;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader subtotal;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.TextBox txtToPrice;
        private System.Windows.Forms.TextBox txtFromPrice;
        private System.Windows.Forms.Button btnSubmitPriceRange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBack;
    }
}