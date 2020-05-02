using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApplication.Models;

namespace MyMVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
         EmployeeContext employeeContext = new EmployeeContext();
        public ActionResult Details()
        {
            
            return View(employeeContext.Employees);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(employeeContext.Employees.FirstOrDefault(e => e.Id == id));
        }
        [HttpPut]
        public ActionResult Edit(int id,Employee newEmployee)
        {            
            Employee employee = employeeContext.Employees.FirstOrDefault(e=> e.Id == id);
            employee.Name = newEmployee.Name;
            employee.Address = newEmployee.Address;
            employee.Email = newEmployee.Email;
            employee.Age = newEmployee.Age;
            employeeContext.SaveChanges();

            return RedirectToAction("Details");

        }
    }
}