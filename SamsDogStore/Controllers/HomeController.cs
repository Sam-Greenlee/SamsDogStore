using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SamsDogStore.Models;
using Microsoft.AspNetCore.Authorization;

namespace SamsDogStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Welcome to the best dog store in town.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Got a question, send to the email below.";

            return View();
        }

        //Only allow registgered users to access this page
        [Authorize]
        public IActionResult Dogs()
        {
            ViewData["Message"] = "Here are our dogs ready for adoption.";

            return View();
        }

        //Only allow registgered users to access this page
        [Authorize]
        public IActionResult CustomerExperiences()
        {
            ViewData["Message"] = "Please comment on your experiences with our store.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
