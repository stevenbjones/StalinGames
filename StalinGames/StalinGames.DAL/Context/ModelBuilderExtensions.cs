using StalinGames.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace StalinGames.DAL.Context
{
    public static class ModelBuilderExtensions
    {
        private static PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();

        public static void Seed(this ModelBuilder modelBuilder)
        {
             #region CreateUsers
            ApplicationUser jens = new ApplicationUser();           
            jens.Id = Guid.NewGuid().ToString();
            jens.UserName = "Jens";
            jens.Email = "Jens@StalinGames.com";
            jens.NormalizedUserName = "JENS";
            jens.PasswordHash = passwordHasher.HashPassword(jens, "$Admin12345");
            jens.SecurityStamp = Guid.NewGuid().ToString();
            jens.Blyats = 2000;

            ApplicationUser steven = new ApplicationUser();
            steven.Id = Guid.NewGuid().ToString();
            steven.UserName = "steven";
            steven.Email = "steven@StalinGames.com";
            steven.NormalizedUserName = "steven";
            steven.PasswordHash = passwordHasher.HashPassword(steven, "$Admin12345");
            steven.SecurityStamp = Guid.NewGuid().ToString();
            steven.Blyats = 2000;


            ApplicationUser frederik = new ApplicationUser();
            frederik.Id = Guid.NewGuid().ToString();
            frederik.UserName = "frederik";
            frederik.Email = "frederik@StalinGames.com";
            frederik.NormalizedUserName = "FREDERIK";
            frederik.PasswordHash = passwordHasher.HashPassword(frederik, "$Admin12345");
            frederik.SecurityStamp = Guid.NewGuid().ToString();
            frederik.Blyats = 2000;

            ApplicationUser peter = new ApplicationUser();
            peter.Id = Guid.NewGuid().ToString();
            peter.UserName = "peter";
            peter.Email = "peter@Gmail.com";
            peter.NormalizedUserName = "PETER";
            peter.PasswordHash = passwordHasher.HashPassword(peter, "$User12345");
            peter.SecurityStamp = Guid.NewGuid().ToString();
            peter.Blyats = 2000;
            #endregion
            modelBuilder.Entity<ApplicationUser>().HasData(jens, frederik, peter, steven);
            modelBuilder.Entity<IdentityRole>().HasData(
          new IdentityRole
          {
              Name = "SuperAdmin",
              Id = "1",
              NormalizedName = "SUPERADMIN"
          },
           new IdentityRole
           {
               Name = "Admin",
               Id = "2",
               NormalizedName = "ADMIN"
           },
            new IdentityRole
            {
                Name = "User",
                Id = "3",
                NormalizedName = "USER"
            }

          );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
          new IdentityUserRole<string>
          {
              UserId = jens.Id,
              RoleId = "1"
          },
           new IdentityUserRole<string>
           {
               UserId = frederik.Id,
               RoleId = "2"
           },
            new IdentityUserRole<string>
            {
                UserId = peter.Id,
                RoleId = "3"
            },
            new IdentityUserRole<string>
            {
                UserId = steven.Id,
                RoleId = "1"
            }
           
          );

            ListItems.Items = new List<PlayerItem>()
            {
               new ProfileTitle
               {
                ItemID = Guid.NewGuid().ToString(),
                Price = 0,
                itemType = ItemType.ProfileTitle,
                ProfileTitleName = "Gambler"
               },
               new ProfileTitle
               {
                  ItemID = Guid.NewGuid().ToString(),
                   ProfileTitleName =  "Simp",
                   Price = 2000,
                   itemType = ItemType.ProfileTitle
               },
               new ProfileTitle
               {
                   ItemID = Guid.NewGuid().ToString(),
                   ProfileTitleName = "Local Champion",
                  Price = 10000,
                  itemType = ItemType.ProfileTitle
               },
               new ProfileTitle
               {
                   ItemID = Guid.NewGuid().ToString(),
                   ProfileTitleName =  "Absolute Legend",
                    Price = 100000,
                    itemType = ItemType.ProfileTitle
               },
              
                new BackgroundPicture
                {
                   ItemID = Guid.NewGuid().ToString(),
                    BackgroundPath = "DefaultBackground.jpg",
                    Price = 0,
                    itemType = ItemType.Background
                },
                new BackgroundPicture
                {
                   ItemID = Guid.NewGuid().ToString(),
                    BackgroundPath = "BackgroundStars.jpg",
                    Price = 5000,
                    itemType = ItemType.Background
                }
            };
            ProfileTitle wolfOfWallStreet = new ProfileTitle
            {

                ItemID = Guid.NewGuid().ToString(),
                Price = 1000000,
                itemType = ItemType.ProfileTitle,
                ProfileTitleName = "KingPin"

            };
            ProfileTitle kingPin = new ProfileTitle
            {

                ItemID = Guid.NewGuid().ToString(),
                Price = 1000000,
                itemType = ItemType.ProfileTitle,
                ProfileTitleName = "KingPin"

            };
            ListItems.Items.Add(wolfOfWallStreet);
            ListItems.Items.Add(kingPin);
            modelBuilder.Entity<PlayerPurchase>().HasData(
                new PlayerPurchase
                {
                    OrderID = Guid.NewGuid().ToString(),
                    UserID = jens.Id,
                    ItemID = wolfOfWallStreet.ItemID
                },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = jens.Id,
                     ItemID = kingPin.ItemID
                 }
                );
        }
    }
}
