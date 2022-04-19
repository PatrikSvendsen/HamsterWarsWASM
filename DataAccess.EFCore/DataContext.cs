using HamsterWarsWASM.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Hamster> Hamsters { get; set; }
    public DbSet<Match> Matches { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Match>().HasData(
            new Match
            {
                Id = 1,
                LoserId = 1,
                WinnerId = 2,
            },
            new Match
            {
                Id = 2,
                LoserId = 4,
                WinnerId = 3,
            },
            new Match
            {
                Id = 3,
                LoserId = 5,
                WinnerId = 6,
            });

        modelBuilder.Entity<Hamster>().HasData(
            new Hamster
            {
                Id = 1,
                Name = "Rasmus",
                Age = 2,
                ImgName = "/images/hamsters/hamster-1.jpg",
                Wins = 0,
                Defeats = 1,
                Games = 1,
                MatchId = 1
            },
            new Hamster
            {
                Id = 2,
                Name = "Patrik",
                Age = 2,
                ImgName = "/images/hamsters/hamster-2.jpg",
                Wins = 1,
                Defeats = 0,
                Games = 1,
                MatchId = 1
            },
            new Hamster
            {
                Id = 3,
                Name = "Pontus",
                Age = 4,
                ImgName = "/images/hamsters/hamster-3.jpg",
                Wins = 1,
                Defeats = 0,
                Games = 1,
                MatchId = 2
            },
            new Hamster
            {
                Id = 4,
                Name = "Mikael",
                Age = 7,
                ImgName = "/images/hamsters/hamster-4.jpg",
                Wins = 0,
                Defeats = 1,
                Games = 1,
                MatchId = 2
            },
            new Hamster
            {
                Id = 5,
                Name = "Claes",
                Age = 10,
                ImgName = "/images/hamsters/hamster-5.jpg",
                Wins = 0,
                Defeats = 1,
                Games = 1,
                MatchId = 3
            },
            new Hamster
            {
                Id = 6,
                Name = "Jimmy",
                Age = 6,
                ImgName = "/images/hamsters/hamster-6.jpg",
                Wins = 1,
                Defeats = 0,
                Games = 1,
                MatchId = 3
            });
    }

}
