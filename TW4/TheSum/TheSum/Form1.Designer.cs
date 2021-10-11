namespace TheSum
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
            this.lbl_odd = new System.Windows.Forms.Label();
            this.lbl_even = new System.Windows.Forms.Label();
            this.btn_odd = new System.Windows.Forms.Button();
            this.btn_even = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_odd
            // 
            this.lbl_odd.AutoSize = true;
            this.lbl_odd.Location = new System.Drawing.Point(239, 105);
            this.lbl_odd.Name = "lbl_odd";
            this.lbl_odd.Size = new System.Drawing.Size(303, 13);
            this.lbl_odd.TabIndex = 0;
            this.lbl_odd.Text = "What is the sum of all odd numbers between 1 and 1,000,000?";
            // 
            // lbl_even
            // 
            this.lbl_even.AutoSize = true;
            this.lbl_even.Location = new System.Drawing.Point(239, 199);
            this.lbl_even.Name = "lbl_even";
            this.lbl_even.Size = new System.Drawing.Size(312, 13);
            this.lbl_even.TabIndex = 0;
            this.lbl_even.Text = "What is the sum of all even numbers between 1 and 1,000,000? ";
            // 
            // btn_odd
            // 
            this.btn_odd.Location = new System.Drawing.Point(357, 137);
            this.btn_odd.Name = "btn_odd";
            this.btn_odd.Size = new System.Drawing.Size(75, 23);
            this.btn_odd.TabIndex = 1;
            this.btn_odd.Text = "Show";
            this.btn_odd.UseVisualStyleBackColor = true;
            this.btn_odd.Click += new System.EventHandler(this.btn_odd_Click);
            // 
            // btn_even
            // 
            this.btn_even.Location = new System.Drawing.Point(357, 238);
            this.btn_even.Name = "btn_even";
            this.btn_even.Size = new System.Drawing.Size(75, 23);
            this.btn_even.TabIndex = 1;
            this.btn_even.Text = "Show";
            this.btn_even.UseVisualStyleBackColor = true;
            this.btn_even.Click += new System.EventHandler(this.btn_even_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_even);
            this.Controls.Add(this.btn_odd);
            this.Controls.Add(this.lbl_even);
            this.Controls.Add(this.lbl_odd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_odd;
        private System.Windows.Forms.Label lbl_even;
        private System.Windows.Forms.Button btn_odd;
        private System.Windows.Forms.Button btn_even;
    }
}

