using ConfeccionCondor.Models;
using ConfeccionCondor.Models.ViewModels;
using ConfeccionCondor.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConfeccionCondor.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            try
            {
                List<ListEmployeesViewModel> listEmployees = Process.getEmployees();
                return View(listEmployees);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public ActionResult CreateEmployees()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployees(Employees model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Employees nuevoPaciente = Process.createEmployees(model);
                }
                return Redirect("~/Employees/");
         
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public ActionResult EditEmployees(int Id)
        {

            Employees getEmployeesById = Process.getEmployesBydId(Id); 
            return View(getEmployeesById);
        }
        [HttpPost]
        public ActionResult EditEmployees(Employees model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Employees nuevoPaciente = Process.editEmployees(model);
                }
                return Redirect("~/Employees/");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            try
            {

                Employees deleteEmployes = Process.deteleEmployes(Id);
                return Redirect("~/Employees/");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}