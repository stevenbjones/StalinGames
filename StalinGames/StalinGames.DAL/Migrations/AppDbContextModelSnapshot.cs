﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StalinGames.DAL.Context;

namespace StalinGames.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "d5558286-d9cd-4621-8173-588573315a1d",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "8755c973-2581-4a64-9f03-2895d0634c6f",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "a464e3ff-e891-4a10-a238-ad55d0145dea",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "5abde424-c88b-49ff-ace2-9e5b7124e572",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "23152f98-5317-478a-a1d7-3b54ccfd9c57",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "6b59c1e0-bd8b-49d4-ace8-ec80de9afbe8",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "6530f76a-6714-456f-85db-53dd29b40371",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("StalinGames.DAL.Models.BackgroundPicture", b =>
                {
                    b.Property<string>("ItemID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BackgroundPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("itemType")
                        .HasColumnType("int");

                    b.HasKey("ItemID");

                    b.ToTable("BackgroundPicture");
                });

            modelBuilder.Entity("StalinGames.DAL.Models.PlayerPurchase", b =>
                {
                    b.Property<string>("OrderID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ItemID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderID");

                    b.ToTable("PlayerPurchases");

                    b.HasData(
                        new
                        {
                            OrderID = "81324328-d4a7-4001-9e73-a893a8f22c2a",
                            ItemID = "e1cae4a0-911e-47f4-8980-305dbfb1581b",
                            UserID = "5abde424-c88b-49ff-ace2-9e5b7124e572"
                        },
                        new
                        {
                            OrderID = "7c151428-8fc2-46a1-b830-6995694443fd",
                            ItemID = "c5b3c034-93d9-40c7-ac21-fc15ac752e01",
                            UserID = "5abde424-c88b-49ff-ace2-9e5b7124e572"
                        });
                });

            modelBuilder.Entity("StalinGames.DAL.Models.ProfileTitle", b =>
                {
                    b.Property<string>("ItemID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProfileTitleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("itemType")
                        .HasColumnType("int");

                    b.HasKey("ItemID");

                    b.ToTable("ProfileTitle");
                });

            modelBuilder.Entity("StalinGames.DAL.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("AccountCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BackGroundItemID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Blyats")
                        .HasColumnType("int");

                    b.Property<long>("LastGamePlayed")
                        .HasColumnType("bigint");

                    b.Property<string>("ProfilePicturePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileTitleItemID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TotalBlyatsLost")
                        .HasColumnType("int");

                    b.Property<int>("TotalGamesPlayed")
                        .HasColumnType("int");

                    b.HasIndex("BackGroundItemID");

                    b.HasIndex("ProfileTitleItemID");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "5abde424-c88b-49ff-ace2-9e5b7124e572",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ae2fd285-13c8-42d6-8349-55614b9ca064",
                            Email = "Jens@StalinGames.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "JENS",
                            PasswordHash = "AQAAAAEAACcQAAAAEF7+icv7FZfqLu/e0nH3ahAhbE8sw9lsysTDxMqWjLMNxln2nDPsEsQqjjFzsqMpkw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1d3135c7-5109-4c92-9920-4c3770f824fa",
                            TwoFactorEnabled = false,
                            UserName = "Jens",
                            AccountCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Blyats = 2000,
                            LastGamePlayed = 0L,
                            TotalBlyatsLost = 0,
                            TotalGamesPlayed = 0
                        },
                        new
                        {
                            Id = "23152f98-5317-478a-a1d7-3b54ccfd9c57",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1dc0c253-f098-47d8-a237-d0a1fd54da9f",
                            Email = "frederik@StalinGames.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "FREDERIK",
                            PasswordHash = "AQAAAAEAACcQAAAAED0vyfcWh7nPzPTQ/TZUjgmvKf9EP+mQHkh8jlTHs85lBjwtrAJi6qZZmN/1UjX5nw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cd5c23d3-d57b-4281-a605-21e324fc8693",
                            TwoFactorEnabled = false,
                            UserName = "frederik",
                            AccountCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Blyats = 2000,
                            LastGamePlayed = 0L,
                            TotalBlyatsLost = 0,
                            TotalGamesPlayed = 0
                        },
                        new
                        {
                            Id = "6b59c1e0-bd8b-49d4-ace8-ec80de9afbe8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d9ea61c5-6cf6-4500-b014-ae2f73ff0128",
                            Email = "peter@Gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "PETER",
                            PasswordHash = "AQAAAAEAACcQAAAAEPFjXcHe185XaHI1l33j5nmk8GHPWGHkAA5M8pzBKFW35QQX29mVAn/O3wn3gfh6tw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "05033f69-79cb-49be-9ede-96a3ef22b237",
                            TwoFactorEnabled = false,
                            UserName = "peter",
                            AccountCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Blyats = 2000,
                            LastGamePlayed = 0L,
                            TotalBlyatsLost = 0,
                            TotalGamesPlayed = 0
                        },
                        new
                        {
                            Id = "6530f76a-6714-456f-85db-53dd29b40371",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d9dbec2c-a9f2-4274-a0a9-d91fdc48bf07",
                            Email = "steven@StalinGames.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "steven",
                            PasswordHash = "AQAAAAEAACcQAAAAEEyU1GuEi+8DtuwH33TX65gzC6beq+CQ5f2s40vfonjfvTz2ILVnCZY/h51vY/uRXg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d15de8bc-f2de-4be1-8071-ed74eaba0293",
                            TwoFactorEnabled = false,
                            UserName = "steven",
                            AccountCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Blyats = 2000,
                            LastGamePlayed = 0L,
                            TotalBlyatsLost = 0,
                            TotalGamesPlayed = 0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StalinGames.DAL.Models.ApplicationUser", b =>
                {
                    b.HasOne("StalinGames.DAL.Models.BackgroundPicture", "BackGround")
                        .WithMany()
                        .HasForeignKey("BackGroundItemID");

                    b.HasOne("StalinGames.DAL.Models.ProfileTitle", "ProfileTitle")
                        .WithMany()
                        .HasForeignKey("ProfileTitleItemID");
                });
#pragma warning restore 612, 618
        }
    }
}
