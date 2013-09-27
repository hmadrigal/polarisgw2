using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class MapDetails : Map, IMapDetails
    {
        [JsonProperty("map_name")]
        public string MapName { get; set; }
        [JsonProperty("min_level")]
        public int MinLevel { get; set; }
        [JsonProperty("max_level")]
        public int MaxLevel { get; set; }
        [JsonProperty("default_floor")]
        public int DefaultFloor { get; set; }
        public Collection<int> Floors { get; set; }
        [JsonProperty("region_id")]
        public int RegionId { get; set; }
        [JsonProperty("region_name")]
        public string RegionName { get; set; }
        [JsonProperty("continent_id")]
        public int ContinentId { get; set; }
        [JsonProperty("continent_name")]
        public string ContinentName { get; set; }
        [JsonProperty("map_rect")]
        public Collection<Collection<int>> MapRect { get; set; }
        [JsonProperty("continent_rect")]
        public Collection<Collection<int>> ContinentRect { get; set; }
    }
}
