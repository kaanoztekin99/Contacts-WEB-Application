using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Product.Controllers
{
    public class EmployeeController : Controller
    {
        JobManager jobManager = new JobManager(new EfJobDal());
        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());

        // Index'e add view diyerek razor view -> use a layout page
        // shared dosyası altından UI Layout'umuzu seçtik ve yükledik.
        public IActionResult Index()
        {
            var values = employeeManager.GetEmployeesListWithJob();
            return View(values);
        }

        public IActionResult ListEmployee()
        {
            var values = JsonConvert.SerializeObject(employeeManager.TGetList());
            return Json(values);
        }

        public IActionResult GetByName(string name)
        {            
            var v = employeeManager.TGetByName(name);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }

        public IActionResult GetById(int id)
        {
            var v = employeeManager.TGetById(id);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }

        [HttpGet]
        public IActionResult AddEmployee() 
        {
            
            List<SelectListItem> values = (from x in jobManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JobID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee p) {
            EmployeeValidator validationRules = new EmployeeValidator();
            ValidationResult results = validationRules.Validate(p);

            if (results.IsValid)
            {
                employeeManager.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {

                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
       
        }

        public IActionResult DeleteEmployee(int id)
        {
            var value = employeeManager.TGetById(id);
            employeeManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateEmployee(int id) {
            List<SelectListItem> values = (from x in jobManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JobID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = employeeManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateEmployee(Employee p) {
            employeeManager.TUpdate(p);
            return RedirectToAction("Index");
        
        }



    }
}
