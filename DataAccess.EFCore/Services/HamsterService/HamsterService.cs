﻿using HamsterWarsWASM.Shared.Entities;
using HamsterWarsWASM.Shared.Service;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Services.HamsterService;

public class HamsterService : IHamsterService
{
    private readonly DataContext _context;
    private static readonly Random rnd = new Random();

    public HamsterService(DataContext context)
    {
        _context = context;
    }

    public async Task<ServiceResponse<Hamster>> CreateHamster(Hamster hamster)
    {
        _context.Hamsters.Add(hamster);
        await _context.SaveChangesAsync();
        return new ServiceResponse<Hamster> { Data = hamster };
    }

    public async Task<ServiceResponse<bool>> DeleteHamster(int hamsterId) // Bättre att inte ta bort hamster helt. Ha dem kvar men "osynliga".
                                                                          // då skiter inte db på sig om man kollar history.
    {
        var dbHamster = await _context.Hamsters.FindAsync(hamsterId);
        if (dbHamster == null)
        {
            return new ServiceResponse<bool>
            {
                Success = false,
                Data = false,
                Message = "Hamster not found."
            };
        }

        dbHamster.Deleted = true;

        await _context.SaveChangesAsync();
        return new ServiceResponse<bool> { Data = true };
    }

    public async Task<ServiceResponse<Hamster>> GetHamsterAsync(int hamsterId)
    {
        var response = new ServiceResponse<Hamster>();
        var hamster = await _context.Hamsters
            .FindAsync(hamsterId);

        if (hamster == null || hamster.Deleted == false) // TODO --Kolla om denna funktion fungerar korrekt
        {
            response.Success = false;
            response.Message = $"No hamster with this Id:{hamsterId}";
        }
        response.Data = hamster;
        return response;
    }
    public async Task<ServiceResponse<List<Hamster>>> GetHamstersAsync()
    {
        var response = new ServiceResponse<List<Hamster>>
        {
            Data = await _context.Hamsters
            .Where(x => x.Deleted == false)
            .ToListAsync()
        };
        return response;
    }
    public async Task<ServiceResponse<List<Hamster>>> GetTop5(string top5)
    {
        var response = new ServiceResponse<List<Hamster>>
        {
            Data = await _context.Hamsters
            //.OrderByDescending(x => x.Wins)
            .Take(2)
            .ToListAsync()
        };
        return response;
    }

    public async Task<ServiceResponse<Hamster>> UpdateHamster(Hamster hamster)
    {
        var dbHamster = await _context.Hamsters.FindAsync(hamster.Id);
        if (dbHamster == null)
        {
            return new ServiceResponse<Hamster>
            {
                Success = false,
                Message = "Hamster not found."
            };
        }

        dbHamster.Name = hamster.Name;
        dbHamster.Age = hamster.Age;
        dbHamster.FavFood = hamster.FavFood;
        dbHamster.Loves = hamster.Loves;
        dbHamster.ImgName = hamster.ImgName;
        dbHamster.Wins = hamster.Wins;
        dbHamster.Defeats = hamster.Defeats;
        dbHamster.Games = hamster.Games;
        dbHamster.Deleted = hamster.Deleted;

        await _context.SaveChangesAsync();
        return new ServiceResponse<Hamster> { Data = hamster };

    }

    public async Task<ServiceResponse<Hamster>> UpdateDefeatedResult(int hamsterId)
    {
        var defeatedHamster = await _context.Hamsters.FindAsync(hamsterId);
        if (defeatedHamster == null)
        {
            return new ServiceResponse<Hamster>
            {
                Success = false,
                Message = "Hamster not found."
            };
        }

        defeatedHamster.Defeats +=
        defeatedHamster.Games +=

        await _context.SaveChangesAsync();
        return new ServiceResponse<Hamster> { Data = defeatedHamster };
    }

    public async Task<ServiceResponse<Hamster>> UpdateWinningResult(int hamsterId)
    {
        var winningHamster = await _context.Hamsters.FindAsync(hamsterId);
        if (winningHamster == null)
        {
            return new ServiceResponse<Hamster>
            {
                Success = false,
                Message = "Hamster not found."
            };
        }

        winningHamster.Wins +=
        winningHamster.Games +=

        await _context.SaveChangesAsync();
        return new ServiceResponse<Hamster> { Data = winningHamster };
    }

    public async Task<ServiceResponse<List<Hamster>>> ShuffleRandomHamsters()
    {
        int n = _context.Hamsters.Count();
        var list = await _context.Hamsters.ToListAsync();

        // Plockat från Stackoverflow/google --https://blog.codinghorror.com/shuffling/
        while (n > 1)
        {
            int k = (rnd.Next(0, n) % n);
            n--;
            Hamster value = list[k];
            list[k] = list[n];
            list[n] = value;
        }

        var response = new ServiceResponse<List<Hamster>>
        {
            Data = list
            .Where(x => x.Deleted == false)
            .Take(2)
            .ToList()
        };

        return response;
    }
}
