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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (uname.Text== "admin" && password.Text=="abc123")
            {
                main_menu menu = new main_menu();
                menu.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("The username and the password you entered is incorrect, try again");
                uname.Clear();
                password.Clear();
                uname.Focus();
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonmenue_Click(object sender, EventArgs e)
        {
            main_menu menu = new main_menu();
            menu.Show();
            Visible = false;
        }
    }
}
