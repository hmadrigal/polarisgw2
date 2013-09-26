using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IDynamicEvents
    {
        Collection<IEvent> Events { get; set; }
    }
}
