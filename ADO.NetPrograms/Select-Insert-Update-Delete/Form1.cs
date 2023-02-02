using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Select_Insert_Update_Delete
{
    public partial class Form1 : Form
    {

        SqlConnection objConn;
        SqlCommand objCmd;
        IDataReader dr;
        string strCmd;
        string strConn = @"Data Source=PRSQL;Initial Catalog=Venkat;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
        public Form1()
        {
            
            InitializeComponent();
            objConn = new SqlConnection(strConn);
            objCmd = new SqlCommand();
            objCmd.Connection = objConn;
        }

        private void label1_Click(object sender, EventArgs e)//
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            strCmd = @"Select * From Employees";
            objCmd.CommandText = strCmd;
            objConn.Open();
            dr = objCmd.ExecuteReader();
            dt.Load(dr);
            dgvEmployee.DataSource = dt;
            dr.Close();
            objConn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            strCmd = "Insert Into Employees values('" + txtName.Text + "','" + txtID.Text + "','" + txtSalary.Text + "','" + txtDept.Text + "')";
            objCmd.CommandText = strCmd;
            objConn.Open();
            int i = objCmd.ExecuteNonQuery();
            objConn.Close();
            MessageBox.Show(i + " Records Inserted");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
        {
            strCmd = "Update Employees Set  Salary = '" + txtSalary.Text + "' where ID = '" + txtID.Text + "'";
            objCmd.CommandText = strCmd;
            objConn.Open();
            int i = objCmd.ExecuteNonQuery();
            objConn.Close();
            MessageBox.Show(i + " Records Updated");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        strCmd = @"Delete Employees where Salary>'" + txtSalary.Text + "'";
        objCmd.CommandText = strCmd;
        objConn.Open();
        int i = objCmd.ExecuteNonQuery();
        objConn.Close();
        MessageBox.Show(i + " Records Deleted");
    }
    }
}
