﻿// <auto-generated />
using System;
using DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HamsterWarsWASM.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HamsterWarsWASM.Shared.Entities.Hamster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("HamsterId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Defeats")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("FavFood")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Games")
                        .HasColumnType("int");

                    b.Property<string>("ImgName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Loves")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("MatchId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.ToTable("Hamsters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 1,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Pizza",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-9.jpg",
                            Loves = "Hjulet",
                            Name = "Rasmus",
                            Wins = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 2,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Fika",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-8.jpg",
                            Loves = "Meetings",
                            Name = "Jimmy",
                            Wins = 0
                        },
                        new
                        {
                            Id = 3,
                            Age = 3,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Pancakes",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-7.jpg",
                            Loves = "Intellisense",
                            Name = "Claes",
                            Wins = 0
                        },
                        new
                        {
                            Id = 4,
                            Age = 2,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Korv",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-1.jpg",
                            Loves = "Korvar",
                            Name = "Korven",
                            Wins = 0
                        },
                        new
                        {
                            Id = 5,
                            Age = 2,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-2.jpg",
                            Loves = "Jumping",
                            Name = "Patrik",
                            Wins = 0
                        },
                        new
                        {
                            Id = 6,
                            Age = 4,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-3.jpg",
                            Loves = "Kvivksilver",
                            Name = "Pontus",
                            Wins = 0
                        },
                        new
                        {
                            Id = 7,
                            Age = 7,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Popcorn",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-4.jpg",
                            Loves = "Berras Bio",
                            Name = "Mikael",
                            Wins = 0
                        },
                        new
                        {
                            Id = 8,
                            Age = 10,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-5.jpg",
                            Loves = "Träd",
                            Name = "Bävern",
                            Wins = 0
                        },
                        new
                        {
                            Id = 9,
                            Age = 2,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Blötmat",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-6.jpg",
                            Loves = "Lekar",
                            Name = "Kattis",
                            Wins = 0
                        },
                        new
                        {
                            Id = 10,
                            Age = 3,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "FUZEON",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-10.jpg",
                            Loves = "Kids",
                            Name = "Hyaena",
                            Wins = 0
                        },
                        new
                        {
                            Id = 11,
                            Age = 3,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-11.jpg",
                            Loves = "Lekar",
                            Name = "Kingfisher",
                            Wins = 0
                        },
                        new
                        {
                            Id = 12,
                            Age = 4,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-12.jpg",
                            Loves = "Hjulet",
                            Name = "Robin",
                            Wins = 0
                        },
                        new
                        {
                            Id = 13,
                            Age = 1,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-13.jpg",
                            Loves = "Lekar",
                            Name = "Lynx",
                            Wins = 0
                        },
                        new
                        {
                            Id = 14,
                            Age = 1,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-14.jpg",
                            Loves = "Lekar",
                            Name = "Duck",
                            Wins = 0
                        },
                        new
                        {
                            Id = 15,
                            Age = 2,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Blötmat",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-15.jpg",
                            Loves = "Hjulet",
                            Name = "Rhinoceros",
                            Wins = 0
                        },
                        new
                        {
                            Id = 16,
                            Age = 3,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-16.jpg",
                            Loves = "Lekar",
                            Name = "Red",
                            Wins = 0
                        },
                        new
                        {
                            Id = 17,
                            Age = 1,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-17.jpg",
                            Loves = "Hjulet",
                            Name = "Gazelle",
                            Wins = 0
                        },
                        new
                        {
                            Id = 18,
                            Age = 5,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-18.jpg",
                            Loves = "Lekar",
                            Name = "Dragon",
                            Wins = 0
                        },
                        new
                        {
                            Id = 19,
                            Age = 4,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Blötmat",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-19.jpg",
                            Loves = "Lekar",
                            Name = "Lourie",
                            Wins = 0
                        },
                        new
                        {
                            Id = 20,
                            Age = 3,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-20.jpg",
                            Loves = "Hjulet",
                            Name = "Squirrel",
                            Wins = 0
                        },
                        new
                        {
                            Id = 21,
                            Age = 2,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-21.jpg",
                            Loves = "Lekar",
                            Name = "Carmine",
                            Wins = 0
                        },
                        new
                        {
                            Id = 22,
                            Age = 2,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Popcorn",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-22.jpg",
                            Loves = "Hjulet",
                            Name = "Snake",
                            Wins = 0
                        },
                        new
                        {
                            Id = 23,
                            Age = 1,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-23.jpg",
                            Loves = "Lekar",
                            Name = "Bear",
                            Wins = 0
                        },
                        new
                        {
                            Id = 24,
                            Age = 3,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-24.jpg",
                            Loves = "Hjulet",
                            Name = "Chickadee",
                            Wins = 0
                        },
                        new
                        {
                            Id = 25,
                            Age = 3,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-25.jpg",
                            Loves = "Lekar",
                            Name = "Vervet ",
                            Wins = 0
                        },
                        new
                        {
                            Id = 26,
                            Age = 3,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-26.jpg",
                            Loves = "Hjulet",
                            Name = "Malagasy ",
                            Wins = 0
                        },
                        new
                        {
                            Id = 27,
                            Age = 3,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-27.jpg",
                            Loves = "Lekar",
                            Name = "Malleefowl",
                            Wins = 0
                        },
                        new
                        {
                            Id = 28,
                            Age = 1,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Bark",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-28.jpg",
                            Loves = "Hjulet",
                            Name = "Desert",
                            Wins = 0
                        },
                        new
                        {
                            Id = 29,
                            Age = 2,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Popcorn",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-29.jpg",
                            Loves = "Lekar",
                            Name = "Kaffir",
                            Wins = 0
                        },
                        new
                        {
                            Id = 30,
                            Age = 1,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-30.jpg",
                            Loves = "Lekar",
                            Name = "Nubian ",
                            Wins = 0
                        },
                        new
                        {
                            Id = 31,
                            Age = 2,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Popcorn",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-31.jpg",
                            Loves = "Hjulet",
                            Name = "Macaw",
                            Wins = 0
                        },
                        new
                        {
                            Id = 32,
                            Age = 3,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Blötmat",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-32.jpg",
                            Loves = "Lekar",
                            Name = "Woodcock",
                            Wins = 0
                        },
                        new
                        {
                            Id = 33,
                            Age = 4,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-33.jpg",
                            Loves = "Hjulet",
                            Name = "Eurasian",
                            Wins = 0
                        },
                        new
                        {
                            Id = 34,
                            Age = 4,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Gräs",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-34.jpg",
                            Loves = "Lekar",
                            Name = "Mynah",
                            Wins = 0
                        },
                        new
                        {
                            Id = 35,
                            Age = 4,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Popcorn",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-35.jpg",
                            Loves = "Lekar",
                            Name = "Sportive",
                            Wins = 0
                        },
                        new
                        {
                            Id = 36,
                            Age = 3,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Gräs",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-36.jpg",
                            Loves = "Hjulet",
                            Name = "Marten",
                            Wins = 0
                        },
                        new
                        {
                            Id = 37,
                            Age = 2,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-37.jpg",
                            Loves = "Lekar",
                            Name = "Malagasy",
                            Wins = 0
                        },
                        new
                        {
                            Id = 38,
                            Age = 1,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Popcorn",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-38.jpg",
                            Loves = "Hjulet",
                            Name = "Grey ",
                            Wins = 0
                        },
                        new
                        {
                            Id = 39,
                            Age = 1,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Gräs",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-39.jpg",
                            Loves = "Lekar",
                            Name = "Bear",
                            Wins = 0
                        },
                        new
                        {
                            Id = 40,
                            Age = 2,
                            Defeats = 0,
                            Deleted = false,
                            FavFood = "Sallad",
                            Games = 0,
                            ImgName = "/images/hamsters/hamster-40.jpg",
                            Loves = "Hjulet",
                            Name = "Four",
                            Wins = 0
                        });
                });

            modelBuilder.Entity("HamsterWarsWASM.Shared.Entities.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MatchId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("LoserId")
                        .HasColumnType("int");

                    b.Property<int>("WinnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("HamsterWarsWASM.Shared.Entities.Hamster", b =>
                {
                    b.HasOne("HamsterWarsWASM.Shared.Entities.Match", "Match")
                        .WithMany("Hamsters")
                        .HasForeignKey("MatchId");

                    b.Navigation("Match");
                });

            modelBuilder.Entity("HamsterWarsWASM.Shared.Entities.Match", b =>
                {
                    b.Navigation("Hamsters");
                });
#pragma warning restore 612, 618
        }
    }
}
