using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IWorldVsWorldMatchDetails
    {
        string MatchId { get; set; }
        Collection<IWorldVsWorldMap> Maps { get; set; }
        Collection<int> Scores { get; set; }
    }
}
