using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssEmpDepDBFirstUsingForm
{
    public partial class Form1 : Form
    {
        static AdoDotNetDatabaseEntities edEntity = new AdoDotNetDatabaseEntities();
        static IEnumerable<Department> departmentList;
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
            int did = int.Parse(colno);
            var Query = (from emp in edEntity.Employees where emp.DID == did select emp).ToList();
            //@"Select * from Employees where DID='" + did + "'";
            dgvEmployees.DataSource = Query;

            float totalsalary = 0;

            foreach (var ee in Query)
            {

                totalsalary += float.Parse(ee.Salary.ToString());
            }
            string deptName = dgvDepartments.CurrentRow.Cells[1].Value.ToString();
            lblEmployeeCount.Text = "Total Employees in " + deptName.TrimEnd() + "Department is " + Query.Count;
            lblSalary.Text = "\n Totla Salary in " + deptName.TrimEnd() + "Department is" + totalsalary;
        }

        private void btnShowDepartments_Click(object sender, EventArgs e)
        {//DataTable boundTable = query.CopyToDataTable<DataRow>();
         //departmentList =from d in edEntity.Departments select d;
         //edEntity.Departments.Fill()
         //Simply convert ot list and assign it to grid
            var qquery = (from d in edEntity.Departments select d).ToList();
            dgvDepartments.DataSource = qquery;
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
