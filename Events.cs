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
using System.Configuration;

namespace digital_diary
{
    
    public partial class Events : Form


    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["my diary"].ConnectionString);
        SqlDataAdapter adpt;
        DataTable dt;
        int Modify_event;
        public Events()
        {
            InitializeComponent();
            this.showdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.showdata();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void showdata()
        {
            adpt = new SqlDataAdapter("select * from add_event", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Events_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Pictures pic = new Pictures();
            pic.Show();
            this.Hide();
        }
    }
}
