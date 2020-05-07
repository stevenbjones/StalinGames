using System;
using System.IO;
using StalinGames.DAL.Models;
using StalinGames.DAL.Repositories;
using StalinGames.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace StalinGames.Controllers
{
    public class HomeController : Controller
    {

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(
            IWebHostEnvironment webHostEnvironment,
            ILogger<HomeController> logger, UserManager<ApplicationUser> userManager)
        {
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
            _userManager = userManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public  IActionResult Create()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            return View(user);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> PlayerSearch(string userName)
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            List<string> roles = new List<string>() { "User"} ;
            foreach (ApplicationUser user in GetUsersByRole(roles))
            {
                if (user.UserName.ToLower().Contains(userName.ToLower()))
                    users.Add(user);
            }
            return View(users);
        }

        public List<ApplicationUser> GetUsersByRole(List<string> roles) 
        {
            List<ApplicationUser> users = _userManager.Users.ToList();

            List<ApplicationUser> usersWithCorrectRole = new List<ApplicationUser>();

            for (int i = 0; i < users.Count; i++)
            {
                for (int j = 0; j < roles.Count; j++)
                {
                    if (_userManager.GetRolesAsync(users[i]).Result[0] == roles[j])
                    {
                        usersWithCorrectRole.Add(users[i]);
                    }
                }

            }
            return usersWithCorrectRole;
        }



    }
}
