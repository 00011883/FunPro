namespace SuperCalculator
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.tbx_one = new System.Windows.Forms.TextBox();
            this.tbx_two = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(364, 176);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(383, 257);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(35, 13);
            this.lbl_result.TabIndex = 1;
            this.lbl_result.Text = "label1";
            // 
            // tbx_one
            // 
            this.tbx_one.Location = new System.Drawing.Point(352, 114);
            this.tbx_one.Name = "tbx_one";
            this.tbx_one.Size = new System.Drawing.Size(100, 20);
            this.tbx_one.TabIndex = 2;
            // 
            // tbx_two
            // 
            this.tbx_two.Location = new System.Drawing.Point(352, 140);
            this.tbx_two.Name = "tbx_two";
            this.tbx_two.Size = new System.Drawing.Size(100, 20);
            this.tbx_two.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_two);
            this.Controls.Add(this.tbx_one);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox tbx_one;
        private System.Windows.Forms.TextBox tbx_two;
    }
}

