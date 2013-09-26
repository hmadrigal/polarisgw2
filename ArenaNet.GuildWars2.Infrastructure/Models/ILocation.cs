using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface ILocation
    {
        Collection<double> Center { get; set; }
        Collection<Collection<double>> Points { get; set; }
        string Type { get; set; }
        Collection<int> ZRange { get; set; }
        double? Rotation { get; set; }
        double? Height { get; set; }
        double? Radius { get; set; }
    }
}
