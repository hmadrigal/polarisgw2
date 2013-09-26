using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IEventDescriptions
    {
        Dictionary<string, IEventDetail> Events { get; set; }
    }
}
