using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class Colors : IColors
    {
        public string Name { get; set; }
        [JsonProperty("base_rgb")]
        public Collection<int> BaseRgb { get; set; }
        [JsonConverter(typeof(GenericJsonConverter<ICloth, Cloth>))]
        public ICloth Cloth { get; set; }
        [JsonConverter(typeof(GenericJsonConverter<ILeather, Leather>))]
        public ILeather Leather { get; set; }
        [JsonConverter(typeof(GenericJsonConverter<IMetal, Metal>))]
        public IMetal Metal { get; set; }
    }
}
