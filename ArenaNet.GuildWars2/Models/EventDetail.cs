using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class EventDetail : IEventDetail
    {
        public string Name { get; set; }
        public int Level { get; set; }
        [JsonProperty("map_id")]
        public int MapId { get; set; }
        public Collection<string> Flags { get; set; }
        [JsonConverter(typeof(GenericJsonConverter<ILocation, Location>))]
        public ILocation Location { get; set; }
    }
}
