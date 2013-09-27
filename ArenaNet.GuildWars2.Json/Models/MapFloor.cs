using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class MapFloor : IMapFloor
    {
        [JsonProperty("texture_dims")]
        public Collection<int> TextureDims { get; set; }

        [JsonConverter(typeof(GenericJsonConverter<IRegion, Region>))]
        public Dictionary<string, IRegion> Regions { get; set; }
    }
}
