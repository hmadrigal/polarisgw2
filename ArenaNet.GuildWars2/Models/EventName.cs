using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaNet.GuildWars2.Models
{
    public class EventName : IEventName
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
