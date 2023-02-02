using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc22myown.DataAccessLayer;

namespace mvc22myown.Models
{
    public class StudentBusinessLayer
    {
        StuDAL dal;
        public StudentBusinessLayer()
        {
            dal = new StuDAL();
        }
        public List<Student> GetAllStudents()
        {
            return dal.Students.ToList();
        }
        public Student SaveStudent(Student s)
        {
            dal.Students.Add(s);
            dal.SaveChanges();
            return s;
        }


        public UserDetail SaveUserDetails(UserDetail u)
        {
            dal.UserDetails.Add(u);
            dal.SaveChanges();
            return u;
        }


        public List<UserDetail> GetAllUserDetails()
        {
            return dal.UserDetails.ToList();
        }
        
        public bool IsValidUser(UserDetail u)
        {
            foreach(UserDetail ud in GetAllUserDetails())
            {
                if(ud.UserName== u.UserName && ud.Password==u.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}