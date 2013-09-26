using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaNet.GuildWars2.Models
{
    public class Leather : ILeather
    {
        public int Brightness { get; set; }
        public double Contrast { get; set; }
        public int Hue { get; set; }
        public double Saturation { get; set; }
        public double Lightness { get; set; }
        public Collection<int> Rgb { get; set; }
    }
}
