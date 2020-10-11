using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultationDayExercise.Areas.Moderation.Controllers
{
    public class ModerateController : Controller
    {
        [Area("Moderation")]
        [Authorize(Roles = "Moderation")]
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
