using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;


namespace ArenaNet.GuildWars2.Models
{
    public class DiscoveredRecipes : IDiscoveredRecipes
    {
        public Collection<int> Recipes { get; set; }
    }
}
