﻿using ApolloClinic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApolloClinic.Areas.Main.Controllers
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

        public IActionResult Specialitati()
        {
            return View();
        }

        public IActionResult Medici()
        {
            return View();
        }

        public IActionResult Investigatii()
        {
            return View();
        }

        public IActionResult Abonamente()
        {
            return View();
        }

        public IActionResult Despre()
        {
            return View();
        }

        public IActionResult Contact()
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