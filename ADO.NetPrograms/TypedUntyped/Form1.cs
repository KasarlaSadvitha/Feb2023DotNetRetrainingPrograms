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

namespace TypedUntyped
{
    public partial class Form1 : Form
    {
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            string strConn = @"Data Source=PRSQL;Initial Catalog=AdoDotNetDatabase;User ID=labuser;Password=Welcome123$";
            objConn =new SqlConnection(strConn);
            string strcmdSelect = @"select * from Department";
            objCmd =new SqlCommand(strcmdSelect , objConn);

            da = new SqlDataAdapter();
            da.SelectCommand = objCmd;
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            ds=new DataSet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDisplayTyped_Click(object sender, EventArgs e)
        {
            EmployeeTypedDataSet etds = new EmployeeTypedDataSet();
            da.Fill(etds,"Department");
            txtName.Text = etds.Department[0].DeptName;
            //etds.Employees[0].ID=54;
            //da.Update(etds.Tables["Employees"]);
        }

        private void btnDisplayUntyped_Click(object sender, EventArgs e)
        {
            da.Fill(ds, "Department");
            txtName.Text = (string)ds.Tables["Department"].Rows[0]["DeptName"];
            dgvEmployees.DataSource = ds;
            dgvEmployees.DataMember = "Department";
        }

        private void btnUpdateUntyped_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["Department"];
            DataRow row = dt.Rows[2];
            row["ID"] = "Dhiraj";
            MessageBox.Show((string)ds.Tables["Department"].Rows[2]["ID"]);

        }
    }
}
