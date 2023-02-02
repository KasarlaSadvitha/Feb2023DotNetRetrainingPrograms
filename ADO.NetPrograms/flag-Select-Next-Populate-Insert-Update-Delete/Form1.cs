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

namespace flag_Select_Next_Populate_Insert_Update_Delete
{
    public partial class Form1 : Form
    {
        string strConn = @"Data Source=PRSQL;Initial Catalog=AdoDotNetDatabase;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
        SqlConnection objConn;
        string strSelect = @"Select * From Employees";
        string strInsert;
        string strUpdate;
        string strDelete;
        SqlCommand selectCommand;
        SqlCommand insertCommand;
        SqlCommand updateCommand;
        SqlCommand deleteCommand;
        SqlDataReader dr;
        bool flag = true;

        public Form1()
        {
            objConn = new SqlConnection(strConn);
            selectCommand = new SqlCommand(strSelect, objConn);
            insertCommand = new SqlCommand(strInsert);
            updateCommand = new SqlCommand(strUpdate);
            deleteCommand = new SqlCommand(strDelete);
            objConn.Open();
            dr = selectCommand.ExecuteReader();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDept_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (objConn.State == ConnectionState.Closed)
                {
                    objConn.Open();
                    dr = selectCommand.ExecuteReader();
                }
                if (dr.Read())
                {
                    txtID.Text = dr["ID"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtSalary.Text = dr["Salary"].ToString();
                    txtDept.Text = dr["DID"].ToString();
                    flag = false;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dr != null && !dr.IsClosed)
            {
                if (dr.Read())
                {
                    txtID.Text = dr["ID"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtSalary.Text = dr["Salary"].ToString();
                    txtDept.Text = dr["DID"].ToString();
                }
                else
                {
                    dr.Close();
                    objConn.Close();
                    MessageBox.Show("All Record Displayed");
                }
            }
            else
            {
                MessageBox.Show("Click Select Button First");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.strInsert = @"Insert Into Employees values('" + txtName.Text + "','" + txtID.Text + "','" + txtSalary.Text + "','" + txtDept.Text + "')";
            insertCommand.CommandText = strInsert;
            insertCommand.Connection = objConn;
            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
            }
            if (dr != null && !dr.IsClosed)
            {
                dr.Close();
            }
            MessageBox.Show(insertCommand.ExecuteNonQuery().ToString() + " Record Inserted");
            objConn.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.strUpdate = "Update Employees Set  Salary = '" + txtSalary.Text + "' where ID = '" + txtID.Text + "'";
            updateCommand.CommandText = strUpdate;
            updateCommand.Connection = objConn;
            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
            }
            if (dr != null && !dr.IsClosed)
            {
                dr.Close();
            }
            MessageBox.Show(updateCommand.ExecuteNonQuery().ToString() + " Record Updated");
            objConn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.strDelete = @"Delete From Employees Where ID = '" + txtID.Text + "'";
            deleteCommand.CommandText = strDelete;
            deleteCommand.Connection = objConn;
            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
            }
            if (dr != null && !dr.IsClosed)
            {
                dr.Close();
            }
            MessageBox.Show(deleteCommand.ExecuteNonQuery().ToString() + " Record Deleted");
            objConn.Close();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
            }
            if (dr != null && !dr.IsClosed)
            {
                DataTable empTable = new DataTable();
                empTable.Load(dr);
                dgvEmployees.DataSource = empTable;
                dr.Close();
                objConn.Close();



            }
            else
            {
                dr = selectCommand.ExecuteReader();
                DataTable empTable = new DataTable();
                empTable.Load(dr);
                dgvEmployees.DataSource = empTable;
                dr.Close();
                objConn.Close();
            }

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
