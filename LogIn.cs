using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeMacilalaHS
{
    public partial class LogIn : Form
    {
        public static LogIn instance;
        public LogIn()
        {
            InitializeComponent();
            instance = this;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            

            if (textBox1.Text == "admin" && textBox2.Text == "admin123")
            {
                dashBoard.Show();
                this.Hide();

            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please enter your usernane abd password");
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
