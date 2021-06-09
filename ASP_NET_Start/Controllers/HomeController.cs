using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP_NET_Start.Models;

namespace ASP_NET_Start.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //var word = "to MVC";
            //ViewBag.Word = word;
            /*var user = new User
            {
                Name = "Name",
                Lastname = "LastName"
            };*/
            //return View();
            //return View(user);
            return View(new User("UserName", "UserLastname"));
        }

        [HttpPost]
        public IActionResult Edit([FromForm] User user)
        {
            /*if (string.IsNullOrEmpty(user.Name))
            {

            }

            if (string.IsNullOrEmpty(user.Lastname))
            {

            }*/
            user.Name += "edited";
            user.Lastname += "edited";

            //return View(user);
            //return Index();
            return View(user);
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

        public IActionResult ShowUser(int age)
        {
            if (age > 18)
            {
                return View(new User("Name_18", "Lastname_18"));
            }
            else
            {
                return View(new User("Name", "Lastname"));
            }
        }
    }
}
