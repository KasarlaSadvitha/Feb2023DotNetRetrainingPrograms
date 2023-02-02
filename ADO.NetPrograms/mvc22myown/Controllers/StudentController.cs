using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc22myown.Models;
using mvc22myown.ViewModel;

namespace mvc22myown.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [Authorize]
        public ActionResult GetStudents()
        {

            StudentBusinessLayer  bla=new StudentBusinessLayer();
            List<Student> Stulist= bla.GetAllStudents();

            List<StudentViewModel> StuVMlist= new List<StudentViewModel>();
            foreach(Student s in Stulist)
            {
                StudentViewModel vm = new StudentViewModel();
                vm.vmId = s.StuId;
                vm.vmName = s.StuName;
                vm.vmSubject = s.StuSubject;

                StuVMlist.Add(vm);
            }

            return View(StuVMlist);
        }

        public ActionResult AddNew()
        {
            return View("CreateStudentview");
        }
        public ActionResult SaveStudent(Student s)
        {
            StudentBusinessLayer bla = new StudentBusinessLayer();
            bla.SaveStudent(s);
            return RedirectToAction("GetStudents");
        }

        [Authorize]
        public string SayHello()
        {
            return "Hello";
        }
    }
}