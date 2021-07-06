
namespace SemsterProject
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuViewItems = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMakeAPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMyAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewAccountDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewPastPurchases = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemByDateTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemByPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMakeAPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.listItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeSystemDataSet = new SemsterProject.StoreSystemDataSet();
            this.lblResults = new System.Windows.Forms.Label();
            this.itemTableAdapter = new SemsterProject.StoreSystemDataSetTableAdapters.ItemTableAdapter();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewItems,
            this.menuMakeAPurchase,
            this.menuMyAccount,
            this.menuMakeAPayment});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(793, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuViewItems
            // 
            this.menuViewItems.Name = "menuViewItems";
            this.menuViewItems.Size = new System.Drawing.Size(95, 24);
            this.menuViewItems.Text = "View Items";
            this.menuViewItems.Click += new System.EventHandler(this.menuViewItems_Click);
            // 
            // menuMakeAPurchase
            // 
            this.menuMakeAPurchase.Name = "menuMakeAPurchase";
            this.menuMakeAPurchase.Size = new System.Drawing.Size(133, 24);
            this.menuMakeAPurchase.Text = "Make a Purchase";
            this.menuMakeAPurchase.Click += new System.EventHandler(this.menuMakeAPurchase_Click);
            // 
            // menuMyAccount
            // 
            this.menuMyAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemViewAccountDetails,
            this.menuItemViewPastPurchases});
            this.menuMyAccount.Name = "menuMyAccount";
            this.menuMyAccount.Size = new System.Drawing.Size(101, 24);
            this.menuMyAccount.Text = "My Account";
            // 
            // menuItemViewAccountDetails
            // 
            this.menuItemViewAccountDetails.Name = "menuItemViewAccountDetails";
            this.menuItemViewAccountDetails.Size = new System.Drawing.Size(232, 26);
            this.menuItemViewAccountDetails.Text = "View Account Details";
            this.menuItemViewAccountDetails.Click += new System.EventHandler(this.menuItemViewAccountDetails_Click);
            // 
            // menuItemViewPastPurchases
            // 
            this.menuItemViewPastPurchases.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemByDateTool,
            this.menuItemByPrice});
            this.menuItemViewPastPurchases.Name = "menuItemViewPastPurchases";
            this.menuItemViewPastPurchases.Size = new System.Drawing.Size(232, 26);
            this.menuItemViewPastPurchases.Text = "View Past Purchases";
            // 
            // menuItemByDateTool
            // 
            this.menuItemByDateTool.Name = "menuItemByDateTool";
            this.menuItemByDateTool.Size = new System.Drawing.Size(144, 26);
            this.menuItemByDateTool.Text = "By Date";
            this.menuItemByDateTool.Click += new System.EventHandler(this.menuItemByDateTool_Click);
            // 
            // menuItemByPrice
            // 
            this.menuItemByPrice.Name = "menuItemByPrice";
            this.menuItemByPrice.Size = new System.Drawing.Size(144, 26);
            this.menuItemByPrice.Text = "By Price";
            this.menuItemByPrice.Click += new System.EventHandler(this.menuItemByPrice_Click);
            // 
            // menuMakeAPayment
            // 
            this.menuMakeAPayment.Name = "menuMakeAPayment";
            this.menuMakeAPayment.Size = new System.Drawing.Size(131, 24);
            this.menuMakeAPayment.Text = "Make a Payment";
            this.menuMakeAPayment.Click += new System.EventHandler(this.menuMakeAPayment_Click);
            // 
            // listItems
            // 
            this.listItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listItems.GridLines = true;
            this.listItems.HideSelection = false;
            this.listItems.Location = new System.Drawing.Point(161, 115);
            this.listItems.MultiSelect = false;
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(449, 192);
            this.listItems.TabIndex = 3;
            this.listItems.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.storeSystemDataSet;
            // 
            // storeSystemDataSet
            // 
            this.storeSystemDataSet.DataSetName = "StoreSystemDataSet";
            this.storeSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.ForeColor = System.Drawing.Color.Red;
            this.lblResults.Location = new System.Drawing.Point(275, 500);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 17);
            this.lblResults.TabIndex = 14;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(683, 414);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(89, 27);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 453);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "My Account ";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuViewItems;
        private System.Windows.Forms.ToolStripMenuItem menuMakeAPurchase;
        private System.Windows.Forms.ToolStripMenuItem menuMyAccount;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewAccountDetails;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewPastPurchases;
        private System.Windows.Forms.ToolStripMenuItem menuItemByDateTool;
        private System.Windows.Forms.ToolStripMenuItem menuItemByPrice;
        private System.Windows.Forms.ToolStripMenuItem menuMakeAPayment;
        private System.Windows.Forms.ListView listItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblResults;
        private StoreSystemDataSet storeSystemDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private StoreSystemDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.Button btnLogOut;
    }
}