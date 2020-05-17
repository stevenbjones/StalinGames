using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StalinGames.ViewModels;

namespace StalinGames.Controllers
{
    public class GamesController : Controller
    {
        [AcceptVerbs("Get", "Post")]
        public async Task<IActionResult> SlotMachine()
        {
            Random random = new Random();
            int getal = random.Next(0, 100);
            SlotMachineViewModel model = new SlotMachineViewModel()
            {
                random = getal
            };
            return View(model);
        }


    }
}