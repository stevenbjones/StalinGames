using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StalinGames.DAL.Models;
using StalinGames.DAL.Repositories;
using StalinGames.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StalinGames.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IPlayerItemRepository _playerItemRepository;
        private readonly IPlayerPurchasesRepository _playerPurchasesRepository;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public HomeController(
            IWebHostEnvironment webHostEnvironment,
            ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, IPlayerItemRepository playerItemRepository, IPlayerPurchasesRepository playerPurchasesRepository, SignInManager<ApplicationUser> signInManager)
        {
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
            _userManager = userManager;
            _playerItemRepository = playerItemRepository;
            _playerPurchasesRepository = playerPurchasesRepository;
            _signInManager = signInManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Create()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            return View(user);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Shop(string message)
        {
            List<PlayerItem> playerItems = _playerItemRepository.GetAll().ToList();
            List<PlayerItem> profileTitles = new List<PlayerItem>();
            List<PlayerItem> backgrounds = new List<PlayerItem>();
            for (int i = 0; i < playerItems.Count(); i++)
            {
                if (playerItems[i].Type == ItemType.ProfileTitle)
                {
                    profileTitles.Add(playerItems[i]);
                }
                else
                {
                    backgrounds.Add(playerItems[i]);
                }
            }
            profileTitles = profileTitles.OrderBy(o => o.Price).ToList();
            backgrounds = backgrounds.OrderBy(o => o.Price).ToList();

            ShopViewModel model = new ShopViewModel();

            if (_signInManager.IsSignedIn(User))
            {
                ApplicationUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;
                List<PlayerPurchase> playerPurchases = _playerPurchasesRepository.GetPlayerPurchasesByUser(user).ToList();
                List<PlayerItem> profileTitlesUser = new List<PlayerItem>();
                List<PlayerItem> backgroundsUser = new List<PlayerItem>();
                for (int i = 0; i < profileTitles.Count(); i++)
                {
                    for (int j = 0; j < playerPurchases.Count(); j++)
                    {
                        if (profileTitles[i].ItemID == playerPurchases[j].ItemID)
                        {
                            profileTitlesUser.Add(profileTitles[i]);
                            profileTitles.RemoveAt(i);
                            j = playerPurchases.Count();
                            i--;
                        }
                    }
                }
                for (int i = 0; i < backgrounds.Count(); i++)
                {
                    for (int j = 0; j < playerPurchases.Count(); j++)
                    {
                        if (backgrounds[i].ItemID == playerPurchases[j].ItemID)
                        {
                            backgroundsUser.Add(backgrounds[i]);
                            backgrounds.RemoveAt(i);
                            j = playerPurchases.Count();
                            i--;
                        }
                    }
                }

                model.ProfileTitlesPurchased = profileTitlesUser;
                model.BackgroundsPurchased = backgroundsUser;
            }
            model.profileTitles = profileTitles;
            model.Backgrounds = backgrounds;
            model.Message = message;

            return View(model);
        }


        [AcceptVerbs("Get", "Post")]
        public async Task<IActionResult> BuyItem(string id)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                ViewBag.ErrorMessage = "You need to be signed in before you can buy this item";
                return View("Error");

            }

            ApplicationUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            PlayerItem item = _playerItemRepository.FindByID(id);
            if (user.Blyats < item.Price)
            {
                return RedirectToAction("Shop", new { message = "You do not have enough Blyats to purchase: " + item.Name });
            }

            user.Blyats = user.Blyats - item.Price;
            _playerPurchasesRepository.Add(user, item);
            await _userManager.UpdateAsync(user);

            return RedirectToAction("Index");
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult PlayerSearch(string userName)
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            List<string> roles = new List<string>() { "User" };
            if (userName == null || userName == "")
            {
                users = GetUsersByRole(roles);
            }
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
                    if (_userManager.GetRolesAsync(users[i]).Result[0] == roles[j] && users[i] != null && users[i].Status == PlayerStatus.Active)
                    {
                        usersWithCorrectRole.Add(users[i]);
                    }
                }
            }
            return usersWithCorrectRole;
        }
    }
}