using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IWeapon
    {
        string DamageType { get; set; }
        string Defense { get; set; }

        IInfixUpgrade InfixUpgrade { get; set; }
        Collection<object> InfusionSlots { get; set; }
        string MaxPower { get; set; }
        string MinPower { get; set; }
        string SuffixItemId { get; set; }
        string Type { get; set; }
    }
}
