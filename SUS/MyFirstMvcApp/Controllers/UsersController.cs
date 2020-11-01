using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BattleCards.Controllers
{
    public class UsersController : Controller
    {
        public HttpResponse Login()
        {
            return this.View();
        }

        public HttpResponse Register()
        {
            return this.View();
        }

        [HttpPost("/Users/Dologin")]
        public HttpResponse DoLogin()
        {
            // TODO: read data
            // TODO: check user
            // TODO: log user
            // TODO: home page
            return this.Redirect("/");
        }
    }
}
