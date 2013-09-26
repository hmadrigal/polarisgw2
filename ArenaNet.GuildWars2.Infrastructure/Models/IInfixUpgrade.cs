using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IInfixUpgrade
    {
        Collection<IWeaponAttribute> Attributes { get; set; }
    }
}
