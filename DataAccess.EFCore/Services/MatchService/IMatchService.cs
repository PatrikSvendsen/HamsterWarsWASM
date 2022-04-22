﻿using HamsterWarsWASM.Shared.Entities;
using HamsterWarsWASM.Shared.Service;

namespace DataAccess.EFCore.Services.MatchService;

public interface IMatchService
{
    Task<ServiceResponse<List<Match>>> GetMatches(); // GET /matches
    Task<ServiceResponse<Match>> GetMatch(int matchId); // GET /matches/id
    Task<ServiceResponse<Match>> CreateMatch(Match match); // POST /matches
    Task<ServiceResponse<bool>> DeleteMatch(int matchId); // DELETE /matches/id

    
}
