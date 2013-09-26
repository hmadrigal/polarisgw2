using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class Continent : IContinent
    {
        public string Name { get; set; }
        [JsonProperty("continent_dims")]
        public Collection<int> ContinentDims { get; set; }
        [JsonProperty("min_zoom")]
        public int MinZoom { get; set; }
        [JsonProperty("max_zoom")]
        public int MaxZoom { get; set; }
        public Collection<int> Floors { get; set; }
    }
}
