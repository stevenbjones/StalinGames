using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StalinGames.DAL.Models;
using StalinGames.DAL.Repositories;
using StalinGames.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StalinGames.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IPlayerPurchasesRepository _playerPurchasesRepository;
        private readonly IPlayerItemRepository _playerItemRepository;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, IWebHostEnvironment webHostEnvironment,
            IPlayerPurchasesRepository playerPurchasesRepository, IPlayerItemRepository playerItemRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _webHostEnvironment = webHostEnvironment;
            _playerPurchasesRepository = playerPurchasesRepository;
            _playerItemRepository = playerItemRepository;
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
            if (_signInManager.IsSignedIn(User) && User.IsInRole("User"))
            {
                ViewBag.ErrorMessage = "You are not allowed to create a new user while logged in.";
                return View("Error");
            }
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
                ViewBag.ErrorMessage = "The specific user with id " + id + " is not found";
                return View("NotFound", id);
            }
            if (user.Status == PlayerStatus.Deleted)
            {
                ViewBag.ErrorMessage = "The user you are currently trying to view has been deleted. Please contact the support team if this should not be the case.";
                return View("Error");
            }
            string backGroundPath = _playerItemRepository.FindByName(user.BackGround).Value;
            PlayerDetailsViewModel model = new PlayerDetailsViewModel()
            {
                Player = user,
                BackgroundPath = backGroundPath
            };
            return View(model);
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
                return View("Error");
            }

            var model = new PlayerEditViewModel
            {
                Id = user.Id,
                Username = user.UserName,
                Email = user.Email,
                ProfilePicturePath = user.ProfilePicturePath,
                Password = user.PasswordHash,
                ConfirmPassword = user.PasswordHash,
                ProfileTitle = user.ProfileTitle,
                BackgroundName = user.BackGround
            };

            var playerPurchaseList = _playerPurchasesRepository.GetPlayerPurchasesByUser(user).ToList();

            List<PlayerItem> profileTitleUser = new List<PlayerItem>();
            List<PlayerItem> backgroundPictureUser = new List<PlayerItem>();

            for (int i = 0; i < playerPurchaseList.Count(); i++)
            {
                var item = _playerItemRepository.FindByID(playerPurchaseList[i].ItemID);
                if (item == null)
                {
                    ViewBag.ErrorMessage = "Something went wrong while trying to find the user's items. Please try again later or contact the support team";
                    return View("Error");
                }

                if (item.Type == ItemType.ProfileTitle)
                {
                    profileTitleUser.Add(item);
                }
                else
                {
                    backgroundPictureUser.Add(item);
                }
            }

            List<SelectListItem> profileTitlesSelect = new List<SelectListItem>();
            List<SelectListItem> backgroundsSelect = new List<SelectListItem>();
            foreach (PlayerItem profileTitle in profileTitleUser)
            {
                profileTitlesSelect.Add(new SelectListItem(profileTitle.Name, profileTitle.Name));
            }
            foreach (PlayerItem backgroundPicture in backgroundPictureUser)
            {
                backgroundsSelect.Add(new SelectListItem(backgroundPicture.Name, backgroundPicture.Name));
            }
            model.ProfileTitles = profileTitlesSelect;
            model.BackgroundNames = backgroundsSelect;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> PlayerEdit(PlayerEditViewModel model)
        {
            //de user in var user steken
            var user = await _userManager.FindByIdAsync(model.Id);

            //de passwoorden van de model halen
            model.Password = user.PasswordHash;
            model.ConfirmPassword = user.PasswordHash;
          
     
            if (ModelState.IsValid)
            {
                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with username = {model.Username} cannot be found";
                    return View("NotFound");
                }
                //checken voor nieuwe profielfoto
                if (model.Photo != null)
                {
                   // we gaan zien of de foto wel een foto is

                        if (!IsImage(model.Photo))
                        {
                            ViewBag.ErrorMessage = ("Image validation error", "An error occured while processing your file. Please make sure the file you upload is an image, or contact the support team.");
                            return View("Error");
                        }
                        if (model.ProfilePicturePath != null)
                    {
                        var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images/ProfilePictures", model.ProfilePicturePath);

                        System.IO.File.Delete(filePath);
                    }

                    user.ProfilePicturePath = ProcessUploadedFile(model);
                }

                user.ProfileTitle = model.ProfileTitle;
                user.BackGround = model.BackgroundName;
                bool checkIfUsernameChanged = false; ;
                //als de username veranderd is maken we checkifusernamechanged true
                if (model.Username != user.UserName)
                {
                    user.UserName = model.Username;
                    checkIfUsernameChanged = true;
                }

                user.Email = model.Email;
                user.UpdatedBy = user.Id;
                user.LastUpdateDate = DateTime.Now.Date;
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    //als de username veranderd is loggen we de gebruiker uit want de cookie veranderd niet mee waardoor de gebruiker anders nooit meer de website zal kunnen gebruiken
                    if (checkIfUsernameChanged)
                    {
                        await _signInManager.SignOutAsync();
                    }

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
                if (model.Photo != null)
                {
                    // we gaan zien of de foto wel een foto is

                    if (!IsImage(model.Photo))
                    {
                        ViewBag.ErrorMessage = "An error occured while processing your file. Please make sure the file you have uploaded is an image, or you can try to contact the support team.";
                        return View("Error");
                    }
                }
                    string _photoFileName = ProcessUploadedFile(model);

                var user = new ApplicationUser
                {
                    UserName = model.Username,
                    Email = model.Email,
                    ProfilePicturePath = _photoFileName,
                    Blyats = 2000,
                    LastGamePlayed = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                    AccountCreatedDate = DateTime.Now.Date,
                    Status = PlayerStatus.Active
                };

                IdentityResult identityResult = await _userManager.CreateAsync(user, model.Password);
                IdentityResult isUserAddedToUserRole = await _userManager.AddToRoleAsync(user, "User");

                if (identityResult.Succeeded && isUserAddedToUserRole.Succeeded)
                {
                    PlayerItem profileTitleDefault = _playerItemRepository.FindByName("Gambler");
                    _playerPurchasesRepository.Add(user, profileTitleDefault);
                    user.ProfileTitle = profileTitleDefault.Name;
                    PlayerItem backgroundPictureDefault = _playerItemRepository.FindByName("Default background");
                    _playerPurchasesRepository.Add(user, backgroundPictureDefault);
                    user.BackGround = backgroundPictureDefault.Name;

                    if (_signInManager.IsSignedIn(User))
                    {
                        ApplicationUser userSignedIn = await _userManager.FindByNameAsync(User.Identity.Name);
                        user.CreatedBy = userSignedIn.Id;
                    }
                    else
                    {
                        user.CreatedBy = user.Id;
                    }

                    if (!_userManager.UpdateAsync(user).Result.Succeeded)
                    {
                        ViewBag.ErrorMessage = "There was a problem trying to add the title and background to the user. Please contact the support team.";
                        return View("Error");
                    }

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
                var signInResult = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);

                if (signInResult.Succeeded)
                {
                    if (_userManager.FindByNameAsync(model.Username).Result.Status == PlayerStatus.Deleted)
                    {
                        await _signInManager.SignOutAsync();
                        ViewBag.ErrorMessage = "The user you are currently trying log into has been deleted. Please contact the support team if this should not be the case.";
                        return View("Error");
                    }
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

            if (model.Photo != null)
            {  
                
                var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images/ProfilePictures");
                uniqueFileName = $"{Guid.NewGuid().ToString()}_{model.Photo.FileName}";
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        //Kleine versie van code van https://stackoverflow.com/questions/11063900/determine-if-uploaded-file-is-image-any-format-on-mvc
        //Om te checken of foto die geupload is wel degelijk een foto is en niet bv. een word document
        public static bool IsImage(IFormFile postedFile)
        {
            //-------------------------------------------
            //  Check the image mime types
            //-------------------------------------------
            if (postedFile.ContentType.ToLower() != "image/jpg" &&
                        postedFile.ContentType.ToLower() != "image/jpeg" &&
                        postedFile.ContentType.ToLower() != "image/pjpeg" &&
                        postedFile.ContentType.ToLower() != "image/gif" &&
                        postedFile.ContentType.ToLower() != "image/x-png" &&
                        postedFile.ContentType.ToLower() != "image/png")
            {
                return false;
            }

            //-------------------------------------------
            //  Check the image extension
            //-------------------------------------------
            if (Path.GetExtension(postedFile.FileName).ToLower() != ".jpg"
                && Path.GetExtension(postedFile.FileName).ToLower() != ".png"
                && Path.GetExtension(postedFile.FileName).ToLower() != ".gif"
                && Path.GetExtension(postedFile.FileName).ToLower() != ".jpeg")
            {
                return false;
            }
            return true;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}