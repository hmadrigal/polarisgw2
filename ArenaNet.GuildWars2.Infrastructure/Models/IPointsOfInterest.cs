using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IPointsOfInterest
    {
        Collection<double> Coordinates { get; set; }
        int Floor { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
    }
}
