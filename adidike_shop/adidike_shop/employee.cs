using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adidike_shop
{
    public partial class employee : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-3S25R88\SQLEXPRESS;Initial Catalog=didikeshop;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from employee";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public employee()
        {
            InitializeComponent();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.didikeshopDataSet3.employee);
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;

            tennv.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            gioitinh.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            ngaysinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            diachi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            gmail.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            sdt.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            ngaylamviec.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            chucvu.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }
        private bool IsIdExists(string idValue)
        {
            bool exists = false;

            string connectionString = @"Data Source=DESKTOP-3S25R88\SQLEXPRESS;Initial Catalog=didikeshop;Integrated Security=True";
            string query = "SELECT COUNT(1) FROM employee WHERE sdt = @sdt";

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
            if (IsIdExists(sdt.Text))
            {
                MessageBox.Show("Số điện thoại này đã tồn tại, vui lòng nhập số khác", "Thông báo");
                return;
            }

            byte[] imageData = null;
            if (anh.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    anh.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageData = ms.ToArray();
                }
            }

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO employee (tennv, gioitinh, ngaysinh, diachi, gmail, sdt, ngaylamviec, chucvu, picture) " +
                                      "VALUES (@name, @gender, @birthdate, @address, @email, @phone, @hiredate, @position, @picture)";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = tennv.Text;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gioitinh.Text;
                command.Parameters.Add("@birthdate", SqlDbType.NVarChar).Value = ngaysinh.Text;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = diachi.Text;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = gmail.Text;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = sdt.Text;
                command.Parameters.Add("@hiredate", SqlDbType.NVarChar).Value = ngaylamviec.Text;
                command.Parameters.Add("@position", SqlDbType.NVarChar).Value = chucvu.Text;

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
            command.CommandText = "delete from employee where sdt='" + sdt.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
                return;

            int i;
            i = dataGridView1.CurrentRow.Index;
            if (sdt.Text != dataGridView1.Rows[i].Cells[5].Value.ToString())
            {
                MessageBox.Show("Bạn không thể thay đổi số điện thoại", "Thông báo");
                return;
            }

            // Save picture
            byte[] imageData = null;
            if (anh.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    anh.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageData = ms.ToArray();
                }
            }

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE employee (tennv, gioitinh, ngaysinh, diachi, gmail, sdt, ngaylamviec, chucvu, picture) " +
                      "VALUES (@name, @gender, @birthdate, @address, @email, @phone, @hiredate, @position, @picture)";

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = tennv.Text;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gioitinh.Text;
                command.Parameters.Add("@birthdate", SqlDbType.NVarChar).Value = ngaysinh.Text;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = diachi.Text;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = gmail.Text;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = sdt.Text;
                command.Parameters.Add("@hiredate", SqlDbType.NVarChar).Value = ngaylamviec.Text;
                command.Parameters.Add("@position", SqlDbType.NVarChar).Value = chucvu.Text;

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
            if (tennv.Text == "" || gioitinh.Text == "" || ngaysinh.Text == "" || diachi.Text == "" || gmail.Text == "" || sdt.Text == "" || ngaylamviec.Text == "" || chucvu.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông báo");
                return false;
            }
            return true;
        }

        private void lammoidgv_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        public void LoadGridByKeyword()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from employee where tennv like '%" + tentimkiem.Text + "%' and sdt like '%" + sdttxt.Text + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void loc_Click(object sender, EventArgs e)
        {
            LoadGridByKeyword();
        }

        private void lammoi_Click(object sender, EventArgs e)
        {
            tennv.Clear();
            gioitinh.SelectedIndex = -1;
            diachi.Clear();
            gmail.Clear();
            sdt.Clear();
            chucvu.SelectedIndex = -1;
        }
    }
}
