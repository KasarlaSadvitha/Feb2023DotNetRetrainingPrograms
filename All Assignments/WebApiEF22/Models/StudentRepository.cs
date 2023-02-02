using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiEF22.DataAccessLayer;

namespace WebApiEF22.Models
{
    public class StudentRepository : IStudentRepository
    {
        MyStuDAL dal = new MyStuDAL();
        public void CreateStudent(Student student)
        {
            dal.Students.Add(student);
            dal.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            //Student s= dal.Students.FirstOrDefault(x => x.Id == id);
            dal.Students.Remove(dal.Students.Find(id));
        }

        public IEnumerable<Student> GetAll()
        {
            return dal.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            Student s = dal.Students.Find(id);
            return s;
        }

        public bool UpdateStudent(int id,Student stud)
        {
          var student= dal.Students.Find(id);
           student.Name = stud.Name ;
            student.Subject = stud.Subject;
            student.Marks = stud.Marks;
            dal.SaveChanges();
            return true;
        }
    }
}