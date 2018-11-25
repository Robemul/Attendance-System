using Oracle.ManagedDataAccess.Client;
using System.Drawing;

namespace Attendance_System
{
    
partial class Attendace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendace));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cloud_Attenda_lable = new System.Windows.Forms.Label();
            this.Employee_ID_BOX = new System.Windows.Forms.TextBox();
            this.PIN_BOX = new System.Windows.Forms.TextBox();
            this.EmployeeID_label = new System.Windows.Forms.Label();
            this.PIN_label = new System.Windows.Forms.Label();
            this.ClockIN_button = new System.Windows.Forms.Button();
            this.Clockout_button = new System.Windows.Forms.Button();
            this.LogIN_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Cloud_Attenda_lable
            // 
            this.Cloud_Attenda_lable.AutoSize = true;
            this.Cloud_Attenda_lable.BackColor = System.Drawing.Color.AliceBlue;
            this.Cloud_Attenda_lable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cloud_Attenda_lable.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cloud_Attenda_lable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cloud_Attenda_lable.Location = new System.Drawing.Point(136, 152);
            this.Cloud_Attenda_lable.Name = "Cloud_Attenda_lable";
            this.Cloud_Attenda_lable.Size = new System.Drawing.Size(372, 28);
            this.Cloud_Attenda_lable.TabIndex = 1;
            this.Cloud_Attenda_lable.Text = "Cloud Attendance System ";
            this.Cloud_Attenda_lable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Employee_ID_BOX
            // 
            this.Employee_ID_BOX.AcceptsTab = true;
            this.Employee_ID_BOX.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Employee_ID_BOX.AllowDrop = true;
            this.Employee_ID_BOX.BackColor = System.Drawing.SystemColors.Window;
            this.Employee_ID_BOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_ID_BOX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Employee_ID_BOX.Location = new System.Drawing.Point(281, 226);
            this.Employee_ID_BOX.MaxLength = 6;
            this.Employee_ID_BOX.Name = "Employee_ID_BOX";
            this.Employee_ID_BOX.Size = new System.Drawing.Size(227, 22);
            this.Employee_ID_BOX.TabIndex = 1;
            this.Employee_ID_BOX.UseSystemPasswordChar = true;
            this.Employee_ID_BOX.TextChanged += new System.EventHandler(this.Employee_ID_BOX_TextChanged_1);
            this.Employee_ID_BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Employee_ID_BOX_KeyPress);
            // 
            // PIN_BOX
            // 
            this.PIN_BOX.AcceptsReturn = true;
            this.PIN_BOX.AcceptsTab = true;
            this.PIN_BOX.Location = new System.Drawing.Point(281, 273);
            this.PIN_BOX.MaxLength = 6;
            this.PIN_BOX.Name = "PIN_BOX";
            this.PIN_BOX.Size = new System.Drawing.Size(227, 22);
            this.PIN_BOX.TabIndex = 2;
            this.PIN_BOX.UseSystemPasswordChar = true;
            this.PIN_BOX.TextChanged += new System.EventHandler(this.PIN_BOX_TextChanged);
            this.PIN_BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PIN_BOX_KeyPress);
            // 
            // EmployeeID_label
            // 
            this.EmployeeID_label.AutoSize = true;
            this.EmployeeID_label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID_label.ForeColor = System.Drawing.Color.DarkMagenta;
            this.EmployeeID_label.Location = new System.Drawing.Point(136, 219);
            this.EmployeeID_label.Name = "EmployeeID_label";
            this.EmployeeID_label.Size = new System.Drawing.Size(127, 28);
            this.EmployeeID_label.TabIndex = 4;
            this.EmployeeID_label.Text = "Employee ID ";
            this.EmployeeID_label.Click += new System.EventHandler(this.EmployeeID_label_Click);
            // 
            // PIN_label
            // 
            this.PIN_label.AutoSize = true;
            this.PIN_label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN_label.ForeColor = System.Drawing.Color.DarkMagenta;
            this.PIN_label.Location = new System.Drawing.Point(191, 267);
            this.PIN_label.Name = "PIN_label";
            this.PIN_label.Size = new System.Drawing.Size(48, 28);
            this.PIN_label.TabIndex = 5;
            this.PIN_label.Text = "PIN ";
            // 
            // ClockIN_button
            // 
            this.ClockIN_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClockIN_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ClockIN_button.Location = new System.Drawing.Point(239, 337);
            this.ClockIN_button.Name = "ClockIN_button";
            this.ClockIN_button.Size = new System.Drawing.Size(109, 54);
            this.ClockIN_button.TabIndex = 3;
            this.ClockIN_button.Text = "Clock IN ";
            this.ClockIN_button.UseVisualStyleBackColor = false;
            this.ClockIN_button.Click += new System.EventHandler(this.ClockIN_button_Click);
            // 
            // Clockout_button
            // 
            this.Clockout_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Clockout_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clockout_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Clockout_button.Location = new System.Drawing.Point(357, 337);
            this.Clockout_button.Name = "Clockout_button";
            this.Clockout_button.Size = new System.Drawing.Size(109, 54);
            this.Clockout_button.TabIndex = 4;
            this.Clockout_button.Text = "Clock OUT                           ";
            this.Clockout_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Clockout_button.UseVisualStyleBackColor = false;
            this.Clockout_button.Click += new System.EventHandler(this.Clockout_button_Click);
            // 
            // LogIN_button
            // 
            this.LogIN_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LogIN_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LogIN_button.Location = new System.Drawing.Point(301, 422);
            this.LogIN_button.Name = "LogIN_button";
            this.LogIN_button.Size = new System.Drawing.Size(93, 48);
            this.LogIN_button.TabIndex = 5;
            this.LogIN_button.Text = "Log IN";
            this.LogIN_button.UseVisualStyleBackColor = false;
            this.LogIN_button.Click += new System.EventHandler(this.LogIN_button_Click);
            // 
            // Attendace_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(685, 502);
            this.Controls.Add(this.LogIN_button);
            this.Controls.Add(this.Clockout_button);
            this.Controls.Add(this.ClockIN_button);
            this.Controls.Add(this.PIN_label);
            this.Controls.Add(this.EmployeeID_label);
            this.Controls.Add(this.PIN_BOX);
            this.Controls.Add(this.Employee_ID_BOX);
            this.Controls.Add(this.Cloud_Attenda_lable);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Attendace_From";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Cloud Attendance System ";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Attendace_SYS_FRONT);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Cloud_Attenda_lable;
        private System.Windows.Forms.TextBox Employee_ID_BOX;
        private System.Windows.Forms.TextBox PIN_BOX;
        private System.Windows.Forms.Label EmployeeID_label;
        private System.Windows.Forms.Label PIN_label;
        private System.Windows.Forms.Button ClockIN_button;
        private System.Windows.Forms.Button Clockout_button;
        private System.Windows.Forms.Button LogIN_button;
    }
}

