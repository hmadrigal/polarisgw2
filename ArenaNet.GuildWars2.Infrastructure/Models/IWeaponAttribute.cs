using System;
namespace ArenaNet.GuildWars2.Models
{
    public interface IWeaponAttribute
    {
        string Attribute { get; set; }
        string Modifier { get; set; }
    }
}
