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
using System.Xml.XPath;
using System.Collections.Specialized;
using System.IO;

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
            dataGridView2.DataSource = table;
        }
        public product()
        {
            InitializeComponent();
            LoadChoices();
        }
        private void LoadChoices()
        {
            listBoxChoices.Items.Add("Thống Kê");
            listBoxChoices.Items.Add("Nhập Sản Phẩm");
            listBoxChoices.Items.Add("Bán Sản Phẩm");
            listBoxChoices.Items.Add("Sản Phẩm");
            listBoxChoices.Items.Add("Hóa Đơn");
            listBoxChoices.Items.Add("Khách Hàng");
            listBoxChoices.Items.Add("Nhân Viên");
            listBoxChoices.Items.Add("Báo Cáo");
            listBoxChoices.Items.Add("Cài đặt");

            listBoxChoices.SelectedIndex = 0;
        }

        private void product_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            this.productTableAdapter2.Fill(this.didikeshopDataSet4.product);
            this.productTableAdapter1.Fill(this.didikeshopDataSet1.product);
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
            loaddata();            
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
                return;

            command = connection.CreateCommand();
            command.CommandText = "insert into product values('"+id.Text+"','" + tensp.Text + "','" + hang.Text + "','" + nhasx.Text + "','" + theloai.Text + "','" + mau.Text + "'" +
                ",'" + kichthuoc.Text + "','" + chatlieu.Text + "','" + gianhap.Text + "','" + giaban.Text + "','" + soluong.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
                return;

            command = connection.CreateCommand();
            command.CommandText = "update product set name='" + tensp.Text + "',hang='" + hang.Text + "',nhasx='" + nhasx.Text + "',theloai='" + theloai.Text + "',color='" + mau.Text + "'" +
                ",size=" + kichthuoc.Text + ",chatlieu='" + chatlieu.Text + "',gianhap=" + gianhap.Text + ",giaban=" + giaban.Text + ",soluong=" + soluong.Text + ",picture='"+anhsp.Image+"' where id='" + id.Text + "'";
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

        private void listBoxChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedChoice = listBoxChoices.SelectedItem.ToString();
        }
        bool CheckInput()
        {
            long result1, result2, result3, result4;
            if(id.Text==""||tensp.Text==""||hang.Text==""||nhasx.Text==""||theloai.Text==""||mau.Text==""||kichthuoc.Text==""||chatlieu.Text==""||gianhap.Text==""||giaban.Text==""||soluong.Text=="")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin","Thông báo");
                return false;
            }
            if (long.TryParse(gianhap.Text, out result1) == false || long.TryParse(giaban.Text, out result2) == false || long.TryParse(soluong.Text, out result3) == false || long.TryParse(kichthuoc.Text, out result4) == false) 
            {
                MessageBox.Show("Hãy nhập lại giá trị số","Thông báo");
                return false;
            }
            if (result1 <= 0 || result2 <= 0 || result3 < 0 || result4 <= 0)  
            {
                MessageBox.Show("Hãy kiểm tra lại dấu của số", "Thông báo");
                return false;
            }
            return true;
        }
        class ketnoi
        {

            public SqlConnection kn = new SqlConnection();
            public void kn_csdl()
            {
                string chuoikn = "Initial Catalog=SQLNCLI.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=QlCN;Data Source=.";

                kn.ConnectionString = chuoikn;
                kn.Open();
            }
            public string lay1giatri(string sql)
            {
                string kq = "";
                try
                {
                    kn_csdl();

                    SqlCommand sqlComm = new SqlCommand(sql, kn);
                    SqlDataReader r = sqlComm.ExecuteReader();
                    if (r.Read())
                    {
                        kq = r["tong"].ToString();
                    }
                }
                catch
                { }
                return kq;
            }


            public void dongketnoi()
            {
                if (kn.State == ConnectionState.Open)
                { kn.Close(); }
            }
            public DataTable bangdulieu = new DataTable();
            public DataTable laybang(string caulenh)
            {
                try
                {
                    kn_csdl();
                    SqlDataAdapter Adapter = new SqlDataAdapter(caulenh, kn);
                    DataSet ds = new DataSet();

                    Adapter.Fill(bangdulieu);
                }
                catch (System.Exception)
                {
                    bangdulieu = null;
                }
                finally
                {
                    dongketnoi();
                }

                return bangdulieu;
            }

            public int xulydulieu(string caulenhsql)
            {
                int kq = 0;
                try
                {
                    kn_csdl();
                    SqlCommand lenh = new SqlCommand(caulenhsql, kn);
                    kq = lenh.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //Thông báo lỗi ra!

                    kq = 0;
                }
                finally
                {
                    dongketnoi();
                }
                return kq;
            }
        }
        public void LoadGridByKeyword()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from product where name like '%" + tentimkiem.Text + "%' and theloai like '%" + loaisptk.Text + "%' and hang like '%" + hangtk.Text + "%' ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }
        private void loc_Click(object sender, EventArgs e)
        {
            LoadGridByKeyword();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id.ReadOnly = true;
            int i;
            i = dataGridView2.CurrentRow.Index;
            id.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            tensp.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            hang.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            nhasx.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            theloai.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            mau.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            kichthuoc.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            chatlieu.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            gianhap.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            giaban.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
            soluong.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();

            SqlCommand cm = new SqlCommand("select picture from product where id=" + id.Text + "", connection);
            string img = cm.ExecuteScalar().ToString();
            if (img==null||img.Length==0)
            {
                anhsp.Image=Properties.Resources.defaultImage;
            }
            else
                anhsp.Image = Image.FromFile(img);
        }

        private void anhsp_Click(object sender, EventArgs e)
        {

        }

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void loaisptk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
