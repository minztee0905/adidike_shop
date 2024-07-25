using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace thanhtoan
{
    public partial class pay : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"";
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable tb =  new DataTable();
        void loaddata()
        
            {
                cmd = conn.CreateCommand(); 
                cmd.CommandText = "select * from payment"; 
                adt.SelectCommand = cmd; 
                tb.Clear();
                adt.Fill(tb);
                dataGridView1.DataSource = tb;
            }
        

        public pay()
        {
            {
                InitializeComponent();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

      

        private void pay_Load(object sender, EventArgs e)
        
        {
            conn = new SqlConnection(str);
            conn.Open(); 
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}

