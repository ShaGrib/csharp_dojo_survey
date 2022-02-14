﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dojo_survey.Models;

namespace dojo_survey.Controllers
{
    public class HomeController : Controller
    {
        public static Ninja sResults = new Ninja();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.sResults = sResults;
            return View();
        }

        [HttpPost("survey")]
        public IActionResult Survey(Ninja newNinja)
        {
            sResults = newNinja;
            ViewBag.sResults = sResults;
            return View("Result", model: sResults);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
