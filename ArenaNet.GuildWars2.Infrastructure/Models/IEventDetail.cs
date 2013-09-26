using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IEventDetail
    {
        Collection<string> Flags { get; set; }
        int Level { get; set; }
        ILocation Location { get; set; }
        int MapId { get; set; }
        string Name { get; set; }
    }
}
