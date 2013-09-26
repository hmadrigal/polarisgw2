using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class Guild : IGuild
    {
        [JsonProperty("guild_id ")]
        public string GuildId { get; set; }
        [JsonProperty("guild_name")]
        public string GuildName { get; set; }
        public string Tag { get; set; }
        [JsonConverter(typeof(GenericJsonConverter<IEmblem, Emblem>))]
        public IEmblem Emblem { get; set; }
    }
}
