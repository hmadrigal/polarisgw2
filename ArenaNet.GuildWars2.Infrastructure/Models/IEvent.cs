using System;
namespace ArenaNet.GuildWars2.Models
{
    public interface IEvent
    {
        string EventId { get; set; }
        int MapId { get; set; }
        string State { get; set; }
        int WorldId { get; set; }
    }
}
