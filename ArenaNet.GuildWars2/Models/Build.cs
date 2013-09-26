using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class Build : IBuild
    {
        [JsonProperty("build_id")]
        public int Id { get; set; }
    }
}
