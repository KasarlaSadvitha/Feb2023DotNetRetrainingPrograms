using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiEF22.Models;

namespace WebApiEF22.Controllers
{
    public class StudentsController : ApiController
    {
        IStudentRepository repost= new StudentRepository();

        // GET: Students

        public void PostStudent(Student stu)
        {
            repost.CreateStudent(stu);
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return repost.GetAll();
        }
        public void PutStudent(int id,Student stu)
        {
            repost.UpdateStudent(id,stu);
        }
        public void DeleteStudent(int id )
        {
            repost.DeleteStudent(id);
        }

    }
}