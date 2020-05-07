using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StalinGames.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StalinGames.ViewModels
{
    public class PlayerEditViewModel : RegisterViewModel
    {
        public string Id { get; set; }  
        public string ProfilePicturePath { get; set; }
        public string ProfileTitle { get; set; }
        public string BackgroundPath { get; set; }
        [DataType(DataType.Password)]
        public new string Password { get; set; }
        [DataType(DataType.Password)]
        public new string ConfirmPassword { get; set; }
        public IEnumerable<SelectListItem> ProfileTitles { get; set; }

        public IEnumerable<SelectListItem> BackgroundPaths { get; set; }
    }
}
