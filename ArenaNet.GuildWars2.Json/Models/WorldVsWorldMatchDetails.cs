using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;


namespace ArenaNet.GuildWars2.Models
{
    public class WorldVsWorldMatchDetails : IWorldVsWorldMatchDetails
    {
        [JsonProperty("match_id")]
        public string MatchId { get; set; }
        public Collection<int> Scores { get; set; }
        [JsonConverter(typeof(GenericJsonConverter<IWorldVsWorldMap, WorldVsWorldMap>))]
        public Collection<IWorldVsWorldMap> Maps { get; set; }
    }
}
