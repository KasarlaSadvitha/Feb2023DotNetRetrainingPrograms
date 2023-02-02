using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc11.DataAccessLayer;

namespace mvc11.Models
{
    public class EmployeeBusinessLayer
    {
        MyCompanyContext empDAL;
        public EmployeeBusinessLayer()
        {
            empDAL = new MyCompanyContext();
        }
        public List<Employee> GetEmployees()
        {
            return empDAL.Employees.ToList();
        }
        
        public Employee SaveEmployee(Employee e)
        {
            empDAL.Employees.Add(e);
            empDAL.SaveChanges();
            return e;
        }

        public UserDetails Saveregister(UserDetails ud)
        {

            empDAL.userDetails.Add(ud);
            empDAL.SaveChanges();
            return ud;
        }

        public bool IsValidUser(UserDetails u)
        {
            var users= from emp in empDAL.userDetails where emp.UserName == u.UserName && emp.Password==u.Password select emp;
            
            //var users = empDAL.userDetails.FirstOrDefault(x=>x.UserName==u.UserName && x.Password==u.Password);
            if(users==null)
            {
                return false;
            }
            else
            {
                return true;
            }
            //if (u.UserName == "Dhiraj" && u.Password == "1234")
            // {
            //    return true;
            // }
            //else { return false; }
        }


    }
}