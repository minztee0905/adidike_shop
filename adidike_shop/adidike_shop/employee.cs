using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

        private void them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into employee values('" + tennv.Text + "','" + gioitinh.Text + "','" + ngaysinh.Text + "','" + diachi.Text + "','" + gmail.Text + "','" + sdt.Text + "','" + ngaylamviec.Text + "','" + chucvu.Text + "')";
            command.ExecuteNonQuery();
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

            command = connection.CreateCommand();
            command.CommandText = "update employee set tennv='" + tennv.Text + "',gioitinh='" + gioitinh.Text + "',ngaysinh='" + ngaysinh.Text + "',diachi='" + diachi.Text + "',gmail='" + gmail.Text + "'" +
                ",sdt='" + sdt.Text + "',chucvu='" + chucvu.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }
        bool CheckInput()
        {
            long result;
            if (tennv.Text == "" || gioitinh.Text == "" || ngaysinh.Text == "" || diachi.Text == "" || gmail.Text == "" || sdt.Text == "" || ngaylamviec.Text == "" || chucvu.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông báo");
                return false;
            }
            if (long.TryParse(sdt.Text, out result) == false)
            {
                MessageBox.Show("Hãy nhập lại giá trị số", "Thông báo");
                return false;
            }
            if (result < 100000000 || result >= 1000000000)
            {
                MessageBox.Show("Số điện thoại gồm 10 chữ số bắt đầu từ số 0", "Thông báo");
                return false;
            }
            return true;
        }

        private void lammoianh_Click(object sender, EventArgs e)
        {

        }

        private void lammoidgv_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        public void LoadGridByKeyword()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from employee where tennv like '%" + tentimkiem.Text + "%' and sdt like '%" + sdt.Text + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void loc_Click(object sender, EventArgs e)
        {
            LoadGridByKeyword();
        }
    }
}
