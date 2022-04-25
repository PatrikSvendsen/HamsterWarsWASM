using DataAccess.EFCore.Services.GenericService;
using HamsterWarsWASM.Shared.Entities;
using HamsterWarsWASM.Shared.Service;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Services.MatchService;

public class MatchService : GenericService<Match>, IMatchService
{
    //private readonly DataContext _context;

    public MatchService(DataContext context) : base(context) 
    { 
        //_context = context;
    }

    //public async Task<ServiceResponse<Match>> CreateMatch(Match match)
    //{
    //    _context.Matches.Add(match);
    //    await _context.SaveChangesAsync();
    //    return new ServiceResponse<Match> { Data = match };
    //}

    //public async Task<ServiceResponse<bool>> DeleteMatch(int matchId)
    //{
    //    var dbMatch = await _context.Matches.FindAsync(matchId);
    //    if (dbMatch == null)
    //    {
    //        return new ServiceResponse<bool>
    //        {
    //            Success = false,
    //            Data = false,
    //            Message = "Match not found."
    //        };
    //    }

    //    dbMatch.Deleted = true;

    //    await _context.SaveChangesAsync();
    //    return new ServiceResponse<bool> { Data = true };
    //}

    //public async Task<ServiceResponse<Match>> GetMatch(int matchId)
    //{
    //    var response = new ServiceResponse<Match>();
    //    var match = await _context.Matches.FindAsync(matchId);

    //    if (match == null || match.Deleted == true)
    //    {
    //        response.Success = false;
    //        response.Message = $"No match with this Id: {matchId}";
    //    }
    //    response.Data = match;
    //    return response;
    //}

    //public async Task<ServiceResponse<List<Match>>> GetMatches()
    //{
    //    //var matches = await _context.Matches.ToListAsync();
    //    //return new ServiceResponse<List<Match>>
    //    //{
    //    //    Data = matches
    //    //};

    //    var response = new ServiceResponse<List<Match>>
    //    {
    //        Data = await _context.Matches
    //        .Where(x => x.Deleted == false)
    //        .ToListAsync()
    //    };

    //    return response;
    //}
}


