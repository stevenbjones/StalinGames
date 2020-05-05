using StalinGames.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
            modelBuilder.Entity<ApplicationUser>().HasData(jens, frederik, peter);
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
            }

          );


        }
    }
}
