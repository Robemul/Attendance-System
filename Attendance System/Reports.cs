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
    public partial class Reports : Form
    {
        private object tABLE2TableAdapter;

        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOG_IN return_to_report = new LOG_IN();
            return_to_report.ShowDialog();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tABLE2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tABLE2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TABLE2' table. You can move, or remove it, as needed.
           

        }
    }
}
