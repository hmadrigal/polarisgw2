using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class MapDescriptions : IMapDescriptions
    {
        [JsonConverter(typeof(GenericJsonConverter<IMapDetails, MapDetails>))]
        public Dictionary<string, IMapDetails> Maps { get; set; }
    }
}
