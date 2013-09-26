using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaNet.GuildWars2.Models
{
    public class DynamicEvents : IDynamicEvents
    {
        [JsonConverter(typeof(GenericJsonConverter<IEvent, Event>))]
        public Collection<IEvent> Events { get; set; }
    }
}
