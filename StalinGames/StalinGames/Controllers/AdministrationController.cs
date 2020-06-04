using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StalinGames.DAL.Models;
using StalinGames.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StalinGames.Controllers
{
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        //[HttpPost]
        //[HttpGet]
        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> BlyatsCheck(double blyats)
        {
            if (blyats < 0)
            {
                return Json($"Please do not enter an amount below 0.");
            }
            if (blyats.ToString().Contains(',') || blyats.ToString().Contains('.'))
            {
                return Json($"Please do not enter comma values.");
            }
            return Json(true);
                    
            
        }
        [HttpGet]
        public IActionResult ListUsers()
        {
            List<string> roles = new List<string>();
            List<ApplicationUser> users = new List<ApplicationUser>();
            roles.Add("User");
            if (User.IsInRole("Admin"))
            {
                users = GetUsersByRole(roles, PlayerStatus.Active);
            }
            else if (User.IsInRole("SuperAdmin"))
            {
                roles.Add("Admin");
                users = GetUsersByRole(roles, PlayerStatus.Active);
            }
            return View(users);

        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public IActionResult ListDeletedUsers()
        {
            List<string> roles = new List<string>();
            roles.Add("User");
            roles.Add("Admin");
            List<ApplicationUser> users = GetUsersByRole(roles, PlayerStatus.Deleted);
            return View(users);
        }

        

        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }

            if (user.Status == PlayerStatus.Deleted)
            {
                ViewBag.ErrorMessage = "The user you are currently trying to view has been deleted. Please contact the support team if this should not be the case.";
                return View("Error");
            }

            // GetClaimsAsync retunrs the list of user Claims
            var userClaims = await _userManager.GetClaimsAsync(user);
            // GetRolesAsync returns the list of user Roles
            var userRole = await _userManager.GetRolesAsync(user);

            var model = new EditUserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Blyats = user.Blyats,
                Role = userRole[0].ToString()
            };
            List<SelectListItem> roles = new List<SelectListItem>();
            roles.Add(new SelectListItem("Admin", "Admin"));
            roles.Add(new SelectListItem("User", "User"));
            model.Roles = roles;

            return View(model);
        }
        

        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.Id);

                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                    return View("NotFound");
                }
                user.Blyats = Convert.ToInt32(model.Blyats);
                user.UpdatedBy = user.Id;
                user.LastUpdateDate = DateTime.Now.Date;
                await _userManager.RemoveFromRoleAsync(user, _userManager.GetRolesAsync(user).Result[0]);
                await _userManager.AddToRoleAsync(user, model.Role);

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListUsers");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUserAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }
            user.Status = PlayerStatus.Deleted;

            IdentityResult result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("ListUsers", "Administration");
            }
            else
            {
                ViewBag.ErrorMessage = $"Something went wrong while trying to delete user: {user.UserName}. Please try again later or contact the support team. ";
                return View("Error");
            }
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpPost]
        public async Task<IActionResult> RestoreUserAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }
            user.Status = PlayerStatus.Active;

            IdentityResult result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("ListDeletedUsers", "Administration");
            }
            else
            {
                ViewBag.ErrorMessage = $"Something went wrong while trying to restore user: {user.UserName}. Please try again later or contact the support team. ";
                return View("Error");
            }
        }


        public List<ApplicationUser> GetUsersByRole(List<string> roles, PlayerStatus status)
        {
            List<ApplicationUser> users = _userManager.Users.ToList();

            List<ApplicationUser> usersWithCorrectRole = new List<ApplicationUser>();

            for (int i = 0; i < users.Count; i++)
            {
                for (int j = 0; j < roles.Count; j++)
                {
                    if (_userManager.GetRolesAsync(users[i]).Result[0] == roles[j] && users[i] != null && users[i].Status == status)
                    {
                        usersWithCorrectRole.Add(users[i]);
                    }
                }
            }

            return usersWithCorrectRole;
        }
     
    }
}