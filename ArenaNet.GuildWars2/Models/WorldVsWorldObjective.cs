namespace ArenaNet.GuildWars2.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class WorldVsWorldObjective : IWorldVsWorldObjective
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        [JsonProperty("owner_guild")]
        public string OwnerGuild { get; set; }
    }
}
