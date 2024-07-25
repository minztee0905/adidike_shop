using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace thanhtoan
{
    public partial class pay : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=MINH-TRIET\SQLEXPRESS;Initial Catalog=adidikeshop;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table =  new DataTable();
        DataTable table1 = new DataTable(); 
        void loaddata()
        
            {
                command = connection.CreateCommand();  
                command.CommandText = "select * from listprd1";  
                adapter.SelectCommand = command;   
                table.Clear(); 
                adapter.Fill(table); 
                dgv2.DataSource = table; 
            }
        void loaddata1()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from listkhachhang";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dgv3.DataSource = table1;
        }


        public pay()
        {
            {
                InitializeComponent();
            }
        }

        public void LoadGridByKeyword()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from listprd1 where name like '%" + txtTenSanPham.Text + "%' and hang like '%" + txtNhaCungCap.Text + "%' ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv2.DataSource = table; 
        }

        public void Timkiemkhachhang()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from listkhachhang where sodienthoai = '" + txtSoDienThoai.Text + "' ";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dgv3.DataSource = table1;

            txtTenKhachHang.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtTenKhachHang.Text = dgv3.Rows[0].Cells[0].Value.ToString(); 
            txtDiaChi.Text = dgv3.Rows[0].Cells[2].Value.ToString();  
        }


        private void button12_Click(object sender, EventArgs e)
        {
            Timkiemkhachhang();
        }

        /* private void tim_Click(object sender, EventArgs e)
         {
             string phoneNumber = txtSoDienThoai.Text.Trim();
             DataRow[] foundRows = customersTable.Select($"PhoneNumber = '{phoneNumber}'");

             if (foundRows.Length > 0)
             {
                 // Nếu tìm thấy khách hàng, hiển thị thông tin
                 labelName.Text = foundRows[0]["Name"].ToString();
                 labelAddress.Text = foundRows[0]["Address"].ToString();
             }
             else
             {
                 // Nếu không tìm thấy khách hàng, hiển thị thông báo
                 labelName.Text = "Không tìm thấy khách hàng";
                 labelAddress.Text = "";
             }
         }*/

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
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void pay_Load_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            loaddata1();
            
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loc_Click(object sender, EventArgs e)
        {
            LoadGridByKeyword();
        }

        private void lammoi_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}

