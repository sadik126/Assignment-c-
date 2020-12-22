using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digital_diary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Name Empty");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Password Empty");

            }
            else if (textBox1.Text == "sadik" && textBox2.Text == "pass")
            {

                Homepage hpg = new Homepage();
                hpg.Show();
                this.Hide();
            }


            else
            {
                MessageBox.Show("the username or password is incorrect");
                textBox2.Clear();
                textBox1.Clear();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
