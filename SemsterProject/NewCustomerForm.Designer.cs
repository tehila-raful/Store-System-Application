﻿
namespace SemsterProject
{
    partial class NewCustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxnewAccountInfo = new System.Windows.Forms.GroupBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxnewAccountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name ";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(157, 44);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(162, 22);
            this.txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(157, 98);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(162, 22);
            this.txtLName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name ";
            // 
            // groupBoxnewAccountInfo
            // 
            this.groupBoxnewAccountInfo.Controls.Add(this.btnCreateAccount);
            this.groupBoxnewAccountInfo.Controls.Add(this.txtPassword);
            this.groupBoxnewAccountInfo.Controls.Add(this.label5);
            this.groupBoxnewAccountInfo.Controls.Add(this.txtUsername);
            this.groupBoxnewAccountInfo.Controls.Add(this.label4);
            this.groupBoxnewAccountInfo.Controls.Add(this.txtEmail);
            this.groupBoxnewAccountInfo.Controls.Add(this.label3);
            this.groupBoxnewAccountInfo.Controls.Add(this.txtLName);
            this.groupBoxnewAccountInfo.Controls.Add(this.label1);
            this.groupBoxnewAccountInfo.Controls.Add(this.label2);
            this.groupBoxnewAccountInfo.Controls.Add(this.txtFName);
            this.groupBoxnewAccountInfo.Location = new System.Drawing.Point(196, 31);
            this.groupBoxnewAccountInfo.Name = "groupBoxnewAccountInfo";
            this.groupBoxnewAccountInfo.Size = new System.Drawing.Size(394, 407);
            this.groupBoxnewAccountInfo.TabIndex = 4;
            this.groupBoxnewAccountInfo.TabStop = false;
            this.groupBoxnewAccountInfo.Text = "Your Account Info";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(147, 297);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(100, 46);
            this.btnCreateAccount.TabIndex = 10;
            this.btnCreateAccount.Text = "Create Account ";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(157, 243);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(162, 22);
            this.txtPassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(157, 194);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(162, 22);
            this.txtUsername.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email Address";
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxnewAccountInfo);
            this.Name = "NewCustomerForm";
            this.Text = "Create Account ";
            this.groupBoxnewAccountInfo.ResumeLayout(false);
            this.groupBoxnewAccountInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxnewAccountInfo;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
    }
}