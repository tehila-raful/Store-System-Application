
namespace SemsterProject
{
    partial class AccountDetail
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
            this.groupBoxAccountDetail = new System.Windows.Forms.GroupBox();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblAccountNum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBoxAccountDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAccountDetail
            // 
            this.groupBoxAccountDetail.Controls.Add(this.lblAccountBalance);
            this.groupBoxAccountDetail.Controls.Add(this.lblCustName);
            this.groupBoxAccountDetail.Controls.Add(this.lblAccountNum);
            this.groupBoxAccountDetail.Location = new System.Drawing.Point(235, 90);
            this.groupBoxAccountDetail.Name = "groupBoxAccountDetail";
            this.groupBoxAccountDetail.Size = new System.Drawing.Size(263, 203);
            this.groupBoxAccountDetail.TabIndex = 12;
            this.groupBoxAccountDetail.TabStop = false;
            this.groupBoxAccountDetail.Text = "My Account Detail";
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Location = new System.Drawing.Point(19, 130);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(0, 17);
            this.lblAccountBalance.TabIndex = 2;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(19, 47);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(0, 17);
            this.lblCustName.TabIndex = 1;
            // 
            // lblAccountNum
            // 
            this.lblAccountNum.AutoSize = true;
            this.lblAccountNum.Location = new System.Drawing.Point(19, 85);
            this.lblAccountNum.Name = "lblAccountNum";
            this.lblAccountNum.Size = new System.Drawing.Size(0, 17);
            this.lblAccountNum.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(27, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 36);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AccountDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxAccountDetail);
            this.Name = "AccountDetail";
            this.Text = "Account Detail";
            this.groupBoxAccountDetail.ResumeLayout(false);
            this.groupBoxAccountDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAccountDetail;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblAccountNum;
        private System.Windows.Forms.Button btnBack;
    }
}