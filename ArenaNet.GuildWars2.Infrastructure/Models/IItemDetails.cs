using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    //// TODO: Please implement data as presented in http://wiki.guildwars2.com/wiki/API/item_details
    public interface IItemDetails
    {
        string Description { get; set; }
        Collection<string> Flags { get; set; }
        Collection<string> GameTypes { get; set; }
        string ItemId { get; set; }
        string Level { get; set; }
        string Name { get; set; }
        string Rarity { get; set; }
        Collection<object> Restrictions { get; set; }
        string Type { get; set; }
        string VendorValue { get; set; }
        IWeapon Weapon { get; set; }
    }
}
