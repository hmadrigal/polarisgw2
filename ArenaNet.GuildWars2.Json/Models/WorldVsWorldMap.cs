namespace ArenaNet.GuildWars2.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;

    public class WorldVsWorldMap : IWorldVsWorldMap
    {
        public string Type { get; set; }
        public Collection<int> Scores { get; set; }
        [JsonConverter(typeof(GenericJsonConverter<IWorldVsWorldObjective, WorldVsWorldObjective>))]
        public Collection<IWorldVsWorldObjective> Objectives { get; set; }
    }
}
