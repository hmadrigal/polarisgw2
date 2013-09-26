using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IContinent
    {
        Collection<int> ContinentDims { get; set; }
        Collection<int> Floors { get; set; }
        int MaxZoom { get; set; }
        int MinZoom { get; set; }
        string Name { get; set; }
    }
}
