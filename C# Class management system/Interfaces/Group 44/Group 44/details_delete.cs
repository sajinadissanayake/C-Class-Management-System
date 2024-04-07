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
    public partial class details_delete : Form
    {
        public details_delete()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\database\projectdb.mdf;Integrated Security=True;Connect Timeout=30");
            int id = int.Parse(deleteid.Text);

            string del = "DELETE FROM registration Where id='" + id+ "'";

            SqlCommand cmd = new SqlCommand(del, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" records deleted successfully");
            }
            catch (SqlException se)
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
