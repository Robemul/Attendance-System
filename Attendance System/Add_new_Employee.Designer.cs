namespace Attendance_System
{
    partial class Add_new_Employee
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
            this.Add_EMP_submit_btn = new System.Windows.Forms.Button();
            this.add_new_emp_cancel = new System.Windows.Forms.Button();
            this.First_name_txt = new System.Windows.Forms.TextBox();
            this.Middle_name_txt = new System.Windows.Forms.TextBox();
            this.SSN_txt_add = new System.Windows.Forms.TextBox();
            this.DOB_txt_add = new System.Windows.Forms.TextBox();
            this.Last_name_txt = new System.Windows.Forms.TextBox();
            this.Employee_ID_txt_add = new System.Windows.Forms.TextBox();
            this.Hire_date_txt = new System.Windows.Forms.TextBox();
            this.First_name_lable = new System.Windows.Forms.Label();
            this.middle_name_lable = new System.Windows.Forms.Label();
            this.Last_name_lable = new System.Windows.Forms.Label();
            this.emp_add_lable = new System.Windows.Forms.Label();
            this.SSN_label_add = new System.Windows.Forms.Label();
            this.DOB_label_add = new System.Windows.Forms.Label();
            this.Hire_date_add_lable = new System.Windows.Forms.Label();
            this.PIN = new System.Windows.Forms.Label();
            this.Confirm_Pin = new System.Windows.Forms.Label();
            this.pin_txtbox = new System.Windows.Forms.TextBox();
            this.confirm_pin_txtbox = new System.Windows.Forms.TextBox();
            this.SEX_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Add_EMP_submit_btn
            // 
            this.Add_EMP_submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_EMP_submit_btn.Location = new System.Drawing.Point(135, 382);
            this.Add_EMP_submit_btn.Name = "Add_EMP_submit_btn";
            this.Add_EMP_submit_btn.Size = new System.Drawing.Size(123, 66);
            this.Add_EMP_submit_btn.TabIndex = 12;
            this.Add_EMP_submit_btn.Text = "Submit";
            this.Add_EMP_submit_btn.UseVisualStyleBackColor = true;
            this.Add_EMP_submit_btn.Click += new System.EventHandler(this.Add_EMP_submit_btn_Click);
            // 
            // add_new_emp_cancel
            // 
            this.add_new_emp_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_emp_cancel.Location = new System.Drawing.Point(397, 383);
            this.add_new_emp_cancel.Name = "add_new_emp_cancel";
            this.add_new_emp_cancel.Size = new System.Drawing.Size(123, 65);
            this.add_new_emp_cancel.TabIndex = 13;
            this.add_new_emp_cancel.Text = "Cancel ";
            this.add_new_emp_cancel.UseVisualStyleBackColor = true;
            this.add_new_emp_cancel.Click += new System.EventHandler(this.add_new_emp_cancel_Click);
            // 
            // First_name_txt
            // 
            this.First_name_txt.Location = new System.Drawing.Point(103, 124);
            this.First_name_txt.Name = "First_name_txt";
            this.First_name_txt.Size = new System.Drawing.Size(209, 22);
            this.First_name_txt.TabIndex = 2;
            this.First_name_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Middle_name_txt
            // 
            this.Middle_name_txt.Location = new System.Drawing.Point(103, 176);
            this.Middle_name_txt.Name = "Middle_name_txt";
            this.Middle_name_txt.Size = new System.Drawing.Size(209, 22);
            this.Middle_name_txt.TabIndex = 3;
            // 
            // SSN_txt_add
            // 
            this.SSN_txt_add.Location = new System.Drawing.Point(397, 121);
            this.SSN_txt_add.MaxLength = 9;
            this.SSN_txt_add.Name = "SSN_txt_add";
            this.SSN_txt_add.Size = new System.Drawing.Size(174, 22);
            this.SSN_txt_add.TabIndex = 7;
            this.SSN_txt_add.Tag = "000-000-000";
            this.SSN_txt_add.UseSystemPasswordChar = true;
            // 
            // DOB_txt_add
            // 
            this.DOB_txt_add.Location = new System.Drawing.Point(397, 171);
            this.DOB_txt_add.MaxLength = 8;
            this.DOB_txt_add.Name = "DOB_txt_add";
            this.DOB_txt_add.Size = new System.Drawing.Size(174, 22);
            this.DOB_txt_add.TabIndex = 8;
            this.DOB_txt_add.TextChanged += new System.EventHandler(this.DOB_txt_add_TextChanged);
            // 
            // Last_name_txt
            // 
            this.Last_name_txt.Location = new System.Drawing.Point(108, 238);
            this.Last_name_txt.Name = "Last_name_txt";
            this.Last_name_txt.Size = new System.Drawing.Size(204, 22);
            this.Last_name_txt.TabIndex = 4;
            // 
            // Employee_ID_txt_add
            // 
            this.Employee_ID_txt_add.Location = new System.Drawing.Point(103, 65);
            this.Employee_ID_txt_add.MaxLength = 6;
            this.Employee_ID_txt_add.Name = "Employee_ID_txt_add";
            this.Employee_ID_txt_add.Size = new System.Drawing.Size(209, 22);
            this.Employee_ID_txt_add.TabIndex = 1;

            // 
            // Hire_date_txt
            // 
            this.Hire_date_txt.AcceptsTab = true;
            this.Hire_date_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hire_date_txt.Location = new System.Drawing.Point(397, 235);
            this.Hire_date_txt.MaxLength = 8;
            this.Hire_date_txt.Name = "Hire_date_txt";
            this.Hire_date_txt.Size = new System.Drawing.Size(174, 27);
            this.Hire_date_txt.TabIndex = 9;
            // 
            // First_name_lable
            // 
            this.First_name_lable.AutoSize = true;
            this.First_name_lable.Location = new System.Drawing.Point(9, 129);
            this.First_name_lable.Name = "First_name_lable";
            this.First_name_lable.Size = new System.Drawing.Size(80, 17);
            this.First_name_lable.TabIndex = 10;
            this.First_name_lable.Text = "First Name ";
            // 
            // middle_name_lable
            // 
            this.middle_name_lable.AutoSize = true;
            this.middle_name_lable.Location = new System.Drawing.Point(7, 181);
            this.middle_name_lable.Name = "middle_name_lable";
            this.middle_name_lable.Size = new System.Drawing.Size(90, 17);
            this.middle_name_lable.TabIndex = 11;
            this.middle_name_lable.Text = "Middle Name";
            // 
            // Last_name_lable
            // 
            this.Last_name_lable.AutoSize = true;
            this.Last_name_lable.Location = new System.Drawing.Point(12, 243);
            this.Last_name_lable.Name = "Last_name_lable";
            this.Last_name_lable.Size = new System.Drawing.Size(80, 17);
            this.Last_name_lable.TabIndex = 12;
            this.Last_name_lable.Text = "Last Name ";
            // 
            // emp_add_lable
            // 
            this.emp_add_lable.AutoSize = true;
            this.emp_add_lable.Location = new System.Drawing.Point(2, 65);
            this.emp_add_lable.Name = "emp_add_lable";
            this.emp_add_lable.Size = new System.Drawing.Size(87, 17);
            this.emp_add_lable.TabIndex = 13;
            this.emp_add_lable.Text = "Employee ID";
            // 
            // SSN_label_add
            // 
            this.SSN_label_add.AutoSize = true;
            this.SSN_label_add.Location = new System.Drawing.Point(336, 124);
            this.SSN_label_add.Name = "SSN_label_add";
            this.SSN_label_add.Size = new System.Drawing.Size(36, 17);
            this.SSN_label_add.TabIndex = 15;
            this.SSN_label_add.Text = "SSN";
            // 
            // DOB_label_add
            // 
            this.DOB_label_add.AutoSize = true;
            this.DOB_label_add.Location = new System.Drawing.Point(336, 176);
            this.DOB_label_add.Name = "DOB_label_add";
            this.DOB_label_add.Size = new System.Drawing.Size(38, 17);
            this.DOB_label_add.TabIndex = 16;
            this.DOB_label_add.Text = "DOB";
            // 
            // Hire_date_add_lable
            // 
            this.Hire_date_add_lable.AutoSize = true;
            this.Hire_date_add_lable.Location = new System.Drawing.Point(323, 238);
            this.Hire_date_add_lable.Name = "Hire_date_add_lable";
            this.Hire_date_add_lable.Size = new System.Drawing.Size(68, 17);
            this.Hire_date_add_lable.TabIndex = 17;
            this.Hire_date_add_lable.Text = "Hire Date";
            // 
            // PIN
            // 
            this.PIN.AutoSize = true;
            this.PIN.Location = new System.Drawing.Point(31, 306);
            this.PIN.Name = "PIN";
            this.PIN.Size = new System.Drawing.Size(30, 17);
            this.PIN.TabIndex = 18;
            this.PIN.Text = "PIN";
            // 
            // Confirm_Pin
            // 
            this.Confirm_Pin.AutoSize = true;
            this.Confirm_Pin.Location = new System.Drawing.Point(311, 304);
            this.Confirm_Pin.Name = "Confirm_Pin";
            this.Confirm_Pin.Size = new System.Drawing.Size(80, 17);
            this.Confirm_Pin.TabIndex = 19;
            this.Confirm_Pin.Text = "Confirm Pin";
            // 
            // pin_txtbox
            // 
            this.pin_txtbox.Location = new System.Drawing.Point(108, 301);
            this.pin_txtbox.MaxLength = 6;
            this.pin_txtbox.Name = "pin_txtbox";
            this.pin_txtbox.Size = new System.Drawing.Size(190, 22);
            this.pin_txtbox.TabIndex = 10;
            this.pin_txtbox.UseSystemPasswordChar = true;
            // 
            // confirm_pin_txtbox
            // 
            this.confirm_pin_txtbox.Location = new System.Drawing.Point(397, 299);
            this.confirm_pin_txtbox.MaxLength = 6;
            this.confirm_pin_txtbox.Name = "confirm_pin_txtbox";
            this.confirm_pin_txtbox.Size = new System.Drawing.Size(174, 22);
            this.confirm_pin_txtbox.TabIndex = 11;
            this.confirm_pin_txtbox.UseSystemPasswordChar = true;
            // 
            // SEX_combobox
            // 
            this.SEX_combobox.FormattingEnabled = true;
            this.SEX_combobox.Location = new System.Drawing.Point(397, 65);
            this.SEX_combobox.Name = "SEX_combobox";
            this.SEX_combobox.Size = new System.Drawing.Size(174, 24);
            this.SEX_combobox.TabIndex = 20;
            this.SEX_combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Add_new_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(618, 460);
            this.Controls.Add(this.SEX_combobox);
            this.Controls.Add(this.confirm_pin_txtbox);
            this.Controls.Add(this.pin_txtbox);
            this.Controls.Add(this.Confirm_Pin);
            this.Controls.Add(this.PIN);
            this.Controls.Add(this.Hire_date_add_lable);
            this.Controls.Add(this.DOB_label_add);
            this.Controls.Add(this.SSN_label_add);
            this.Controls.Add(this.emp_add_lable);
            this.Controls.Add(this.Last_name_lable);
            this.Controls.Add(this.middle_name_lable);
            this.Controls.Add(this.First_name_lable);
            this.Controls.Add(this.Hire_date_txt);
            this.Controls.Add(this.Employee_ID_txt_add);
            this.Controls.Add(this.Last_name_txt);
            this.Controls.Add(this.DOB_txt_add);
            this.Controls.Add(this.SSN_txt_add);
            this.Controls.Add(this.Middle_name_txt);
            this.Controls.Add(this.First_name_txt);
            this.Controls.Add(this.add_new_emp_cancel);
            this.Controls.Add(this.Add_EMP_submit_btn);
            this.Name = "Add_new_Employee";
            this.Text = "Add new Employee";
            this.Load += new System.EventHandler(this.Add_new_Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_EMP_submit_btn;
        private System.Windows.Forms.Button add_new_emp_cancel;
        private System.Windows.Forms.TextBox First_name_txt;
        private System.Windows.Forms.TextBox Middle_name_txt;
        private System.Windows.Forms.TextBox SSN_txt_add;
        private System.Windows.Forms.TextBox DOB_txt_add;
        private System.Windows.Forms.TextBox Last_name_txt;
        private System.Windows.Forms.TextBox Employee_ID_txt_add;
        private System.Windows.Forms.TextBox Hire_date_txt;
        private System.Windows.Forms.Label First_name_lable;
        private System.Windows.Forms.Label middle_name_lable;
        private System.Windows.Forms.Label Last_name_lable;
        private System.Windows.Forms.Label emp_add_lable;
        private System.Windows.Forms.Label SSN_label_add;
        private System.Windows.Forms.Label DOB_label_add;
        private System.Windows.Forms.Label Hire_date_add_lable;
        private System.Windows.Forms.Label PIN;
        private System.Windows.Forms.Label Confirm_Pin;
        private System.Windows.Forms.TextBox pin_txtbox;
        private System.Windows.Forms.TextBox confirm_pin_txtbox;
        private System.Windows.Forms.ComboBox SEX_combobox;
    }
}