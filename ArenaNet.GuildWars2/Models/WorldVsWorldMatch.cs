using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaNet.GuildWars2.Models
{
    public class WorldVsWorldMatch : IWorldVsWorldMatch
    {
        [JsonProperty("wvw_match_id")]
        public string WvwMatchId { get; set; }
        [JsonProperty("red_world_id")]
        public int RedWorldId { get; set; }
        [JsonProperty("blue_world_id")]
        public int BlueWorldId { get; set; }
        [JsonProperty("green_world_id")]
        public int GreenWorldId { get; set; }
        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }
        [JsonProperty("end_time")]
        public DateTime EndTime { get; set; }
    }
}
