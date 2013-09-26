using System;
namespace ArenaNet.GuildWars2.Models
{
    public interface IWorldVsWorldMatch
    {
        int BlueWorldId { get; set; }
        DateTime EndTime { get; set; }
        int GreenWorldId { get; set; }
        int RedWorldId { get; set; }
        DateTime StartTime { get; set; }
        string WvwMatchId { get; set; }
    }
}
