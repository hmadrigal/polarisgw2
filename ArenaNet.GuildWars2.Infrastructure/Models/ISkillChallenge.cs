﻿using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface ISkillChallenge
    {
        Collection<double> Coordinates { get; set; }
    }
}
