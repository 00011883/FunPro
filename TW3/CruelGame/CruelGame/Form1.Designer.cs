namespace CruelGame
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
            this.lbl_age = new System.Windows.Forms.Label();
            this.rdb_21 = new System.Windows.Forms.RadioButton();
            this.rdb_21to35 = new System.Windows.Forms.RadioButton();
            this.rdb_35 = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_age.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_age.Location = new System.Drawing.Point(363, 78);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(93, 13);
            this.lbl_age.TabIndex = 0;
            this.lbl_age.Text = "What is your age?";
            // 
            // rdb_21
            // 
            this.rdb_21.AutoSize = true;
            this.rdb_21.ForeColor = System.Drawing.SystemColors.Control;
            this.rdb_21.Location = new System.Drawing.Point(376, 105);
            this.rdb_21.Name = "rdb_21";
            this.rdb_21.Size = new System.Drawing.Size(46, 17);
            this.rdb_21.TabIndex = 2;
            this.rdb_21.TabStop = true;
            this.rdb_21.Text = "< 21";
            this.rdb_21.UseVisualStyleBackColor = true;
            // 
            // rdb_21to35
            // 
            this.rdb_21to35.AutoSize = true;
            this.rdb_21to35.ForeColor = System.Drawing.SystemColors.Control;
            this.rdb_21to35.Location = new System.Drawing.Point(376, 129);
            this.rdb_21to35.Name = "rdb_21to35";
            this.rdb_21to35.Size = new System.Drawing.Size(64, 17);
            this.rdb_21to35.TabIndex = 3;
            this.rdb_21to35.TabStop = true;
            this.rdb_21to35.Text = "21 to 35";
            this.rdb_21to35.UseVisualStyleBackColor = true;
            // 
            // rdb_35
            // 
            this.rdb_35.AutoSize = true;
            this.rdb_35.ForeColor = System.Drawing.SystemColors.Control;
            this.rdb_35.Location = new System.Drawing.Point(376, 153);
            this.rdb_35.Name = "rdb_35";
            this.rdb_35.Size = new System.Drawing.Size(46, 17);
            this.rdb_35.TabIndex = 4;
            this.rdb_35.TabStop = true;
            this.rdb_35.Text = "> 35";
            this.rdb_35.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(366, 186);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(90, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start the Game";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.rdb_35);
            this.Controls.Add(this.rdb_21to35);
            this.Controls.Add(this.rdb_21);
            this.Controls.Add(this.lbl_age);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.RadioButton rdb_21;
        private System.Windows.Forms.RadioButton rdb_21to35;
        private System.Windows.Forms.RadioButton rdb_35;
        private System.Windows.Forms.Button btn_start;
    }
}

