﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATV_3_UC5.Models;

namespace ATV_3_UC5.Controllers
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

        public IActionResult Serviços()
        {
            return View();
        }

         public IActionResult Contato()
        {
            return View();
        }

        public IActionResult SalvarMensagem(Mensagem m)
        {
            return View("ConfirmarMsg", m);
        }

    
    }
}
