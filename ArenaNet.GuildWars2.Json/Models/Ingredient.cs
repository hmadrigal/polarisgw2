using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class Ingredient : IIngredient
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }
        public string Count { get; set; }
    }
}
