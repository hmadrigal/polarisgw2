using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class Emblem : IEmblem
    {
        [JsonProperty("background_id")]
        public int BackgroundId { get; set; }
        [JsonProperty("foreground_id")]
        public int ForegroundId { get; set; }
        public Collection<object> flags { get; set; }
        [JsonProperty("background_color_id")]
        public int BackgroundColorId { get; set; }
        [JsonProperty("foreground_primary_color_id")]
        public int ForegroundPrimaryColorId { get; set; }
        [JsonProperty("foreground_secondary_color_id")]
        public int ForegroundSecondaryColorId { get; set; }
    }
}
