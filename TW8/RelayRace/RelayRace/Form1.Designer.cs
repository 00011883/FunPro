namespace RelayRace
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
            this.tbx_time1 = new System.Windows.Forms.TextBox();
            this.tbx_time2 = new System.Windows.Forms.TextBox();
            this.lbl_time1 = new System.Windows.Forms.Label();
            this.lbl_time2 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_time1
            // 
            this.tbx_time1.Location = new System.Drawing.Point(110, 89);
            this.tbx_time1.Name = "tbx_time1";
            this.tbx_time1.Size = new System.Drawing.Size(100, 20);
            this.tbx_time1.TabIndex = 0;
            // 
            // tbx_time2
            // 
            this.tbx_time2.Location = new System.Drawing.Point(110, 115);
            this.tbx_time2.Name = "tbx_time2";
            this.tbx_time2.Size = new System.Drawing.Size(100, 20);
            this.tbx_time2.TabIndex = 0;
            // 
            // lbl_time1
            // 
            this.lbl_time1.AutoSize = true;
            this.lbl_time1.Location = new System.Drawing.Point(120, 157);
            this.lbl_time1.Name = "lbl_time1";
            this.lbl_time1.Size = new System.Drawing.Size(39, 13);
            this.lbl_time1.TabIndex = 1;
            this.lbl_time1.Text = "Time 1";
            // 
            // lbl_time2
            // 
            this.lbl_time2.AutoSize = true;
            this.lbl_time2.Location = new System.Drawing.Point(120, 179);
            this.lbl_time2.Name = "lbl_time2";
            this.lbl_time2.Size = new System.Drawing.Size(39, 13);
            this.lbl_time2.TabIndex = 1;
            this.lbl_time2.Text = "Time 2";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(120, 205);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(60, 13);
            this.lbl_total.TabIndex = 2;
            this.lbl_total.Text = "Total Time:";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(123, 240);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 329);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_time2);
            this.Controls.Add(this.lbl_time1);
            this.Controls.Add(this.tbx_time2);
            this.Controls.Add(this.tbx_time1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_time1;
        private System.Windows.Forms.TextBox tbx_time2;
        private System.Windows.Forms.Label lbl_time1;
        private System.Windows.Forms.Label lbl_time2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_submit;
    }
}

