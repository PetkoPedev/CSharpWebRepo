using Microsoft.EntityFrameworkCore;
using MUSACA.Data;
using SUS.HTTP;
using SUS.MvcFramework;
using System.Collections.Generic;

namespace MUSACA
{
    public class Startup : IMvcApplication
    {
        public void Configure(List<Route> routeTable)
        {
            new ApplicationDbContext().Database.Migrate();
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            //throw new System.NotImplementedException();
        }
    }
}