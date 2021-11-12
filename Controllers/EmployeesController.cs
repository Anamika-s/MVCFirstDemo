using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Deepak",
                Department = "HR",
                Salary = 19000

            };
            ViewBag.employee = employee;
            return View();
        }

        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Deepak",
                Department = "HR",
                Salary = 19000
            };
            return View(employee);
        }

        public ActionResult List()
        {
            // Initialize Collection by usig Collection Initializer
            List<Employee> employeesList = new List<Employee>()

            { new Employee(){ Id=1, Name="Ajay", Department="HR", Salary=19000},
              new Employee(){ Id=2, Name="Jay", Department="Accts", Salary=21000},
              new Employee(){ Id=3, Name="Deepak", Department="HR", Salary=35000},
              new Employee(){ Id=4, Name="Geeta", Department="Sales", Salary=25000},
              new Employee(){ Id=5, Name="Manish", Department="Accts", Salary=28000},
              new Employee(){ Id=6, Name="Sagar", Department="Sales", Salary=21000},
              new Employee(){ Id=7, Name="Ravi", Department="HR", Salary=37000}

            };
            ViewBag.list = employeesList;
            return View();
        }
        public ActionResult PassingListToView()
        {
            // Initialize Collection by usig Collection Initializer
            List<Employee> employeesList = new List<Employee>()

            { new Employee(){ Id=1, Name="Ajay", Department="HR", Salary=19000},
              new Employee(){ Id=2, Name="Jay", Department="Accts", Salary=21000},
              new Employee(){ Id=3, Name="Deepak", Department="HR", Salary=35000},
              new Employee(){ Id=4, Name="Geeta", Department="Sales", Salary=25000},
              new Employee(){ Id=5, Name="Manish", Department="Accts", Salary=28000},
              new Employee(){ Id=6, Name="Sagar", Department="Sales", Salary=21000},
              new Employee(){ Id=7, Name="Ravi", Department="HR", Salary=37000}

            };
            
            return View(employeesList);
        }
    }
}