using System;
namespace ArenaNet.GuildWars2.Models
{
    public interface IIngredient
    {
        string Count { get; set; }
        string ItemId { get; set; }
    }
}
