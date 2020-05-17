using Microsoft.AspNetCore.Hosting;
using StalinGames.DAL.Models;
using StalinGames.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StalinGames.BLL.Services
{
    class PlayerItemService
    {
        private readonly IPlayerItemRepository _playerItemRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public PlayerItemService(IPlayerItemRepository playerItemRepository, IWebHostEnvironment webHostEnvironment)
        {
            _playerItemRepository = playerItemRepository;
            _webHostEnvironment = webHostEnvironment;
        }
        public List<PlayerItem> GetAllProfileTitles()
        {
            var playerItems = _playerItemRepository.GetAll().ToList();
            var playerItemProfileTitles = new List<PlayerItem>();
            for (int i = 0; i < playerItems.Count(); i++)
            {
                if (playerItems[i].itemType == ItemType.ProfileTitle)
                {
                    playerItemProfileTitles.Add(playerItems[i]);
                }
              
            }
            return playerItemProfileTitles;
        }
        public List<PlayerItem> GetAllBackgrounds()
        {
            var playerItems = _playerItemRepository.GetAll().ToList();
            var playerItemBackgrounds = new List<PlayerItem>();
            for (int i = 0; i < playerItems.Count(); i++)
            {
                if (playerItems[i].itemType == ItemType.Background)
                {
                    playerItemBackgrounds.Add(playerItems[i]);
                }

            }
            return playerItemBackgrounds;
        }
    }
}
