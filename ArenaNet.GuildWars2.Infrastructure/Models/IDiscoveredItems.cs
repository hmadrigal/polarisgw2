using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IDiscoveredItems
    {
        Collection<int> ItemIds { get; set; }
    }
}
