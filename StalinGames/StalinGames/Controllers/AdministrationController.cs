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
                user.Blyats = model.Blyats;
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

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found!";
                return View("NotFound");
            }

            var model = new EditRoleViewModel()
            {
                Id = role.Id,
                RoleName = role.Name,
            };

            var listUser = _userManager.Users.ToList();

            foreach (var user in listUser)
            {
                var isInRole = await _userManager.IsInRoleAsync(user, role.Name);

                if (isInRole)
                {
                    model.Users.Add(user.UserName);
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found!";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;

                // Update the Role using UpdateAsync
                var result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;

            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found!";
                return View("NotFound");
            }

            var model = new List<UserRoleViewModel>();
            var listUsers = _userManager.Users.ToList();

            foreach (var user in listUsers)
            {
                var userRoleViewModel = new UserRoleViewModel()
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                };

                var isInRole = await _userManager.IsInRoleAsync(user, role.Name);

                if (isInRole)
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                model.Add(userRoleViewModel);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUsersInRoleAsync(List<UserRoleViewModel> model, string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found!";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await _userManager.FindByIdAsync(model[i].UserId);
                var isInRole = await _userManager.IsInRoleAsync(user, role.Name);

                IdentityResult result = null;

                if (model[i].IsSelected && !isInRole)
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && isInRole)
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                    {
                        continue;
                    }
                    else
                    {
                        return RedirectToAction("EditRole", new { Id = roleId });
                    }
                }
            }

            return RedirectToAction("EditRole", new { Id = roleId });
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