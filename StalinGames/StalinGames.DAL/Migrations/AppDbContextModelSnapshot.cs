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
                            ConcurrencyStamp = "2e36daff-c92b-4e68-bb0b-e35a279a68b4",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "c1f4951b-f6a1-4ba4-ab71-3ad57784d0b4",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "5868d45d-ebf1-48ae-b2c4-29d84f1a2d6f",
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
                            UserId = "e0d48632-5a2b-40d9-babd-6585a478ab09",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "474cefd2-42cd-4a24-abba-a5dd3a61afe1",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "fbbc4a4b-4f35-4cd9-a34d-2b2060598678",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "2bfdf9fc-9fba-424c-bdc9-db3e8c7bc4af",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "068e7ce5-eda6-4961-89e8-3b29284a0fa3",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "434fb57b-3d64-4352-9c91-7b7862c622dc",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "ad0869ce-64ad-459c-9fde-e0522fd4c0c4",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "0f36484f-2040-4483-88e7-9544b258fc74",
                            RoleId = "3"
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

            modelBuilder.Entity("StalinGames.DAL.Models.PlayerItem", b =>
                {
                    b.Property<string>("ItemID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemID");

                    b.ToTable("PlayerItems");

                    b.HasData(
                        new
                        {
                            ItemID = "daa8e021-5637-4d98-ba6c-315d67a22488",
                            Name = "Simp",
                            Price = 2000,
                            Type = 0
                        },
                        new
                        {
                            ItemID = "fc45844c-a729-4de0-9d76-bf6845b54792",
                            Name = "Local Champion",
                            Price = 10000,
                            Type = 0
                        },
                        new
                        {
                            ItemID = "17305c55-4d03-4162-bcf0-4dcf1b49563c",
                            Name = "Absolute Legend",
                            Price = 100000,
                            Type = 0
                        },
                        new
                        {
                            ItemID = "4e0cca5c-aa25-4c41-abf7-cbba810eec38",
                            Name = "Black jack master",
                            Price = 200000,
                            Type = 1,
                            Value = "BlackJackMaster.jpg"
                        },
                        new
                        {
                            ItemID = "0acc88dd-f253-4335-9451-12e3ec0d912c",
                            Name = "Simple card pattern",
                            Price = 5000,
                            Type = 1,
                            Value = "CardPattern.jpg"
                        },
                        new
                        {
                            ItemID = "98b8971f-1907-4356-a597-5c683e5e52cd",
                            Name = "Casino master",
                            Price = 500000,
                            Type = 1,
                            Value = "CasinoMaster.jpg"
                        },
                        new
                        {
                            ItemID = "d123e239-392a-466c-8a47-e8b927794e3d",
                            Name = "Ace on fire",
                            Price = 50000,
                            Type = 1,
                            Value = "FireAce.jpg"
                        },
                        new
                        {
                            ItemID = "ee498721-6ecb-4343-986a-760a528983bd",
                            Name = "Roulette master",
                            Price = 200000,
                            Type = 1,
                            Value = "RouletteMaster.jpg"
                        },
                        new
                        {
                            ItemID = "a21eb22d-0aaa-46f3-a23e-8974f98aab0f",
                            Name = "Slot machine master",
                            Price = 200000,
                            Type = 1,
                            Value = "SlotMachineMaster.jpg"
                        },
                        new
                        {
                            ItemID = "88f584b8-d837-4d43-953f-bd48a58697a3",
                            Name = "Gambler",
                            Price = 0,
                            Type = 0
                        },
                        new
                        {
                            ItemID = "b4d7f0a6-0c99-4f7c-900e-00ea7811c708",
                            Name = "Wolf of Wall Street",
                            Price = 500000,
                            Type = 0
                        },
                        new
                        {
                            ItemID = "ea887ee4-13a8-409c-83ed-041923eb38c1",
                            Name = "KingPin",
                            Price = 1000000,
                            Type = 0
                        },
                        new
                        {
                            ItemID = "67b16a25-ed00-4f73-b0c8-b750a9caca12",
                            Name = "Default background",
                            Price = 0,
                            Type = 1,
                            Value = "DefaultBackground.jpg"
                        },
                        new
                        {
                            ItemID = "dee9e2b6-e006-416b-8fb1-fa6efa06e877",
                            Name = "Ultimate true StalinGames casino master",
                            Price = 1000000,
                            Type = 1,
                            Value = "TrueStalinGamesMaster.jpg"
                        });
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
                            OrderID = "eff27f0f-fbdd-4364-bddb-eb4579399fb8",
                            ItemID = "b4d7f0a6-0c99-4f7c-900e-00ea7811c708",
                            UserID = "e0d48632-5a2b-40d9-babd-6585a478ab09"
                        },
                        new
                        {
                            OrderID = "e7a21260-9e42-46fc-8547-9d369a10fc69",
                            ItemID = "ea887ee4-13a8-409c-83ed-041923eb38c1",
                            UserID = "e0d48632-5a2b-40d9-babd-6585a478ab09"
                        },
                        new
                        {
                            OrderID = "eb7a068b-2c1e-460d-b317-127ad6a9d0ae",
                            ItemID = "67b16a25-ed00-4f73-b0c8-b750a9caca12",
                            UserID = "e0d48632-5a2b-40d9-babd-6585a478ab09"
                        },
                        new
                        {
                            OrderID = "fe8b891a-ccbb-414c-a3d1-c8ff420694b0",
                            ItemID = "dee9e2b6-e006-416b-8fb1-fa6efa06e877",
                            UserID = "e0d48632-5a2b-40d9-babd-6585a478ab09"
                        },
                        new
                        {
                            OrderID = "b5bc73e7-71b9-46b8-8acd-ffd0c68f297f",
                            ItemID = "b4d7f0a6-0c99-4f7c-900e-00ea7811c708",
                            UserID = "ad0869ce-64ad-459c-9fde-e0522fd4c0c4"
                        },
                        new
                        {
                            OrderID = "9b1d4525-3589-4c1b-8a3c-ca256d483ea2",
                            ItemID = "67b16a25-ed00-4f73-b0c8-b750a9caca12",
                            UserID = "ad0869ce-64ad-459c-9fde-e0522fd4c0c4"
                        },
                        new
                        {
                            OrderID = "3f217ac7-c9d4-443f-9fa1-1acfcfdd6a26",
                            ItemID = "67b16a25-ed00-4f73-b0c8-b750a9caca12",
                            UserID = "068e7ce5-eda6-4961-89e8-3b29284a0fa3"
                        },
                        new
                        {
                            OrderID = "1ed7d38a-b2f7-43ed-bccb-36a19c639719",
                            ItemID = "67b16a25-ed00-4f73-b0c8-b750a9caca12",
                            UserID = "434fb57b-3d64-4352-9c91-7b7862c622dc"
                        },
                        new
                        {
                            OrderID = "7104a070-565e-4e44-bed1-86ebd13c89b7",
                            ItemID = "67b16a25-ed00-4f73-b0c8-b750a9caca12",
                            UserID = "0f36484f-2040-4483-88e7-9544b258fc74"
                        },
                        new
                        {
                            OrderID = "bd6f0c78-eaa4-4c2d-beca-8465a7f74e8e",
                            ItemID = "88f584b8-d837-4d43-953f-bd48a58697a3",
                            UserID = "ad0869ce-64ad-459c-9fde-e0522fd4c0c4"
                        },
                        new
                        {
                            OrderID = "79417ce6-4667-41b5-a017-3834f1aeeced",
                            ItemID = "88f584b8-d837-4d43-953f-bd48a58697a3",
                            UserID = "068e7ce5-eda6-4961-89e8-3b29284a0fa3"
                        },
                        new
                        {
                            OrderID = "dce8f9e4-3aab-43f6-946e-8b22f056a410",
                            ItemID = "88f584b8-d837-4d43-953f-bd48a58697a3",
                            UserID = "434fb57b-3d64-4352-9c91-7b7862c622dc"
                        },
                        new
                        {
                            OrderID = "beaaa60d-9d04-47cc-9596-4a17a93d6270",
                            ItemID = "88f584b8-d837-4d43-953f-bd48a58697a3",
                            UserID = "0f36484f-2040-4483-88e7-9544b258fc74"
                        },
                        new
                        {
                            OrderID = "43f053fb-0a9d-4ce4-b0ca-393023b00b44",
                            ItemID = "88f584b8-d837-4d43-953f-bd48a58697a3",
                            UserID = "fbbc4a4b-4f35-4cd9-a34d-2b2060598678"
                        },
                        new
                        {
                            OrderID = "ef2159ba-6d59-4afa-b6ce-fccea46dba17",
                            ItemID = "88f584b8-d837-4d43-953f-bd48a58697a3",
                            UserID = "474cefd2-42cd-4a24-abba-a5dd3a61afe1"
                        },
                        new
                        {
                            OrderID = "615617b3-1487-43a4-af3b-8afd3e168b95",
                            ItemID = "88f584b8-d837-4d43-953f-bd48a58697a3",
                            UserID = "2bfdf9fc-9fba-424c-bdc9-db3e8c7bc4af"
                        },
                        new
                        {
                            OrderID = "97137e0d-c42c-4855-a153-14bb0907856c",
                            ItemID = "67b16a25-ed00-4f73-b0c8-b750a9caca12",
                            UserID = "fbbc4a4b-4f35-4cd9-a34d-2b2060598678"
                        },
                        new
                        {
                            OrderID = "0b1dcff7-6694-4a2b-a16c-850a590799cf",
                            ItemID = "67b16a25-ed00-4f73-b0c8-b750a9caca12",
                            UserID = "474cefd2-42cd-4a24-abba-a5dd3a61afe1"
                        },
                        new
                        {
                            OrderID = "82237991-cca0-41b3-b964-fad2a77fe377",
                            ItemID = "67b16a25-ed00-4f73-b0c8-b750a9caca12",
                            UserID = "2bfdf9fc-9fba-424c-bdc9-db3e8c7bc4af"
                        });
                });

            modelBuilder.Entity("StalinGames.DAL.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("AccountCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BackGround")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Blyats")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("LastGamePlayed")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProfilePicturePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TotalBlyatsLost")
                        .HasColumnType("int");

                    b.Property<int>("TotalGamesPlayed")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "e0d48632-5a2b-40d9-babd-6585a478ab09",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "799e83bd-9aba-4084-8533-46d2c0182042",
                            Email = "Jens@StalinGames.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "JENS",
                            PasswordHash = "AQAAAAEAACcQAAAAEO9ohucz/rdShQsIcUK6233Kqg4AwmF50qFNQvRqMbctp5B9rcP3FK4a+lECjhFsGw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a75d737f-a00b-4a5c-be68-c52d8f65cf39",
                            TwoFactorEnabled = false,
                            UserName = "Jens",
                            AccountCreatedDate = new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            BackGround = "Default background",
                            Blyats = 2000,
                            CreatedBy = "e0d48632-5a2b-40d9-babd-6585a478ab09",
                            LastGamePlayed = 1591278688L,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfileTitle = "KingPin",
                            Status = 0,
                            TotalBlyatsLost = 0,
                            TotalGamesPlayed = 0
                        },
                        new
                        {
                            Id = "474cefd2-42cd-4a24-abba-a5dd3a61afe1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d03f1432-81a9-46e1-b432-5c4159ed6e46",
                            Email = "frederik@StalinGames.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "FREDERIK",
                            PasswordHash = "AQAAAAEAACcQAAAAEJcBOwtoZfLAPqtTfkA23xAfIfRS+Jh37kBZRqGduzV1PKml3bDEgOgr12gbxm/tHQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "070811c7-4a53-44fe-b5af-ceef8a16fc43",
                            TwoFactorEnabled = false,
                            UserName = "frederik",
                            AccountCreatedDate = new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            BackGround = "Default background",
                            Blyats = 2000,
                            CreatedBy = "474cefd2-42cd-4a24-abba-a5dd3a61afe1",
                            LastGamePlayed = 1591278688L,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfileTitle = "Gambler",
                            Status = 0,
                            TotalBlyatsLost = 0,
                            TotalGamesPlayed = 0
                        },
                        new
                        {
                            Id = "fbbc4a4b-4f35-4cd9-a34d-2b2060598678",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "45c79bde-0f96-491f-8367-430a2c907e65",
                            Email = "peter@Gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "PETER",
                            PasswordHash = "AQAAAAEAACcQAAAAEJvX4duougGE9oJbBBq118vIHatLdZudWOPKWVOJblBbLm2cEXIfGK/QObnsAylZXw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "49c96358-3adc-45a0-a966-42d6a01b3af3",
                            TwoFactorEnabled = false,
                            UserName = "peter",
                            AccountCreatedDate = new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            BackGround = "Default background",
                            Blyats = 2000,
                            CreatedBy = "fbbc4a4b-4f35-4cd9-a34d-2b2060598678",
                            LastGamePlayed = 1591278688L,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfileTitle = "Gambler",
                            Status = 0,
                            TotalBlyatsLost = 0,
                            TotalGamesPlayed = 0
                        },
                        new
                        {
                            Id = "2bfdf9fc-9fba-424c-bdc9-db3e8c7bc4af",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b4e5b0fd-5ad9-466a-81fa-0d79fa18463d",
                            Email = "steven@StalinGames.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "steven",
                            PasswordHash = "AQAAAAEAACcQAAAAEKoyVsyy/wpVaRXAxnPADVoy7YbdaxltV2wvteUsIm4mWnYCItbh5X5Gw+XyzazetA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0074f8ca-e5ad-49a8-a02f-fe02a2a338ce",
                            TwoFactorEnabled = false,
                            UserName = "steven",
                            AccountCreatedDate = new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            BackGround = "Default background",
                            Blyats = 2000,
                            CreatedBy = "2bfdf9fc-9fba-424c-bdc9-db3e8c7bc4af",
                            LastGamePlayed = 1591278688L,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfileTitle = "Gambler",
                            Status = 0,
                            TotalBlyatsLost = 0,
                            TotalGamesPlayed = 0
                        },
                        new
                        {
                            Id = "068e7ce5-eda6-4961-89e8-3b29284a0fa3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4a2c6364-4774-4cda-8e62-ce2574ba3d48",
                            Email = "frank@Gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "frank",
                            PasswordHash = "AQAAAAEAACcQAAAAEHGxGIz/O0dGb6J2LFLNGTDYim8oMJGmJ5/BlGW8piMlFoy9bKXG5nMA8OSN4CWgVg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4f7fd574-59f3-4bb6-85d7-75fc6e51d5d8",
                            TwoFactorEnabled = false,
                            UserName = "frank",
                            AccountCreatedDate = new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            BackGround = "Default background",
                            Blyats = 2000,
                            CreatedBy = "068e7ce5-eda6-4961-89e8-3b29284a0fa3",
                            LastGamePlayed = 1591278688L,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfileTitle = "Gambler",
                            Status = 0,
                            TotalBlyatsLost = 0,
                            TotalGamesPlayed = 0
                        },
                        new
                        {
                            Id = "434fb57b-3d64-4352-9c91-7b7862c622dc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1908a597-42f8-4bac-b1ea-76ebd33e3c6a",
                            Email = "jan@Gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "jan",
                            PasswordHash = "AQAAAAEAACcQAAAAEITmUAd6HqgqLPrPRWzPIxm6K8851euTLmhYAKICdU4Fw02RCHAImYcxtz1OYvsfJQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "59370f79-a251-4235-9133-373815e4a714",
                            TwoFactorEnabled = false,
                            UserName = "jan",
                            AccountCreatedDate = new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            BackGround = "Default background",
                            Blyats = 2000,
                            CreatedBy = "434fb57b-3d64-4352-9c91-7b7862c622dc",
                            LastGamePlayed = 1591278688L,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfileTitle = "Gambler",
                            Status = 0,
                            TotalBlyatsLost = 0,
                            TotalGamesPlayed = 0
                        },
                        new
                        {
                            Id = "ad0869ce-64ad-459c-9fde-e0522fd4c0c4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4120ce5e-300c-4b4b-89a9-683aa2350a45",
                            Email = "eddy@Gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "eddy",
                            PasswordHash = "AQAAAAEAACcQAAAAEMt6jXzKhn9vdqDsrwyEkJWR0exwoydlEm7USmaPhBDFc97M1TRwR+Xfwb7L7phFXg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3387d469-05eb-428f-8aad-1ac205b0aab9",
                            TwoFactorEnabled = false,
                            UserName = "eddy",
                            AccountCreatedDate = new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            BackGround = "Default background",
                            Blyats = 2000,
                            CreatedBy = "ad0869ce-64ad-459c-9fde-e0522fd4c0c4",
                            LastGamePlayed = 1591278688L,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfileTitle = "Gambler",
                            Status = 0,
                            TotalBlyatsLost = 0,
                            TotalGamesPlayed = 0
                        },
                        new
                        {
                            Id = "0f36484f-2040-4483-88e7-9544b258fc74",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2caecd79-ea89-4cca-ab75-1facaac49c54",
                            Email = "karel@Gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "karel",
                            PasswordHash = "AQAAAAEAACcQAAAAEE7GGe89S6l1v9SRTO4aJiYXuUDtG4TYhC4X5dLpiZUELdEEXD/SyCjAsawgAw+IXg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a2d9444e-abca-4a23-9b90-eea5e36bbe6e",
                            TwoFactorEnabled = false,
                            UserName = "karel",
                            AccountCreatedDate = new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            BackGround = "Default background",
                            Blyats = 2000,
                            CreatedBy = "0f36484f-2040-4483-88e7-9544b258fc74",
                            LastGamePlayed = 1591278688L,
                            LastUpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfileTitle = "Gambler",
                            Status = 0,
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
#pragma warning restore 612, 618
        }
    }
}
