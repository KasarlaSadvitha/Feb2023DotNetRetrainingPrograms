using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBFirstLinqinAsp.Net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static AdoDotNetDatabaseEntities1 edEntity = new AdoDotNetDatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShowDepartments_Click(object sender, EventArgs e)
        {//DataTable boundTable = query.CopyToDataTable<DataRow>();
         //departmentList =from d in edEntity.Departments select d;
         //edEntity.Departments.Fill()
         //Simply convert ot list and assign it to grid
            var qquery = (from d in edEntity.Departments select d).ToList();
            dgvDepartments.DataSource = qquery;
            dgvDepartments.DataBind();
        }

        protected void btnShowEmployees_Click(object sender, EventArgs e)
        {
           // string currentValue =(string) dgvDepartments.SelectedValue;

           // int rowIndex = int.Parse(e.CommandArgument.ToString());
            // string val = (string)dgvDepartments.DataKeys[rowIndex]["DID"];


            string colno = dgvDepartments.CurrentRow.Cells[0].Value.ToString();
            int did = int.Parse(colno);
            var Query = (from emp in edEntity.Employees where emp.DID == did select emp).ToList();
            //@"Select * from Employees where DID='" + did + "'";
            dgvEmployees.DataSource = Query;
            dgvEmployees.DataBind();
            float totalsalary = 0;

            foreach (var ee in Query)
            {

                totalsalary += float.Parse(ee.Salary.ToString());
            }
            string deptName = dgvDepartments.CurrentRow.Cells[1].Value.ToString();
            lblEmployeeCount.Text = "Total Employees in " + deptName.TrimEnd() + "Department is " + Query.Count;
            lblSalary.Text = "\n Totla Salary in " + deptName.TrimEnd() + "Department is" + totalsalary;
        }
    }
}