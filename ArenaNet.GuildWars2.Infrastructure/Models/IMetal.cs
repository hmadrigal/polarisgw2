using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IMetal
    {
        int Brightness { get; set; }
        double Contrast { get; set; }
        int Hue { get; set; }
        double Lightness { get; set; }
        Collection<int> Rgb { get; set; }
        double Saturation { get; set; }
    }
}
