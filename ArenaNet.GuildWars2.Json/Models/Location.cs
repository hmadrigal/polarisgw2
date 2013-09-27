using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class Location : ILocation
    {
        public string Type { get; set; }
        public Collection<double> Center { get; set; }

        // TODO: only when type is set to 'poly'
        public Collection<Collection<double>> Points { get; set; }
        [JsonProperty("z_range")]
        public Collection<int> ZRange { get; set; }

        // TODO: only when type is set to 'sphere'

        // TODO: only when type is set to 'cylinder'
        public double? Height { get; set; }
        public double? Radius { get; set; }
        public double? Rotation { get; set; }
    }
}
