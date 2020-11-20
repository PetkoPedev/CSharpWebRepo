using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstAspNetApplication.Data;
using MyFirstAspNetApplication.Service;
using MyFirstAspNetApplication.ViewModels.ViewComponents;

namespace MyFirstAspNetApplication.ViewComponents
{
    public class RegisteredUsersViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;
        public RegisteredUsersViewComponent(ApplicationDbContext dbContext, IInstanceCounter instance)
        {
            this.dbContext = dbContext;
        }
        public IViewComponentResult Invoke(string title)
        {
            var users = this.dbContext.Users.Count();
            var viewModel = new RegisteredUsersViewModel
            {
                Title = title,
                Users = users,
            };

            return this.View(viewModel);
        }
    }
}
