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
            this.num_dep = new System.Windows.Forms.NumericUpDown();
            this.lbl_dep = new System.Windows.Forms.Label();
            this.num_year = new System.Windows.Forms.NumericUpDown();
            this.num_percent = new System.Windows.Forms.NumericUpDown();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_dep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_percent)).BeginInit();
            this.SuspendLayout();
            // 
            // num_dep
            // 
            this.num_dep.Location = new System.Drawing.Point(337, 111);
            this.num_dep.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.num_dep.Name = "num_dep";
            this.num_dep.Size = new System.Drawing.Size(120, 20);
            this.num_dep.TabIndex = 0;
            // 
            // lbl_dep
            // 
            this.lbl_dep.AutoSize = true;
            this.lbl_dep.Location = new System.Drawing.Point(265, 113);
            this.lbl_dep.Name = "lbl_dep";
            this.lbl_dep.Size = new System.Drawing.Size(43, 13);
            this.lbl_dep.TabIndex = 1;
            this.lbl_dep.Text = "Deposit";
            // 
            // num_year
            // 
            this.num_year.Location = new System.Drawing.Point(337, 137);
            this.num_year.Name = "num_year";
            this.num_year.Size = new System.Drawing.Size(120, 20);
            this.num_year.TabIndex = 2;
            // 
            // num_percent
            // 
            this.num_percent.Location = new System.Drawing.Point(337, 164);
            this.num_percent.Name = "num_percent";
            this.num_percent.Size = new System.Drawing.Size(120, 20);
            this.num_percent.TabIndex = 2;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(322, 206);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Calculate";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(274, 262);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_result.TabIndex = 1;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(274, 138);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(34, 13);
            this.lbl_year.TabIndex = 1;
            this.lbl_year.Text = "Years";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Percentage";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(306, 76);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(111, 13);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Calculate your interest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.num_percent);
            this.Controls.Add(this.num_year);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_dep);
            this.Controls.Add(this.num_dep);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_dep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_percent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_dep;
        private System.Windows.Forms.Label lbl_dep;
        private System.Windows.Forms.NumericUpDown num_year;
        private System.Windows.Forms.NumericUpDown num_percent;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_title;
    }
}

