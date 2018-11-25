using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System
{
    public partial class LOG_IN : Form
    {
        public LOG_IN()
        {
            InitializeComponent();
        }

        private void Exit_Login_btn_Click(object sender, EventArgs e)
        {
           this.Close();
         }

       
        private void report_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports Report_form = new Reports();
            Report_form.ShowDialog();
        }

        private void Add_emp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_new_Employee New_EMP_form = new Add_new_Employee ();
            New_EMP_form.ShowDialog();
        }
    }
}
