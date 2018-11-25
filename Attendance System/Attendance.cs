using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;


namespace Attendance_System
{
    public partial class Attendace : Form
    {
        private const string Time_Format = "{0:h:mm:ss tt}";



        public Attendace()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void Employee_ID_BOX_TextChanged(object sender, EventArgs e)
        {

        }

        public void PIN_BOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClockIN_button_Click(object sender, EventArgs e)
        {

            OracleConnection connection = new OracleConnection("User Id=sa;Password=masterpassword;Data Source=orainst1.cisclfdiuyna.us-east-2.rds.amazonaws.com:1521/ORADB");
            OracleDataAdapter sda = new OracleDataAdapter("select count(*) from sa.\"Emp_Pro_table\" where EMPLOYEE_ID='" + Employee_ID_BOX.Text + "' and PIN = '" + PIN_BOX.Text + "' ", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                connection.Open();
                string cmdText = @"INSERT INTO Emp_time_sheet (EMPLOYEE_ID)" + "VALUES (?)";
                OracleCommand cmd = new OracleCommand(cmdText, connection);
                cmd.Parameters.AddWithValue ("@EMPLOYEE_ID", Employee_ID_BOX.Text) ;
                cmd.ExecuteNonQuery();
                if (MessageBox.Show(string.Format(Time_Format, DateTime.Now), "Clock In",
                        MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Employee_ID_BOX.Text = "";
                    PIN_BOX.Text = "";
                }




            }
            else { 
                MessageBox.Show("please enter correct Employee ID and PIN", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Employee_ID_BOX.Text = "";
                PIN_BOX.Text = "";
            }
        }




            private void Attendace_SYS_FRONT(object sender, EventArgs e)
            {

            }


            private void EmployeeID_label_Click(object sender, EventArgs e)
            {

            }

        private void Clockout_button_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=sa;Password=masterpassword;Data Source=orainst1.cisclfdiuyna.us-east-2.rds.amazonaws.com:1521/ORADB");
            OracleDataAdapter sda = new OracleDataAdapter("select count(*) from sa.\"Emp_Pro_table\" where EMPLOYEE_ID='" + Employee_ID_BOX.Text + "' and PIN = '" + PIN_BOX.Text + "' ", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                
                    if (MessageBox.Show(string.Format(Time_Format, DateTime.Now), "Clock OUT",
                        MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Employee_ID_BOX.Text = "";
                        PIN_BOX.Text = "";
                    }
                
            }
            else
            {
                MessageBox.Show("please enter correct Employee ID and PIN", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Employee_ID_BOX.Text = "";
                PIN_BOX.Text = "";
            }

        }


            private void Employee_ID_BOX_TextChanged_1(object sender, EventArgs e)
            {

            }

            private void Employee_ID_BOX_KeyPress(object sender, KeyPressEventArgs e)
            {
                char ch = e.KeyChar;
                if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                {
                    e.Handled = true;
                }
            }

            private void PIN_BOX_KeyPress(object sender, KeyPressEventArgs e)
            {
                char ch = e.KeyChar;
                if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                {
                    e.Handled = true;
                }
            }

            private void LogIN_button_Click(object sender, EventArgs e)
            {
                OracleConnection connection = new OracleConnection("User Id=sa;Password=masterpassword;Data Source=orainst1.cisclfdiuyna.us-east-2.rds.amazonaws.com:1521/ORADB");
                OracleDataAdapter sda = new OracleDataAdapter("select count(*) from sa.\"Emp_Pro_table\" where EMPLOYEE_ID='" + Employee_ID_BOX.Text + "' and PIN = '" + PIN_BOX.Text + "' ", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    
                        this.Hide();
                        LOG_IN login_form = new LOG_IN();
                        login_form.ShowDialog();

                Employee_ID_BOX.Text = "";
                PIN_BOX.Text = "";
                
                }
                else
                    MessageBox.Show("please enter correct Employee ID and PIN", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Employee_ID_BOX.Text = "";
                PIN_BOX.Text = "";
            }
        }


    }


