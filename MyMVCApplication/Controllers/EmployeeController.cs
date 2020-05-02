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
        
        public ActionResult Details()
        {

            EmployeeContext employeeContext = new EmployeeContext();
            //Employee employee = employeeContext.Employees.FirstOrDefault(e => e.Id == id);
            return  View(employeeContext.Employees); 
        }
        public ActionResult Edit(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee=employeeContext.Employees.FirstOrDefault()

        }
}