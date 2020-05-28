using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StalinGames.DAL.Models;
using System;

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
            jens.LastGamePlayed = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            jens.AccountCreatedDate = DateTime.Now.Date;
            jens.CreatedBy = jens.Id;
            jens.Status = PlayerStatus.Active;

            ApplicationUser steven = new ApplicationUser();
            steven.Id = Guid.NewGuid().ToString();
            steven.UserName = "steven";
            steven.Email = "steven@StalinGames.com";
            steven.NormalizedUserName = "steven";
            steven.PasswordHash = passwordHasher.HashPassword(steven, "$Admin12345");
            steven.SecurityStamp = Guid.NewGuid().ToString();
            steven.Blyats = 2000;
            steven.LastGamePlayed = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            steven.AccountCreatedDate = DateTime.Now.Date;
            steven.CreatedBy = steven.Id;
            steven.Status = PlayerStatus.Active;

            ApplicationUser frederik = new ApplicationUser();
            frederik.Id = Guid.NewGuid().ToString();
            frederik.UserName = "frederik";
            frederik.Email = "frederik@StalinGames.com";
            frederik.NormalizedUserName = "FREDERIK";
            frederik.PasswordHash = passwordHasher.HashPassword(frederik, "$Admin12345");
            frederik.SecurityStamp = Guid.NewGuid().ToString();
            frederik.Blyats = 2000;
            frederik.LastGamePlayed = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            frederik.AccountCreatedDate = DateTime.Now.Date;
            frederik.CreatedBy = frederik.Id;
            frederik.Status = PlayerStatus.Active;

            ApplicationUser peter = new ApplicationUser();
            peter.Id = Guid.NewGuid().ToString();
            peter.UserName = "peter";
            peter.Email = "peter@Gmail.com";
            peter.NormalizedUserName = "PETER";
            peter.PasswordHash = passwordHasher.HashPassword(peter, "$User12345");
            peter.SecurityStamp = Guid.NewGuid().ToString();
            peter.Blyats = 2000;
            peter.LastGamePlayed = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            peter.AccountCreatedDate = DateTime.Now.Date;
            peter.CreatedBy = peter.Id;
            peter.Status = PlayerStatus.Active;

            ApplicationUser frank = new ApplicationUser();
            frank.Id = Guid.NewGuid().ToString();
            frank.UserName = "frank";
            frank.Email = "frank@Gmail.com";
            frank.NormalizedUserName = "frank";
            frank.PasswordHash = passwordHasher.HashPassword(frank, "$User12345");
            frank.SecurityStamp = Guid.NewGuid().ToString();
            frank.Blyats = 2000;
            frank.LastGamePlayed = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            frank.AccountCreatedDate = DateTime.Now.Date;
            frank.CreatedBy = frank.Id;
            frank.Status = PlayerStatus.Active;


            ApplicationUser jan = new ApplicationUser();
            jan.Id = Guid.NewGuid().ToString();
            jan.UserName = "jan";
            jan.Email = "jan@Gmail.com";
            jan.NormalizedUserName = "jan";
            jan.PasswordHash = passwordHasher.HashPassword(jan, "$User12345");
            jan.SecurityStamp = Guid.NewGuid().ToString();
            jan.Blyats = 2000;
            jan.LastGamePlayed = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            jan.AccountCreatedDate = DateTime.Now.Date;
            jan.CreatedBy = jan.Id;
            jan.Status = PlayerStatus.Active;

            ApplicationUser eddy = new ApplicationUser();
            eddy.Id = Guid.NewGuid().ToString();
            eddy.UserName = "eddy";
            eddy.Email = "eddy@Gmail.com";
            eddy.NormalizedUserName = "eddy";
            eddy.PasswordHash = passwordHasher.HashPassword(eddy, "$User12345");
            eddy.SecurityStamp = Guid.NewGuid().ToString();
            eddy.Blyats = 2000;
            eddy.LastGamePlayed = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            eddy.AccountCreatedDate = DateTime.Now.Date;
            eddy.CreatedBy = eddy.Id;
            eddy.Status = PlayerStatus.Active;

            ApplicationUser karel = new ApplicationUser();
            karel.Id = Guid.NewGuid().ToString();
            karel.UserName = "karel";
            karel.Email = "karel@Gmail.com";
            karel.NormalizedUserName = "karel";
            karel.PasswordHash = passwordHasher.HashPassword(karel, "$User12345");
            karel.SecurityStamp = Guid.NewGuid().ToString();
            karel.Blyats = 2000;
            karel.LastGamePlayed = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            karel.AccountCreatedDate = DateTime.Now.Date;
            karel.CreatedBy = karel.Id;
            karel.Status = PlayerStatus.Active;



            #endregion CreateUsers

            modelBuilder.Entity<ApplicationUser>().HasData(jens, frederik, peter, steven, frank, jan, eddy, karel);
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
            },
            new IdentityUserRole<string>
            {
                UserId = frank.Id,
                RoleId = "3"
            },
            new IdentityUserRole<string>
            {
                UserId = jan.Id,
                RoleId = "3"
            },
            new IdentityUserRole<string>
            {
                UserId = eddy.Id,
                RoleId = "3"
            },
            new IdentityUserRole<string>
            {
                UserId = karel.Id,
                RoleId = "3"
            }

          );

            modelBuilder.Entity<PlayerItem>().HasData(

                
               new PlayerItem
               {
                   ItemID = Guid.NewGuid().ToString(),
                   Name = "Simp",
                   Price = 2000,
                   Type = ItemType.ProfileTitle
               },

               new PlayerItem
               {
                   ItemID = Guid.NewGuid().ToString(),
                   Name = "Local Champion",
                   Price = 10000,
                   Type = ItemType.ProfileTitle
               },
               new PlayerItem
               {
                   ItemID = Guid.NewGuid().ToString(),
                   Name = "Absolute Legend",
                   Price = 100000,
                   Type = ItemType.ProfileTitle
               },

                new PlayerItem
                {
                    ItemID = Guid.NewGuid().ToString(),
                    Value = "BlackJackMaster.jpg",
                    Price = 200000,
                    Type = ItemType.Background,
                    Name = "Black jack master"
                },
                new PlayerItem
                {
                    ItemID = Guid.NewGuid().ToString(),
                    Value = "CardPattern.jpg",
                    Price = 5000,
                    Type = ItemType.Background,
                    Name = "Simple card pattern"
                },
                new PlayerItem
                {
                    ItemID = Guid.NewGuid().ToString(),
                    Value = "CasinoMaster.jpg",
                    Price = 500000,
                    Type = ItemType.Background,
                    Name = "Casino master"
                },
                new PlayerItem
                {
                    ItemID = Guid.NewGuid().ToString(),
                    Value = "FireAce.jpg",
                    Price = 50000,
                    Type = ItemType.Background,
                    Name = "Ace on fire"
                },
                new PlayerItem
                {
                    ItemID = Guid.NewGuid().ToString(),
                    Value = "RouletteMaster.jpg",
                    Price = 200000,
                    Type = ItemType.Background,
                    Name = "Roulette master"
                },
                new PlayerItem
                {
                    ItemID = Guid.NewGuid().ToString(),
                    Value = "SlotMachineMaster.jpg",
                    Price = 200000,
                    Type = ItemType.Background,
                    Name = "Slot machine master"
                }

               );
            PlayerItem gambler = new PlayerItem
            {
                ItemID = Guid.NewGuid().ToString(),
                Price = 0,
                Type = ItemType.ProfileTitle,
                Name = "Gambler"
            };
            PlayerItem wolfOfWallStreet = new PlayerItem
            {
                ItemID = Guid.NewGuid().ToString(),
                Price = 500000,
                Type = ItemType.ProfileTitle,
                Name = "Wolf of Wall Street"
            };
            PlayerItem kingPin = new PlayerItem
            {
                ItemID = Guid.NewGuid().ToString(),
                Price = 1000000,
                Type = ItemType.ProfileTitle,
                Name = "KingPin"
            };
            PlayerItem defaultBackground = new PlayerItem
            {
                ItemID = Guid.NewGuid().ToString(),
                Value = "DefaultBackground.jpg",
                Price = 0,
                Type = ItemType.Background,
                Name = "Default background"
            };
            PlayerItem trueStalinGamesMaster = new PlayerItem
            {
                ItemID = Guid.NewGuid().ToString(),
                Value = "TrueStalinGamesMaster.jpg",
                Price = 1000000,
                Type = ItemType.Background,
                Name = "Ultimate true StalinGames casino master"
            };

            modelBuilder.Entity<PlayerItem>().HasData(gambler, wolfOfWallStreet, kingPin, defaultBackground, trueStalinGamesMaster);
           
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
                 },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = jens.Id,
                     ItemID = defaultBackground.ItemID
                 },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = jens.Id,
                     ItemID = trueStalinGamesMaster.ItemID
                 },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = eddy.Id,
                     ItemID = wolfOfWallStreet.ItemID
                 },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = eddy.Id,
                     ItemID = defaultBackground.ItemID
                 },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = frank.Id,
                     ItemID = defaultBackground.ItemID
                 },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = jan.Id,
                     ItemID = defaultBackground.ItemID
                 },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = karel.Id,
                     ItemID = defaultBackground.ItemID
                 },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = eddy.Id,
                     ItemID = gambler.ItemID
                 },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = frank.Id,
                     ItemID = gambler.ItemID
                 },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = jan.Id,
                     ItemID = gambler.ItemID
                 },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = karel.Id,
                     ItemID = gambler.ItemID
                 },
                  new PlayerPurchase
                  {
                      OrderID = Guid.NewGuid().ToString(),
                      UserID = peter.Id,
                      ItemID = gambler.ItemID
                  },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = frederik.Id,
                     ItemID = gambler.ItemID
                 },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = steven.Id,
                     ItemID = gambler.ItemID
                 },
                  new PlayerPurchase
                  {
                      OrderID = Guid.NewGuid().ToString(),
                      UserID = peter.Id,
                      ItemID = defaultBackground.ItemID
                  },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = frederik.Id,
                     ItemID = defaultBackground.ItemID
                 },
                 new PlayerPurchase
                 {
                     OrderID = Guid.NewGuid().ToString(),
                     UserID = steven.Id,
                     ItemID = defaultBackground.ItemID
                 }

                );
            frank.BackGround = defaultBackground.Name;
            jan.BackGround = defaultBackground.Name;
            eddy.BackGround = defaultBackground.Name;
            karel.BackGround = defaultBackground.Name;
            steven.BackGround = defaultBackground.Name;
            frederik.BackGround = defaultBackground.Name;
            peter.BackGround = defaultBackground.Name;         
            jens.BackGround = defaultBackground.Name;

            frank.ProfileTitle = gambler.Name;
            jan.ProfileTitle = gambler.Name;
            eddy.ProfileTitle = gambler.Name;
            karel.ProfileTitle = gambler.Name;
            steven.ProfileTitle = gambler.Name;
            frederik.ProfileTitle = gambler.Name;
            peter.ProfileTitle = gambler.Name;
            jens.ProfileTitle = kingPin.Name;





        }
    }
}