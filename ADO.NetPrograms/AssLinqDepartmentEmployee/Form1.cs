using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssLinqDepartmentEmployee
{
    public partial class Form1 : Form
    {
        EmpDeptLinqToSqlClassDataContext dc = new EmpDeptLinqToSqlClassDataContext();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblEmployeeCount_Click(object sender, EventArgs e)
        {

        }

        private void lblSalary_Click(object sender, EventArgs e)
        {

        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            string colno = dgvDepartments.CurrentRow.Cells[0].Value.ToString();
            short did = short.Parse(colno);
            var Query  = from emp in dc.Employees where emp.DID == did select emp;
            //@"Select * from Employees where DID='" + did + "'";
            dgvEmployees.DataSource = Query;




            float totalsalary = 0;
            
            foreach (var ee in Query)
            {

                totalsalary += float.Parse(ee.Salary.ToString());
            }
            string deptName = dgvDepartments.CurrentRow.Cells[1].Value.ToString();
            lblEmployeeCount.Text = "Total Employees in " + deptName.TrimEnd() + "Department is "+Query.Count() ;
            lblSalary.Text = "\n Totla Salary in " + deptName.TrimEnd() + "Department is" + totalsalary;

           // MessageBox.Show("Total Salary " + (from emp in dc.Employees where emp.DID == did  Select sum(emp.Salary) ) ;
            //new SqlCommand("select sum(Salary) from Employees where Employees.DID='" + did + "'", objConn).ExecuteScalar());
        }

        private void btnShowDepartments_Click(object sender, EventArgs e)
        {
            dgvDepartments.DataSource = dc.Departments;
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
