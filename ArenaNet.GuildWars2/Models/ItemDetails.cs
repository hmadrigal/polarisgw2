using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class ItemDetails : IItemDetails
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Level { get; set; }
        public string Rarity { get; set; }
        [JsonProperty("vendor_value")]
        public string VendorValue { get; set; }
        [JsonProperty("game_types")]
        public Collection<string> GameTypes { get; set; }
        public Collection<string> Flags { get; set; }
        public Collection<object> Restrictions { get; set; }
        [JsonConverter(typeof(GenericJsonConverter<IWeapon, Weapon>))]
        public IWeapon Weapon { get; set; }
    }
}
