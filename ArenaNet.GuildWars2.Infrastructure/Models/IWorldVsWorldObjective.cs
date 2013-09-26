using System;
namespace ArenaNet.GuildWars2.Models
{
    public interface IWorldVsWorldObjective
    {
        int Id { get; set; }
        string Owner { get; set; }
        string OwnerGuild { get; set; }
    }
}
