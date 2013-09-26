using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface ITask
    {
        Collection<double> Coordinates { get; set; }
        int Id { get; set; }
        int Level { get; set; }
        string Objective { get; set; }
    }
}
