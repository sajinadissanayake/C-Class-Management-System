using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_44
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void mupdate_Click(object sender, EventArgs e)
        {

        }

        private void mregistration_Click(object sender, EventArgs e)
        {
            student_registration a = new student_registration();
            a.Show();
            Visible = false;

        }

        private void mupdate_Click_1(object sender, EventArgs e)
        {
           details_update a = new details_update();
            a.Show();
            Visible = false;
        }

        private void mpayment_Click(object sender, EventArgs e)
        {

            payments a = new payments();
            a.Show();
            Visible = false;
        }

        private void mpaymentcheck_Click(object sender, EventArgs e)
        {
            payment_checking a = new payment_checking();
            a.Show();
            Visible = false;
        }

        private void mdetails_Click(object sender, EventArgs e)
        {
            details_table a = new details_table();
            a.Show();
            Visible = false;
        }

        private void mdelete_Click(object sender, EventArgs e)
        {
            details_delete a = new details_delete();
            a.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
