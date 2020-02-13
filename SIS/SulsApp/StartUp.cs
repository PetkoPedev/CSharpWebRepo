using SIS.HTTP;
using SIS.MvcFramework;
using SulsApp.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SulsApp
{
    public class StartUp : IMvcApplication
    {
        public void Configure(IList<Route> routeTable)
        {
            
        }

        public void ConfigureServices()
        {
            var db = new ApplicationDbContext();
            db.Database.EnsureCreated();
        }
    }
}
