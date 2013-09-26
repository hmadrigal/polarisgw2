using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IWorldVsWorldMap
    {
        Collection<IWorldVsWorldObjective> Objectives { get; set; }
        Collection<int> Scores { get; set; }
        string Type { get; set; }
    }
}
