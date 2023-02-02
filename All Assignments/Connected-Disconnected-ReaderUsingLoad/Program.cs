using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Connected_Disconnected_ReaderUsingLoad
{
    internal class Program
    {

        static void Connected()
        {



            string strCon = "Data Source=PRSQL;Initial Catalog=AdoDotNetDatabase;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
            // string connectionString = @"Data Source=PRSQL;User ID=labuser;Password=Welcome123$;Initial Catalog=EmployeeDB;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = strCon;





            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            string strCommand = "select * from Employees";
            command.CommandText = strCommand;





            SqlDataReader reader;





            connection.Open();
            reader = command.ExecuteReader(); // Returns data reader object which will refer to the result set fro read operations 
            Console.Write("ID");
            Console.Write("\t Name");
            Console.Write("\t Salary");
            Console.WriteLine("\t Department ID");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine(reader.Read());



            while (reader.Read())
            {
                Console.Write(reader[0]);
                Console.Write("\t" + reader["Name"]);
                Console.Write("\t" + reader["Salary"]);
                Console.WriteLine("\t" + reader["DID"]);
            }
            Console.WriteLine("---------------------------------------");





            reader.Close();
            connection.Close();





        }
        static void Disconnected()
        {
            string strCon = @"Data Source=PRSQL;Initial Catalog=AdoDotNetDatabase;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
            SqlConnection conn = new SqlConnection(strCon);
            conn.ConnectionString = strCon;



            SqlCommand Objcmd = conn.CreateCommand();
            string strcmd = "Select * from Employees";
            Objcmd.Connection = conn;
            Objcmd.CommandType = System.Data.CommandType.Text;
            Objcmd.CommandText = strcmd;



            SqlDataAdapter Objadapter = new SqlDataAdapter();
            Objadapter.SelectCommand = Objcmd;
            System.Data.DataSet ds = new System.Data.DataSet();
            Objadapter.Fill(ds, "Employees");



            System.Data.DataTable empTable = ds.Tables["Employees"];



        Console.Write("ID");
            Console.Write("\tNAME");
            Console.Write("\t SALARY");
            Console.WriteLine("\tDEPT_ID");




            Console.WriteLine("------------------------------");



            foreach (DataRow row in empTable.Rows)
            {
                Console.Write(row[0]);
                Console.Write("\t" + row["Name"]);
                Console.Write(row["Salary"]);
                Console.WriteLine("\t" + row["DID"]);
            }



    Console.WriteLine("******************************");








        }

static void AutomaticConnection()
{



    string strCon = @"Data Source=PRSQL;Initial Catalog=AdoDotNetDatabase;Persist Security Info=True;User ID=labuser;Password=Welcome123$";
    // string connectionString = @"Data Source=PRSQL;User ID=labuser;Password=Welcome123$;Initial Catalog=EmployeeDB;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    SqlConnection connection = new SqlConnection();
    connection.ConnectionString = strCon;





    SqlCommand command = new SqlCommand();
    command.Connection = connection;
    command.CommandType = CommandType.Text;
    string strCommand = @"select * from Employees";
    command.CommandText = strCommand;





    SqlDataReader reader;







    connection.Open();
    reader = command.ExecuteReader(); // Returns data reader object which will refer to the result set fro read operations



    System.Data.DataTable empTable = new DataTable();
    empTable.Load(reader);



    Console.Write("ID");
    Console.Write("\t Name");
    Console.Write("\t Salary");
    Console.WriteLine("\t Department ID");
    Console.WriteLine("---------------------------------------");





    foreach (DataRow row in empTable.Rows)
    {
        Console.Write(row[0]);
        Console.Write("\t" + row["Name"]);
        Console.Write(row["Salary"]);
        Console.WriteLine("\t" + row["DID"]);
    }
    Console.WriteLine("---------------------------------------");





    reader.Close();
    connection.Close();





}
static void Main(string[] args)
        {
            Connected();
            Console.WriteLine("---------------------------------");
             Disconnected();
            Console.WriteLine("---------------------------------");
            AutomaticConnection();
            Console.WriteLine("---------------------------------");
            Console.ReadKey();




        }

    }
}
