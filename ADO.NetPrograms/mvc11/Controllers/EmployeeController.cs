using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc11.Models;
using mvc11.ViewModel;

namespace mvc11.Controllers

{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [Authorize]
        public ActionResult GetEmployees()
        {
            EmployeeRecordsViewModel empRecords = new EmployeeRecordsViewModel();
            List<EmployeeViewModel> empViewModels =new List<EmployeeViewModel>();
            EmployeeBusinessLayer empBla = new EmployeeBusinessLayer();
            List<Employee> employees = empBla.GetEmployees();
            foreach(Employee emp in employees)
            {
                EmployeeViewModel evm =new EmployeeViewModel();
                evm.EmployeeId = emp.EmployeeID;
                evm.EmployeeName = emp.FirstName + " " + emp.LastName;
                evm.Salary = (int)emp.Salary;
                if(emp.Salary > 18000)
                {
                    evm.SalaryColor = "Yellow";
                }
                else
                {
                    evm.SalaryColor = "green";
                }
                empViewModels.Add(evm);
            }
             empRecords.MyEmployees = empViewModels;
            return View(empRecords);
            //return View();
        }


        public ActionResult AddNew()
        {
          
          //return View("CreateEmployee");
          return View("CreateEmployee" , new CreateEmployeeViewModel());
        }
        public ActionResult SaveEmployee(Employee e,string BtnSubmit)
        {
            switch(BtnSubmit)
            {
                case "Save Employee":
                    if(ModelState.IsValid)
                    {
                        EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
                        empBal.SaveEmployee(e);
                        return RedirectToAction("GetEmployees");
                    }
                    else
                    {
                        CreateEmployeeViewModel vm = new CreateEmployeeViewModel();
                        vm.FirstName = e.FirstName;
                        vm.LastName = e.LastName;
                        if(e.Salary.HasValue)
                        {
                            vm.Salary = int.Parse(e.Salary.ToString());

                        }
                        else
                        {
                            vm.Salary = int.Parse(ModelState["Salary"].Value.AttemptedValue);
                        }
                        return View("CreateEmployee", vm);

                        
                    }

                case "Cancel":
                    return RedirectToAction("GetEmployees");
            }
            //EmployeeBusinessLayer empBla2 = new EmployeeBusinessLayer();
           // empBla2.SaveEmployee(e);
           // return RedirectToAction("GetEmployees");

            return new EmptyResult();

        }
        

        [Authorize]
        public string SayHello()
        {
            return "Hello";
        }

    }
}