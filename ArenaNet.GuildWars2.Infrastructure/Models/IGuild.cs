using System;
namespace ArenaNet.GuildWars2.Models
{
    public interface IGuild
    {
        IEmblem Emblem { get; set; }
        string GuildId { get; set; }
        string GuildName { get; set; }
        string Tag { get; set; }
    }
}
