using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DBFirst_Crude_Operations_EmployeeDepartment
{
    
    internal class Program
    {
        static AdoDotNetDatabaseEntities1 EmpDepEntities = new AdoDotNetDatabaseEntities1();
        static string Name;
        //string gender;
        static decimal salary;


        //***********************************************
       
        static void DisplayAllEmployees()
        {
            List < Employee > employees = (from emp in EmpDepEntities.Employees
                                           select emp).ToList<Employee>();
            foreach (Employee emp in employees)
            {
                Console.WriteLine("ID :{0}", emp.ID);
                Console.WriteLine("NAME :{0}", emp.Name);
                Console.WriteLine("SALARY :{0}", emp.Salary);
                Console.WriteLine("********************************");
            }
        }

        
        static Employee EmployeesWithEmpId(int id)
        {
            List<Employee> list = (from emp in EmpDepEntities.Employees
                                   where emp.ID == id
                                   select emp).ToList<Employee>();
            return list[0];
        }
        static void PrintEmployeeDetails(int id)
        {
            //  Console.WriteLine("Enter Employee Id");
            //  int id = int.Parse(Console.ReadLine());
            var e = EmployeesWithEmpId(id);

            Console.WriteLine("ID ={0}\t", e.ID);
            Console.WriteLine("\nName ={0}\t", e.Name);
            Console.WriteLine("\nSalary ={0}\t", e.Salary);
        }

        static void UpdateEmployee(int id)
        {
            List<Employee> list = (from emp in EmpDepEntities.Employees
                                   where emp.ID == id
                                   select emp).ToList<Employee>();
            Console.WriteLine("Enter Name");
            list[0].Name = Console.ReadLine();

            Console.WriteLine("Enter Salary");

            list[0].Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department Id");
            list[0].ID = byte.Parse(Console.ReadLine());
            EmpDepEntities.SaveChanges();

            Console.WriteLine("Employee Details of EmpId {0} Updated Successfully", list[0].ID);
        }

       
        static void DeleteEmployee(int id)
        {
            List<Employee> list = (from emp in EmpDepEntities.Employees
                                   where emp.ID == id
                                   select emp).ToList<Employee>();
            EmpDepEntities.Employees.Remove(list[0]);
            EmpDepEntities.SaveChanges();
            Console.WriteLine("Employee with EmpId {0} Deleted Successfully", list[0].ID);
        }
      
        static void InsertEmployee()
        {
            Employee emp1 = new Employee { Name = "Mohit", Salary = 36745, ID = 1 };

            EmpDepEntities.Employees.Add(emp1);
            EmpDepEntities.SaveChanges();

            Console.WriteLine("Employee with EmpId {0} Insterted Successfully", emp1.ID);


        }
        
        
        static void PrintEmployeesAscendingOrder()

        {
            List < Employee > employees = (from emp in EmpDepEntities.Employees
                                     orderby emp.Salary
                                     select emp).ToList<Employee>();
            foreach (var e in employees)//salary
            {
                Console.WriteLine("ID ={0}\t", e.ID);
                Console.WriteLine("\nName ={0}\t", e.Name);
                Console.WriteLine("\nSalary ={0}\t", e.Salary);
                Console.WriteLine("\nDepartment Id ={0}\t", e.ID);
                Console.WriteLine("***************************************");
            }
        }
        static void Main(string[] args)
        {
            DisplayAllEmployees();
            Console.WriteLine("Enter Employee Id");
            int id = int.Parse(Console.ReadLine());
            PrintEmployeeDetails( id);
            InsertEmployee();
            UpdateEmployee(id);
             DeleteEmployee(id);
            PrintEmployeesAscendingOrder();

        }
    }
}
