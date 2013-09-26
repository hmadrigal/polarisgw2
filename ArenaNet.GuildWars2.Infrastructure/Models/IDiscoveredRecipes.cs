using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IDiscoveredRecipes
    {
        Collection<int> Recipes { get; set; }
    }
}
