
namespace SemsterProject
{
    partial class MakePayment
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
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.btnSubmitPayment = new System.Windows.Forms.Button();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBoxPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.btnSubmitPayment);
            this.groupBoxPayment.Controls.Add(this.txtPaymentAmount);
            this.groupBoxPayment.Controls.Add(this.label15);
            this.groupBoxPayment.Location = new System.Drawing.Point(220, 90);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(340, 200);
            this.groupBoxPayment.TabIndex = 16;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Make a Payment ";
            // 
            // btnSubmitPayment
            // 
            this.btnSubmitPayment.Location = new System.Drawing.Point(136, 125);
            this.btnSubmitPayment.Name = "btnSubmitPayment";
            this.btnSubmitPayment.Size = new System.Drawing.Size(75, 48);
            this.btnSubmitPayment.TabIndex = 2;
            this.btnSubmitPayment.Text = "Submit Payment ";
            this.btnSubmitPayment.UseVisualStyleBackColor = true;
            this.btnSubmitPayment.Click += new System.EventHandler(this.btnSubmitPayment_Click);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(182, 46);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(100, 22);
            this.txtPaymentAmount.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Payment Amount ";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(318, 352);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 17);
            this.lblResults.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 36);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MakePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.groupBoxPayment);
            this.Name = "MakePayment";
            this.Text = "Make Payment";
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.Button btnSubmitPayment;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnBack;
    }
}