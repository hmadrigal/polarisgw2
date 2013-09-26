using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class PointsOfInterest : IPointsOfInterest
    {
        [JsonProperty("poi_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Floor { get; set; }
        [JsonProperty("coord")]
        public Collection<double> Coordinates { get; set; }
    }
}
