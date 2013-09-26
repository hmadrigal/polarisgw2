using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IColorDescriptions
    {
        Collection<KeyValuePair<string, IColors>> Colors { get; set; }
    }
}
