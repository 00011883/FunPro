namespace Exchanger
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
            this.tbx_input = new System.Windows.Forms.TextBox();
            this.lbl_euro = new System.Windows.Forms.Label();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.lbl_usd = new System.Windows.Forms.Label();
            this.lbl_fee = new System.Windows.Forms.Label();
            this.lbl_payable = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_input
            // 
            this.tbx_input.Location = new System.Drawing.Point(137, 85);
            this.tbx_input.Name = "tbx_input";
            this.tbx_input.Size = new System.Drawing.Size(100, 20);
            this.tbx_input.TabIndex = 0;
            // 
            // lbl_euro
            // 
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.Location = new System.Drawing.Point(182, 128);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(29, 13);
            this.lbl_euro.TabIndex = 1;
            this.lbl_euro.Text = "Euro";
            // 
            // lbl_rate
            // 
            this.lbl_rate.AutoSize = true;
            this.lbl_rate.Location = new System.Drawing.Point(129, 160);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(82, 13);
            this.lbl_rate.TabIndex = 1;
            this.lbl_rate.Text = "Exchange rate: ";
            // 
            // lbl_usd
            // 
            this.lbl_usd.AutoSize = true;
            this.lbl_usd.Location = new System.Drawing.Point(124, 194);
            this.lbl_usd.Name = "lbl_usd";
            this.lbl_usd.Size = new System.Drawing.Size(87, 13);
            this.lbl_usd.TabIndex = 1;
            this.lbl_usd.Text = "Exhcanged USD";
            // 
            // lbl_fee
            // 
            this.lbl_fee.AutoSize = true;
            this.lbl_fee.Location = new System.Drawing.Point(132, 230);
            this.lbl_fee.Name = "lbl_fee";
            this.lbl_fee.Size = new System.Drawing.Size(79, 13);
            this.lbl_fee.TabIndex = 1;
            this.lbl_fee.Text = "Exchange fee: ";
            // 
            // lbl_payable
            // 
            this.lbl_payable.AutoSize = true;
            this.lbl_payable.Location = new System.Drawing.Point(134, 264);
            this.lbl_payable.Name = "lbl_payable";
            this.lbl_payable.Size = new System.Drawing.Size(77, 13);
            this.lbl_payable.TabIndex = 1;
            this.lbl_payable.Text = "Payable USD: ";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(148, 312);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_payable);
            this.Controls.Add(this.lbl_fee);
            this.Controls.Add(this.lbl_usd);
            this.Controls.Add(this.lbl_rate);
            this.Controls.Add(this.lbl_euro);
            this.Controls.Add(this.tbx_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_input;
        private System.Windows.Forms.Label lbl_euro;
        private System.Windows.Forms.Label lbl_rate;
        private System.Windows.Forms.Label lbl_usd;
        private System.Windows.Forms.Label lbl_fee;
        private System.Windows.Forms.Label lbl_payable;
        private System.Windows.Forms.Button btn_submit;
    }
}

