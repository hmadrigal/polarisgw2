using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class WeaponAttribute : IWeaponAttribute
    {
        public string Attribute { get; set; }
        public string Modifier { get; set; }
    }
}
