﻿using SIS.HTTP;
using SIS.HTTP.Logging;
using SIS.HTTP.Response;
using SIS.MvcFramework;
using SulsApp.Services;
using SulsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SulsApp.Controllers
{
    class HomeController : Controller
    {
        private readonly ILogger logger;

        public HomeController(ILogger logger)
        {
            this.logger = logger;
        }

        [HttpGet("/")]
        public HttpResponse Index()
        {
            this.logger.Log("Hello from Index");
            var viewModel = new IndexViewModel
            {
                Message = "Welcome to SULS Platform!",
                Year = DateTime.UtcNow.Year,
            };
            return this.View(viewModel);
        }
    }
}
