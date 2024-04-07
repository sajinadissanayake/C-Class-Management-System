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
    public partial class student_registration : Form
    {
        public student_registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonreg_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\database\projectdb.mdf;Integrated Security=True;Connect Timeout=30");

            int Id = int.Parse(regid.Text);
            string Name = regname.Text;
            int Gd = int.Parse(reggrade.Text);
            int Phone = int.Parse(regnum.Text);
            string Address = regadd.Text;
            string Date = regdate.Text;

            string qry = "Insert Into registration values('" + Id + "','" + Name + "','" + Gd + "','" + Phone + "','" + Address + "','" + Date + "')";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successfull");
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
