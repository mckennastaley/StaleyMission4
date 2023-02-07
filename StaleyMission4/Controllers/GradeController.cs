using Microsoft.AspNetCore.Mvc;
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

        //View for calculator page
        public IActionResult Calculator()
        {
            return View();
        }
    }
}
