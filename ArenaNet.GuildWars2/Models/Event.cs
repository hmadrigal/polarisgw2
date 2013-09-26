using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaNet.GuildWars2.Models
{
    public class Event : IEvent
    {
        [JsonProperty("world_id")]
        public int WorldId { get; set; }
        [JsonProperty("map_id")]
        public int MapId { get; set; }
        [JsonProperty("event_id")]
        public string EventId { get; set; }

        public string State { get; set; }
    }
}
