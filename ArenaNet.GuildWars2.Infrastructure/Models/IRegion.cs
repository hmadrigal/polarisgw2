using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IRegion
    {
        Collection<int> LabelCoordinates { get; set; }
        Collection<KeyValuePair<string, IMapRegionDetails>> Maps { get; set; }
        string Name { get; set; }
    }
}
