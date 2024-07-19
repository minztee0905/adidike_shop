using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adidike_shop
{
    public partial class product : Form
    {
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
            string inputText = textBox1.Text;

            string numericText = new string(inputText.Where(char.IsDigit).ToArray());

            if (long.TryParse(numericText, out long number))
            {
                string formattedText = number.ToString("N0");

                textBox1.TextChanged -= textBox1_TextChanged;

                textBox1.Text = formattedText;
                textBox1.SelectionStart = formattedText.Length;

                textBox1.TextChanged += textBox1_TextChanged;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string inputText = textBox2.Text;

            string numericText = new string(inputText.Where(char.IsDigit).ToArray());

            if (long.TryParse(numericText, out long number))
            {
                string formattedText = number.ToString("N0");

                textBox2.TextChanged -= textBox2_TextChanged;

                textBox2.Text = formattedText;
                textBox2.SelectionStart = formattedText.Length;

                textBox2.TextChanged += textBox2_TextChanged;
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string inputText = textBox3.Text;

            string numericText = new string(inputText.Where(char.IsDigit).ToArray());

            if (long.TryParse(numericText, out long number))
            {
                string formattedText = number.ToString("N0");

                textBox3.TextChanged -= textBox3_TextChanged;

                textBox3.Text = formattedText;
                textBox3.SelectionStart = formattedText.Length;

                textBox3.TextChanged += textBox3_TextChanged;
            }
        }

    }
}
