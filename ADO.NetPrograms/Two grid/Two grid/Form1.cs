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

namespace Two_grid
{
    public partial class Form1 : Form
    {
        string strConn = @"Data Source=PRSQL;Initial Catalog=""saikiran DB"";User ID=labuser;Password=Welcome123$";
        SqlConnection objConn;
        public Form1()
        {
            InitializeComponent();
            objConn = new SqlConnection(strConn);
            objConn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            string colno = dgvDepartments.CurrentRow.Cells[0].Value.ToString();
            short did = short.Parse(colno);
            string strCmd = @"Select * from Employee where DID='" + did + "'";
            SqlCommand strcmdemp = new SqlCommand(strCmd, objConn);
            DataTable empTable = new DataTable();



            SqlDataReader empReader = strcmdemp.ExecuteReader();
            empTable.Load(empReader);



            //SqlDataAdapter empAdapter =  new SqlDataAdapter(strcmdemp);
            //empAdapter.Fill(empTable);



            dgvEmployees.DataSource = empTable;





            float totalSalary = 0;
            foreach (DataRow row in empTable.Rows)
            {
                totalSalary += float.Parse(row["Salary"].ToString());
            }
            string deptName = dgvDepartments.CurrentRow.Cells[1].Value.ToString();
            lblEmployeeCount.Text = "Total Employees in " + deptName.TrimEnd() + "Department is " + empTable.Rows.Count;
            lblSalary.Text = "\n Totla Salary in " + deptName.TrimEnd() + "Department is" + totalSalary;



            MessageBox.Show("Total Salary " + new SqlCommand("select sum(Salary) from Employee where Employee.DID='" + did + "'", objConn).ExecuteScalar());

        }

        private void btnShowDepartments_Click(object sender, EventArgs e)
        {
            string strCmd = @"Select * from Departments";
            SqlCommand StrcmdDept = new SqlCommand(strCmd, objConn);
            DataTable deptTable = new DataTable();



            SqlDataReader deptReader = StrcmdDept.ExecuteReader();
            deptTable.Load(deptReader);
            dgvDepartments.DataSource = deptTable;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
