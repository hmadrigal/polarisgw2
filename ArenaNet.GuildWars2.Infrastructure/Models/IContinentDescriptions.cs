using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IContinentDescriptions
    {
        Dictionary<string, IContinent> Continents { get; set; }
    }
}
