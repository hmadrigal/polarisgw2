using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IMapDetails : IMap
    {
        int ContinentId { get; set; }
        string ContinentName { get; set; }
        Collection<Collection<int>> ContinentRect { get; set; }
        int DefaultFloor { get; set; }
        Collection<int> Floors { get; set; }
        string MapName { get; set; }
        Collection<Collection<int>> MapRect { get; set; }
        int MaxLevel { get; set; }
        int MinLevel { get; set; }
        int RegionId { get; set; }
        string RegionName { get; set; }
    }
}
