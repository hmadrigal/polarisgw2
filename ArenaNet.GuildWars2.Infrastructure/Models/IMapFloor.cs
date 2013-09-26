using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IMapFloor
    {
        Dictionary<string, IRegion> Regions { get; set; }
        Collection<int> TextureDims { get; set; }
    }
}
