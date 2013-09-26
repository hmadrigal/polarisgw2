using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public interface IWorld
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
