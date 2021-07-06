
namespace SemsterProject
{
    partial class MakePurchase
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
            this.groupBoxPurchase = new System.Windows.Forms.GroupBox();
            this.comboBoxlistItems = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeSystemDataSet = new SemsterProject.StoreSystemDataSet();
            this.lblOrderNumValue = new System.Windows.Forms.Label();
            this.lblSubmitResults = new System.Windows.Forms.Label();
            this.btnSubmitPurchase = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrderNumText = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.storeSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new SemsterProject.StoreSystemDataSetTableAdapters.ItemTableAdapter();
            this.groupBoxPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeSystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPurchase
            // 
            this.groupBoxPurchase.Controls.Add(this.comboBoxlistItems);
            this.groupBoxPurchase.Controls.Add(this.lblOrderNumValue);
            this.groupBoxPurchase.Controls.Add(this.lblSubmitResults);
            this.groupBoxPurchase.Controls.Add(this.btnSubmitPurchase);
            this.groupBoxPurchase.Controls.Add(this.label3);
            this.groupBoxPurchase.Controls.Add(this.lblOrderNumText);
            this.groupBoxPurchase.Controls.Add(this.txtQuantity);
            this.groupBoxPurchase.Controls.Add(this.label2);
            this.groupBoxPurchase.Location = new System.Drawing.Point(177, 113);
            this.groupBoxPurchase.Name = "groupBoxPurchase";
            this.groupBoxPurchase.Size = new System.Drawing.Size(353, 237);
            this.groupBoxPurchase.TabIndex = 11;
            this.groupBoxPurchase.TabStop = false;
            this.groupBoxPurchase.Text = "Purchase ";
            // 
            // comboBoxlistItems
            // 
            this.comboBoxlistItems.DataSource = this.itemBindingSource;
            this.comboBoxlistItems.DisplayMember = "ItemName";
            this.comboBoxlistItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxlistItems.FormattingEnabled = true;
            this.comboBoxlistItems.Location = new System.Drawing.Point(127, 66);
            this.comboBoxlistItems.Name = "comboBoxlistItems";
            this.comboBoxlistItems.Size = new System.Drawing.Size(121, 24);
            this.comboBoxlistItems.TabIndex = 17;
            this.comboBoxlistItems.ValueMember = "ItemName";
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
            // lblOrderNumValue
            // 
            this.lblOrderNumValue.AutoSize = true;
            this.lblOrderNumValue.Location = new System.Drawing.Point(148, 39);
            this.lblOrderNumValue.Name = "lblOrderNumValue";
            this.lblOrderNumValue.Size = new System.Drawing.Size(12, 17);
            this.lblOrderNumValue.TabIndex = 15;
            this.lblOrderNumValue.Text = " ";
            // 
            // lblSubmitResults
            // 
            this.lblSubmitResults.AutoSize = true;
            this.lblSubmitResults.Location = new System.Drawing.Point(109, 234);
            this.lblSubmitResults.Name = "lblSubmitResults";
            this.lblSubmitResults.Size = new System.Drawing.Size(0, 17);
            this.lblSubmitResults.TabIndex = 11;
            // 
            // btnSubmitPurchase
            // 
            this.btnSubmitPurchase.Location = new System.Drawing.Point(86, 166);
            this.btnSubmitPurchase.Name = "btnSubmitPurchase";
            this.btnSubmitPurchase.Size = new System.Drawing.Size(116, 51);
            this.btnSubmitPurchase.TabIndex = 10;
            this.btnSubmitPurchase.Text = "Add Item to Order";
            this.btnSubmitPurchase.UseVisualStyleBackColor = true;
            this.btnSubmitPurchase.Click += new System.EventHandler(this.btnSubmitPurchase_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            // 
            // lblOrderNumText
            // 
            this.lblOrderNumText.AutoSize = true;
            this.lblOrderNumText.Location = new System.Drawing.Point(6, 39);
            this.lblOrderNumText.Name = "lblOrderNumText";
            this.lblOrderNumText.Size = new System.Drawing.Size(111, 17);
            this.lblOrderNumText.TabIndex = 5;
            this.lblOrderNumText.Text = " Order Number: ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(127, 119);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 22);
            this.txtQuantity.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Item Name: ";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(177, 39);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(212, 29);
            this.btnNewOrder.TabIndex = 14;
            this.btnNewOrder.Text = "Create New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(260, 402);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 17);
            this.lblResults.TabIndex = 18;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 36);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // storeSystemDataSetBindingSource
            // 
            this.storeSystemDataSetBindingSource.DataSource = this.storeSystemDataSet;
            this.storeSystemDataSetBindingSource.Position = 0;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // MakePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.groupBoxPurchase);
            this.Name = "MakePurchase";
            this.Text = "Create An Order ";
            this.Load += new System.EventHandler(this.MakePurchase_Load);
            this.groupBoxPurchase.ResumeLayout(false);
            this.groupBoxPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeSystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPurchase;
        private System.Windows.Forms.ComboBox comboBoxlistItems;
        private System.Windows.Forms.Label lblOrderNumValue;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lblSubmitResults;
        private System.Windows.Forms.Button btnSubmitPurchase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrderNumText;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource storeSystemDataSetBindingSource;
        private StoreSystemDataSet storeSystemDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private StoreSystemDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
    }
}