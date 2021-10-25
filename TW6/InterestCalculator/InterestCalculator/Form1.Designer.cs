namespace InterestCalculator
{
    partial class Form1
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
            this.tbx_deposit = new System.Windows.Forms.TextBox();
            this.tbx_interest = new System.Windows.Forms.TextBox();
            this.lbl_deposit = new System.Windows.Forms.Label();
            this.lbl_interest = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_deposit
            // 
            this.tbx_deposit.Location = new System.Drawing.Point(353, 79);
            this.tbx_deposit.Name = "tbx_deposit";
            this.tbx_deposit.Size = new System.Drawing.Size(100, 20);
            this.tbx_deposit.TabIndex = 0;
            // 
            // tbx_interest
            // 
            this.tbx_interest.Location = new System.Drawing.Point(353, 115);
            this.tbx_interest.Name = "tbx_interest";
            this.tbx_interest.Size = new System.Drawing.Size(100, 20);
            this.tbx_interest.TabIndex = 0;
            // 
            // lbl_deposit
            // 
            this.lbl_deposit.AutoSize = true;
            this.lbl_deposit.Location = new System.Drawing.Point(282, 82);
            this.lbl_deposit.Name = "lbl_deposit";
            this.lbl_deposit.Size = new System.Drawing.Size(43, 13);
            this.lbl_deposit.TabIndex = 1;
            this.lbl_deposit.Text = "Deposit";
            // 
            // lbl_interest
            // 
            this.lbl_interest.AutoSize = true;
            this.lbl_interest.Location = new System.Drawing.Point(283, 118);
            this.lbl_interest.Name = "lbl_interest";
            this.lbl_interest.Size = new System.Drawing.Size(42, 13);
            this.lbl_interest.TabIndex = 1;
            this.lbl_interest.Text = "Interest";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(325, 153);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_interest);
            this.Controls.Add(this.lbl_deposit);
            this.Controls.Add(this.tbx_interest);
            this.Controls.Add(this.tbx_deposit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_deposit;
        private System.Windows.Forms.TextBox tbx_interest;
        private System.Windows.Forms.Label lbl_deposit;
        private System.Windows.Forms.Label lbl_interest;
        private System.Windows.Forms.Button btn_submit;
    }
}

