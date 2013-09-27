using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class MapRegionDetails : MapDescriptions, IMapRegionDetails
    {
        public string Name { get; set; }
        [JsonProperty("min_level")]
        public int MinLevel { get; set; }
        [JsonProperty("max_level")]
        public int MaxLevel { get; set; }
        [JsonProperty("default_floor")]
        public int DefaultFloor { get; set; }
        [JsonProperty("map_rect")]
        public Collection<Collection<int>> MapRect { get; set; }
        [JsonProperty("continent_rect")]
        public Collection<Collection<int>> ContinentRect { get; set; }
        [JsonProperty("points_of_interest")]
        [JsonConverter(typeof(GenericJsonConverter<IPointsOfInterest, PointsOfInterest>))]
        public Collection<IPointsOfInterest> PointsOfInterest { get; set; }
        [JsonConverter(typeof(GenericJsonConverter<ITask, Task>))]
        public Collection<ITask> Tasks { get; set; }
        [JsonProperty("skill_challenges")]
        [JsonConverter(typeof(GenericJsonConverter<ISkillChallenge, SkillChallenge>))]
        public Collection<ISkillChallenge> SkillChallenges { get; set; }
        [JsonConverter(typeof(GenericJsonConverter<ISector, Sector>))]
        public Collection<ISector> Sectors { get; set; }
    }
}
