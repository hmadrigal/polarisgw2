using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaNet.GuildWars2.Models
{
    public class DiscoveredItems : IDiscoveredItems
    {
        [JsonProperty("items")]
        public Collection<int> ItemIds { get; set; }
    }
}
