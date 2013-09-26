using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IWorldVsWorldMatches
    {
        Collection<IWorldVsWorldMatch> Matches { get; set; }
    }
}
