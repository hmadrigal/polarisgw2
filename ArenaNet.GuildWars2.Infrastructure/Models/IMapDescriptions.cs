using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IMapDescriptions
    {
        Dictionary<string, IMapDetails> Maps { get; set; }
    }
}
