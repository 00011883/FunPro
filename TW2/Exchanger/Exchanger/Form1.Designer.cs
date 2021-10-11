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
			this.btn_convert = new System.Windows.Forms.Button();
			this.num_amount = new System.Windows.Forms.NumericUpDown();
			this.num_rate = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.num_amount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_rate)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_convert
			// 
			this.btn_convert.Location = new System.Drawing.Point(344, 204);
			this.btn_convert.Name = "btn_convert";
			this.btn_convert.Size = new System.Drawing.Size(75, 23);
			this.btn_convert.TabIndex = 0;
			this.btn_convert.Text = "Exchange";
			this.btn_convert.UseVisualStyleBackColor = true;
			this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
			// 
			// num_amount
			// 
			this.num_amount.Location = new System.Drawing.Point(323, 126);
			this.num_amount.Name = "num_amount";
			this.num_amount.Size = new System.Drawing.Size(120, 20);
			this.num_amount.TabIndex = 1;
			// 
			// num_rate
			// 
			this.num_rate.Location = new System.Drawing.Point(323, 163);
			this.num_rate.Name = "num_rate";
			this.num_rate.Size = new System.Drawing.Size(120, 20);
			this.num_rate.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.num_rate);
			this.Controls.Add(this.num_amount);
			this.Controls.Add(this.btn_convert);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.num_amount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_rate)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button btn_convert;
		private System.Windows.Forms.NumericUpDown num_amount;
		private System.Windows.Forms.NumericUpDown num_rate;
	}
}

