﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StalinGames.DAL.Models;
using StalinGames.DAL.Repositories;
using StalinGames.ViewModels;

namespace StalinGames.Controllers
{
    public class GamesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IPlayerPurchasesRepository _playerPurchasesRepository;
        private readonly IPlayerItemRepository _playerItemRepository;

        public GamesController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, IWebHostEnvironment webHostEnvironment,
            IPlayerPurchasesRepository playerPurchasesRepository, IPlayerItemRepository playerItemRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _webHostEnvironment = webHostEnvironment;
            _playerPurchasesRepository = playerPurchasesRepository;
            _playerItemRepository = playerItemRepository;
        }

        [HttpGet]
        public async Task<IActionResult> SlotMachine()
        {

            ApplicationUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> SlotMachine(int getal)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Blyats += getal;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return Json(user.Blyats);
            }
            else
            {
                ViewBag.ErrorMessage = "Error while updating user blyats";
                return View("Error");
            }
                
            
            //return Ok("Success");
        }

        [HttpPost]
        public IActionResult SlotMachineTest(int getal)
        {
            getal = 69420;
            return Json(getal);
            //return Ok("Success");
        }



    }
}