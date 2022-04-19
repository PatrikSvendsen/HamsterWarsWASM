using HamsterWarsWASM.Shared.Entities;
using HamsterWarsWASM.Shared.Service;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Services.MatchService;

public class MatchService : IMatchService
{
    private readonly DataContext _context;

    public MatchService(DataContext context)
    {
        _context = context;
    }

    public async Task<ServiceResponse<List<Match>>> GetMatches()
    {
        var matches = await _context.Matches.ToListAsync();
        return new ServiceResponse<List<Match>>
        {
            Data = matches
        };
    }
}


