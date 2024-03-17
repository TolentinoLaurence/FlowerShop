using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeMacilalaHS
{
    public partial class EMPLOYEE : Form
    {
        public static EMPLOYEE instanse;

        DataTable table = new DataTable("table");
        int index;
        public EMPLOYEE()
        {
            InitializeComponent();
            instanse = this;
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtID.Text.Trim(), txtNAME.Text.Trim(), cbGENDER.Text.Trim(), cbPOSITION.Text.Trim(), txtADDRESS.Text.Trim()
                , txtCONTACT.Text.Trim(), dateTimePicker1.Text.Trim(), dateTimePicker2.Text.Trim());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            txtID.Text = row.Cells[0].Value.ToString();
            txtNAME.Text = row.Cells[1].Value.ToString();
            cbGENDER.Text = row.Cells[2].Value.ToString();
            cbPOSITION.Text = row.Cells[3].Value.ToString();
            txtADDRESS.Text = row.Cells[4].Value.ToString();
            txtCONTACT.Text = row.Cells[5].Value.ToString();
            dateTimePicker1.Text = row.Cells[6].Value.ToString();
            dateTimePicker2.Text = row.Cells[7].Value.ToString();
        }

        private void btmDELETE_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }

        private void EMPLOYEE_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("NAME", Type.GetType("System.String"));
            table.Columns.Add("GENDER", Type.GetType("System.String"));
            table.Columns.Add("POSITION", Type.GetType("System.String"));
            table.Columns.Add("ADDRESS", Type.GetType("System.String"));
            table.Columns.Add("CONTACT", Type.GetType("System.Int64"));
            table.Columns.Add("D.O.B", Type.GetType("System.String"));
            table.Columns.Add("D.O.H", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }

        private void btmUPDATE_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = txtID.Text;
            newdata.Cells[1].Value = txtNAME.Text;
            newdata.Cells[2].Value = cbGENDER.Text;
            newdata.Cells[3].Value = cbPOSITION.Text;
            newdata.Cells[4].Value = txtADDRESS.Text;
            newdata.Cells[5].Value = txtCONTACT.Text;
            newdata.Cells[6].Value = dateTimePicker1.Text;
            newdata.Cells[7].Value = dateTimePicker2.Text;
        }
    }
}
