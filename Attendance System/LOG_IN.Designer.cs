namespace Attendance_System
{
    partial class LOG_IN
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
            this.Add_emp_btn = new System.Windows.Forms.Button();
            this.Exit_Login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_emp_btn
            // 
            this.Add_emp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_emp_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_emp_btn.Location = new System.Drawing.Point(150, 82);
            this.Add_emp_btn.Name = "Add_emp_btn";
            this.Add_emp_btn.Size = new System.Drawing.Size(167, 79);
            this.Add_emp_btn.TabIndex = 2;
            this.Add_emp_btn.Text = "Add an Employee";
            this.Add_emp_btn.UseVisualStyleBackColor = true;
            this.Add_emp_btn.Click += new System.EventHandler(this.Add_emp_btn_Click);
            // 
            // Exit_Login_btn
            // 
            this.Exit_Login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Login_btn.ForeColor = System.Drawing.Color.Black;
            this.Exit_Login_btn.Location = new System.Drawing.Point(171, 254);
            this.Exit_Login_btn.Name = "Exit_Login_btn";
            this.Exit_Login_btn.Size = new System.Drawing.Size(127, 72);
            this.Exit_Login_btn.TabIndex = 4;
            this.Exit_Login_btn.Text = "Log Out ";
            this.Exit_Login_btn.UseVisualStyleBackColor = true;
            this.Exit_Login_btn.Click += new System.EventHandler(this.Exit_Login_btn_Click);
            // 
            // LOG_IN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(449, 356);
            this.Controls.Add(this.Exit_Login_btn);
            this.Controls.Add(this.Add_emp_btn);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "LOG_IN";
            this.Text = "LOG_IN";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Add_emp_btn;
        private System.Windows.Forms.Button Exit_Login_btn;
    }
}