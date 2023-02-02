using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LinqToDataSet
{
    internal class Program
    {

        //static void UntypedDataSet()
        //{
        //    SqlConnection objConn = new SqlConnection();
        //    SqlCommand objCmd = new SqlCommand();
        //    string strConn = @"Data Source=PRSQL;Initial Catalog=AdoDotNetDatabase;User ID=labuser;Password=Welcome123$";
        //    string strCmd = "Select StuID , StuName , StuYear from Students";
        //    objConn.ConnectionString = strConn;
        //    objCmd.Connection = objConn;
        //    objCmd.CommandType = CommandType.Text;
        //    objCmd.CommandText=strCmd;

        //    SqlDataAdapter da = new SqlDataAdapter();
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = objCmd;
        //    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
        //    da.Fill(ds, "Students");
        //    DataTable stuTable = ds.Tables["Students"];

        //    // DataRow row = stuTable.NewRow();
        //    // row["StuID"] = 120;
        //    //row["StuName"]="Raghav";
        //    //row["StuYear"]=2023;
        //    //row["StuDID"]=6;
        //    //da.Update(stuTable);

        //    var query = from stu in stuTable.AsEnumerable()
        //                select new
        //                {
        //                   // ID = stu.Field<Int16>("StuID"),
        //                    Name= stu.Field<string>("StuName"),
        //                    //Department= stu.Field<Int16>("StuDID")
        //                };
        //    foreach(var e in query)
        //    {
        //       // Console.WriteLine("{0}\t" , e.ID);
        //        Console.WriteLine("{0}\t", e.Name);
        //        //Console.WriteLine("{0}\t", e.Department);

        //    }
        //}

        static void TypedDataSet()
        {
            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.StudentsTableAdapter studsAdapter = new DataSet1TableAdapters.StudentsTableAdapter();


            //StudentDataSetDataContext stu = new StudentDataSetDataContext();
            //StudentDataSetDataContextTableAdapters.StudentTableAdapters stuAda = StudentDataSetDataContextTableAdapters.StudentTableAdapters();
            //stuAda.Insert("Rajendra",1300,3);                      //dddddddddddddddddddddddddddd
            studsAdapter.Fill(ds.Students);

            var query = from s in ds.Students
                        select new
                        {
                            ID = s.StuID,
                            Name = s.StuName,
                            Department = s.StuDID,
                            Year = s.StuYear
                        };
            //StudentDataSet.StudentRows row = stu.Students.NewStudentsRow();
            //row.StuName="Himaja";
            //row.StuID=123;
            //row.StuDID =2;
            //row.StuYear=2030;
            // stu.Students.Rows.Add(row);
            //StudentTableAdapter.Update(stu.Students);

            foreach (var e in query)
            {
                Console.WriteLine("{0}\t", e.ID);
                Console.WriteLine("{0}\t", e.Name);
                Console.WriteLine("{0}\t", e.Year);
                Console.WriteLine("{0}\t", e.Department);
            }

        }

        static void twotablequery()
        {
            SqlConnection objconn1 = new SqlConnection();
            SqlCommand objcmd1 = new SqlCommand();
            string strconn1 = @"data source=prsql;initial catalog=adodotnetdatabase;user id=labuser;password=welcome123$";
            string strcmd1 = "select stuid , stuname , stuyear from students";
            objconn1.ConnectionString = strconn1;
            objcmd1.Connection = objconn1;
            objcmd1.CommandType = CommandType.Text;
            objcmd1.CommandText = strcmd1;

            SqlDataAdapter da = new sqldataadapter();
            dataset ds = new dataset();
            da.selectcommand = objcmd1;
            sqlcommandbuilder cmdbuilder = new sqlcommandbuilder(da);
            da.fill(ds, "students");
            datatable stutable = ds.tables["students"];

            strcmd1 = "select did , deptname from department";
            objcmd1.commandtext = strcmd1;
            da.fill(ds, "departments");
            datatable depttable = ds.tables["deparments"];

            var query = from s in stutable.asenumerable()
                        join d in depttable.asenumerable() on s.field<int>("studid") equals  //dddddddddddddd
                        d.field<int>("did")
                        orderby s.field<int>("stuid")
                        select new
                        {
                            id = s.field<int>("studid"),
                            name = s.field<string>("stuname"),
                            departmentid = d.field<int>("did"),
                            departmentname = d.field<string>("deptname")
                        };
            foreach (var e in query)
            {
                console.writeline("{0}\t", e.id);
                console.writeline("{0}\t", e.name);
                console.writeline("{0}\t", e.departmentid);
                console.writeline("{0}\t", e.departmentname);
            }
        }
        static void Main(string[] args)
        {
            //UntypedDataSet();
            Console.ReadKey();
            TypedDataSet();
        }
    }
}
