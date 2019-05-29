using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleDIApp.DominClass;
using SampleDIApp.Models;

namespace SampleDIApp.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeService employeeService;

        public string displayMessage(IEmployeeService _empserviceObj)
        {
            employeeService = _empserviceObj;
            string Message = employeeService.DisplayEmployees();
            return Message;
        }

        public IActionResult Index()
        {
            EmployeeService _empserviceObj = new EmployeeService();
            ViewData["Message"] = displayMessage(_empserviceObj);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
