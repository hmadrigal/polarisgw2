using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ArenaNet.GuildWars2.Models
{
    public class Map : IMap
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
