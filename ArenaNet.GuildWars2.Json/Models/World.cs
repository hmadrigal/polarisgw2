namespace ArenaNet.GuildWars2.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    

    public class World : IWorld
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
