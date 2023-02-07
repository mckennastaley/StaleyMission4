using Microsoft.AspNetCore.Mvc;
using StaleyMission4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaleyMission4.Controllers
{
    public class GradeController : Controller
    {

        //View for home (index) page
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        //View for calculator page
        public IActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        //Post for Calculator form
        public IActionResult Calculator(calcmodel model)
        {
            return View();
        }
    }
}
