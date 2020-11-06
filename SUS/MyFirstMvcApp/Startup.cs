﻿using BattleCards.Data;
using Microsoft.EntityFrameworkCore;
using BattleCards.Controllers;
using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.Collections.Generic;
using System.Text;
using BattleCards.Services;

namespace BattleCards
{
    public class Startup : IMvcApplication
    {

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            // AddSingleton
            // AddTransient
            // AddScoped
            serviceCollection.Add<IUsersService, UsersService>();
            serviceCollection.Add<ICardsService, CardsService>();
        }

        public void Configure(List<Route> routeTable)
        {
            new ApplicationDbContext().Database.Migrate();
        }
    }
}
