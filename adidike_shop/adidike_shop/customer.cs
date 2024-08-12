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
using System.Security.Policy;
using System.IO;

namespace adidike_shop
{
    public partial class customer : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-3S25R88\SQLEXPRESS;Initial Catalog=didikeshop;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from customer";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public customer()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void customer_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.didikeshopDataSet2.customer);
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;

            tenkhachhang.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            gioitinh.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            ngaydangki.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            diachi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            gmail.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            sdt.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

            SqlCommand cm = new SqlCommand("select picture from customer where sdt=" + sdt.Text + "", connection);
            string img = cm.ExecuteScalar().ToString();
            if (img == null || img.Length == 0)
            {
                anh.Image = Properties.Resources.defaultImage;
            }
            else
            {
                //anhsp.Image = Image.FromFile(img);
            }
        }
        private bool IsSdtExists(string idValue)
        {
            bool exists = false;

            string connectionString = @"Data Source=DESKTOP-3S25R88\SQLEXPRESS;Initial Catalog=didikeshop;Integrated Security=True";
            string query = "SELECT COUNT(1) FROM customer WHERE sdt = @sdt";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sdt", idValue);

                    int count = (int)command.ExecuteScalar();
                    exists = count > 0;
                }
            }
            return exists;
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.StartsWith("0") && phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }
        private void them_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
                return;

            if (!IsValidPhoneNumber(sdt.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải bắt đầu bằng '0' và có đúng 10 ký tự.", "Thông báo");
                return;
            }
            if (IsSdtExists(sdt.Text))
            {
                MessageBox.Show("Số điện thoại này đã tồn tại, vui lòng nhập số khác", "Thông báo");
                return;
            }

            byte[] imageData = null;
            if (picture.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageData = ms.ToArray();
                }
            }

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO customer (tenkh, gioitinh, ngaydki, diachi, gmail, sdt, picture) " +
                                      "VALUES (@name, @gender, @registrationDate, @address, @email, @phone, @picture)";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = tenkhachhang.Text;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gioitinh.Text;
                command.Parameters.Add("@registrationDate", SqlDbType.NVarChar).Value = ngaydangki.Text;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = diachi.Text;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = gmail.Text;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = sdt.Text;

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
            command = connection.CreateCommand();
            command.CommandText = "delete from customer where sdt='" + sdt.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
                return;

            int i = dataGridView1.CurrentRow.Index;
            if (sdt.Text != dataGridView1.Rows[i].Cells[5].Value.ToString())
            {
                MessageBox.Show("Bạn không thể thay đổi số điện thoại", "Thông báo");
                return;
            }

            // Save picture
            byte[] imageData = null;
            if (picture.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageData = ms.ToArray();
                }
            }

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE customer SET tenkh = @name, gioitinh = @gender, ngaydki = @registrationDate, " +
                                      "diachi = @address, gmail = @email, picture = @picture " +
                                      "WHERE sdt = @phone";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = tenkhachhang.Text;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gioitinh.Text;
                command.Parameters.Add("@registrationDate", SqlDbType.NVarChar).Value = ngaydangki.Text;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = diachi.Text;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = gmail.Text;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = sdt.Text;

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

        bool CheckInput()
        {
            long result;
            if (tenkhachhang.Text == "" || gioitinh.Text == "" || ngaydangki.Text == "" || diachi.Text == "" || gmail.Text == "" || sdt.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông báo");
                return false;
            }
            if (long.TryParse(sdt.Text, out result) == false)
            {
                MessageBox.Show("Hãy nhập lại giá trị số", "Thông báo");
                return false;
            }
            if (result<100000000||result>=1000000000)
            {
                MessageBox.Show("Số điện thoại gồm 10 chữ số bắt đầu từ số 0", "Thông báo");
                return false;
            }
            return true;
        }
        public void LoadGridByKeyword()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from customer where tenkh like '%" + tentimkiem.Text + "%' and sdt like '%" + sdttxt.Text + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void lammoidgv_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loc_Click(object sender, EventArgs e)
        {
            LoadGridByKeyword();
        }

        private void lammoianh_Click(object sender, EventArgs e)
        {
            tenkhachhang.Clear();
            gioitinh.SelectedIndex = -1;
            ngaydangki.Value=DateTime.Now;
            diachi.Clear();
            gmail.Clear();
            sdt.Clear();
        }
    }
}
