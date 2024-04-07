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
    public partial class details_update : Form
    {
        public details_update()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void update1_Click(object sender, EventArgs e)
        {

           
         
        


        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\database\projectdb.mdf;Integrated Security=True;Connect Timeout=30");
            int Id = int.Parse(updateid.Text);
            string Name = updatename.Text;
  

            string updatenm = "UPDATE registration set name= '" + Name + "'  WHERE id='" + Id + "'";
            SqlCommand cmd1 = new SqlCommand(updatenm, con);

            try
            {
                con.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data updated Successfully");
            }
            catch (Exception se)
            {
                MessageBox.Show("" + se);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\database\projectdb.mdf;Integrated Security=True;Connect Timeout=30");
            int Id = int.Parse(updateid.Text);
            int Gd = int.Parse(updategrade.Text);

            string updateGd = "UPDATE registration set grade= '" + Gd + "'  WHERE id='" + Id + "'";
            SqlCommand cmd2 = new SqlCommand(updateGd, con);
            try
            {
                con.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Data updated Successfully");
            }
            catch (Exception se)
            {
                MessageBox.Show("" + se);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\database\projectdb.mdf;Integrated Security=True;Connect Timeout=30");
            int Id = int.Parse(updateid.Text);
            string Address = updateadd.Text;
            string updatead = "UPDATE registration set address= '" + Address + "'  WHERE id='" + Id + "'";
            SqlCommand cmd4 = new SqlCommand(updatead, con);
            try
            {
                con.Open();
                cmd4.ExecuteNonQuery();
                MessageBox.Show("Data updated Successfully");
            }
            catch (Exception se)
            {
                MessageBox.Show("" + se);
            }





        }

        private void button3_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\database\projectdb.mdf;Integrated Security=True;Connect Timeout=30");
            int Id = int.Parse(updateid.Text);
            int Phone = int.Parse(updatenum.Text);

            string updateph = "UPDATE registration set phone= '" + Phone + "'  WHERE id='" + Id + "'";
            SqlCommand cmd3 = new SqlCommand(updateph, con);
            try
            {
                con.Open();
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Data updated Successfully");
            }
            catch (Exception se)
            {
                MessageBox.Show("" + se);
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
