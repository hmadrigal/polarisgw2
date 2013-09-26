using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class InfixUpgrade : IInfixUpgrade
    {
        [JsonConverter(typeof(GenericJsonConverter<IWeaponAttribute, WeaponAttribute>))]
        public Collection<IWeaponAttribute> Attributes { get; set; }
    }
}
