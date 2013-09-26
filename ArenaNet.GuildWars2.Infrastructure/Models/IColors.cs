using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IColors
    {
        Collection<int> BaseRgb { get; set; }
        ICloth Cloth { get; set; }
        ILeather Leather { get; set; }
        IMetal Metal { get; set; }
        string Name { get; set; }
    }
}
