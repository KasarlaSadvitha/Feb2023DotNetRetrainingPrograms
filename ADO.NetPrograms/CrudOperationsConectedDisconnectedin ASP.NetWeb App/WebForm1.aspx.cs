using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudOperationsConectedDisconnectedin_ASP.NetWeb_App
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection objConn;
        SqlCommand objCmd;
        IDataReader dr;
        string strCmd;
        string strConn = "Data Source=PRSQL;Initial Catalog=AdoDotNetDatabase;User ID=labuser;Password=Welcome123$";
        // InitializeComponent();
        DataTable dt = new DataTable();



        protected void Page_Load(object sender, EventArgs e)
        {
            objConn = new SqlConnection(strConn);
            objCmd = new SqlCommand();
            objCmd.Connection = objConn;
        }
        protected void btnSelect_Click(object sender, EventArgs e)
        {
           
            
            strCmd = @"Select * From Employees";
            objCmd.CommandText = strCmd;
            objConn.Open();
            dr = objCmd.ExecuteReader();
            dt.Load(dr);
            dgvEmployees.DataSource = dt;
            dgvEmployees.DataBind();
            dr.Close();
            objConn.Close();
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            strCmd = "Insert Into Employees values('" + txtName.Text + "','" + txtId.Text + "','" + txtSalary.Text + "','" + txtdid.Text + "')";
            objCmd.CommandText = strCmd;
            objConn.Open();
            int i = objCmd.ExecuteNonQuery();
            //dgvEmployees.DataBind();
            objConn.Close();
            //MessageBox.Show(i + " Records Inserted");
            mylblinsert.Text = i + " Records Inserted";
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            strCmd = "Update Employees Set  Salary = '" + txtSalary.Text + "' where ID = '" + txtId.Text + "'";
            objCmd.CommandText = strCmd;
            objConn.Open();
            int i = objCmd.ExecuteNonQuery();
            objConn.Close();
            // MessageBox.Show(i + " Records Updated");
            mylblinsert.Text = i + " Records Updated";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            strCmd = @"Delete Employees where Salary>'" + txtSalary.Text + "'";
            objCmd.CommandText = strCmd;
            objConn.Open();
            int i = objCmd.ExecuteNonQuery();
            objConn.Close();
           // MessageBox.Show(i + " Records Deleted");
        }
        protected void btnnDelete_Click(object sender, EventArgs e)
        {
            strCmd = @"Delete Employees where Salary>'" + txtSalary.Text + "'";
             objCmd.CommandText = strCmd;
            //DataTable deptTable = new DataTable();
            SqlDataAdapter dadapter = new SqlDataAdapter(strCmd, objConn);
            dadapter.Fill(dt);
            objConn.Open();
           // int i = objCmd.ExecuteNonQuery();
            //objConn.Close();
            // MessageBox.Show(i + " Records Deleted");
            mylblinsert.Text = " Records Deleted";
        }
    }
}