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
    public partial class DashBoard : Form
    {
        public static DashBoard instance;
        public DashBoard()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMPLOYEE Employee = new EMPLOYEE();
            Employee.Show();
            this.Hide();
        }
    }
}
