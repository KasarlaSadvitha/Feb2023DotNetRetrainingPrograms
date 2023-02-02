using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiEF22.Models
{
    internal interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetStudentById(int id);
        void DeleteStudent(int id);
        void CreateStudent(Student student);
        bool UpdateStudent(int id, Student stud);


    }
}
