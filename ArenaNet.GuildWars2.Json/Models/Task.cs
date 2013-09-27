﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2.Models
{
    public class Task : ITask
    {
        [JsonProperty("task_id")]
        public int Id { get; set; }
        public string Objective { get; set; }
        public int Level { get; set; }
        [JsonProperty("coord")]
        public Collection<double> Coordinates { get; set; }
    }
}
