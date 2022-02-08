using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TimeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace TimeManagement.Controllers
{
    public class HomeController : Controller
    {
        private TaskFormContext _taskContext { get; set; }

        public HomeController(TaskFormContext something)
        {
            _taskContext = something;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Quadrants()
        {
            return View();
        }

        public IActionResult addTask()
        {
            return View();
        }

        public IActionResult viewTask()
        {
            return View();
        }

        public IActionResult Edit()
        {
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
