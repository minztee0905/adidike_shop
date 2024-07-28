namespace adidike_shop
{
    partial class customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxChoices = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.lammoianh = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ngaydangki = new System.Windows.Forms.DateTimePicker();
            this.sdt = new System.Windows.Forms.TextBox();
            this.gmail = new System.Windows.Forms.TextBox();
            this.tenkhachhang = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diachi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gioitinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenkhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.didikeshopDataSet2 = new adidike_shop.didikeshopDataSet2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sdttxt = new System.Windows.Forms.TextBox();
            this.lammoidgv = new System.Windows.Forms.Button();
            this.loc = new System.Windows.Forms.Button();
            this.tentimkiem = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerTableAdapter = new adidike_shop.didikeshopDataSet2TableAdapters.customerTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.didikeshopDataSet2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxChoices
            // 
            this.listBoxChoices.FormattingEnabled = true;
            this.listBoxChoices.ItemHeight = 16;
            this.listBoxChoices.Location = new System.Drawing.Point(30, 24);
            this.listBoxChoices.Name = "listBoxChoices";
            this.listBoxChoices.Size = new System.Drawing.Size(154, 660);
            this.listBoxChoices.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.sua);
            this.panel2.Controls.Add(this.xoa);
            this.panel2.Controls.Add(this.lammoianh);
            this.panel2.Controls.Add(this.them);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(190, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 617);
            this.panel2.TabIndex = 38;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(64, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(226, 186);
            this.dataGridView2.TabIndex = 35;
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(179, 562);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(78, 31);
            this.sua.TabIndex = 34;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(95, 562);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(78, 31);
            this.xoa.TabIndex = 33;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // lammoianh
            // 
            this.lammoianh.Location = new System.Drawing.Point(263, 562);
            this.lammoianh.Name = "lammoianh";
            this.lammoianh.Size = new System.Drawing.Size(78, 31);
            this.lammoianh.TabIndex = 32;
            this.lammoianh.Text = "Làm mới";
            this.lammoianh.UseVisualStyleBackColor = true;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(11, 562);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(78, 31);
            this.them.TabIndex = 31;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.97033F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.02967F));
            this.tableLayoutPanel1.Controls.Add(this.ngaydangki, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sdt, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.gmail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tenkhachhang, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.diachi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gioitinh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 235);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 307);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // ngaydangki
            // 
            this.ngaydangki.CustomFormat = "MM/dd/yyyy";
            this.ngaydangki.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaydangki.Location = new System.Drawing.Point(104, 105);
            this.ngaydangki.Name = "ngaydangki";
            this.ngaydangki.Size = new System.Drawing.Size(228, 22);
            this.ngaydangki.TabIndex = 42;
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(104, 258);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(228, 22);
            this.sdt.TabIndex = 25;
            // 
            // gmail
            // 
            this.gmail.Location = new System.Drawing.Point(104, 207);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(228, 22);
            this.gmail.TabIndex = 24;
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.Location = new System.Drawing.Point(104, 3);
            this.tenkhachhang.Name = "tenkhachhang";
            this.tenkhachhang.Size = new System.Drawing.Size(228, 22);
            this.tenkhachhang.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 51);
            this.label21.TabIndex = 21;
            this.label21.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giới Tính";
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(104, 156);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(228, 22);
            this.diachi.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 51);
            this.label8.TabIndex = 4;
            this.label8.Text = "Gmail";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Đăng Ký";
            // 
            // gioitinh
            // 
            this.gioitinh.FormattingEnabled = true;
            this.gioitinh.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gioitinh.Location = new System.Drawing.Point(104, 54);
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Size = new System.Drawing.Size(228, 24);
            this.gioitinh.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 51);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 52);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số Điện Thoại";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(343, 40);
            this.label9.TabIndex = 29;
            this.label9.Text = "Thông Tin Khách Hàng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenkhDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.ngaydkiDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.gmailDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(545, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(767, 416);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tenkhDataGridViewTextBoxColumn
            // 
            this.tenkhDataGridViewTextBoxColumn.DataPropertyName = "tenkh";
            this.tenkhDataGridViewTextBoxColumn.HeaderText = "Tên Khách Hàng";
            this.tenkhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenkhDataGridViewTextBoxColumn.Name = "tenkhDataGridViewTextBoxColumn";
            this.tenkhDataGridViewTextBoxColumn.Width = 120;
            // 
            // gioitinhDataGridViewTextBoxColumn
            // 
            this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.gioitinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
            this.gioitinhDataGridViewTextBoxColumn.Width = 40;
            // 
            // ngaydkiDataGridViewTextBoxColumn
            // 
            this.ngaydkiDataGridViewTextBoxColumn.DataPropertyName = "ngaydki";
            this.ngaydkiDataGridViewTextBoxColumn.HeaderText = "Ngày Đăng Ký";
            this.ngaydkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaydkiDataGridViewTextBoxColumn.Name = "ngaydkiDataGridViewTextBoxColumn";
            this.ngaydkiDataGridViewTextBoxColumn.Width = 80;
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            this.diachiDataGridViewTextBoxColumn.Width = 120;
            // 
            // gmailDataGridViewTextBoxColumn
            // 
            this.gmailDataGridViewTextBoxColumn.DataPropertyName = "gmail";
            this.gmailDataGridViewTextBoxColumn.HeaderText = "Gmail";
            this.gmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gmailDataGridViewTextBoxColumn.Name = "gmailDataGridViewTextBoxColumn";
            this.gmailDataGridViewTextBoxColumn.Width = 120;
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sdtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            this.sdtDataGridViewTextBoxColumn.Width = 80;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.didikeshopDataSet2;
            // 
            // didikeshopDataSet2
            // 
            this.didikeshopDataSet2.DataSetName = "didikeshopDataSet2";
            this.didikeshopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sdttxt);
            this.panel4.Controls.Add(this.lammoidgv);
            this.panel4.Controls.Add(this.loc);
            this.panel4.Controls.Add(this.tentimkiem);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(545, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(767, 173);
            this.panel4.TabIndex = 40;
            // 
            // sdttxt
            // 
            this.sdttxt.Location = new System.Drawing.Point(373, 77);
            this.sdttxt.Name = "sdttxt";
            this.sdttxt.Size = new System.Drawing.Size(248, 22);
            this.sdttxt.TabIndex = 36;
            // 
            // lammoidgv
            // 
            this.lammoidgv.Location = new System.Drawing.Point(176, 105);
            this.lammoidgv.Name = "lammoidgv";
            this.lammoidgv.Size = new System.Drawing.Size(84, 40);
            this.lammoidgv.TabIndex = 35;
            this.lammoidgv.Text = "Làm mới";
            this.lammoidgv.UseVisualStyleBackColor = true;
            this.lammoidgv.Click += new System.EventHandler(this.lammoidgv_Click);
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(44, 105);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(84, 40);
            this.loc.TabIndex = 34;
            this.loc.Text = "Lọc";
            this.loc.UseVisualStyleBackColor = true;
            this.loc.Click += new System.EventHandler(this.loc_Click);
            // 
            // tentimkiem
            // 
            this.tentimkiem.Location = new System.Drawing.Point(24, 77);
            this.tentimkiem.Name = "tentimkiem";
            this.tentimkiem.Size = new System.Drawing.Size(248, 22);
            this.tentimkiem.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(370, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "Số Điện Thoại";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(761, 40);
            this.label13.TabIndex = 30;
            this.label13.Text = "Bộ lọc";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 16);
            this.label17.TabIndex = 31;
            this.label17.Text = "Tên Khách Hàng";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Pink;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(183, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1129, 41);
            this.label22.TabIndex = 38;
            this.label22.Text = "Khách Hàng";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(767, 22);
            this.label4.TabIndex = 41;
            this.label4.Text = "Danh sách khách hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBoxChoices);
            this.Name = "customer";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.customer_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.didikeshopDataSet2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxChoices;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tenkhachhang;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.ComboBox gioitinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button lammoidgv;
        private System.Windows.Forms.Button loc;
        private System.Windows.Forms.TextBox tentimkiem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox gmail;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button lammoianh;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox sdttxt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label4;
        private didikeshopDataSet2 didikeshopDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private didikeshopDataSet2TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DateTimePicker ngaydangki;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
    }
}