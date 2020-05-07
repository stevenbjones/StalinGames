using System.Threading.Tasks;
using StalinGames.DAL.Models;
using StalinGames.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Linq;
using StalinGames.DAL.Repositories;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StalinGames.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IPlayerPurchasesRepository _playerPurchasesRepository;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, IWebHostEnvironment webHostEnvironment, IPlayerPurchasesRepository playerPurchasesRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _webHostEnvironment = webHostEnvironment;
            _playerPurchasesRepository = playerPurchasesRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        //[HttpPost]
        //[HttpGet]
        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);


            if (user == null)
            {
                return Json(true);
            }
            else
            {
                if (_signInManager.IsSignedIn(User))
                {
                    var userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
                    if (user.Email == userLoggedIn.Email)
                    {
                        return Json(true);
                    }
                    else
                    {
                        return Json($"Email {email} is already in use");
                    }
                }
                else
                {
                    return Json($"Email {email} is already in use");
                }


            }
        }

        //[HttpPost]
        //[HttpGet]
        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsUsernameInUse(string username)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user == null)
            {
                return Json(true);
            }
            else
            {
                if (_signInManager.IsSignedIn(User) && user.UserName == User.Identity.Name)
                { return Json(true); }
                else
                {
                    return Json($"Username {username} is already in use");
                }


            }
        }

        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public IActionResult PlayerDetails(string id)
        {

            ApplicationUser user = _userManager.FindByIdAsync(id).Result;
            if (user == null)
            {
                Response.StatusCode = 404;
                return View("UserNotFound", id);
            }
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> PlayerEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }
            
            if (_userManager.FindByNameAsync(User.Identity.Name).Result != user)
            {
                ViewBag.ErrorMessage = "You are not allowed to do this action.";
                return View("NotFound");
            }

            var model = new PlayerEditViewModel
            {
                Id = user.Id,
                Username = user.UserName,
                Email = user.Email,
                ProfilePicturePath = user.ProfilePicturePath,
                Password = user.PasswordHash,
                ConfirmPassword = user.PasswordHash
            };

            var playerPurchaseList = _playerPurchasesRepository.GetAll().ToList();        

            List<ProfileTitle> profileTitleUser = new List<ProfileTitle>();
            List<BackgroundPicture> backgroundPictureUser = new List<BackgroundPicture>();

            //for (int i = 0; i < playerPurchaseList.Count; i++)
            //{
            //    if (playerPurchaseList[i].UserID == model.Id)
            //    {
            //        for (int i = 0; i < PlayerItem; i++)
            //        {

            //        }
            //        if (playerPurchaseList[i].ItemID = )
            //    }
            //}
            //List<SelectListItem> profileTitles = new List<SelectListItem>();
            //List<SelectListItem> backgrounds = new List<SelectListItem>();
            //foreach (ProfileTitle profileTitle in )
            //    roles.Add(new SelectListItem());
            //roles.Add(new SelectListItem("User", "User"));
            //model.Roles = roles; TODO voor de user titles

            //dus basically, maak repository voor player item, doe die for loop link item id aan item id, en dan checke voor profilelist of background en zet het in de juiste list, en dan gwn nog die lists convertere ewn klaar

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> PlayerEdit(PlayerEditViewModel model)
        {
                var user = await _userManager.FindByIdAsync(model.Id);
            model.Password = user.PasswordHash;
            model.ConfirmPassword = user.PasswordHash;
            if (ModelState.IsValid)
            {
                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with username = {model.Username} cannot be found";
                    return View("NotFound");
                }
                user.UserName = model.Username;
                user.Email = model.Email;

                if (model.Photo != null)
                {
                    if (model.ProfilePicturePath != null)
                    {
                        var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", model.ProfilePicturePath);

                        System.IO.File.Delete(filePath);
                    }

                    user.ProfilePicturePath = ProcessUploadedFile(model);
                }

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    await _signInManager.SignOutAsync();
                    await _signInManager.PasswordSignInAsync(user, user.PasswordHash, false, false); //werkt niet
                    return RedirectToAction("PlayerDetails", new { id = user.Id });
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
          
            return View(model);
        }

        

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAsync(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                string _photoFileName = ProcessUploadedFile(model);

                var user = new ApplicationUser
                {
                    UserName = model.Username,
                    Email = model.Email,
                    ProfilePicturePath = _photoFileName,
                    Blyats = 2000,
                    LastGamePlayed = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                    AccountCreatedDate = DateTime.Now.Date
                };

                IdentityResult identityResult = await _userManager.CreateAsync(user, model.Password);
                IdentityResult isUserAddedToUserRole = await _userManager.AddToRoleAsync(user, "User");

                if (identityResult.Succeeded && isUserAddedToUserRole.Succeeded)
                {
                    ProfileTitle profileTitleDefault = (ProfileTitle)ListItems.Items[0];                   
                    _playerPurchasesRepository.Add(user, profileTitleDefault);
                    user.ProfileTitle = profileTitleDefault.ProfileTitleName;
                    BackgroundPicture backgroundPictureDefault = (BackgroundPicture)ListItems.Items[6];
                    _playerPurchasesRepository.Add(user, backgroundPictureDefault);
                    user.BackGround = backgroundPictureDefault.BackgroundPath;

                   
                    //redirect naar listUsers als de user een admin of superadmin is die de gebruiker heeft aangemaakt
                    if (_signInManager.IsSignedIn(User) && User.IsInRole("Admin") || _signInManager.IsSignedIn(User) && User.IsInRole("SuperAdmin"))
                    {
                        return RedirectToAction("ListUsers", "Administration");
                    }

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
             {
                var temp = model.Username;
                var signInResult =  await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);

                if (signInResult.Succeeded)
                {
                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(model);
        }

        private string ProcessUploadedFile(RegisterViewModel model)
        {
            string uniqueFileName = null;
            var _model = model.Photo;

            if (model.Photo != null)
            {
                var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName = $"{Guid.NewGuid().ToString()}_{model.Photo.FileName}";
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        //private List<PlayerPurchase> GetUsersPurchasesByType(ApplicationUser user, ItemType type)
        //{
        //    List<>
        //    for (int i = 0; i < length; i++)
        //    {

        //    }
        //}

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
