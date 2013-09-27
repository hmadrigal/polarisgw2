using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;


namespace ArenaNet.GuildWars2.Models
{
    public class WorldVsWorldMatches : IWorldVsWorldMatches
    {
        [JsonProperty("wvw_matches")]
        [JsonConverter(typeof(GenericJsonConverter<IWorldVsWorldMatch, WorldVsWorldMatch>))]
        public Collection<IWorldVsWorldMatch> Matches { get; set; }
    }
}
