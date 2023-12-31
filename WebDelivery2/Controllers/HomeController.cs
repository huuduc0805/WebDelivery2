﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebDelivery2.Models;

namespace WebDelivery2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
   
        public IActionResult Login()
        {
            return View();
        }

            public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Admin()
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