using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Group_44
{
    public partial class payments : Form
    {
        public payments()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void payments_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paynow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\database\projectdb.mdf;Integrated Security=True;Connect Timeout=30");
            int id = int.Parse(payid.Text);
            string name = payname.Text;
            string cs = paysub.Text;
            int fee = int.Parse(payamou.Text);

            string qry = "Insert Into payments values('" + id + "','" + name + "','" + cs + "','" + fee + "')";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Payment Recorded Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void buttonmenue_Click(object sender, EventArgs e)
        {
            main_menu menu = new main_menu();
            menu.Show();
            Visible = false;
        }
    }
}
