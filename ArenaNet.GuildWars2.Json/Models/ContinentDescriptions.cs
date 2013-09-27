using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class ContinentDescriptions : IContinentDescriptions
    {
        [JsonConverter(typeof(GenericJsonConverter<IContinent, Continent>))]
        public Dictionary<string, IContinent> Continents { get; set; }
    }
}
