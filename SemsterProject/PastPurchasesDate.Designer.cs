
namespace SemsterProject
{
    partial class PastPurchasesDate
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
            this.groupBoxPastPurchases = new System.Windows.Forms.GroupBox();
            this.listPurchasesByDate = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSubmitDates = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBoxPastPurchases.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPastPurchases
            // 
            this.groupBoxPastPurchases.Controls.Add(this.listPurchasesByDate);
            this.groupBoxPastPurchases.Controls.Add(this.btnSubmitDates);
            this.groupBoxPastPurchases.Controls.Add(this.dateTimePickerTo);
            this.groupBoxPastPurchases.Controls.Add(this.label8);
            this.groupBoxPastPurchases.Controls.Add(this.label7);
            this.groupBoxPastPurchases.Controls.Add(this.dateTimePickerFrom);
            this.groupBoxPastPurchases.Controls.Add(this.label6);
            this.groupBoxPastPurchases.Controls.Add(this.label1);
            this.groupBoxPastPurchases.Controls.Add(this.label4);
            this.groupBoxPastPurchases.Controls.Add(this.label5);
            this.groupBoxPastPurchases.Location = new System.Drawing.Point(147, 16);
            this.groupBoxPastPurchases.Name = "groupBoxPastPurchases";
            this.groupBoxPastPurchases.Size = new System.Drawing.Size(507, 418);
            this.groupBoxPastPurchases.TabIndex = 13;
            this.groupBoxPastPurchases.TabStop = false;
            this.groupBoxPastPurchases.Text = "Past Purchases ";
            // 
            // listPurchasesByDate
            // 
            this.listPurchasesByDate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listPurchasesByDate.HideSelection = false;
            this.listPurchasesByDate.Location = new System.Drawing.Point(24, 149);
            this.listPurchasesByDate.Name = "listPurchasesByDate";
            this.listPurchasesByDate.Size = new System.Drawing.Size(446, 251);
            this.listPurchasesByDate.TabIndex = 15;
            this.listPurchasesByDate.UseCompatibleStateImageBehavior = false;
            this.listPurchasesByDate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Order Num";
            this.columnHeader4.Width = 84;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Item Name";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantity";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Price";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Subtotal";
            this.columnHeader8.Width = 65;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Order Date";
            this.columnHeader9.Width = 96;
            // 
            // btnSubmitDates
            // 
            this.btnSubmitDates.Location = new System.Drawing.Point(385, 74);
            this.btnSubmitDates.Name = "btnSubmitDates";
            this.btnSubmitDates.Size = new System.Drawing.Size(75, 46);
            this.btnSubmitDates.TabIndex = 11;
            this.btnSubmitDates.Text = "Submit Dates";
            this.btnSubmitDates.UseVisualStyleBackColor = true;
            this.btnSubmitDates.Click += new System.EventHandler(this.btnSubmitDates_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(112, 113);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(255, 22);
            this.dateTimePickerTo.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "From: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "To: ";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(112, 63);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(255, 22);
            this.dateTimePickerFrom.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Select Dates";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 0;
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
            // PastPurchasesDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxPastPurchases);
            this.Name = "PastPurchasesDate";
            this.Text = "PastPurchases";
            this.groupBoxPastPurchases.ResumeLayout(false);
            this.groupBoxPastPurchases.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPastPurchases;
        private System.Windows.Forms.ListView listPurchasesByDate;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnSubmitDates;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
    }
}