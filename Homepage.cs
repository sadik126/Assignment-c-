using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digital_diary
{
    public partial class Homepage : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["my diary"].ConnectionString);
        SqlDataAdapter adpt;
        DataTable dt;


        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Text box Empty");
            }
            
            
            else
            {
                MessageBox.Show("Saved");
                Events ev = new Events();
                    ev.Show();
                this.Hide();
            }

            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["my diary"].ConnectionString);
           
            con.Open();
            string sql = "INSERT INTO add_event (date,event,importance) VALUES('" + dateTimePicker1.Text + "','"+textBox1.Text+"','"+comboBox1.Text+"')";
            SqlCommand command = new SqlCommand(sql, con);
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("User added successfully.");
            }
            else
            {
                MessageBox.Show("there is an error.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Events evt = new Events();
            evt.Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("delete from add_event where event='"+textBox2.Text+"'", con);
            
            dt = new DataTable();
            adpt.Fill(dt);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Text box Empty");
            }


            else
            {
                MessageBox.Show("deleted");
                Events ev = new Events();
                ev.Show();
                this.Hide();
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("update  add_event set event='" + textBox3.Text + "' where event='"+textBox4.Text+"'", con);
            

            dt = new DataTable();
            adpt.Fill(dt);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Text box Empty");
            }


            else
            {
                MessageBox.Show("Saved");
                Events ev = new Events();
                ev.Show();
                this.Hide();
            }
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
