using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;


namespace ArenaNet.GuildWars2.Models
{
    public class Weapon : IWeapon
    {
        public string Type { get; set; }
        [JsonProperty("damage_type")]
        public string DamageType { get; set; }
        [JsonProperty("min_power")]
        public string MinPower { get; set; }
        [JsonProperty("max_power")]
        public string MaxPower { get; set; }
        public string Defense { get; set; }
        [JsonProperty("infusion_slots")]
        public Collection<object> InfusionSlots { get; set; }
        [JsonProperty("infix_upgrade")]
        [JsonConverter(typeof(GenericJsonConverter<IInfixUpgrade, InfixUpgrade>))]
        public IInfixUpgrade InfixUpgrade { get; set; }
        [JsonProperty("suffix_item_id")]
        public string SuffixItemId { get; set; }
    }
}
