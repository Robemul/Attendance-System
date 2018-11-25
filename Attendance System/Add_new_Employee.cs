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

        /*
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        */
        public Add_new_Employee()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_new_emp_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_new_Employee_Load(object sender, EventArgs e)
        {

        }

        private void Add_EMP_submit_btn_Click(object sender, EventArgs e)
        {

            con = new OracleConnection(@"DATA SOURCE=orainst1.cisclfdiuyna.us-east-2.rds.amazonaws.com:1521/ORADB:/;PERSIST SECURITY INFO=True;USER ID=SA;Password=masterpassword");
            con.Open();
            cmd = new OracleCommand("INSERT INTO Emp_time_sheet (FIRST_NAME, MIDDLE_NAME,LAST_NAME, EMPLOYEE_ID, SSN, SEX, DOB,HIREDATE, PIN) " +
                   "VALUES (@FIRST_NAME, @MIDDLE_NAME,@LAST_NAME,@EMPLOYEE_ID,@SSN,@SEX,@DOB,@HIREDATE,@PIN)", con);
            cmd.Parameters.Add("@FIRST_NAME", First_name_txt.Text);
            cmd.Parameters.Add("@MIDDLE_NAME", Middle_name_txt.Text);
            cmd.Parameters.Add("@LAST_NAME", Last_name_txt.Text);
            cmd.Parameters.Add("@EMPLOYEE_ID", Employee_ID_txt_add.Text);
            cmd.Parameters.Add("@SSN", SSN_txt_add.Text);

            cmd.Parameters.Add("@DOB", DOB_txt_add.Text);
            cmd.Parameters.Add("@HIREDATE", Hire_date_txt.Text);
            cmd.Parameters.Add("@PIN", pin_txtbox.Text);

            cmd.ExecuteNonQueryAsync();





            /*  
              con = new SqlConnection(@"DATA SOURCE=orainst1.cisclfdiuyna.us-east-2.rds.amazonaws.com:1521/ORADB:/;PERSIST SECURITY INFO=True");
              con.Open();
              cmd = new SqlCommand("INSERT INTO Emp_time_sheet (FIRST_NAME, MIDDLE_NAME,LAST_NAME, EMPLOYEE_ID, SSN, SEX, DOB,HIREDATE, PIN) " +
                  "VALUES (@FIRST_NAME, @MIDDLE_NAME,@LAST_NAME,@EMPLOYEE_ID,@SSN,@SEX,@DOB,@HIREDATE,@PIN)",con);

              cmd.Parameters.Add("@FIRST_NAME", First_name_txt.Text);
              cmd.Parameters.Add("@MIDDLE_NAME", Middle_name_txt.Text);
              cmd.Parameters.Add("@LAST_NAME", Last_name_txt.Text);
              cmd.Parameters.Add("@EMPLOYEE_ID", Employee_ID_txt_add.Text);
              cmd.Parameters.Add("@SSN", SSN_txt_add.Text);
              cmd.Parameters.Add("@SEX", Male_radio_btn_add.Checked.ToString());
              cmd.Parameters.Add("@DOB", DOB_txt_add.Text);
              cmd.Parameters.Add("@HIREDATE", Hire_date_txt.Text);
              cmd.Parameters.Add("@PIN", pin_txtbox.Text);
              cmd.ExecuteNonQuery();
              */

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
            if (!char.IsDigit(ch) && ch != 7 && ch != 0)
            {
                e.Handled = true;
            }
        }
    }
}

