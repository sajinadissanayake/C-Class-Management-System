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
    public partial class payment_checking : Form
    {
        public payment_checking()
        {
            InitializeComponent();
        }

        private void payment_checking_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttoncheck_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\database\projectdb.mdf;Integrated Security=True;Connect Timeout=30");
            int id = int.Parse(checkid.Text);

            string qry = "select * FROM payments where id = '"+id+"'";

            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "payments");
            paydatabox.DataSource = ds.Tables["payments"];




        }

        private void buttonmenue_Click(object sender, EventArgs e)
        {
            main_menu menu = new main_menu();
            menu.Show();
            Visible = false;
        }
    }
}
