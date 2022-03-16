using CurtainWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CurtainWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult CheckOut()
        {
            return View();
        }
        public IActionResult Confitrmation()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Elements()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Main()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult SingleBlog()
        {
            return View();
        }
        public IActionResult SingleProduct()
        {
            return View();
        }
    }
}
