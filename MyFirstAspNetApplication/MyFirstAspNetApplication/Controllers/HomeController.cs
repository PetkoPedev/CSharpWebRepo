using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyFirstAspNetApplication.Data;
using MyFirstAspNetApplication.Models;
using MyFirstAspNetApplication.Service;
using MyFirstAspNetApplication.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAspNetApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext dbContext;
        private readonly IShortStringService shortStringService;
        private readonly IConfiguration configuration;
        private readonly IInstanceCounter instanceCounter;

        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext dbContext,
            IShortStringService shortStringService,
            IConfiguration configuration,
            IInstanceCounter instanceCounter)
        {
            _logger = logger;
            this.dbContext = dbContext;
            this.shortStringService = shortStringService;
            this.configuration = configuration;
            this.instanceCounter = instanceCounter;
        }

        public IActionResult Index(int id)
        {
            var viewModel = new IndexViewModel
            {
                Id = id,
                Name = "Petko",
                Year = DateTime.UtcNow.Year,
                ProcessorCount = Environment.ProcessorCount,
                UsersCount = this.dbContext.Users.Count(),
                Description = "dkjsdnfjsbfdjlfgbdgjdjghdjknvdfjkghuijgnbjngbjngljfghlitjghifjgkjjjjjjjjjjjjhkhkgkuhgykgkhkgjhgufdtrutifgedrftgyedrtfyg",
            };
            viewModel.Description = this.shortStringService.GetShort(viewModel.Description, 10);

            return View(viewModel);
        }

        public IActionResult Exception()
        {
            throw new Exception();
        }

        public IActionResult StatusCodeError(int errorCode)
        {
            return this.View();
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
    }
}
