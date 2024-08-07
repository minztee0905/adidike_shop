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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

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
            int selectionStart = giaban.SelectionStart;
            int selectionLength = giaban.SelectionLength;

            // xoa phan cach
            string text = giaban.Text.Replace(".", "").Replace(",", "");

            if (int.TryParse(text, out int number))
            {
                // format
                giaban.Text = number.ToString("N0", CultureInfo.InvariantCulture);
                //
                giaban.SelectionStart = selectionStart;
                giaban.SelectionLength = selectionLength;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = gianhap.SelectionStart;
            int selectionLength = gianhap.SelectionLength;

            // xoa phan cach
            string text = gianhap.Text.Replace(".", "").Replace(",", "");

            if (int.TryParse(text, out int number))
            {
                // format
                gianhap.Text = number.ToString("N0", CultureInfo.InvariantCulture);
                //
                gianhap.SelectionStart = selectionStart;
                gianhap.SelectionLength = selectionLength;
            }
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
        private bool IsIdExists(string idValue)
        {
            bool exists = false;

            string connectionString = @"Data Source=DESKTOP-3S25R88\SQLEXPRESS;Initial Catalog=didikeshop;Integrated Security=True";
            string query = "SELECT COUNT(1) FROM product WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", idValue);

                    int count = (int)command.ExecuteScalar();
                    exists = count > 0;
                }
            }
            return exists;
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
                return;
            if (IsIdExists(id.Text))
            {
                MessageBox.Show("ID này đã tồn tại, vui lòng nhập ID khác", "Thông báo");
                return;
            }

            string text1 = gianhap.Text.Replace(".", "").Replace(",", "");
            int.TryParse(text1, out int number1);

            string text2 = giaban.Text.Replace(".", "").Replace(",", "");
            int.TryParse(text2, out int number2);

            //++ Save picture
            byte[] imageData = null;
            if (anhsp.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    anhsp.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageData = ms.ToArray();
                }
            }

            //-- 
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO product (id, name, hang, nhasx, theloai, color, size, chatlieu, gianhap, giaban, soluong, picture) " +
                                      "VALUES (@id, @name, @hang, @nhasx, @theloai, @color, @size, @chatlieu, @gianhap, @giaban, @soluong, @picture)";

                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id.Text;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = tensp.Text;
                command.Parameters.Add("@hang", SqlDbType.NVarChar).Value = hang.Text;
                command.Parameters.Add("@nhasx", SqlDbType.NVarChar).Value = nhasx.Text;
                command.Parameters.Add("@theloai", SqlDbType.NVarChar).Value = theloai.Text;
                command.Parameters.Add("@color", SqlDbType.NVarChar).Value = mau.Text;
                command.Parameters.Add("@size", SqlDbType.NVarChar).Value = kichthuoc.Text;
                command.Parameters.Add("@chatlieu", SqlDbType.NVarChar).Value = chatlieu.Text;
                command.Parameters.Add("@gianhap", SqlDbType.Int).Value = number1;
                command.Parameters.Add("@giaban", SqlDbType.Int).Value = number2;
                command.Parameters.Add("@soluong", SqlDbType.NVarChar).Value = soluong.Text;

                if (imageData != null)
                {
                    command.Parameters.Add("@picture", SqlDbType.VarBinary).Value = imageData;
                }
                else
                {
                    command.Parameters.Add("@picture", SqlDbType.VarBinary).Value = DBNull.Value;
                }
                command.ExecuteNonQuery();
            }
            loaddata();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
                return;

            int i;
            i = dataGridView2.CurrentRow.Index;
            if (id.Text != dataGridView2.Rows[i].Cells[0].Value.ToString())
            {
                MessageBox.Show("Bạn không thể thay đổi ID", "Thông báo");
                return;
            }

            string text1 = gianhap.Text.Replace(".", "").Replace(",", "");
            int.TryParse(text1, out int number1);

            string text2 = giaban.Text.Replace(".", "").Replace(",", "");
            int.TryParse(text2, out int number2);

            // Save picture
            byte[] imageData = null;
            if (anhsp.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    anhsp.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageData = ms.ToArray();
                }
            }

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE product SET name=@name, hang=@hang, nhasx=@nhasx, theloai=@theloai, color=@color, size=@size, chatlieu=@chatlieu, gianhap=@gianhap, giaban=@giaban, soluong=@soluong, picture=@picture WHERE id=@id";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = tensp.Text;
                command.Parameters.Add("@hang", SqlDbType.NVarChar).Value = hang.Text;
                command.Parameters.Add("@nhasx", SqlDbType.NVarChar).Value = nhasx.Text;
                command.Parameters.Add("@theloai", SqlDbType.NVarChar).Value = theloai.Text;
                command.Parameters.Add("@color", SqlDbType.NVarChar).Value = mau.Text;
                command.Parameters.Add("@size", SqlDbType.NVarChar).Value = kichthuoc.Text;
                command.Parameters.Add("@chatlieu", SqlDbType.NVarChar).Value = chatlieu.Text;
                command.Parameters.Add("@gianhap", SqlDbType.Int).Value = number1;
                command.Parameters.Add("@giaban", SqlDbType.Int).Value = number2;
                command.Parameters.Add("@soluong", SqlDbType.NVarChar).Value = soluong.Text;
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id.Text;

                // picture
                if (imageData != null)
                {
                    command.Parameters.Add("@picture", SqlDbType.VarBinary).Value = imageData;
                }
                else
                {
                    command.Parameters.Add("@picture", SqlDbType.VarBinary).Value = DBNull.Value;
                }
                command.ExecuteNonQuery();
            }
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
            if(id.Text==""||tensp.Text==""||hang.Text==""||nhasx.Text==""||theloai.Text==""||mau.Text==""||kichthuoc.Text==""||chatlieu.Text==""||gianhap.Text==""||giaban.Text==""||soluong.Text=="")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin","Thông báo");
                return false;
            }
            if ((!string.IsNullOrEmpty(gianhap.Text) && gianhap.Text[0] == '-') || (!string.IsNullOrEmpty(giaban.Text) && giaban.Text[0] == '-'))  
            {
                MessageBox.Show("Hãy kiểm tra lại dấu của số", "Thông báo");
                return false;
            }
            return true;
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

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
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
            {
                //anhsp.Image = Image.FromFile(img);
            }
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void anhsp_Click_1(object sender, EventArgs e)
        {

        }

        private void lammoi_Click(object sender, EventArgs e)
        {
            id.Clear();
            tensp.Clear();
            hang.SelectedIndex = -1;
            nhasx.SelectedIndex = -1;
            theloai.SelectedIndex = -1;
            mau.SelectedIndex = -1;
            kichthuoc.SelectedIndex = -1;
            chatlieu.SelectedIndex = -1;
            id.Clear();
            gianhap.Clear();
            giaban.Clear();
            soluong.Clear();
        }
    }
}
