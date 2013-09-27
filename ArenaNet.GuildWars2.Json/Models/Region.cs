using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class Region : IRegion
    {
        public string Name { get; set; }
        [JsonProperty("label_coord")]
        public Collection<int> LabelCoordinates { get; set; }
        [JsonConverter(typeof(GenericJsonConverter<IMapRegionDetails, MapRegionDetails>))]
        public Collection<KeyValuePair<string, IMapRegionDetails>> Maps { get; set; }
    }
}
