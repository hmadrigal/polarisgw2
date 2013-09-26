
using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface ISector
    {
        Collection<double> Coordinates { get; set; }
        int Id { get; set; }
        int Level { get; set; }
        string Name { get; set; }
    }
}
