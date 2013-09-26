using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class Metal : IMetal
    {
        public int Brightness { get; set; }
        public double Contrast { get; set; }
        public int Hue { get; set; }
        public double Saturation { get; set; }
        public double Lightness { get; set; }
        public Collection<int> Rgb { get; set; }
    }
}
