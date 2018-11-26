using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO;
using FileHelpers;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Attendance_System
{
    public partial class Add_new_Employee : Form
    {
        OracleCommand cmd;
        OracleConnection con;
        OracleDataAdapter da;

        
        public Add_new_Employee()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_new_emp_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendace login_form = new Attendace();
            login_form.ShowDialog();
        }

        private void Add_new_Employee_Load(object sender, EventArgs e)
        {

        }

        private void Add_EMP_submit_btn_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=sa;Password=masterpassword;Data Source=orainst1.cisclfdiuyna.us-east-2.rds.amazonaws.com:1521/ORADB");
            string F_name = First_name_txt.Text;
            string M_name = Middle_name_txt.Text;
            string L_name = Last_name_txt.Text;
            string P_1 = pin_txtbox.Text;
            string P_2 = confirm_pin_txtbox.Text;
            
            int Emp_id = Int32.Parse(Employee_ID_txt_add.Text);

            if (First_name_txt.Text != "" && Last_name_txt.Text != "" && Employee_ID_txt_add.Text != "")
            {
                if (P_1 == P_2)
                {
                    string query = "INSERT INTO sa.\"Emp_Pro_table\" (FIRST_NAME,MIDDLE_NAME,LAST_NAME,PIN,EMPLOYEE_ID ) VALUES ('" + F_name + "','" + M_name + "','" + L_name
                    + "','" + P_1 + "','" + Emp_id + "')";
                    OracleCommand addemp_cmd = new OracleCommand(query, connection);
                    connection.Open();
                    addemp_cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("New Employee have been submited", "alert", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    Attendace login_form = new Attendace();
                    login_form.ShowDialog();
                }


                else
                {
                    MessageBox.Show("PIN does not match", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pin_txtbox.Text = "";
                    Confirm_Pin.Text = "";
                }

            }
        
            else
            {
                MessageBox.Show("please complete the form correctly", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DOB_txt_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_ID_txt_add_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Employee_ID_txt_add_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

