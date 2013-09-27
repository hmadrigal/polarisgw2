using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class ColorDescriptions : IColorDescriptions
    {
        [JsonConverter(typeof(GenericJsonConverter<IColors, Colors>))]
        public Collection<KeyValuePair<string, IColors>> Colors { get; set; }
    }
}
