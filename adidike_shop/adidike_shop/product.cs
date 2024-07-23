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

namespace adidike_shop
{
    public partial class product : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-3S25R88\SQLEXPRESS;Initial Catalog=didikeshop;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from product";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public product()
        {
            InitializeComponent();
        }

        private void product_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void product_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
/*            string inputText = giaban.Text;

            string numericText = new string(inputText.Where(char.IsDigit).ToArray());

            if (long.TryParse(numericText, out long number))
            {
                string formattedText = number.ToString("N0");

                giaban.TextChanged -= textBox1_TextChanged;

                giaban.Text = formattedText;
                giaban.SelectionStart = formattedText.Length;

                giaban.TextChanged += textBox1_TextChanged;
            }*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
/*            string inputText = gianhap.Text;

            string numericText = new string(inputText.Where(char.IsDigit).ToArray());

            if (long.TryParse(numericText, out long number))
            {
                string formattedText = number.ToString("N0");

                gianhap.TextChanged -= textBox2_TextChanged;

                gianhap.Text = formattedText;
                gianhap.SelectionStart = formattedText.Length;

                gianhap.TextChanged += textBox2_TextChanged;
            }*/
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string inputText = soluong.Text;

            string numericText = new string(inputText.Where(char.IsDigit).ToArray());

            if (long.TryParse(numericText, out long number))
            {
                string formattedText = number.ToString("N0");

                soluong.TextChanged -= textBox3_TextChanged;

                soluong.Text = formattedText;
                soluong.SelectionStart = formattedText.Length;

                soluong.TextChanged += textBox3_TextChanged;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            nhasx.Height = 30;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            id.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tensp.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tensp.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            hang.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            nhasx.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            theloai.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            mau.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            kichthuoc.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            chatlieu.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            gianhap.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            giaban.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            soluong.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
        }

        private void them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into product values('"+id.Text+"','" + tensp.Text + "','" + hang.Text + "','" + nhasx.Text + "','" + theloai.Text + "','" + mau.Text + "'" +
                ",'" + kichthuoc.Text + "','" + chatlieu.Text + "','" + gianhap.Text + "','" + giaban.Text + "','" + soluong.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update product set name='" + tensp.Text + "',hang='" + hang.Text + "',nhasx='" + nhasx.Text + "',theloai='" + theloai.Text + "',color='" + mau.Text + "'" +
                ",size=" + kichthuoc.Text + ",chatlieu='" + chatlieu.Text + "',gianhap=" + gianhap.Text + ",giaban=" + giaban.Text + ",soluong=" + soluong.Text + " where id='" + id.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            command=connection.CreateCommand();
            command.CommandText = "delete from product where id='" + id.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
